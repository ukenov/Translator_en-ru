using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Newtonsoft.Json;
using NHunspell;
using RestSharp;

namespace TranslationService
{
    public static class Globals
    {
        public static List<string> CorectWords = new List<string>(); // to collect all corected words
        public static String combindedString;
        public static int test = 0;
    }
    public class Translator
    {
        public TranslateResult Translate(string text)
        {
            var request = RequsestServices(string.Format(AppCache.UrlDetectSrcLanguage, AppCache.API, text));
            var response = JsonConvert.DeserializeObject<TranslateResponse>(request.Content);

            if (response.Lang.Equals("en"))
            {
                return Translate("en_us.aff", "en_us.dic", "ru", text);
            }
            else if (response.Lang.Equals("ru"))
            {
                return Translate("ru.aff", "ru.dic", "en", text);
            }

            return new TranslateResult();
        }

        private TranslateResult Translate(string aff, string dic, string toLang, string source)
        {
            var translateResult = new TranslateResult();

            translateResult.CorrectedResult = UsingSpellChecker(aff, dic, source);

            var response2 = RequsestServices(string.Format(AppCache.UrlTranslateLanguage, AppCache.API, Globals.combindedString, toLang));
            var result = JsonConvert.DeserializeObject<TranslateResponse>(response2.Content);
            
            Globals.CorectWords.Clear();

            translateResult.Result = result.Text[0];

            return translateResult;
        }

        private string UsingSpellChecker(string a, string b, string input)
        {
            using (Hunspell hunspell = new Hunspell(a, b))
            {
                string[] collectedWords = GetWords(input); // all words without punctuation
                foreach (string word in collectedWords)
                {
                    bool correct = hunspell.Spell(word);
                    if (correct == true)
                    {
                        Globals.CorectWords.Add(word);
                    }
                    else if (correct == false)
                    {
                        Globals.test = 1;
                        List<string> suggestions = hunspell.Suggest(word);
                        var corected = suggestions.FirstOrDefault();
                        Globals.CorectWords.Add(corected);
                    }
                }
                Globals.combindedString = string.Join(" ", Globals.CorectWords.ToArray());
                if (Globals.test == 1)
                {
                    return "Did you mean " + Globals.combindedString + "?";
                }
            }

            return "";
        }

        private IRestResponse RequsestServices(string strUrl)
        {
            var client = new RestClient()
            {
                BaseUrl = new Uri(strUrl)
            };

            var request = new RestRequest()
            {
                Method = Method.GET
            };

            return client.Execute(request);
        }

        static string[] GetWords(string input)
        {
            MatchCollection matches = Regex.Matches(input, @"\b[\w']*\b");

            var words = from m in matches.Cast<Match>()
                        where !string.IsNullOrEmpty(m.Value)
                        select TrimSuffix(m.Value);

            return words.ToArray();
        }

        static string TrimSuffix(string word)
        {
            int apostropheLocation = word.IndexOf('\'');
            if (apostropheLocation != -1)
            {
                word = word.Substring(0, apostropheLocation);
            }

            return word;
        }
    }

    public class TranslateResponse
    {
        public int Code { get; set; }
        public string Lang { get; set; }
        public List<string> Text { get; set; }
    }

    public class TranslateResult
    {
        public string Result { get; set; }
        public string CorrectedResult { get; set; }
    }
}

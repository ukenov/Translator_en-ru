using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranslationService
{
    class AppCache
    {
        public static string API { get; } = @"trnsl.1.1.20190417T134106Z.ff5e50e85cb626d6.77b2cad5685c5ea5c27b2f879e14de7bb609b220";
        public static string UrlGetAvailableLanguages { get; } = @"https://translate.yandex.net/api/v1.5/tr.json/getLangs?key={0}&ui={1}";
        public static string UrlDetectSrcLanguage { get; } = @"https://translate.yandex.net/api/v1.5/tr.json/detect?key={0}&text={1}";
        public static string UrlTranslateLanguage { get; } = @"https://translate.yandex.net/api/v1.5/tr.json/translate?key={0}&text={1}&lang={2}";
    }
}

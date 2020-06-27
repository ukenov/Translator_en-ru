using System;
using TranslationService;

namespace TranslatorConsole
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.GetEncoding("Cyrillic");
            Console.InputEncoding = System.Text.Encoding.GetEncoding("Cyrillic");
            var translate = new Translator();
            var input = Console.ReadLine();
            var result = translate.Translate(input);
            Console.WriteLine(result.CorrectedResult);
            Console.WriteLine(result.Result);
            Console.ReadKey();
        }
    }
}

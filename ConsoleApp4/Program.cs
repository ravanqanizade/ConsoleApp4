using System;
using System.Collections.Generic;

class Translator
{
    static void Main(string[] args)
    {
        Dictionary<string, string> englishToAzerbaijani = new Dictionary<string, string>
        {
            { "hello", "salam" },
            { "world", "dunya" },
            { "apple", "alma" },
            { "book", "kitab" },
            { "computer", "komputer" }
        };

        Dictionary<string, string> azerbaijaniToEnglish = new Dictionary<string, string>
        {
            { "salam", "hello" },
            { "dunya", "world" },
            { "alma", "apple" },
            { "kitab", "book" },
            { "komputer", "computer" }
        };

        Console.WriteLine("Tercume etmek istediyiniz sozu daxil edin:");
        string word = Console.ReadLine().ToLower();

        string translatedWord = TranslateWord(word, englishToAzerbaijani, azerbaijaniToEnglish);

        if (translatedWord != null)
        {
            Console.WriteLine($"Ceviri: {translatedWord}");
        }
        else
        {
            Console.WriteLine("Ceviri tapilmadi.");
        }
    }

    static string TranslateWord(string word, Dictionary<string, string> englishToAzerbaijani, Dictionary<string, string> azerbaijaniToEnglish)
    {
        if (englishToAzerbaijani.ContainsKey(word))
        {
            return englishToAzerbaijani[word];
        }
        else if (azerbaijaniToEnglish.ContainsKey(word))
        {
            return azerbaijaniToEnglish[word];
        }
        else
        {
            return null;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

// Reard Gjoni
// 03.02.2024
// Kata link: https://www.codewars.com/kata/5390bac347d09b7da40006f6/train/csharp

namespace Exercises.JadenCasingStrings
{
    public static class JadenCase
    {
        public static string ToJadenCase(this string phrase)
        {
            string[] PhraseSeparatedBySpaces = phrase.Split(' ');
            StringBuilder NewPhrase = new StringBuilder(phrase);
            List<string> NewWordsList = new List<string>(){};

            // TODO: use Substring
            foreach (string Word in PhraseSeparatedBySpaces)
            {
                NewWordsList.Add(Word);
                //NewWord[0] = Word[0].ToString().ToUpper();
                NewPhrase.Append(Word + ' ');

                //NewWordFirstLetter = Word[0].ToString().ToUpper();
            }

            NewWordsList.ForEach(word =>
            {
                word[0].ToString().ToUpper();
            });

            NewWordsList.ForEach(Console.WriteLine);

            return string.Empty;
        }
    }
}

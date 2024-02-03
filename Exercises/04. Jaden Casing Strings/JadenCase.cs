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
            StringBuilder NewPhrase = new StringBuilder();

            foreach (string Word in PhraseSeparatedBySpaces)
            {
                string UpperCaseFirstLetter = Word[0].ToString().ToUpper();
                string RestOfWord = Word.Substring(1);
                string NewWord = UpperCaseFirstLetter + RestOfWord;

                NewPhrase.Append(NewWord + ' ');
            }

            return NewPhrase.ToString().Trim(' ');
        }
    }
}

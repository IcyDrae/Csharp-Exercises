using System;
using System.Linq;

// Reard Gjoni
// 03.02.2024
// Kata link: https://www.codewars.com/kata/5277c8a221e209d3f6000b56/train/csharp

namespace Exercises.ValidBraces
{
    public class Brace
    {
        public static bool validBraces(String braces)
        {
            var current = "";

            while (braces.Any() && current != braces)
            {
                current = braces;
                braces = braces
                            .Replace("()", "")
                            .Replace("[]", "")
                            .Replace("{}", "");
            }

            return !braces.Any();
        }
    }
}

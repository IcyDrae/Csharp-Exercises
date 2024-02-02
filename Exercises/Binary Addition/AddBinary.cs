using System;

// Reard Gjoni
// 22.01.2024
// Kata link: https://www.codewars.com/kata/551f37452ff852b7bd000139/train/csharp

namespace Exercises.Binary_Addition
{
    public class Binary_Addition
    {
        public static string AddBinary(int a, int b)
        {
            int Result = (a + b);
            string ResultToBinaryString = Convert.ToString(Result, 2);

            //Console.WriteLine(ResultToBinaryString);

            return ResultToBinaryString;
        }
    }
}

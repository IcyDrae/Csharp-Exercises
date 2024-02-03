using System;
using System.Collections.Generic;

// Reard Gjoni
// 30.01.2024
// Kata link: https://www.codewars.com/kata/55bf01e5a717a0d57e0000ec/train/csharp

namespace Exercises.Persistent_Bugger
{
    public class PersistentBugger
    {
        public static int Persistence(long n)
        {
            int MultiplicationPersistence = 0;

            while (n.ToString().Length > 1)
            {
                n = Multiply(n);
                MultiplicationPersistence++;
            }

            return MultiplicationPersistence;
        }

        private static int Multiply(long number)
        {
            string ParameterToString = number.ToString();
            int NumberDigitAmount = ParameterToString.Length;
            int LoopIndex;
            int Result = 1;

            for (LoopIndex = 0; LoopIndex < NumberDigitAmount; LoopIndex++)
            {
                string Character = ParameterToString[LoopIndex].ToString();
                int Number = Convert.ToInt32(Character);

                Result = Result * Number;
            }

            return Result;
        }
    }
}

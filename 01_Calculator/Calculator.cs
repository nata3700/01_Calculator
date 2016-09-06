using System;

namespace _01_Calculator
{
    internal class Calculator
    {
        internal static int Add(int v1, int v2)
        {
            return v1 + v2;
        }

        internal static int Subtract(int v1, int v2)
        {
            return v1 - v2;
        }

        internal static int Sum(int[] numbers)
        {
            int resultat = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                resultat = resultat + numbers[i];
            }

            return resultat;
        }

        internal static int Multiply(int[] numbers)
        {
            int result = 1;

            for (int i = 0; i < numbers.Length; i++)
            {
                result *= numbers[i]; // "resultat *= numbers[i]" is the same as "resultat = resultat * numbers[i]"
            }

            return result;
        }
    }      
}
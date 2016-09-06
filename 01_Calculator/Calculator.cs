using System;

namespace _01_Calculator
{
    internal class Calculator
    {
        internal static int Add(int v1, int v2)
        {
            throw new NotImplementedException();
        }

        internal static int Subtract(int v1, int v2)
        {
            throw new NotImplementedException();
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
    }
}
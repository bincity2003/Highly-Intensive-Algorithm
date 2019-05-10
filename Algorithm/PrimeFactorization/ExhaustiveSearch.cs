using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.PrimeFactorization
{
    public static class ExhaustiveSearch
    {
        public static long[] Factor(decimal number)
        {
            List<long> Factors = new List<long>();

            long factor = 2;

            while (number >= factor * factor)
            {
                if (number % factor == 0)
                {
                    Factors.Add(factor);
                    number /= factor;
                }
                else
                {
                    factor += 1;
                }
            }
            Factors.Add(Convert.ToInt64(number));

            return Factors.ToArray();
        }
    }
}

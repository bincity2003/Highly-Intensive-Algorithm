using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.PrimeFactorization
{
    public static class ImprovedExhaustiveSearch
    {
        public static long[] Factor(decimal number)
        {
            List<long> Factors = new List<long>();

            while (number % 2 == 0)
            {
                Factors.Add(2);
                number /= 2;
            }

            for (int i = 3; i <= Math.Sqrt(Convert.ToDouble(number)); i += 2)
            {
                while (number % i == 0)
                {
                    Factors.Add(i);
                    number /= i;
                }
            }
            Factors.Add(Convert.ToInt64(number));
            return Factors.ToArray();
        }
    }
}

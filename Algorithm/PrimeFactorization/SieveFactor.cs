using System;
using System.Collections.Generic;
using System.Text;

using Algorithm.PrimeGenerator;

namespace Algorithm.PrimeFactorization
{
    public static class SieveFactor
    {
        public static long[] Factor(decimal n)
        {
            long[] pfactors = Sieve.Generate((long)Math.Sqrt(Convert.ToDouble(n)));

            List<long> factors = new List<long>();

            foreach (var item in pfactors)
            {
                while (n % item == 0)
                {
                    factors.Add(item);
                    n /= item;
                }
            }

            return factors.ToArray();
        }

        public static long[] Factor(decimal n, long[] cache)
        {
            List<long> factors = new List<long>();

            foreach (var item in cache)
            {
                if (item >= n)
                {
                    break;
                }
                while (n % item == 0)
                {
                    factors.Add(item);
                    n /= item;
                }
            }

            return factors.ToArray();  
        }

        public static long[] GetCache(decimal n)
        {
            return Sieve.Generate((long)Math.Sqrt(Convert.ToDouble(n)));
        }
    }
}

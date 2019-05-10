using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.PrimeGenerator
{
    public static class ExhaustiveSearch
    {
        public static bool IsPrime(long n)
        {
            if (n == 1) return false;
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}

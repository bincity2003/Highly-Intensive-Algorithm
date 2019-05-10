using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.PrimeGenerator
{
    public static class ImprovedExhaustiveSearch
    {
        public static bool IsPrime(long n)
        {
            if (n == 0 || n == 1) return false;
            if (n == 2 || n == 3) return false;

            for (int i = 0; i < Math.Sqrt(n); i += 2)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
    }
}

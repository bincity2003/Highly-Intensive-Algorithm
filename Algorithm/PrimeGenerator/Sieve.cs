using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.PrimeGenerator
{
    public static class Sieve
    {
        public static long[] Generate(long n)
        {
            bool[] array = new bool[n + 1];
            for (int i = 2; i <= n; i++)
            {
                array[i] = true;
            }
            List<long> Result = new List<long>();
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (array[i])
                {
                    for (int k = i * i; k <= n; k += i)
                    {
                        array[k] = false;
                    }
                }
            }

            for (int i = 2; i < array.Length; i++)
            {
                if (array[i])
                {
                    Result.Add(i);
                }
            }

            return Result.ToArray();
        }
    }
}

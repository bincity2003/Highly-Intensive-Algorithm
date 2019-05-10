using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using Algorithm;
using Algorithm.PrimeFactorization;
using Algorithm.PrimeGenerator;

namespace Program
{
    class Program
    {
        const long NUMBER = 12345678910111;
        const int ITERATION = 1000;

        static void Main(string[] args)
        {
            //Console.WriteLine("Factorizing a {0}-digit number {1} times....", NUMBER.ToString().Length, ITERATION);
            List<Thread> threads = new List<Thread>
            {
                //new Thread(() => ExhaustiveSearchTimer()),
                //new Thread(() => ImprovedExhaustiveSearchTimer()),
                //new Thread(() => SieveFactorTimer())
            };

            foreach (var item in threads)
            {
                item.Start();
            }

            foreach (var item in threads)
            {
                item.Join();
            }

            Console.ReadLine();
        }

        static void ExhaustiveSearchTimer()
        {
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            for (int i = 0; i < ITERATION; i++)
            {
                ExhaustiveSearch.Factor(NUMBER);
            }
            stopwatch.Stop();

            Console.WriteLine("ExhaustiveSearch took : {0}ms", stopwatch.ElapsedMilliseconds);
        }

        static void ImprovedExhaustiveSearchTimer()
        {
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            for (int i = 0; i < ITERATION; i++)
            {
                ImprovedExhaustiveSearch.Factor(NUMBER);
            }
            stopwatch.Stop();

            Console.WriteLine("ImprovedExhaustiveSearch took : {0}ms", stopwatch.ElapsedMilliseconds);
        }

        static void SieveFactorTimer()
        {
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            long[] cache = SieveFactor.GetCache(NUMBER);
            for (int i = 0; i < ITERATION; i++)
            {
                SieveFactor.Factor(NUMBER, cache);
            }
            stopwatch.Stop();

            Console.WriteLine("SieveFactor took : {0}ms", stopwatch.ElapsedMilliseconds);
        }
    }
}

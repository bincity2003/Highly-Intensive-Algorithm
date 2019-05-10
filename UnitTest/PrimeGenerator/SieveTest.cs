using NUnit.Framework;

using Algorithm;
using Algorithm.PrimeGenerator;

namespace UnitTest.PrimeGenerator
{
    [TestFixture]
    public static class SieveTest
    {
        [Test]
        public static void DoTest()
        {
            long[] Result = new long[]
            {
                2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37
            };

            Assert.AreEqual(Result, Sieve.Generate(40));
        }
    }
}

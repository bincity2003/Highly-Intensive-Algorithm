﻿using NUnit.Framework;

using Algorithm;
using Algorithm.PrimeFactorization;

namespace UnitTest.PrimeFactorization
{
    [TestFixture]
    public static class SieveFactorTest
    {
        [Test]
        public static void DoTest()
        {
            long[] FactorsOf120 = new long[]
            {
                2, 2, 2, 3, 5
            };

            Assert.AreEqual(FactorsOf120, SieveFactor.Factor(120));
        }
    }
}

using Algos;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgosTests
{
    [TestFixture]
    public class FactorialTests
    {
        [Test]
        public void GetFactorialReturns1For1AsInput()
        {
            var result = Factorial.GetFactorial(1);
            Assert.AreEqual(result, 1);
        }

        [Test]
        public void GetFactorialReturnsValidResultForValidInput()
        {
            var result = Factorial.GetFactorial(5);
            Assert.AreEqual(result, 120);
        }

        [Test]
        public void GetFactorialRecursiveReturnsValidResultForValidInput()
        {
            var result = Factorial.GetFactorialRecursive(5);
            Assert.AreEqual(result, 120);
        }
    }
}

using Algos;
using NUnit.Framework;

namespace AlgosTest
{
    [TestFixture]
    class FactorialTest
    {
        [Test]
        public void ReturnFactorialReturnsForValidInput()
        {
            var result = Factorial.GetFactorial(1);
            result.Should.be(1);
        }
    }
}

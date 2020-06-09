using Microsoft.VisualStudio.TestTools.UnitTesting;
using BalancedBracketsNS;

namespace BalancedBracketsTests
{
    [TestClass]
    public class BalancedBracketsTests
    {
        // TODO: Add tests to this file.

        [TestMethod]
        public void OnlyBracketsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]"));
        }
        [TestMethod]
        public void IfBracketsAreWrongChar()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("{}"));
        }
        [TestMethod]
        public void ThisIsTheSingletonTest()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("["));
        }
        [TestMethod]
        public void UnBalancedTest()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[]]"));
        }
    }
}

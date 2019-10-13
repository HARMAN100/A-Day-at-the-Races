using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Races;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Empty_Payout()
        {
            // Arrange
            var bet = new Bet();

            // Act
            var actual = bet.PayOut("Day Break");

            // Asset
            Assert.AreEqual(0, actual);
        }

        [TestMethod]
        public void Not_Enough_Cash_Message()
        {
            // Arrange
            var guy = new Guy();

            // Act
            var actual = guy.PlaceBet(1, "Day Break", 1);

            // Assert
            Assert.AreEqual(false, actual);
        }
    }
}

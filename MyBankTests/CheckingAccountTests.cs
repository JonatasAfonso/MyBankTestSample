using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyBankLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBankLib.Tests
{
    [TestClass()]
    public class CheckingAccountTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Withdraw_ValidAmount_ChangesBalance()
        {
            // arrange
            double currentBalance = 10.0;
            double withdrawal = 1.0;
            double expected = 9.0;
            var account = new CheckingAccount("JohnDoe", currentBalance);

            // act
            account.Withdraw(withdrawal);

            // assert
            Assert.AreEqual(expected, account.Balance);
        }

        [TestMethod]
        public void Withdraw_AmountMoreThanBalance_Throws()
        {
            // arrange
            var account = new CheckingAccount("John Doe", 10.0);

            // act and assert
            Assert.ThrowsException<ArgumentException>(() => account.Withdraw(20.0));
        }

        [DataTestMethod]
        [DataRow(12, 3, 4)]
        [DataRow(12, 2, 6)]
        [DataRow(12, 4, 3)]
        public void DivideTest(int n, int d, int q)
        {
            Assert.AreEqual(q, n / d);
        }
    }
}
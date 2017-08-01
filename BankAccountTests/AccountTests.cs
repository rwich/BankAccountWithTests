using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankAccount;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount.Tests
{
    [TestClass()]
    public class AccountTests
    {
        Account acc;

        [TestInitialize]
        public void InitTests()
        {
            acc = new Account();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CreateAccountWithNegativeBalanceThrowEx()
        {
            double initialBalance = -1;
            Account acc = new Account(initialBalance);
        }

        [TestMethod]
        public void CreateAccountWithPositiveInitialBalance()
        {
            double initialBalance = 100;
            Account acc = new Account(initialBalance);
            Assert.AreEqual(initialBalance, acc.Balance);
        }

        [TestMethod()]
        [TestCategory("DepositTests")]
        public void DepositPositiveAmount()
        {
            //Arrange
            Account acc = new Account();
            double initialBalance = 0;
            double depositAmount = 10;
            double expectedBalance = initialBalance + depositAmount;

            //Act
            acc.Deposit(depositAmount);

            //Assert
            Assert.AreEqual(expectedBalance, acc.Balance);
        }

        [TestMethod]
        [TestCategory("DepositTests")]
        [ExpectedException(typeof(ArgumentException))]
        public void DepositNegativeAmountShouldThrowException()
        {
            //Arrange
            Account a = new Account();
            //double initialBalance = 0;
            double depositAmount = -5;


            //Act
            a.Deposit(depositAmount);

            //Assert
            //Assert is handled by ExpectedException attribute
        }

        [TestMethod]
        [TestCategory("WithdrawTests")]
        public void WithdrawPositiveAmount()
        {
            Account acc = new Account();
            //Arrange
            double initialBalance = 0;
            double withdrawAmount = 10;
            double expectedBalance = initialBalance - withdrawAmount;

            //Act
            acc.Withdraw(withdrawAmount);

            //Assert
            Assert.AreEqual(expectedBalance, acc.Balance);
        }

        [TestMethod]
        [Priority(1)]
        [ExpectedException(typeof(ArgumentException))]
        public void WithdrawNegativeAmountShouldThrowException()
        {
            Account acc = new Account();
            double withdrawAmount = -10;
            acc.Withdraw(withdrawAmount);
        }
    }
}
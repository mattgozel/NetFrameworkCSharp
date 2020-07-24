using NUnit.Framework;
using SGBank.BLL.DepositRules;
using SGBank.BLL.WithdrawRules;
using SGBank.Models;
using SGBank.Models.Interfaces;
using SGBank.Models.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGBank.Tests
{
    [TestFixture]
    public class PremiumAccountTests
    {
        [TestCase("55555", "Premium Account", 100, AccountType.Free, 250, false)]
        [TestCase("55555", "Premium Account", 100, AccountType.Premium, -100, false)]
        [TestCase("55555", "Premium Account", 100, AccountType.Premium, 250, true)]
        public void PremiumAccountDepositRuleTest(string accountNumber, string name, decimal balance, AccountType accountType, decimal amount, bool expectedResult)
        {
            IDeposit deposit = new NoLimitDepositRule();
            Account account = new Account();

            account.AccountNumber = accountNumber;
            account.Name = name;
            account.Balance = balance;
            account.Type = accountType;

            AccountDepositResponse depositResponse = deposit.Deposit(account, amount);

            Assert.AreEqual(expectedResult, depositResponse.Success);
        }

        [TestCase("55555", "Premium Account", 100, AccountType.Free, -100, 100, false)]
        [TestCase("55555", "Premium Account", 100, AccountType.Premium, 100, 100, false)]
        [TestCase("55555", "Premium Account", 100, AccountType.Premium, -1000, -900, false)]
        [TestCase("55555", "Premium Account", 150, AccountType.Premium, -50, 100, true)]
        [TestCase("55555", "Premium Account", 100, AccountType.Premium, -150, -60, true)]
        public void PremiumAccountWtihdrawRuleTest(string accountNumber, string name, decimal balance, AccountType accountType, decimal amount, decimal newBalance, bool expectedResult)
        {
            IWithdraw withdraw = new PremiumAccountWithdrawRule();
            Account account = new Account();

            account.AccountNumber = accountNumber;
            account.Name = name;
            account.Balance = balance;
            account.Type = accountType;

            AccountWithdrawResponse withdrawResponse = withdraw.Withdraw(account, amount);

            Assert.AreEqual(expectedResult, withdrawResponse.Success);

            if (withdrawResponse.Success == true)
            {
                Assert.AreEqual(newBalance, account.Balance);
            }
        }
    }
}

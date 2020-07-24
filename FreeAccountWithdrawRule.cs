using SGBank.Models;
using SGBank.Models.Interfaces;
using SGBank.Models.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGBank.BLL.WithdrawRules
{
    public class FreeAccountWithdrawRule : IWithdraw
    {
        public AccountWithdrawResponse Withdraw(Account account, decimal amount)
        {
            AccountWithdrawResponse withdrawResponse = new AccountWithdrawResponse();

            if (account.Type != AccountType.Free)
            {
                withdrawResponse.Success = false;
                withdrawResponse.Message = "Error: a non-free account hit the Free Withdraw Rule. Contact IT";
                return withdrawResponse;
            }

            if (amount >= 0)
            {
                withdrawResponse.Success = false;
                withdrawResponse.Message = "Withdrawl amounts must be negative.";
                return withdrawResponse;
            }

            if (amount < -100)
            {
                withdrawResponse.Success = false;
                withdrawResponse.Message = "Free accounts cannot withdraw more than $100 per day.";
                return withdrawResponse;
            }

            if (account.Balance + amount < 0)
            {
                withdrawResponse.Success = false;
                withdrawResponse.Message = "Free accounts cannot overdraft.";
                return withdrawResponse;
            }

            withdrawResponse.Success = true;
            withdrawResponse.Account = account;
            withdrawResponse.Amount = amount;
            withdrawResponse.OldBalance = account.Balance;
            account.Balance += amount;
            return withdrawResponse;
        }
    }
}

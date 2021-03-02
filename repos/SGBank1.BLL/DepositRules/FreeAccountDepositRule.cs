using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGBank.Models;
using SGBank.Models.Interfaces;
using SGBank.Models.Responses;

namespace SGBank.BLL.DepositRules
{
    public class FreeAccountDepositRule : IDeposit
    {
        public AccountDepositResponses Deposit(Account account, decimal amount)
        {
            AccountDepositResponses response = new AccountDepositResponses();

            if(account.Type != AccountType.Free)
            {
                response.Success = false;
                response.Message = "Error : a non free acount hit the Free Deposit Rule. Contact IT";
                return response;
            }
            if (amount > 100)
            {
                response.Success = false;
                response.Message = "Free accounts cannot deposit more than $100 at a time";
                return response;
            }
            if (amount <= 0)
            {
                response.Success = false;
                response.Message = "Deposit must be greater than zero";
                return response;
            }
            else
            {
                response.OldBalance = account.Balance;
                account.Balance += amount;
                response.Account = account;
                response.Amount = amount;
                response.Success = true;
                return response;
            }
        }
    }
}

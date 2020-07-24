using SGBank.BLL;
using SGBank.Models.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGBank.UI.Workflows
{
    public class WithdrawWorkflow
    {
        public void Execute()
        {
            Console.Clear();

            AccountManager manager = AccountManagerFactory.Create();

            Console.Write("Enter an account number: ");
            string accountNumber = Console.ReadLine();

            Console.Write("Enter a withdrawl amount: ");
            decimal amount = decimal.Parse(Console.ReadLine());

            AccountWithdrawResponse withdrawResponse = manager.Withdraw(accountNumber, amount);

            if (withdrawResponse.Success == true)
            {
                Console.WriteLine("Withdrawl completed!");
                Console.WriteLine($"Account Number: {withdrawResponse.Account.AccountNumber}");
                Console.WriteLine($"Old balance: {withdrawResponse.OldBalance:c}");
                Console.WriteLine($"Amount Withdrawn: {withdrawResponse.Amount:c}");
                Console.WriteLine($"New balance: {withdrawResponse.Account.Balance:c}");
            }
            else
            {
                Console.WriteLine("An error occurred: ");
                Console.WriteLine(withdrawResponse.Message);
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}

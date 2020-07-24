using SGBank.Models;
using SGBank.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGBank.Data
{            
    public class FileAccountRepository : IAccountRepository
    {
        public static string filePath = @"C:\data\Accounts.txt";
        Account loadedAccount = new Account();
        public List<Account> List()
        {
            List<Account> accounts = new List<Account>();

            using (StreamReader sr = new StreamReader(filePath))
            {
                sr.ReadLine();
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    Account newAccount = new Account();

                    var columns = line.Split(',');

                    newAccount.AccountNumber = columns[0];
                    newAccount.Name = columns[1];
                    newAccount.Balance = decimal.Parse(columns[2]);
                    
                    if (columns[3].Contains('F'))
                    {
                        newAccount.Type = AccountType.Free;
                    }
                    if (columns[3].Contains('B'))
                    {
                        newAccount.Type = AccountType.Basic;
                    }
                    if (columns[3].Contains('P'))
                    {
                        newAccount.Type = AccountType.Premium;
                    }

                    accounts.Add(newAccount);
                }
            }
                
            return accounts;
        }
        

        public Account LoadAccount(string AccountNumber)
        {
            var accounts = List();

            var x = accounts.Where(a => a.AccountNumber == AccountNumber);

            var accountNumberCheck = x.Any(a => a.AccountNumber == AccountNumber);

            if (accountNumberCheck == true)
            {
                foreach (var a in x)
                {
                    loadedAccount = a;
                    return a;
                }

                return loadedAccount;
            }
         
            else
            {
                return null;
            }

        }

        public void SaveAccount(Account account)
        {
            var accounts = List();

            var x = accounts.Where(a => a.AccountNumber == account.AccountNumber);

            foreach (var a in x)
            {
                a.Balance = account.Balance;
            }

            CreateAccountFile(accounts);
        }

        private void CreateAccountFile(List<Account> accounts)
        {
            if (File.Exists(filePath))
                File.Delete(filePath);

            using(StreamWriter sr = new StreamWriter(filePath))
            {
                sr.WriteLine("AccountNumber,Name,Balance,Type");
                foreach(var account in accounts)
                {
                    sr.WriteLine($"{account.AccountNumber},{account.Name},{account.Balance.ToString()},{account.Type.ToString().Substring(0,1)}");
                }
            }
        }
    }
}

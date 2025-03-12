using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_system
{
    internal class Bank
    {
        private List<Account> accounts;
        public Bank()
        {
            accounts = new List<Account>();
        }
        public void createaccount(Account account) { 
            
            accounts.Add(account);
            Console.WriteLine($"Account created successfully.");
        }

        public Account FindAccount(int accountNumber)
        {
            return accounts.Find(acc => acc.AccountNumber == accountNumber);
        }
        public void TransferMoney(int fromAccountNumber, int toAccountNumber, decimal amount)
        {
            var fromAccount = FindAccount(fromAccountNumber);
            var toAccount = FindAccount(toAccountNumber);

            if (fromAccount != null && toAccount != null)
            {
                fromAccount.withdraw(amount);
                toAccount.Deposit(amount);
                Console.WriteLine("تم تحويل المبلغ بنجاح.");
            }
            else
            {
                Console.WriteLine("أحد الحسابات غير موجود.");
            }
        }
    }
}

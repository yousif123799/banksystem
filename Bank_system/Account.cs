using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Bank_system
{
    internal class Account
    {
        public abstract class AAccount
        {
            public int AccountNumber { protected set; get; }
            public string owner_name { protected set; get; }
            public decimal balance { protected set; get; }
            protected List<string> transactions;

            public AAccount(int account_number, string owner_name, decimal balance)
            {
                this.AccountNumber = account_number;
                this.owner_name = owner_name;
                this.balance = balance;
            }
            public void deposit(decimal money)
            {
                if (money > 0)
                {
                    balance += money;
                    Console.WriteLine($"Deposited {money} into account {this.AccountNumber}");
                }
                else
                {
                    Console.WriteLine("Invalid deposit amount.");
                }

            }
            public void withdraw(decimal money)
            {
                if (money > 0 && balance >= money)
                {
                    balance -= money;
                    Console.WriteLine($"Withdrew {money} from account {this.AccountNumber}");
                    if (balance == 0)
                    {
                        Console.WriteLine($"Account {this.AccountNumber} is now empty.");
                    }

                }
                else
                {
                    Console.WriteLine("The money in the balance is not enough.");

                }


            }
            public void DisplayAccountDetails()
            {
                Console.WriteLine($"رقم الحساب: {AccountNumber}, اسم العميل: {owner_name}, الرصيد: {balance}");
                Console.WriteLine("سجل العمليات:");
                foreach (var transaction in transactions)
                {
                    Console.WriteLine(transaction);
                }
            }
            protected void AddTransaction(string type, decimal amount)
            {
                transactions.Add(new Transaction(type, amount));
            }

        }
    }
}
    

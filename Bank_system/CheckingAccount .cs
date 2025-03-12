using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Bank_system.Account;

namespace Bank_system
{
    internal class CheckingAccount: AAccount
    {
       
            private decimal OverdraftLimit; // حد السحب على المكشوف
            public CheckingAccount(int accountNumber, string ownerName, decimal initialBalance, decimal overdraftLimit) : base(accountNumber, ownerName, initialBalance)
            {
                OverdraftLimit = overdraftLimit;

            }
            public void Withdraw(decimal amount)
            {
                if (amount > 0 && balance - amount >= -OverdraftLimit)
                {
                    balance -= amount;
                    
                    Console.WriteLine($"Withdrew {amount} from account");

                }
                else
                {
                    
                    Console.WriteLine("The Operation can't be done.");
                }
            }
        }
    }


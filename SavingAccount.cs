using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Bank_system.Account;

namespace Bank_system
{
    internal class SavingAccount: AAccount
    {
        private decimal InterestRate;  

        public SavingAccount(int accountNumber, string ownerName, decimal initialBalance, decimal interestRate): base(accountNumber, ownerName, initialBalance)
        {
            InterestRate = interestRate;
        }
        public  void ApplyAccountRules()
        {
            
            decimal interest = balance * InterestRate / 100;
            deposit(interest);
        }

    }
}

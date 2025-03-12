using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_system
{
    internal class Transaction
    {
        public string type { get; set; }
        public decimal amount { get; set; }
        public DateTime DateTime { get; set; }
        public Transaction(string type, decimal amount)
        {
            DateTime = DateTime.Now;
            this.type = type;
            this.amount = amount;

        }
        public string operation()
        {
            return $"Transaction type: {type}, Amount: {amount}, Date: {DateTime.ToShortDateString()}";
        }


    }
}

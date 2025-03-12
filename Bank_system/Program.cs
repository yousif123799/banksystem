namespace Bank_system
{
    internal class Program
    {
        static void Main(string[] args)
        {


            class Program
        {
            static void Main(string[] args)
            {
                Bank bank = new Bank();

                Console.WriteLine("مرحبًا بك في نظام إدارة البنك!");

                // إنشاء حسابات تجريبية
                var savingsAccount = new SavingsAccount(1, "أحمد علي", 1000, 2.5m);
                var checkingAccount = new CheckingAccount(2, "سارة محمد", 500, 200);

                bank.CreateAccount(savingsAccount);
                bank.CreateAccount(checkingAccount);

                // تنفيذ عمليات تجريبية
                savingsAccount.Deposit(200);
                savingsAccount.ApplyAccountRules();

                checkingAccount.Withdraw(600);
                bank.TransferMoney(1, 2, 150);

                bank.DisplayAllAccounts();
            }
        }



    }
}
}

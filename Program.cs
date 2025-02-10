namespace Account_Utilities
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 
            
            // Accounts
            var accounts = new List<Account>();
            accounts.Add(new Account());
            accounts.Add(new Account("Larry"));
            accounts.Add(new Account("Moe", 2000));
            accounts.Add(new Account("Curly", 5000));

            AccountUtil.Display(accounts);
            AccountUtil.Deposit(accounts, 1000);
            AccountUtil.Withdraw(accounts, 2000);

            // Savings
            var savAccounts = new List<Account>();
            savAccounts.Add(new Account());
            savAccounts.Add(new ("Superman"));
            savAccounts.Add(new SavingAccount("Batman", 2000));
            savAccounts.Add(new SavingAccount("Wonderwoman", 5000, 5.0));

            AccountUtil.Display(savAccounts);
            AccountUtil.Deposit(savAccounts, 1000);
            AccountUtil.Withdraw(savAccounts, 2000);

            // Checking
            var checAccounts = new List<Account>();
            checAccounts.Add(new Account());
            checAccounts.Add(new Account("Larry2"));
            checAccounts.Add(new CheckingAccount("Moe2", 2000));
            checAccounts.Add(new CheckingAccount("Curly2", 5000));

            AccountUtil.Display(checAccounts);
            AccountUtil.Deposit(checAccounts, 1000);
            AccountUtil.Withdraw(checAccounts, 2000);
            AccountUtil.Withdraw(checAccounts, 2000);

            // Trust
            var trustAccounts = new List<Account>();
            trustAccounts.Add(new Account());
            trustAccounts.Add(new Account("Superman2"));
            trustAccounts.Add(new Account("Batman2", 2000));
            trustAccounts.Add(new TrustAccount("Wonderwoman2", 5000, 5.0));

            AccountUtil.Display(trustAccounts);
            AccountUtil.Deposit(trustAccounts, 1000);
            AccountUtil.Deposit(trustAccounts, 6000);
            AccountUtil.Withdraw(trustAccounts, 2000);
            AccountUtil.Withdraw(trustAccounts, 3000);
            AccountUtil.Withdraw(trustAccounts, 500);
            
            #endregion
            Account a1 = new CheckingAccount("Ahmed", 5000);
            Account TrustAcc = new TrustAccount("Mohamed", 10000);
            TrustAcc.Deposit(6000);
            a1.Withdraw(2000);
            Console.WriteLine($"The New Balance of The TrustAccount is :{TrustAcc.Balance}");
            Console.WriteLine($"The New Balance of The Saving Account is :{a1.Balance}");
            Account acc1 = new Account("Hazem",5000);
            Account acc2 = new Account("Seif",10000);

        }
    }
}

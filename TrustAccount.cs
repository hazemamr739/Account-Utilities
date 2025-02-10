using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account_Utilities
{
    public class TrustAccount : SavingAccount
    {
        

        public TrustAccount(string Name, double Balance, double interestRate=0) : base(Name, Balance,interestRate)
        {
           
        }


        public override bool Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                if(amount >= 5000)
                {
                    IntersetRate = 50;
                    Balance += IntersetRate;
                    return true;
                }
                return true;
            }
            return false;
        }
        public override bool Withdraw(double amount)
        { double limitWithdrawl = (20 / 100) * Balance;
            DateTime date = DateTime.Now;

            for(int i = 0; i < 3; i++)
            {
                if (amount > limitWithdrawl)
                {
                    return false;
                }
                else if(amount <= limitWithdrawl)
                {   Balance -= amount;
                    return true;
                }
            }   
                return false;
        }
    }
}

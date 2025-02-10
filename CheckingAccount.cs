using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account_Utilities
{
    public class CheckingAccount : Account
    {
        public  double  FeesPerWithdrawl {get;}

        public CheckingAccount(string Name,double Balance,double feesPerWithdrawl=1.5) :base(Name,Balance)
        {
            FeesPerWithdrawl = feesPerWithdrawl;
        }
        public override bool Withdraw(double amount)
        {
            if (Balance - amount >= 0)
            {
                Balance -= amount;
                Balance -= FeesPerWithdrawl;
                return true;
            }
            return false;
        }

    }
}

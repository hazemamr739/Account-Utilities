using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account_Utilities
{
    public class SavingAccount : Account
    {
        public double IntersetRate { get; set; }

        public SavingAccount(string Name,double Balance,double intersetRate=0) :base(Name,Balance)
        {
            IntersetRate = intersetRate;
        }
        
    }
}

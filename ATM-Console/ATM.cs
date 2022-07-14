using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Console
{
    public class ATM
    {
        public int amount = 10000;
        List<Logs> allLogs = new List<Logs> ();
        public int makeWithdrawal(int amount,string reason)
        {
            return this.amount - amount;
        }

        public int makeDeposit(int amount)
        {
            return this.amount + amount;
        }
    }
}

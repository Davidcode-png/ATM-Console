using ATM_Console.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Console.Domain.Entities
{
    internal class Transaction
    {
        public long TransactionId { get; set; }
        public long UserBankAccountID { get; set; }
        public DateTime TransactionDate { get; set; }
        public TransactionType TransactionType { get; set; }
        public string? Description { get; set; }
        public Decimal TransactionAmount { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Console
{
    public class Logs
    {
        public string? notes { get; }
        public DateTime? date { get; }

        public Logs(string notes,DateTime date)
        {
            this.notes = notes;
            this.date = date;
        }
    }
}

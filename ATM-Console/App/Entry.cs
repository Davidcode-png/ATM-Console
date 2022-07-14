using ATM_Console.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Console.App
{
    internal class Entry
    {
        static void Main(string[] args)

        {
            

            ATM_App atmApp = new ATM_App();
            atmApp.InitializeData();
            atmApp.Run();
            //Utility.PressEnterToContinue();
        }
    }
}

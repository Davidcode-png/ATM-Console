using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ATM_Console.UI
{
    internal class Utility
    {
        private static long tranId;
        public static long GetTransactionId()
        {
            return ++tranId;
        }
        private static CultureInfo culture = new CultureInfo("yo-NG");

        //Thread.CurrentThread.CurrentCulture = culture;
        // Clone the NumberFormatInfo object and create
        // a new object for the local currency of France.
        //NumberFormatInfo LocalFormat = (NumberFormatInfo)NumberFormatInfo.CurrentInfo.Clone();
        public static string GetSecretInput(string prompt)
        {
            bool isPrompt = true;
            string asterics = "";

            StringBuilder input = new StringBuilder();
            while (true)
            {
                if (isPrompt) Console.WriteLine(prompt);
                isPrompt = false;
                ConsoleKeyInfo inputKey =  Console.ReadKey(true);

                if(inputKey.Key == ConsoleKey.Enter)
                {
                    if(input.Length == 6)
                    {
                        //Console.WriteLine("Check something");
                        break;
                    }
                    else
                    {
                        PrintMessage("\nPlease Enter 6 digits.", false);
                        isPrompt = true;
                        input.Clear();
                        continue;
                    }
                }
                if(inputKey.Key == ConsoleKey.Backspace && input.Length > 0)
                {
                    input.Remove(input.Length - 1,1);
                }
                else if(inputKey.Key != ConsoleKey.Backspace)
                {
                    input.Append(inputKey.KeyChar);
                    Console.Write(asterics + "*");
                }
            }
            return input.ToString();
        }
        public static void PrintMessage(string msg,bool success=true)
        {
            if (success)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            Console.WriteLine(msg);
            Console.ForegroundColor = ConsoleColor.Green;
            PressEnterToContinue();
        }
        public static string GetUserInput(string prompt)
        {
            Console.WriteLine($"Enter {prompt}");

            return Console.ReadLine();
        }
        public static void PressEnterToContinue()
        {
            Console.WriteLine("\nEnter to Continue...\n");
            Console.ReadLine();
        }

        public static void PrintDotAnimation(int timer = 10)
        {
            for (int i = 0; i < timer; i++)
            {
                Console.Write(".");
                Thread.Sleep(200);
            }
            Console.Clear();
        }

        public static string FormatAmount(decimal amt)
        {
            //return amt.ToString("C2",CultureInfo.CreateSpecificCulture("en-US"));
            return String.Format(culture, "{0:C2}", amt);
        }
    }
}

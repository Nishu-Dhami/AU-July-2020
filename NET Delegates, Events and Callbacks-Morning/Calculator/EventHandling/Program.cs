using System;
using System.IO;

namespace EventHandling
{
     public class ProcessEventArgs : EventArgs
    {
        public int num1 { get; set; }
        public int num2 { get; set; }
    }

    public class Calculator
    {
        public event EventHandler<ProcessEventArgs> ProcessCompleted;
        public void StartProcess()
        {
            var items = new ProcessEventArgs();
            try
            {
                Console.Write("Enter first number:");
                String a = Console.ReadLine();
                Console.WriteLine("");
                Console.Write("Enter second number:");
                String b = Console.ReadLine();
                Console.WriteLine("");
                items.num1 = Convert.ToInt32(a);
                items.num2 = Convert.ToInt32(b);
                Console.Write("Press Enter to calculate sum of entered numbers...");
                ConsoleKeyInfo keyinfo;
                keyinfo = Console.ReadKey();
                Console.WriteLine("");
                if (keyinfo.Key == ConsoleKey.Enter)
                {
                    OnProcessCompleted(items);
                } 
                else
                {
                    Console.WriteLine("You entered {0} key instead of Enter key.",keyinfo.Key);
                }   
            }
            catch (Exception ex)
            {
                Console.WriteLine("'{0}' exception occured!!!", ex);
            }
        }
        protected virtual void OnProcessCompleted(ProcessEventArgs e)
        {
            ProcessCompleted?.Invoke(this, e);
        }
    }

    class Program
    {
        public static void Main()
        {
            Calculator cal= new Calculator();
            cal.ProcessCompleted += cal_ProcessCompleted;
            cal.StartProcess();
        }
        public static void cal_ProcessCompleted(object sender, ProcessEventArgs e)
        {
            Console.WriteLine("Sum of {0} amd {1} is {2} ",e.num1,e.num2,e.num1 + e.num2);
        }

    }

}
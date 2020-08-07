using System;
using System.IO;

namespace LOG
{
    class Program
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        static void Main(string[] args)
        {
            Boolean flag = true;
            log.Info("Starting Execution!!!");
            try
            {
                string content = File.ReadAllText(@"C:\Users\nishu\Desktop\file.txt");
                Console.WriteLine(content);
            }
            catch (FileNotFoundException ex)
            {
                flag = false;
                Console.WriteLine("File not found! '{0}' exception occured".,ex);
                log.Error(ex.StackTrace);
            }
            catch (DirectoryNotFoundException ex)
            {
                flag = false;
                Console.WriteLine("Directory not found! C:\Users\nishu\Desktop caught '{0}' exception",ex.Message);
                log.Error(ex.StackTrace);
            }
            catch (Exception ex)
            {
                flag = false;
                Console.WriteLine("'{0}' exception occured",ex.Message);
            }
            finally
            {
                if (!flag)
                {
                    log.Warn("Unsuccessful Operation");
                }
                else
                {
                    Console.WriteLine("Finished . . .");
                    log.Info("Program Execution Ended\n\n");
                }
                
            }
            Console.ReadLine();
        }

    }
}
using System;
using System.IO;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(File.ReadAllText(@"C:\Users\nishu\Desktop\file.txt"));
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("File not found! '{0}' exception occured",e.Message);
            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine("Directory not found! '{0}' exception occured",e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("'{0}' exception occured!",e.Message);
            }
            finally
            {
                Console.WriteLine("Finished...");
            }
            Console.ReadLine();
        }
    }
}

using System;
using System.IO;
using System.Collections.Generic;

namespace File_Handling
{
    class Program
    {
        static void Main(string[] args)
        {
            string dir=@"C:\Users\nishu\Desktop\NET File Handling\File IO Handling\Files";
            if(!Directory.Exists(dir))
            Directory.CreateDirectory(dir);
            string file1=@"C:\Users\nishu\Desktop\NET File Handing\File IO Handling\Files\file.txt";
            try{
                using(StreamWriter writer=File.CreateText(file1))
                {
                    writer.WriteLine("Opening new file!!!");
                    writer.WriteLine("Name: Nishu Dhami");
                    writer.WriteLine("Adding info");
                    writer.WriteLine("Closing new file!!!");
                }

                var n= File.ReadAllLines(@"C:\\Users\\Desktop\\NET File Handing\\File IO Handling\\Files\\file.txt").Sum(s => s.Length);
                Console.WriteLine("No of Characters in file are {0}",n);

                try
                {
                    Stack <string> st = new Stack <string>();
                    int nooflines = 0;
                    using (StreamReader reader = new StreamReader(@"C:\\Users\\Desktop\\NET File Handing\\File IO Handling\\Files\\file.txt"))
                    {
                        while (reader.ReadLine()!= null)
                        {
                            st.Push(reader.ReadLine());
                            nooflines++;
                        }
                    }
                    using (StreamWriter newwriter = File.CreateText(@"C:\\Users\\Desktop\\NET File Handing\\File IO Handling\\Files\\newfile. txt"))
                    {
                        while(nooflines>0)
                        {
                            newwriter.WriteLine(st.Pop());
                            nooflines--;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("'{0}' exception occured!!!",ex.Message);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("'{0}' exception occured!!!",ex.ToString());
            }
        }
    }
}

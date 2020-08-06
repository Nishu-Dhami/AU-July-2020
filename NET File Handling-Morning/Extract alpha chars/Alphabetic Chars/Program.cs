using System;
using System.IO;

namespace Alphabetic_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter file path: ");
            string path=Console.ReadLine();
            Console.WriteLine();
            if (File.Exists(path))
            {
                try
                {
                    FileStream f1 = File.OpenRead(path);
                    byte[] filedata = new byte[f1.Length];
                    f1.Read(filedata, 0, (int)f1.Length);
                    f1.Close();

                    StreamWriter f2 = new StreamWriter("C:\\Users\\nishu\\Desktop\\NET File Handling\\Extract alpha chars\\newfile.txt");
                    for (int i = 0; i < filedata.Length; i++)
                    {
                        int val = Convert.ToInt32(filedata[i]);
                        if (val == 10 || val == 13 || (val >= 32 && val <= 127))
                            f2.Write(Convert.ToChar(filedata[i]));
                    }
                    f2.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("'{0}' exception occured!!!", ex.Message);
                }
            }
            else
            {
                Console.WriteLine("No file found at {0}", path);
                return;
            }

        }
    }
}

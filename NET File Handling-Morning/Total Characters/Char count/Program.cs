using System;

namespace Char_count
{
    class Program
    {
        public delegate int Character_Count(string a,string b);

        public static int func(string a,string b)
        {
            return a.Length + b.Length;
        }
        static void Main(string[] args)
        {
            Character_Count obj=new Character_Count(func);
            Console.Write("Enter first string: ");
            String a=Console.ReadLine();
            Console.WriteLine();
            Console.Write("Enter second string: ");
            String b=Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Total Characters in {0} and {1} are {2}.",a,b,obj(a,b));
        }
    }
}

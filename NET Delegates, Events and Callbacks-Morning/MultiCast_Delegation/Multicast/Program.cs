using System;

namespace Multicast
{
    public delegate string concatenate(string a, string b);
    class Program
    {
        public static string str=" string";
        public static string del1(string a,string b)
        {
            return (a.Length>=b.Length?a+str:b+str);
        }
        public static string del2(string a,string b)
        {
            return (a.Length<=b.Length?a+str:b+str);
        }

        static void Main(string[] args)
        {
            Console.Write("Enter first string: ");
            string a=Console.ReadLine();
            Console.WriteLine();
            Console.Write("Enter second string: ");
            string b=Console.ReadLine();
            Console.WriteLine();
            concatenate c1=new concatenate(del1);
            concatenate c2=new concatenate(del2);
            concatenate obj=c1+c2;
            Console.WriteLine(obj(a,b));

        }
    }
}

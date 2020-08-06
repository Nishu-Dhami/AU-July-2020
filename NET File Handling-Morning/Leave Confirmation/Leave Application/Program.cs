using System;

namespace Leave_Application
{
    public class Leave{
        public delegate void Notify();
        public event Notify LeaveStatus;
        private int Available;
        private int required;

        public Leave(int Available,int required)
        {
            this.Available=Available;
            this.required=required;
        }

        public void Status(){
            if(this.Available>=this.required)
            LeaveStatus?.Invoke();
            else
            Console.WriteLine("Only {0} leaves are available!!!",this.Available);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            String a,b;
            Console.Write("Enter no. of available leaves: ");
            a=Console.ReadLine();
            Console.WriteLine();
            Console.Write("Enter no. of leaves required: ");
            b=Console.ReadLine();
            Console.WriteLine();
            int avl = Int32.Parse(a);
            int req = Int32.Parse(b);
            Console.WriteLine();
            Leave obj=new Leave(avl,req);
            obj.LeaveStatus += obj_LeaveStatus;
            obj.Status();
        }
        public static void obj_LeaveStatus(){
            Console.Write("Do you want to apply for leave application(Y/N) : ");
            String ch=Console.ReadLine();
            Console.WriteLine();
            if(ch=="Y")
            Console.WriteLine("Leave request sent to the Manager for approval.");
            else
            Console.WriteLine("Leave Request Cancelled!!!");
        }
    }
}

using System;
using System.IO;
using System.Collections.Generic;

namespace GenericQueueDemo
{
    public class Student
    {
        public int RNo { get; set; }
        public string Name { get; set; }
        public int Grade {get; set;}
        public string Gender { get; set; }
        public int Score { get; set; }
    }
    public class main
    {
        static void Main(string[] args)
        {
            Student std1=new Student()
            {
                RNo=01,
                Name="Aakash",
                Grade=10,
                Gender="Male",
                Score=450
            };
            Student std2=new Student()
            {
                RNo=02,
                Name="Nishu",
                Grade=10,
                Gender="Female",
                Score=500
            };
            Student std3=new Student()
            {
                RNo=03,
                Name="Parul",
                Grade=10,
                Gender="Female",
                Score=400
            };
            Student std4=new Student()
            {
                RNo=04,
                Name="Rahul",
                Grade=10,
                Gender="Male",
                Score=420
            };
            Student std5=new Student()
            {
                RNo=05,
                Name="Sameeksha",
                Grade=10,
                Gender="Female",
                Score=480
            };
            
            Queue<Student> std_queue=new Queue<Student>();
            
            std_queue.Enqueue(std1);
            std_queue.Enqueue(std2);
            std_queue.Enqueue(std3);
            std_queue.Enqueue(std4);
            std_queue.Enqueue(std5);
            
            Console.WriteLine("Entering Class 10th Students Data: ");
            Console.WriteLine(" ");
            Console.WriteLine("RNo | Name | Grade | Gender | Score ");
            
            foreach(Student std in std_queue)
            {
                Console.WriteLine(std.RNo + " | " + std.Name+" | "+std.Grade+" | "+std.Gender+" | "+std.Score);
            }
            
            Console.WriteLine(" ");
            Console.WriteLine("Queue Length becomes "+std_queue.Count);
            Console.WriteLine(" ");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            
            Console.WriteLine(" ");
            Console.WriteLine("Reading Data of first student ");
            Console.WriteLine(" ");
            Console.WriteLine("RNo | Name | Grade | Gender | Score ");
            Student s=std_queue.Peek();
            Console.WriteLine(s.RNo + " | " + s.Name+" | "+s.Grade+" | "+s.Gender+" | "+ s.Score);
            
            Console.WriteLine(" ");
            
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            
            Console.WriteLine(" ");
            Console.WriteLine("Reading Class 10th Students Information");
            Console.WriteLine(" ");
            Console.WriteLine("RNo | Name | Grade | Gender | Score ");
            Student s1=std_queue.Dequeue();
            Console.WriteLine(s1.RNo + " | " + s1.Name+" | "+s1.Grade+" | "+s1.Gender+" | "+s1.Score);
            
            Student s2=std_queue.Dequeue();
            Console.WriteLine(s2.RNo + " | " + s2.Name+" | "+s2.Grade+" | "+s2.Gender+" | "+s2.Score);
            
            Student s3=std_queue.Dequeue();
            Console.WriteLine(s3.RNo + " | " + s3.Name+" | "+s3.Grade+" | "+s3.Gender+" | "+s3.Score);
            
            Student s4=std_queue.Dequeue();
            Console.WriteLine(s4.RNo + " | " + s4.Name+" | "+s4.Grade+" | "+s4.Gender+" | "+s4.Score);
            
            Student s5=std_queue.Dequeue();
            Console.WriteLine(s5.RNo + " | " + s5.Name+" | "+s5.Grade+" | "+s5.Gender+" | "+s5.Score);
        
            Console.WriteLine(" "); 
            Console.WriteLine("Queue Length becomes "+std_queue.Count);  
        }
        
    }
}

using System;
using System.Data;
using MySql.Data.MySqlClient;
using Microsoft.Data.SqlClient;

namespace ADO.net
{
    class SQLConnect
    {
        SqlConnecton conn;
        SqlDataAdaptor sqlad;
        DataSet db;

        public SQLConnect()
        {
            string str=null;
            MySqlConnection conn;
            str="server=localhost;databse=Nishu;uid=root;";
            conn=new MySqlConnection(str);
            conn.Open();
            db=new DataSet();
        }

        public void Student_Details()
        {
            Console.WriteLine("Student Details!!!");
            sqlad=new SqlDataAdaptor("Select * from Student",conn);
            db=new DataSet();
            sqlad.Fill(db);
            if(db!=null)
            {
                for(int i=0; i < db.Tables[0].Rows.Count ; i++)
                {
                    Console.WriteLine("RollNo.: "+db.Tables[0].Rows[i]["RNo"]+" | Name: "+db.Tables[0].Rows[i]["Name"]+" | Block: "+db.Tables[0].Rows[i]["BNo"]);
                }
            }
        }

        public void Block_Details()
        {
            Console.WriteLine("Displaying Block details!!!");
            sqlad=new SqlDataAdaptor("Seclect * from Block",conn);
            db=new DataSet();
            sqlad.Fill(db);
            if(db!=null)
            {
                for(int i=0;i<db.Tables[0].Rows.Count;i++)
                {
                    Console.WriteLine("Block ID: "+db.Tables[0].Rows[i]["BNo"]+" | Block Name: "+db.Tables[0].Rows[i]["BName"]);
                }
            }
        }

        public void Add_Block()
        {
            Console.Write("Enter Block Number : ");
            string bno=Console.ReadLine();
            Console.Write("Enter Block name : ");
            string bname=Console.ReadLine();
            string query="execute Insert_Block "+"'"+bno+"'"+","+"'"+bname+"'"+";";

            SqlCommand cmd =new SqlCommand(query,conn);
            Console.WriteLine("Rows inserted to Block Table");
        }

        public void Add_Student()
        {
            Console.Write("Enter Roll No.: ");
            string rno=Console.ReadLine();
            Console.Write("Enter Student Name: ");
            string name=Console.ReadLine();
            Console.Write("Enter Block Assigned to Student: ");
            string blck=Console.ReadLine();
            string query="execute Insert_Student "+"'"+rno+"'"+","+"'"+name+"'"+","+"'"+blck+"'"+";";
            Console.WriteLine("Details of one student added!!!");
        }

        public Remove_Student()
        {
            string rno;
            Console.Write("Enter RollNo. of students whose details you want to erase: ");
            rno=Console.ReadLine();
            string query="execute delete_from_Student "+"'"+RowNotInTableException+"'"+";";
            int rowAffected=0;
            SqlCommand cmd=new SqlCommand(query,conn);
            rowAffected=ConsoleModifiers.ExecuteNonQuery();
            Console.WriteLine("Student Details deleted successfully!");
        }
        public void assign_block()
        {
            Console.WriteLine("Assigning block!!!");
            string query = "execute block_of_Student;";
            sqlad=new SqlDataAdaptor(query,conn);
            db=new DataSet();
            sqlad.Fill(db);
            if(db!=null)
            {
                for(int i=0;i<db.Tables[0].Rows.Count;i++)
                {
                    Console.WriteLine("RollNo: "+db.Tables[0].Rows[i]["RNo"]+" | Name: "+db.Tables[0].Rows[i]["Name"]+" | Block_Name:"+ds.Tables[0].Rows[i]["BName"]);
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SQLConnect obj=new SQLConnect();
            obj.Add_Block();
            obj.Block_Details();
            obj.Add_Student();
            obj.Student_Details();
            obj.Remove_Student();
            obj.assign_block();
        }
    }
}

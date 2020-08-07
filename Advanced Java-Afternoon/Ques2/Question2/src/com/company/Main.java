package com.company;
import java.awt.event.MouseAdapter;
import java.util.*;
import java.io.*;
import  org.dom4j.*;
import org.dom4j.io.SAXReader;

public class Main {

    public static  void addrecord(PrintWriter myfile, int RollNo, String FirstName, String Middlename, String Lastname, String Gender,float marks){
        try {
            myfile.println("RollNo: " + RollNo);
            myfile.println("FirstName: " + FirstName);
            myfile.println("MiddleName: " + Middlename);
            myfile.println("LastName: " + Lastname);
            myfile.println("Gender: " + Gender);
            myfile.println("Marks: " + marks);
        }
        catch (Exception ex){
            System.out.println(ex.getMessage());
        }
    }
    public static void main(String[] args) {
        PrintWriter myfile=null;
        int RollNo=0;
        String FirstName=null;
        String MiddleName=null;
        String LastName=null;
        String Gender=null;
        float Marks=0;
        try{
            File file=new File("/home/nishu/AU_2020/assgn/AU-July-2020/Advanced Java-Morning/Ques2/Question2/output.txt");
            if (file.createNewFile()){
                System.out.println("New File "+file.getName()+" created!");
            }
            else
            {
                System.out.println("File already exists");
            }

            File input=new File("./input.txt");
            SAXReader saxReader=new SAXReader();
            Document document=saxReader.read(input);
            List<Node> nodes=document.selectNodes("/class/student");

            for (Node n: nodes){
                RollNo=Integer.parseInt(n.valueOf("@rollno"));
                FirstName=n.selectSingleNode("name/firstname").getText();
                MiddleName=n.selectSingleNode("name/middlename").getText();
                LastName=n.selectSingleNode("name/lastname").getText();
                Gender=n.selectSingleNode("gender").getText();
                Marks=Float.parseFloat(n.selectSingleNode("marks").getText());
            }
            myfile=new PrintWriter("/home/nishu/AU_2020/assgn/AU-July-2020/Advanced Java-Morning/Ques2/Question2/output.txt");
            addrecord(myfile,RollNo,FirstName,MiddleName,LastName,Gender, Marks);
            System.out.println("Record Added Successfully!");
        }
        catch (IOException|DocumentException ex){
            ex.printStackTrace();
        }
        finally {
            try{
                if(myfile!=null){
                    myfile.close();}}
            catch (Exception ex){
                ex.printStackTrace();
            }
        }
    }
}

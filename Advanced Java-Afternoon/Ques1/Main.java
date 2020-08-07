package com.company;
import java.io.*;
import  java.util.*;

public class Main {
        static int result=0;
        public static void nooffiles(String path) {
            File file= new File(path);
            File[] file_list=file.listFiles();
            if(file_list!=null) {
                for (int i = 0; i < file_list.length; i++) {
                    result++;
                    File f = file_list[i];
                    System.out.println("File "+i+": "+f);
                    if (f.isDirectory()) {
                        nooffiles(f.getAbsolutePath());
                    }
                }
            }
        }
    public  static void main(String[] args)
    {
        String path="/home/nishu/AU_2020/assgn/AU-July-2020/HTML-CSS-Evening";
        nooffiles(path);
        System.out.println("No of files in given path are: "+result);
    }
}


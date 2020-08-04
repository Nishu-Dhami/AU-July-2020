package com.company;

import java.awt.*;
import java.util.*;
import java.util.List;
import  java.util.concurrent.*;

class BlockingQueue{

    private List<Integer> list = new ArrayList<>();
    private int data;
    private int limit;

    public BlockingQueue(int limit){
        this.limit=limit;
    }
    public synchronized void put() {
        while(true) {
            if(list.size() >=limit) {
                System.out.println("Queue limit reached! No more items can be added");
                try {
                    wait();
                } catch(InterruptedException e) {
                    e.printStackTrace();
                }
            }
            else {
                System.out.println("Enter item to insert: ");
                Scanner sc1=new Scanner(System.in);
                this.data=sc1.nextInt();
                System.out.println(Thread.currentThread().getName() + " added " + this.data +" to the queue.");
                list.add(this.data);
                notifyAll();
            }
        }
    }

    public synchronized void take() {
        while(true) {
            if(list.size() == 0) {
                System.out.println("Queue is Empty. No item to take out.");
                try {
                    wait();
                } catch(InterruptedException e) {
                    e.printStackTrace();
                }
            }
            else {
                int size=list.size();
                int num=list.remove(0);
                System.out.println(Thread.currentThread().getName() + " took out " + num);
                notify();
            }
        }
    }
}

public class Main {

    public static void main(String[] args) throws InterruptedException {
        System.out.println("Enter no.of consumer threads you want to create: ");
        Scanner sc = new Scanner(System.in);
        int n = sc.nextInt();
        System.out.println("Enter queue limit: ");
        Scanner scn=new Scanner(System.in);
        int limit=scn.nextInt();
        BlockingQueue queue = new BlockingQueue(limit);

        Thread t1=new Thread(()-> {
            queue.put();
        });
        t1.start();
        ExecutorService t2 = Executors.newFixedThreadPool(n);
        for (int i = 0; i < n; i++) {
            t2.submit(new Runnable() {
                public void run() {
                    queue.take();
                }
            });
        }
    }
}

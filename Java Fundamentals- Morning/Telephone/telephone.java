import java.util.*;
import java.io.*; 

interface telephone_interface{
    void dial(String s); // Make a call to the 10 digit input string
    void end_call(); //End the current call
    void redial_number(); // Redial the last dialed number
    void receive_call(String r); // Recieve a call
    void call_history(); // Shows dial call history of user
}

class telephone implements telephone_interface{
    
    public boolean calling;
    public  Stack<String> contacts = new Stack<String>(); 
    
    telephone(){
        calling= false;
        contacts.push("No outgoing or incoming calls!");
    }

    @Override
    public void dial(String str)
    {
        String number;
        if(!calling)
        {
            if(str.matches(" "))
            {
                System.out.println("Dial a number");
                Scanner sc= new Scanner(System.in);   
                System.out.print("Enter a valid 10 digit number: ");  
                number= sc.nextLine();
            }
            else{ number=str; }
            if(contacts.peek()=="No outgoing or incoming calls!"){contacts.pop();}
            contacts.push(number);
            System.out.println("Dialing "+ number);
            end_call();
        }
        else 
        {
            System.out.println("Person is on another call!");
        }
        
    }

    @Override    
    public void end_call()
    {
            System.out.println("Call Ended");
            calling = false;
    }

    @Override    
    public void redial_number()
    {
        if(!calling)
        {
           String str = contacts.peek(); 
           System.out.println("Redialling "+str);
           dial(str);
        }
        else{
            System.out.println("Cannot make a call while being on another call");
        }
    }

    @Override
    public void receive_call(String str)
    {
        calling=true;
        System.out.println("Incoming call from "+ str);
        System.out.println("Recieved the call");
        end_call();
    }  
    
    @Override
    public void call_history()
    {
        System.out.println("Call logs \n"+contacts);
    }
}
public class Main{
    public static void main(String[] args) {
        telephone t = new telephone();
        t.dial("8168578735");
        t.dial("9728570051");
        t.redial_number();
        t.dial(" ");
        t.call_history();
        t.receive_call("8685894074");
        t.call_history();
    }
}
using System;

class Program
{
    
    static void Main(string[] args)
    {
        int age = 30;
        double salary = 1000.50;
        string name = "John";
        bool isEmployed = true;
        // Console.WriteLine("Hello mY NAME Is Rachit");
    

        if (age >= 18)
        {
            Console.WriteLine("You are an\t adult.");// \t sequence will add a tab.
        }
        else
        {
            Console.WriteLine("You are a minor."+"Your age:\n"+ age);
        }
        Console.WriteLine(name);
        //If We use Console.Write() multiple times consecutively, it will keep appending the output without any separation or new line between the subsequent calls.
        Console.Write(salary);
        Console.Write(isEmployed );
    }
}
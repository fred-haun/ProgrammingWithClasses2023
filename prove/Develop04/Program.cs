using System;
using System.Timers;
using System.Threading;
class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        menu.Choice();
    }
}

class Menu
{
    public void Choice()
    {
        bool hasChoosen = false;
        while(hasChoosen == false)
        {
            Console.WriteLine("Menu Options");
            Console.WriteLine("\t1. Start breathing activity");
            Console.WriteLine("\t2. Start reflecting activity");
            Console.WriteLine("\t3. Start listing activity");
            Console.WriteLine("\t4. Quit");
            Console.Write("Select a choice from the menu: ");
            string menuChoice = Console.ReadLine();
            if (menuChoice == "1")
            {
                Breathing breath = new Breathing();
                breath.breathing();
                hasChoosen = true;
            }
            else if (menuChoice == "2")
            {
                Reflecting reflect = new Reflecting();
                reflect.reflecting();
                hasChoosen = true;
            }
            else if (menuChoice == "3")
            {
                Listing listen = new Listing();
                listen.listing();
                hasChoosen = true;
            }
            else if (menuChoice == "4")
            {
                System.Environment.Exit(1);
            }
            else
            {
                Console.WriteLine("WRONG!!!");
            }
        }  
    }
}

class Breathing
{
    public void breathing()
    {
        Console.WriteLine("Welcome to the Breathing Activity.\n");
        Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.\n");
        Console.Write("How many breathing cycles would you like to complete? ");
        int cycleNumber = Convert.ToInt32(Console.ReadLine());

        while(cycleNumber > 0)
        {
            Console.WriteLine(cycleNumber);
            cycleNumber -= 1;
        }
    }
}

class Reflecting
{
    public void reflecting()
    {
        Console.WriteLine("Welcome to the Reflecting Activity.\n");
        Console.WriteLine("This activity will help you reflect on times in your life when you have show strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.\n");
        Console.Write("How long in seconds ");
    }
}

class Listing
{
    public void listing()
    {
        Console.WriteLine("Bogos Binted");
    }
}

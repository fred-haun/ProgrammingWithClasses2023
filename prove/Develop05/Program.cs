using System;
using System.IO;
using System.Xml.Serialization;
class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        menu.Options();
    }
}
class Menu
{
    public int points = 0;
    public void Options()
    {
        bool vaildchoice = false;
        while (vaildchoice == false)
        {
            Console.WriteLine($"\nYou have {points} points.\n");
            Console.WriteLine("Menu Options");
            Console.WriteLine(" 1. Create New Goal");
            Console.WriteLine(" 2. List Goals");
            Console.WriteLine(" 3. Save Goals");
            Console.WriteLine(" 4. Load Goals");
            Console.WriteLine(" 5. Record Event");
            Console.WriteLine(" 6. Quit");
            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                CreateGoal creategoal = new CreateGoal();
                creategoal.whichGoal();
            }
            else if (choice == "2")
            {
                notReady();
                vaildchoice = true;
            }
            else if (choice == "3")
            {
                notReady();
                vaildchoice = true;
            }
            else if (choice == "4")
            {
                notReady();
                vaildchoice = true;
            }
            else if (choice == "5")
            {
                vaildchoice = true;
                notReady();
            }
            else if (choice == "6")
            {
                Console.WriteLine("Have a good day!");
                System.Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Not a choice bruh");
            }
        }   
    }
    public void notReady()
    {
        Console.WriteLine("Not ready yet bruh");
    }
}
class Points
{
    public int points;
    public int newpoints;
    public int currentpoints;
    public int Point()
    {
        currentpoints = newpoints + points;
        return currentpoints;
    }
}
class CreateGoal
{
    public void whichGoal()
    {
        string goalChoice;
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine(" 1. Simple Goal");
        Console.WriteLine(" 2. Eternal Goal");
        Console.WriteLine(" 3. Checklsut Goal");
        Console.Write("Which type of goal would you like to create? ");
        goalChoice = Console.ReadLine();
        if (goalChoice == "1")
        {
            simpleGoal();
        }
    }
    public void simpleGoal()
    {
        Console.Write("What is the name of your goal? ");
        string newgoal = Console.ReadLine();
    }
}
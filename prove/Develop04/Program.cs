using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Security.Cryptography.X509Certificates;
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
    public string choice;
    public void Choice()
    {
        Console.Clear();
        bool validChoice = false;
        while (validChoice == false)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Start breathing activity");
            Console.WriteLine(" 2. Start reflecting activity");
            Console.WriteLine(" 3. Start listing activity");
            Console.WriteLine(" 4. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();
            if (choice == "1")  
            {
                Breathing breathing = new Breathing();
                breathing.prompt();
                breathing.getReady();
                validChoice = true;
            }
            else if (choice == "2")
            {
                Reflecting reflect = new Reflecting();
                reflect.prompt();
                validChoice = true;
            }
            else if (choice == "3")
            {
                Listing listing = new Listing();
                listing.prompt();
                validChoice = true;
            }

            else if (choice == "4")
            {
                Console.WriteLine("Have a good day!");
                System.Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Not a vaild choice");
                validChoice = false;
            }
        }
    }
}

class Breathing
{
    public string whichPart;
    public int seconds;
    public void prompt()
    {
        Console.Clear();
        Console.WriteLine("Welcome to the Breathing Activity.\n");
        Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly. Clear yout mind and focus on your breathing.\n");
        Console.Write("How long, in increments of 10 seconds, would you like your session? ");
        string sec = Console.ReadLine();
        seconds = Convert.ToInt32(sec);
        getReady();
    }
    public void getReady()
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
        whichPart = "3";
        loading();
    }
    public void breath()
    {
        int cycles = seconds / 10;
        while (cycles != 0)
        {
            Console.Write("Breath in...");
            Console.Write("5");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("4");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("3");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("2");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("1");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.WriteLine("");
            Console.Write("Now breath out...");
            Console.Write("5");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("4");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("3");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("2");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("1");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.WriteLine("");
            cycles -= 1;
        }
        Console.WriteLine("");
        whichPart = "2";
        loading();
    }
    public void wellDone()
    {
        Console.WriteLine("Well done!");
        Console.WriteLine("");
        whichPart = "1";
        loading();
    }
    public void completion()
    {
        Console.WriteLine($"You have completed another {seconds} seconds of the Breathing Activity.");
        Console.WriteLine("");
        whichPart = "0";
        loading();       
    }

    public void loading()
    {
        int loading = 3;
        while (loading != 0)
        {
            Console.Write("-");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("|");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(500);
            Console.Write("\b \b");
            loading -= 1;
        }
        if (whichPart == "3")
        {
            breath();
        }
        else if (whichPart == "2")
        {
            wellDone();
        }
        else if (whichPart == "1")
        {
            completion();
        }
        else
        {
        Menu menu = new Menu();
        menu.Choice();
        }
    } 
}

class Listofprompts
{
    public string _generatePrompt;

    public void display()
    {
        Random rand = new Random();
        int number = rand.Next(0, 7);
        if (number == 1)
        {
            _generatePrompt = " --- Think of a time where you overcame a challenge. ---";
        }
        else if (number == 2)
        {
            _generatePrompt = " --- Think of a time when you made a good friend. ---";
        }
        else if (number == 3)
        {
            _generatePrompt = " --- Think of a time when you provided service to others. ---";
        }
        else if (number == 4)
        {
            _generatePrompt = " --- Think of a time that brings you great joy. ---";
        }
        else if (number == 5)
        {
            _generatePrompt = " --- Think about where you want to be in five years. ---";
        }
        else if (number == 6)
        {
            _generatePrompt = " --- Think of the little service oppritunities you can do on a daily basis. ---";
        }
        else
        {
            _generatePrompt = " --- Think only kind thoughts about yourself. ---";
        }

        Console.WriteLine($"{_generatePrompt}");
    }
}
class Listofquestions
{
    public string _generatequestion1;
    public string _generatequestion2;

    public void q1()
    {
        Random rand = new Random();
        int number = rand.Next(0, 5);
        if (number == 1)
        {
            _generatequestion1 = " > How did you feel when it was complete? ";
        }
        else if (number == 2)
        {
            _generatequestion1 = " > What is your favorite thing about this experiance? ";
        }
        else if (number == 3)
        {
            _generatequestion1 = " > How will you apply these feelings? ";
        }
        else
        {
            _generatequestion1 = " > Do you feel happy? If not, why not? ";
        }
        Console.Write($"{_generatequestion1}");
    }
    public void q2()
    {
        Random rand = new Random();
        int number = rand.Next(0, 5);
        if (number == 1)
        {
            _generatequestion2 = "\n > What makes this a positive experiance? ";
        }
        else if (number == 2)
        {
            _generatequestion2 = "\n > What can you do to positively reinforce yourself? ";
        }
        else if (number == 3)
        {
            _generatequestion2 = "\n > Will today be a good day? ";
        }
        else
        {
            _generatequestion2 = "\n > How are you in general? ";
        }
        Console.Write($"{_generatequestion2}");
    }

}
class Reflecting
{
    public int seconds;
    public string whichPart;
    public int waittime = 1;
    public void prompt()
    {
        Console.Clear();
        Console.WriteLine("Welcome to the Reflecting Activity.");
        Console.WriteLine("");
        Console.WriteLine("This activity will help you relect on times in your life when you have shown strength and resilience. This will help you recognise the power you have and how you can use it in other aspects of yor life.}");
        Console.WriteLine("");
        Console.Write("How long, in seconds, would you like for your session? ");
        string sec = Console.ReadLine();
        seconds = Convert.ToInt32(sec);
        getReady();
    }
    public void getReady()
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
        whichPart = "5";
        loading();
    }
    public void getPrompt()
    {
        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine("");
        Listofprompts prompts = new Listofprompts();
        prompts.display();
        Console.WriteLine("");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experiance.");
        Console.Write("You may begin in: ");
        Console.Write("5");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("4");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("3");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("2");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("1");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.WriteLine("");
        question1();
    }
    public void question1()
    {
        Console.Clear();
        waittime = seconds / 6;
        Listofquestions question = new Listofquestions();
        question.q1();
        whichPart = "4";
        loading();
    }
    public void question2()
    {
        waittime = seconds / 6;
        Listofquestions question = new Listofquestions();
        question.q2();
        whichPart = "3";
        loading();
    }
    public void loading()
    {
        if (whichPart == "2" || whichPart == "1")
        {
            waittime = 1;
        }
        while (waittime != 0)
        {
            int loading = 3;
            while (loading != 0)
            {
                Console.Write("-");
                Thread.Sleep(250);
                Console.Write("\b \b");
                Console.Write("\\");
                Thread.Sleep(250);
                Console.Write("\b \b");
                Console.Write("|");
                Thread.Sleep(250);
                Console.Write("\b \b");
                Console.Write("/");
                Thread.Sleep(250);
                Console.Write("\b \b");
                loading -= 1;
            }
            waittime -=1;
        }
        if (whichPart == "5")
        {
            getPrompt();
        }
        else if (whichPart == "4")
        {
            question2();
        }
        else if (whichPart == "3")
        {
            welldone();
        }
        else if (whichPart == "2")
        {
            completion();
        }
        else
        {
            Menu menu = new Menu();
            menu.Choice();
        }
    }
    public void welldone()
    {
        Console.WriteLine("");
        Console.WriteLine("\nWell Done!!");
        whichPart = "2";
        loading();
    }
    public void completion()
    {
        Console.WriteLine($"\nYou have completed another {seconds} seconds of the Reflecting Activity.");
        whichPart = "1";
        loading();
    }
}
class Listing
{
    public int seconds;
    public string whichPart;
    public string answer;
    public void prompt()
    {
        Console.Clear();
        Console.WriteLine("Welcome to the Listing Activity.");
        Console.WriteLine("");
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many good things as you can in a certain area.}");
        Console.WriteLine("");
        Console.Write("How long, in seconds, would you like for your session? ");
        string sec = Console.ReadLine();
        seconds = Convert.ToInt32(sec);
        getReady();
    }
    public void getReady()
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
        whichPart = "5";
        loading();
    }
    public void loading()
    {
        int loading = 3;
        while (loading != 0)
        {
            Console.Write("-");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("|");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(250);
            Console.Write("\b \b");
            loading -= 1;
        }
        if (whichPart == "5")
        {
            list();
        }
        else if (whichPart == "4")
        {
            completion();
        }
        else
        {
            Menu menu = new Menu();
            menu.Choice();
        }
    }
    public void list()
    {
        Console.WriteLine("\nList as many responses you can to the following prompt:");
        Listofprompts prompts = new Listofprompts();
        prompts.display();
        Console.Write("You may begin in: ");
        Console.Write("5");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("4");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("3");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("2");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("1");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.WriteLine("");
        write();
    }
    public void write()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(seconds);
        int answers = 0;
        while (DateTime.Now < futureTime)
        {
            Console.Write(" > ");
            answer = Console.ReadLine();
            answers += 1;
        }
        Console.WriteLine($"You listed {answers} items!\n");
        Console.WriteLine("Well done!!");
        whichPart = "4";
        loading();
    }
    public void completion()
    {
        Console.WriteLine($"You have completed another {seconds} seconds of the Listening Activity.");
        whichPart = "3";
        loading();
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
class Program
{
    static void Main(string[] args)
    {
        Choice choice = new Choice();
        choice.choice();
    }
}

class Choice
{
    public void choice()
    {
        Console.WriteLine("Welcome to games! \n \nPlease choose a game.");
        Console.WriteLine(" 1. Tic-Tac-Toe");
        Console.WriteLine(" 2. Slot Machine");
        Console.WriteLine(" 3. Quit");
        bool invalidchoice = true;
        while (invalidchoice == true)
        {
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                Console.Clear();
                Tictactoerules tictactoerules = new Tictactoerules();
                tictactoerules.text();                
                invalidchoice = false;
            }
            else if (choice == "2")
            {
                Console.Clear();
                Slotmachinerules slotmachinerules = new Slotmachinerules();
                slotmachinerules.text();
                invalidchoice = false;
            }
            else if (choice == "3")
            {
                Console.WriteLine("Have a good day!");
                System.Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Not a vaild choice.");
            }
        }    
    }
}

class Tictactoe
{
    public string XorO()
    {
        bool validchoice = false; 
        string XO = " ";
        while (validchoice == false)
        {
            Console.Clear();
            Console.WriteLine("Choose either X or O \n1. X\n2. O\n");
            string XOchoice = Console.ReadLine();
            if (XOchoice == "1")
            {
                validchoice = true;
                XO = "X";
            }
            else if (XOchoice == "2")
            {
                validchoice = true;
                XO = "O";
            }
            else
            {
                Console.WriteLine("Not a choice. Try again");
            }
        }
        other(XO);
        return XO;
    }
    public string other(string XO)
    {
        string XOcom;
        if (XO == "X")
        {
            XOcom = "O";
        }
        else
        {
            XOcom = "X";
        }
        Tttgame(numbers, XO, XOcom);
        return XOcom;
    }
    List<string> numbers = new List<string> { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
    public void Tttgame(List<string> numbers, string XO, string XOcom)
    {
        Loading loading = new Loading();
        Outcome outcome = new Outcome();
        Console.Clear();
        int turns = 0;
        bool endgame = false;
        while (endgame == false)
        {
            Console.Clear();
            Console.WriteLine($" {numbers[6]} | {numbers[7]} | {numbers[8]} \n___________\n\n {numbers[3]} | {numbers[4]} | {numbers[5]} \n___________\n\n {numbers[0]} | {numbers[1]} | {numbers[2]} \n");
            Console.WriteLine("Please make a choice: ");
            bool invalidchoice = true;

            while (invalidchoice == true)
            {
                string choice = Console.ReadLine();
                int intchoice = Convert.ToInt32(choice);
                if (intchoice >= 10 || intchoice <= 0)
                {
                    Console.WriteLine("Not a choice\nTry again: ");
                }
                else if (numbers[intchoice - 1] == "X" || numbers[intchoice - 1] == "O")
                {
                    Console.WriteLine("Already Chosen\nTry again: ");
                }
                else
                {
                    numbers[intchoice - 1] = XO;
                    invalidchoice = false;
                }
            }
            turns += 1;
            Console.Clear();
            Console.WriteLine($" {numbers[6]} | {numbers[7]} | {numbers[8]} \n___________\n\n {numbers[3]} | {numbers[4]} | {numbers[5]} \n___________\n\n {numbers[0]} | {numbers[1]} | {numbers[2]} \n");
            if (numbers[0] == XO && numbers[1] == XO && numbers[2] == XO ||
                numbers[3] == XO && numbers[4] == XO && numbers[5] == XO ||
                numbers[6] == XO && numbers[7] == XO && numbers[8] == XO ||
                numbers[0] == XO && numbers[3] == XO && numbers[6] == XO ||
                numbers[1] == XO && numbers[4] == XO && numbers[7] == XO ||
                numbers[2] == XO && numbers[5] == XO && numbers[8] == XO ||
                numbers[0] == XO && numbers[4] == XO && numbers[8] == XO ||
                numbers[6] == XO && numbers[4] == XO && numbers[2] == XO)
            {
                outcome.win();
            }
            else if (turns == 9)
            {
                outcome.neither();
            }
            loading.loading();
            bool invalidAI = true;
            while (invalidAI == true)
            {
                Random rand = new Random();
                int okay = rand.Next(0, 9);
                if (numbers[okay] == "X" | numbers[okay] == "O")
                {
                    okay += 1 % 9;
                }
                else
                {
                    numbers[okay] = XOcom;
                    turns += 1;
                    invalidAI = false;
                }
            }
            Console.Clear();
            Console.WriteLine($" {numbers[6]} | {numbers[7]} | {numbers[8]} \n___________\n\n {numbers[3]} | {numbers[4]} | {numbers[5]} \n___________\n\n {numbers[0]} | {numbers[1]} | {numbers[2]} \n");
            if (numbers[0] == XOcom && numbers[1] == XOcom && numbers[2] == XOcom ||
                numbers[3] == XOcom && numbers[4] == XOcom && numbers[5] == XOcom ||
                numbers[6] == XOcom && numbers[7] == XOcom && numbers[8] == XOcom ||
                numbers[0] == XOcom && numbers[3] == XOcom && numbers[6] == XOcom ||
                numbers[1] == XOcom && numbers[4] == XOcom && numbers[7] == XOcom ||
                numbers[2] == XOcom && numbers[5] == XOcom && numbers[8] == XOcom ||
                numbers[0] == XOcom && numbers[4] == XOcom && numbers[8] == XOcom ||
                numbers[6] == XOcom && numbers[4] == XOcom && numbers[2] == XOcom)
            {
                outcome.fail();
            }
        }
    }
}
class Loading
{
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
    }
}
class Outcome
{
    Playagain playagain = new Playagain();
    public void fail()
    {
        Console.WriteLine("Sorry, the computer wins.\n");
        playagain.playagainttt();
    }
    public void fails()
    {
        Console.WriteLine("Sorry, you wan out of money.\n");
        playagain.playagains();
    }
    public void win()
    {
        Console.WriteLine("You are a Winner!\n");
        playagain.playagainttt();
    }
    public void neither()
    {
        Console.WriteLine("Nobody wins.\n");
        playagain.playagainttt();
    }

}
class Playagain
{
    Loading loading = new Loading();
    private void prompt()
    {
        Console.WriteLine("Would you like to play again?\n1. Yes\n2. No");
    }
    public void playagainttt()
    {
        loading.loading();
        Console.Clear();
        bool invalidchoice = true; 
        prompt();
        while (invalidchoice == true)
        {
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                Tictactoe tictactoe = new Tictactoe();
                tictactoe.XorO();
            }
            else if (choice == "2")
            {
                Console.WriteLine("Have a good day!\n");
                System.Environment.Exit(0);
            }
        }
    }
    public void playagains()
    {
        loading.loading();
        Console.Clear();
        bool invalidchoice = true; 
        prompt();
        while (invalidchoice == true)
        {
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                Slotmachine slotmachine = new Slotmachine();
                slotmachine.startmoney();
            }
            else if (choice == "2")
            {
                Console.WriteLine("Have a good day!\n");
                System.Environment.Exit(0);
            }
        }
    }
}

class Slotmachine
{
    Loading loading = new Loading();
    Random rand = new Random();
    public int startmoney()
    {
        Console.WriteLine("How much money do you have? ");
        string startmoney = Console.ReadLine();
        int intstartmoney = Convert.ToInt32(startmoney);
        if (intstartmoney <= 0)
        {
            Console.WriteLine("You are to broke to play.");
            System.Environment.Exit(0);
        } 
        display(intstartmoney);
        return intstartmoney;
    }
    public void display(int intstartmoney)
    {
        float currentmoney = (float)intstartmoney;
        Console.Clear();
        float firstnum = 0;
        float secondnum = 0;
        float thirdnum = 0;
        bool endgame = false;
        while (endgame == false)
        {
            bool badbet = true;
            while (badbet == true)
            {
                Console.WriteLine($"_____________\n|           |\n|  {firstnum}  {secondnum}  {thirdnum}  |\n|___________|");
                Console.WriteLine($"You have ${currentmoney.ToString("n2")}");
                Console.WriteLine("How much do you want to bet? (or press Q to quit)");
                string bet = Console.ReadLine();
                if (bet == "q" || bet == "Q")
                {
                    Playagain playagain = new Playagain();
                    playagain.playagains();
                } 
                float floatbet = Convert.ToSingle(bet);
                if (floatbet > currentmoney || floatbet <= 0)
                {
                    Console.WriteLine("Not a vaild amount");
                }
                else
                {
                    loading.loading();
                    Console.Clear();
                    firstnum = rand.Next(0,10);
                    secondnum = rand.Next(0,10);
                    thirdnum = rand.Next(0,10);
                    currentmoney = ((currentmoney - floatbet) + ((firstnum + secondnum + thirdnum) / 14) * floatbet); 
                    if (currentmoney <= 0)
                    {
                        Outcome outcome = new Outcome();
                        outcome.fails();
                    }
                    badbet = false;
                }
            }      
        }
    }
}
class Slotmachinerules
{
    Slotmachine slotmachine = new Slotmachine();
    public void text()
    {
        Console.Clear();
        Console.WriteLine("Three numbers from 0 - 9 will appear whenever you make a bet. These numbers will be added together, divided by 14, and multipled by your bet. You will win money every turn, but it's likely that the money recieved will be less than your bet.");
        Console.WriteLine("\nHit enter when ready");
        Console.ReadLine();
        slotmachine.startmoney();
    }
}
class Tictactoerules
{
    Tictactoe tictactoe = new Tictactoe();
    public void text()
    {
        Console.Clear();
        Console.WriteLine("You will play against a computer opponent. Your goal is to match three in a row. Choose where to put put piece by typing in the number on the board.");
        Console.WriteLine("\nHit enter when ready");
        Console.ReadLine();
        tictactoe.XorO();
    }
}
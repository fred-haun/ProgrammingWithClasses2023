using System;

public class choice
{
    public void choices()
    {
        Console.WriteLine("");
        getScripture scripture = new getScripture();
        scripture.scripture();
        Console.WriteLine("");
        Console.WriteLine("Press enter to continue or type 'quit' to finish");
        string Choice = Console.ReadLine();
        string choice = Choice.ToLower();
        if(choice == "quit")
        {
            Console.WriteLine("Goodbye!");
        }
    }
}
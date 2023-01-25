using System;
using System.Collections.Generic;
public class choices
{
    public string _choice;
    public bool endloop;
    writing write =  new writing();

    public void entry()
    {

        bool endloop = false;
        while (endloop == false)
        {
            endloop = false;
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            _choice =  Console.ReadLine();
            generatePrompts prompt = new generatePrompts();
            if (_choice == "1")
            {
                prompt.display();
                write.entry();
                Console.WriteLine(write.entries[0]);
            }
            else if (_choice == "2")
            {
                write.saved();
                Console.WriteLine(write.entries.Count);
            }
            else if (_choice == "3")
            {
                Console.WriteLine("not ready yet");
                endloop = true;
            }
            else if (_choice == "4")
            {
                Console.WriteLine("not ready yet");
                endloop = true;
            }
            else if (_choice == "5")
            {
                Console.WriteLine("Goodbye!");
                endloop = true;
            }
            else
            {
                Console.WriteLine("Not a choice yo.");
            }
        }
    }

}
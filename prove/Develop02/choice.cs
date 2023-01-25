using System;

public class choices
{
    public string _choice;

    public void entry()
    {

        bool endloop = false;
        while (endloop == false)
        {
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            _choice =  Console.ReadLine();
            if (_choice == "1")
            {
                endloop = true;
            }
            else if (_choice == "2")
            {
                Console.WriteLine("not ready yet");
                endloop = true;
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
using System;

class Program
{
    static void Main(string[] args)
    {
        choices choice = new choices();
        choice.entry();
        generatePrompts prompt = new generatePrompts();
        writing write = new writing();
        if (choice._choice == "1")
        {
            prompt.display();
            write.entry();
            Console.WriteLine($"{write._entry}");
        }

    }
}
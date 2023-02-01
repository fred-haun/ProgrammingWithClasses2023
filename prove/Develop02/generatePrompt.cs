using System;
using System.Collections.Generic;
public class generatePrompts
{
    public string _generatePrompt;

    public void display()
    {
        Random rand = new Random();
        int number = rand.Next(0, 6);
        if (number == 1)
        {
            _generatePrompt = "Write your feelings.";
        }
        else if (number == 2)
        {
            _generatePrompt = "What was the coolest thing to happen today?";
        }
        else if (number == 3)
        {
            _generatePrompt = "Why do it be?";
        }
        else if (number == 4)
        {
            _generatePrompt = "What is something you need to get off your chest?";
        }
        else if (number == 5)
        {
            _generatePrompt = "What can I do to make tommorrow a great day?";
        }
        else
        {
            _generatePrompt = "Tell a secret";
        }

        Console.WriteLine($"{_generatePrompt}");
    }
}

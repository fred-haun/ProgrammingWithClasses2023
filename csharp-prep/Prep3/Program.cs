using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);
        //Console.WriteLine($"Your random number is {number}!");
        bool guessed = false;
        int turns = 1;
        while(guessed == false)
        {
            Console.Write("Please enter your guess between 1 and 100: ");
            int guess = int.Parse(Console.ReadLine());
            if (guess > number)
            {
                Console.WriteLine("Lower");
                turns += 1;
            }
            else if (guess < number)
            {
                Console.WriteLine("Higher");
                turns += 1;
            }
            else
            {
                Console.WriteLine("You got it!");
                guessed = true;
            }
        }
        Console.WriteLine($"It took you {turns} turns to guess correctly.");
        //Console.WriteLine($"They guessed {guess}");

    }
}
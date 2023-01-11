using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<float> numbers = new List<float>();
        bool isZero = false;
        while(isZero == false)
        {
            Console.Write("Enter number: ");
            int enterNumber = int.Parse(Console.ReadLine());
            if (enterNumber == 0)
            {
                isZero = true;
            }
            else
            {
                numbers.Add(enterNumber);
            }

        }
        int sum = 0;
        float totalNum = 0;
        int biggestNum = 0;
        foreach (int number in numbers)
        {
            sum += number;
            totalNum += 1;
            if (number > biggestNum)
            {
                biggestNum = number;
            }
        }
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {sum/totalNum}");
        Console.WriteLine($"The largest number is: {biggestNum}");
        //Console.WriteLine("Hello Prep4 World!");
    }
}
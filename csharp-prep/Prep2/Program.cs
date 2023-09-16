Console.Write("What is your grade percentage? ");
string percent = Console.ReadLine();
int percentNumber = int.Parse(percent);
string letterGrade = "Q";
string plusMinus = "";
if (percentNumber >= 60 && percentNumber < 100)
{
    if ((percentNumber %10 == 0 || percentNumber %10 == 1 || percentNumber %10 == 2))
    {
        plusMinus = "-";
    }
    else if (percentNumber %10 == 7 || percentNumber %10 == 8 || percentNumber %10 == 9)
    {
        plusMinus = "+";
    }
    else
    {
        plusMinus = "";
    }
}
else if (percentNumber >= 100)
{
    plusMinus = "+";
}
else
{
    plusMinus = "";
}
if (percentNumber >= 90)
{
    letterGrade = "A";
}
else if (percentNumber >= 80 && percentNumber < 90)
{
    letterGrade = "B";
}
else if (percentNumber >= 70 && percentNumber < 80)
{
    letterGrade = "C";
}
else if (percentNumber >= 60 && percentNumber < 70)
{
    letterGrade = "D";
}
else
{
    letterGrade = "F";
}
if (percentNumber >= 90)
{
    Console.WriteLine($"You have earned an {letterGrade}{plusMinus}. Great Job!");
}
else if (percentNumber >= 70 && percentNumber < 90)
{
    Console.WriteLine($"You have earned a {letterGrade}{plusMinus}. Good Job!");
}
else
{
    Console.WriteLine($"You have earned an {letterGrade}{plusMinus}. Try again.");
}
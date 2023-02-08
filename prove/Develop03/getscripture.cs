using System;
using System.IO;
using System.Text.RegularExpressions;
public class getScripture
{
    private int number;
    public void scripture()
    {
        Random rand = new Random();
        number = rand.Next(0, 31103);       
        using(var reader = new StreamReader(@"C:\BYUI_Winter_2023\Programming With Classes\ProgrammingWithClasses2023\prove\Develop03\kjv.csv"))
        {
            List<string> reference = new List<string>();
            List<string> book = new List<string>();
            List<string> bookNumber = new List<string>();
            List<string> chapter = new List<string>();
            List<string> verseNumber = new List<string>();
            List<string> verse = new List<string>();
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = Regex.Split(line, ",(?=(?:[^\"]*\"[^\"]*\")*[^\"]*$)");

                reference.Add(values[0]);
                book.Add(values[1]);
                bookNumber.Add(values[2]);
                chapter.Add(values[3]);
                verseNumber.Add(values[4]);
                verse.Add(values[5]);
            }
            Console.WriteLine($"{book[number]} {chapter[number]}:{verseNumber[number]}\n{verse[number]}");
        }
    }
}
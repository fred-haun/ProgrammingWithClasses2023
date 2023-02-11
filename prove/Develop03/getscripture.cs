using System;
using System.IO;
using System.Collections.Generic;
using System.Text.RegularExpressions;
public class getScripture
{
    public string choosenVerse;
    choice choice = new choice();
    public string scripture()
    {
        Random rand = new Random();
        List<string> reference = new List<string>();
        List<string> book = new List<string>();
        List<string> bookNumber = new List<string>();
        List<string> chapter = new List<string>();
        List<string> verseNumber = new List<string>();
        List<string> verse = new List<string>();
        int number = rand.Next(0, 31103);       
        using(var reader = new StreamReader(@"C:\BYUI_Winter_2023\Programming With Classes\ProgrammingWithClasses2023\prove\Develop03\kjv.csv"))
        //C:\Users\fredr\Desktop\Winter 2023\Programming With Classes\ProgrammingWithClasses2023\prove\Develop03\kjv.csv
        {
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
            choosenVerse = verse[number];
        }
        Console.WriteLine("");
        Console.WriteLine($"{book[number]} {chapter[number]}:{verseNumber[number]}"); 
        return choosenVerse;
     }
    public void deleteWords(string choosenVerse)
    {
        List<string> verseWords = new List<string>(choosenVerse.Split(" "));
        List<int> used = new List<int>();
        int wordsLeft = verseWords.Count();
        while(wordsLeft > 0)
        {
            Random rand = new Random();
            int number = rand.Next(0, verseWords.Count); 
            foreach(var word in verseWords)
            {
                Console.Write($"{word} ");
            }
            verseWords[number] = "______";
            //verseWords.RemoveAt(number);    
            Console.WriteLine("");
            wordsLeft -= 1;
            //Console.WriteLine(wordsLeft);
            choice.choices();
        }
    }
}
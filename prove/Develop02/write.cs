using System;
using System.Collections.Generic;
using System.IO;
public class Writing
{
    DateTime todayDate = DateTime.Now;
    public string _entry;
    public string _total;
    public List<string> entries = new List<string>();
    
    public void entry()
    {
        generatePrompts prompt = new generatePrompts();
        prompt.display();
        Console.Write("> ");
        _entry = Console.ReadLine();
        entries.Add("\nDate: " + todayDate  + " - Prompt: " + prompt._generatePrompt + "\n" + _entry);
    }
    public void saved()
    {
        
        for(int i=0; i<entries.Count;i++)
        {
            Console.WriteLine(entries[i]);  
        }
        
    }
    public string filename;

    public void create()
    {
        Console.WriteLine("What is the filename?");
        filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            for(int i=0; i<entries.Count;i++)
            {
                outputFile.WriteLine(entries[i]);  
            }
        }
    }   
}
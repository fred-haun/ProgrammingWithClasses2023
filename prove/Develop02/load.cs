using System;
using System.Collections.Generic;
using System.IO;

public class Loading
{
    public string loadFileName;
    public bool isloaded = false;
    public string append;
    DateTime date = DateTime.Now;
    writing write = new writing();
    generatePrompts prompt = new generatePrompts();
    public List<string> loadFile = new List<string>();
    public void load()
    {
        
        Console.WriteLine("What is the filename? ");
        loadFileName = Console.ReadLine();
        
        string[] lines = File.ReadAllLines(loadFileName);  
        foreach (string line in lines) 
        { 
            Console.WriteLine(line);
            loadFile.Add(line);
        }
    }
    public void show()
    {
        Console.WriteLine("What is the filename?");
        string filename1 = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename1))
        {
            for(int i=0; i<loadFile.Count;i++)
            {
                outputFile.WriteLine(loadFile[i]);  
            }
        } 
    }
    public void entry()
    {
        prompt.display();
        Console.Write("> ");
        append = Console.ReadLine();
        loadFile.Add("\nDate: " + date + " - Prompt: " + prompt._generatePrompt + "\n" + append);
    }
    public void showFile()
    {
        for(int i=0; i<loadFile.Count;i++)
        {
            Console.WriteLine(loadFile[i]);  
        }
    }
}
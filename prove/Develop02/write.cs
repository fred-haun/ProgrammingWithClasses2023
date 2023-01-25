using System;
using System.Collections.Generic;
public class writing
{
    DateTime date = DateTime.Today;
    public string _entry;
    public List<string> entries = new List<string>();
    public void entry()
    {
        Console.Write("> ");
        _entry = Console.ReadLine();
        entries.Add(_entry);
    }
    public void saved()
    {
        for(int i=0; i<entries.Count;i++)
        {
            Console.WriteLine(entries[i]);
        }
        
    }
}
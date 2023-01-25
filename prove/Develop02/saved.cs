using System;
using System.Collections.Generic;
public class saved
{
    public void display()
    {
        writing write = new writing();
        foreach(string entry in write.entries)
        {
            Console.WriteLine(write.entries);
        }
        
    }
}
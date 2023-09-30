using System;
using System.IO;
using System.Text.RegularExpressions;
class Program
{
    static void Main(string[] args)
    {
        getScripture start = new getScripture();
        start.scripture();
        start.deleteWords(start.choosenVerse);
    }
    
}
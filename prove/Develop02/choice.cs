using System;
using System.Collections.Generic;
public class choices
{
    public string _choice;
    public bool endloop;
    writing write = new writing();
    Loading loading = new Loading();
    public void entry()
    {

        bool endloop = false;
        while (endloop == false)
        {
            endloop = false;
            Console.WriteLine("");
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            _choice =  Console.ReadLine();
            if (_choice == "1" && loading.isloaded == false)
            {
                write.entry();
            }
            else if (_choice == "1" && loading.isloaded == true)
            {
                loading.entry();
            }
            else if (_choice == "2")
            {
                if (loading.isloaded == false) 
                {
                    write.saved();
                }
                else if (loading.isloaded == true)
                {
                    loading.showFile();
                }
            }
            else if (_choice == "3")
            {
                loading.load();
                loading.isloaded = true;
            }
            else if (_choice == "4" && loading.isloaded == false)
            {
                write.create();
            }
            else if (_choice == "4" && loading.isloaded == true)
            {
                loading.show();
            }
            else if (_choice == "5")
            {
                Console.WriteLine("Goodbye!");
                endloop = true;
            }
            else
            {
                Console.WriteLine("Not a choice yo.");
            }
        }
    }

}
using System;
using System.Dynamic;
using System.Runtime.CompilerServices;
using System.Collections;
using System.Reflection.Metadata.Ecma335;

namespace vs // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            // change appearance
            Console.Title = "arne";
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            
            Console.WindowHeight = 40;
            
            //convo ish
            Console.WriteLine("Hello, I am Arne.");
            Console.WriteLine("whats yours?");
            
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            
            Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.DarkGreen;

            Console.WriteLine("Hi, (InsertNameHere).\nWhat do you do?");
            
            Console.ForegroundColor = ConsoleColor.DarkYellow;

            Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.DarkGreen;

            Console.WriteLine("Cool! \nWhats your favourite color?");

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            
            Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("Nice, \nNow i've extracted information now i will self destruct.");
            

            //ending in a blip for 2 secs
            if (Console.ReadKey().Key == ConsoleKey.K);
            {
                Console.Beep(3000, 2000);
            }
        }
    }
}



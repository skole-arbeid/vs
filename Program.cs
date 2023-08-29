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
            Console.Title = "Arne";
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            
            
            //convo ish
            Console.WriteLine("Hello, I am Arne.");
            Console.WriteLine("whats yours?");
            
            string userName = Console.ReadLine();
            Console.WriteLine("Hello" + userName + ", nice to meet you! \nWhat do you do?");
            
            Console.ReadLine();

            Console.WriteLine("Cool! \nWhats your favourite color?");
            
            Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.DarkRed;

            Console.WriteLine("OK, \nNow i've extracted information now i will self destruct.");

            //ending in a blip for 2 secs
            if (Console.ReadKey().Key == ConsoleKey.Enter);
            {
                Console.Beep(3000, 1500);
                Console.Beep(3000, 1500);
                Console.Beep(3000, 1500);
                Console.Beep(3000, 4000);
            }
        }
    }
}
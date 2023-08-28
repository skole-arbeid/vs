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
            Console.Title = "arne";
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            
            Console.WindowHeight = 40;
            
            
            Console.WriteLine("Hello, I am Arne.");
            Console.WriteLine("whats yours?");

            Console.ReadLine();

            Console.WriteLine("Hi, (InsertNameHere).\nWhat do you do?");
            
            Console.ReadLine();

            Console.WriteLine("Cool! \nWhats your favourite color?");

            Console.ReadLine();
            Console.WriteLine("Nice, \nNow i've extracted information now i will self destruct.");
            
            if (Console.ReadKey().Key == ConsoleKey.K);
            {
                Console.Beep(5000, 5000);
            }
        }
    }
}
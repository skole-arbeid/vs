﻿using System;
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

            Console.WriteLine("Hi, (InsertNameHere).\n What do you do?");
            
            Console.ReadLine();

            Console.WriteLine("Cool! \n Whats your favourite color?");
            
            if (Console.ReadKey().Key == ConsoleKey.K);
            {
                Console.Beep(1000, 500);
            }
        }
    }
}
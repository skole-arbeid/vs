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
            
            
            Console.WriteLine("You are an idiot HAHAHA! You are an idiot HAHAHA! You are an idiot HAHAHA! You are an idiot HAHAHA!...                  do you admit that you are an idiot?                                                                                     Y/N");
            if (Console.ReadKey().Key == ConsoleKey.Y)
            {
             Console.Beep(523, 500);
            }
            
        }
    }
}
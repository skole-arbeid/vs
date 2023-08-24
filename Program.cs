using System;
using System.Dynamic;
using System.Runtime.CompilerServices;
using System.Collections;

namespace vs // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("You are an idiot HAHAHA! You are an idiot HAHAHA! You are an idiot HAHAHA! You are an idiot HAHAHA!...                 do you admit that you are an idiot?                                               Y/N                                                 - dedsec");
            if (Console.ReadKey().Key == ConsoleKey.Y)
            {
             Console.Beep(523, 500);
            }
        }
    }
}
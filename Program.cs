using System;
using System.Dynamic;
using System.Runtime.CompilerServices;
using System.Collections;
using System.Reflection.Metadata.Ecma335;
using Microsoft.VisualBasic;

namespace vs // Note: actual namespace depends on the project name.
{
    class Program2
    {
        static void Main(string[] args)
        {
            // change appearance
            Console.Title = "Arne";
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            
            meetAlien();

            Console.WriteLine("---------------");

            meetAlien();

            Console.WriteLine("---------------");
           
           
            //ending in a blip for 2 secs
            if (Console.ReadKey().Key == ConsoleKey.Y) {
                Console.Beep(2000, 900);
                Console.Beep(2000, 900);
                Console.Beep(2000, 900);
                Console.Beep(2000, 2000);
            } else if (Console.ReadKey().Key != ConsoleKey.Y) {
                Console.Beep(5000, 1000);
            }           
        }
    
        static void meetAlien()
        {
            Random numberGen = new Random();

            string name = "X-" + numberGen.Next(10, 9999);
            int age = numberGen.Next(10, 10000);

            Console.WriteLine("Hi, my name is " + name);
            Console.WriteLine("I am " + age + " years old!");
            Console.WriteLine("Im an corrix \n(an human like species that has conseptive and presentive memory, they also have a life span up to 10000 years)");
        }
    
    }
}

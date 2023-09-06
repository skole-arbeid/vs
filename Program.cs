using System;
using System.Dynamic;
using System.Runtime.CompilerServices;
using System.Collections;
using System.Reflection.Metadata.Ecma335;
using Microsoft.VisualBasic;

namespace vs // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            // change appearance
            Console.Title = "Alien Dating Simulator";
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            
             object alien1 = meetAlien1();

            Console.WriteLine("---------------");

            object alien2 = meetAlien2();

            Console.WriteLine("---------------");
           
            Console.WriteLine("choose 1 or 2");
            
            while(true) 
            {
                if (Console.ReadKey().Key == ConsoleKey.NumPad1) {
                Console.WriteLine("\nyou chose alien #1");
                Console.WriteLine(alien1);
                Console.WriteLine("have a date?");
                break;
            } else if (Console.ReadKey().Key == ConsoleKey.NumPad2) {
                Console.WriteLine("\nyou chose alien #2");
                Console.WriteLine(alien2);
                Console.WriteLine("have a date?");
                break;
            } else{
                Console.WriteLine("that was not an option");
            }
            }
            
            
            while(true)
            {
                Console. WriteLine("yes or no");

                if (Console.ReadLine() == "yes") {
                Console.WriteLine("yay!");
                Console.WriteLine("I can really feel an connection!");
                break;
            } 
            else if (Console.ReadLine() == "no") {
                Console.WriteLine("D,:");
                Console.WriteLine("damn okay :( i could really feel an connection thooo");
                break;
            }
            else {
                Console.WriteLine("this was not an option");
            }
            }
           
            while(true)
            {
                if (Console.ReadKey().Key == ConsoleKey.Y) {
                Console.Beep(1000, 900);
                Console.Beep(1000, 900);
                Console.Beep(1000, 900);
                Console.Beep(1000, 2000);
            } else if (Console.ReadKey().Key == ConsoleKey.N) {
                Console.Beep(1000, 1000);
            } else{
                Console.WriteLine("die");
            }
            }
            
        }
    
        static object meetAlien1()
        {
            Random numberGen = new Random();

            string name = "X- " + numberGen.Next(10, 9999);
            int age = numberGen.Next(10, 10000);
            
            Console.WriteLine("alien 1 Bio!");
            Console.WriteLine("Hi, my name is " + name + "<3");
            Console.WriteLine("I am " + age + " years old!");
            Console.WriteLine("Im an corrix \n(an human like species that has conseptive and presentive memory, they also have a life span up to 10000 years)");
            string text = "Hello I'm" + name + "<3\n" + "I am " + age + " years old!\n" + "Im an corrix";
            return text;
        }
    
        static object meetAlien2()
        {
            Random numberGen = new Random();

            string name = "Elf- " + numberGen.Next(10, 9999);
            int age = numberGen.Next(10, 200);
            
            Console.WriteLine("alien 2 Bio!");
            Console.WriteLine("Hi, my name is " + name + "<3");
            Console.WriteLine("I am " + age + " years old!");
            Console.WriteLine("Im an Omada \n(an elf like species that has amazing food and an life span of 200 years)");
            string text = "Hello I'm " + name + "<3\n" + "I'm " + age + " years old!\n" + "Im an Omada";
            return age;
        }
    }
}

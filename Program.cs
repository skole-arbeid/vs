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
            Console.WriteLine("Hello " + userName + ", nice to meet you! \nWhat do you do?");
            
            Console.ReadLine();

            Console.WriteLine("Cool! \nWhats your favourite color?");
            
            Console.ReadLine();



            int num01;
            int num02;

            Console.Write("ok, input a number: ");
            num01 = Convert.ToInt32( Console.ReadLine() );
            
            Console.Write("input a second number: ");
            num02 = Convert.ToInt32( Console.ReadLine() );

            int result = num01 * num02;
            Console.WriteLine("the answer is " + result);

            Console.ForegroundColor = ConsoleColor.DarkRed;

            Console.WriteLine("I will now self destruct.");

            //ending in a blip for 2 secs
            if (Console.ReadKey().Key == ConsoleKey.Enter);
            {
                Console.Beep(2000, 900);
                Console.Beep(2000, 900);
                Console.Beep(2000, 900);
                Console.Beep(2000, 2000);
            }
        }
    }
}
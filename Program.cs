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
            
            Console.WriteLine("lets try to make an average");
            
            double num01;
            double num02;
            double num03;

            Console.Write("ok, input a number: ");
            num01 = Convert.ToDouble( Console.ReadLine() );
            
            Console.Write("input a second number: ");
            num02 = Convert.ToDouble( Console.ReadLine() );

            Console.Write("input a third number: ");
            num03 = Convert.ToDouble(Console.ReadLine() );

            double result = (num01 + num02 + num03) / 3;
            Console.WriteLine("the average is " + result);

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

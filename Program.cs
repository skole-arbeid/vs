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
            Console.Title = "Arne";
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            
            Console.Write("input a number between 1 and 5: ");

            int num = Convert.ToInt32(Console.ReadLine());

            if (num == 1) {
                Console.WriteLine("One");
            } else if (num ==2) {
                Console.WriteLine("Two");
            } else if (num == 3) {
                Console.WriteLine("Three");
            } else if (num == 4) {
                Console.WriteLine("Four");
            } else if (num == 5) {
                Console.WriteLine("Five");
            }
           
           
           
            //ending in a blip for 2 secs
            if (Console.ReadKey().Key == ConsoleKey.K) {
                Console.Beep(2000, 900);
                Console.Beep(2000, 900);
                Console.Beep(2000, 900);
                Console.Beep(2000, 2000);
            } else if (Console.ReadKey().Key != ConsoleKey.K) {
                Console.Beep(5000, 1000);
            }
            
        }
    }
}

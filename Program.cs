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
            
            bool isCorrectGuess = false;
            Random random = new Random();

            int randomNum = random.Next(1, 11);

            Console.WriteLine("Welcome to the number guessing game \nAnumber between 1 and 10 will be generated \nIf you guess correctly you win!");
            

           
           
           while(!isCorrectGuess)
           {
                Console.WriteLine("input an number: ");
                int guess = Convert.ToInt32(Console.ReadLine());

                if(guess > randomNum) 
                {
                    Console.WriteLine("your guess is too high!");
                } else if(guess < randomNum) 
                {
                    Console.WriteLine("your guess is too low!");
                } else if(guess == randomNum) 
                {
                    Console.WriteLine("your guess was right!");
                    isCorrectGuess = true;
                }
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

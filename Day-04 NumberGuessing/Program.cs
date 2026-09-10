using System;
using System.Collections.Generic;


namespace NumberGuessing
{
    class Program
    {
        static void Main(string[] args)
        {
           int random =  new Random().Next(1, 101);

            //Console.WriteLine("Enter a number to Guess:");
            //int guess = Convert.ToInt32(Console.ReadLine());

            while (true)
            {
                Console.WriteLine("Enter a number to Guess:");
                int guess = Convert.ToInt32(Console.ReadLine());

                if (guess == random)
                {
                    Console.WriteLine("you guessed it Right, Jackpot!");
                    break;
                }
                else if(guess < random)
                {
                    Console.WriteLine("too low");
                }
                else if(guess > random)
                {
                    Console.WriteLine("too high");
                }
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    class Program
    {
        static void Main(string[] args)
        {
            bool guessedCorrect = false;
            double amazingCarPrice = 3595.56;
            int currentGuess = 1;
            int maxGuesses = 3;
            
            

            Console.WriteLine("Welcome To Ben's Guessing Game");
            Console.WriteLine("You have a fantastic chance to win an new car But first of all you have to guessthe price, you have  three guesses!If you are insuccesfull after three attempts the program will exit, Good Luck!");
            Console.WriteLine("-----------------------------------------");

            do
            {
                Console.WriteLine("Please Enter Your Guess (" + currentGuess + " of " + maxGuesses + "): ");
                double guessedPrice = Convert.ToDouble(Console.ReadLine());

                if ( guessedPrice > amazingCarPrice)
                {
                    Console.WriteLine("You have guessed to high, try again!");
                }
                else if (guessedPrice < amazingCarPrice)
                {
                    Console.WriteLine("You have guessed to low, try again!" + (maxGuesses - currentGuess) + "guesses left");
                }
                else if (guessedPrice == amazingCarPrice)
                {
                    Console.WriteLine("You have correctly guessed the car price and won the car! With:" + (maxGuesses - currentGuess) + "guesses left");
                    guessedCorrect = true;
                    break;
                }

                currentGuess++;
            }
            while ( guessedCorrect == false && currentGuess <= maxGuesses);

            if (guessedCorrect == false && currentGuess >= maxGuesses)
            {
                Console.WriteLine("You have run out of guesses and didnt win the car!");
            }

           Console.ReadLine();



        }
    }
}

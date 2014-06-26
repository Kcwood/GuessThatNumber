using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessThatNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //Getting the console to ask if the user would like to play a game
            Console.WriteLine("Hi sweetness, wanna play a game?");
            //Calling the function to run
            GuessThatNumber();
            //Keeps the console open
            Console.WriteLine();
        }
        static void GuessThatNumber()
        {
            //Computer telling the user some info
            Console.WriteLine("I am thinking of a cute little number....");
            //Gets the computer to make a random guess
            //between 1 and 100
            Random compGuess = new Random();
            int randomNum = compGuess.Next(1, 101);
            //Setting the variable to count
            //the number of guesses
            int count = 0;
            //Place holder to later convert our string to a number
            int newInput = 0;
            //Computer asking the user what their 
            //guess is
            Console.WriteLine("What's your guess sweetie?");
            //Setting up a loop to have the user guess higher 
            //or lower from the random number
            while (newInput != randomNum)
            {
                //Getting input from the user
                string yourGuess = Console.ReadLine();
                int input = int.Parse(yourGuess);
                //Seeing if the users guess 
                //is lower than the random number
                if (input < randomNum)
                {
                    //Prints to the console
                    Console.WriteLine("Guess higher cutie!");
                    //Adds 1 to the count
                    count++;
                }
                //Seeing if the users guess
                //is greater than the random number
                else if (input > randomNum)
                {
                    //Prints to the console
                    Console.WriteLine("Guess lower honey!");
                    //Adds 1 to the count
                    count++;
                }
                //If both statements are false above 
                //it will print this to the console
                else if (input == randomNum)
                {
                    Console.WriteLine("You guessed my fabulous number! It took you " + (count + 1) + " guesses. Would you like to play again darling?");
                }
            }
        }
    }
}  

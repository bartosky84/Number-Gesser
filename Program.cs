using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string appName = "Number Gesser";
            string appVersion = "1.0.0";
            string appAuthor = "Bartosz Kruk";

            //Change text color
            Console.ForegroundColor = ConsoleColor.Green;

            //Write app info
            Console.WriteLine("{0}: Version: {1} by {2}", appName, appVersion, appAuthor);

            //Rest text color
            Console.ResetColor();

            //Ask user name 
            Console.WriteLine("What is your name? ");

            //Get user inputs
            string inputName = Console.ReadLine();
            Console.WriteLine("Hello {0}, let's play game!", inputName);

            while (true) {

            //Set  init correct number
            // int correctNumber = 7;
            //Create new rendom object
            Random random = new Random();
            int correctNumber = random.Next(1, 10);


            //Init guess var
            int guess = 0;

            Console.WriteLine("Guess number between 1 to 10");
            Console.WriteLine("Enter the number: ");

            //while guess is not correct
            while(guess != correctNumber)
            {
                string input = Console.ReadLine();
                //Make shure its number
                if(!int.TryParse(input, out guess))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please enter an actual number ");
                    Console.ResetColor();
                    //Keep going 
                    continue;
                }
                //Cast ot int put in guess
                guess = Int32.Parse(input);

                //Match guess to correct number
                if(guess != correctNumber)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wrong number, pleace try again ");
                    Console.ResetColor();
                }
            }
            //Output success msg
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("You are CORRECT");
            Console.ResetColor();

                //Ask to play again:
                Console.WriteLine("Play Again??? [ Y or N ]");
                //Get answer
                string answer = Console.ReadLine().ToUpper();

                if(answer == "Y")
                {
                    continue;

                }
                else if(answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }



            }
            
        }
    }
}

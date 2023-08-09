using System;
using System.Xml.Schema;

namespace GuessTheNumber
{
    class program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            bool playAgain = true;

            String decision;
            int minumum = 1;
            int maximum = 100;
            int guess;
            int number;
            int guessAttempt;

            while (playAgain)
            {
                guess = 0;
                guessAttempt = 0;
                decision = "";

                number = random.Next(minumum, maximum + 1);


                while (guess != number) 
                {
                    Console.WriteLine("Guess number between" + minumum + " - " + maximum + " : ");
                    guess = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine("Guess: " + guess );

                    if(guess > number)
                    {
                        Console.WriteLine();
                        Console.WriteLine(guess + " is too high!");
                    }
                    else if (guess < number)
                    {
                        Console.WriteLine();
                        Console.WriteLine(guess + " is too low!");
                    }
                    guessAttempt++;
                }
                Console.WriteLine("number: "  + number);
                Console.WriteLine("You WIN!");
                Console.WriteLine("guesses: " + guessAttempt);

                Console.WriteLine("Would you like to play again (Y/N)?");
                decision = Console.ReadLine();
                decision = decision.ToUpper();

                if(decision == "Y")
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                }
            }

            Console.WriteLine("Thanks for playing!");
            Console.ReadKey();
        } 
    }
}
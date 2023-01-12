using System;

class Program
{
    static void Main(string[] args)
    {
        string keepPlaying = "yes";

        do
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);

            int guess;
            int guesses = 0;
            
            do
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());

                guesses ++;

                if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }

            } while (!(magicNumber == guess));

            Console.Write("You guessed it in ");
            Console.Write(guesses);
            Console.WriteLine(" tries!");

            Console.Write("Play again? ");
            keepPlaying = Console.ReadLine();
        } while (keepPlaying == "yes");
    }
}
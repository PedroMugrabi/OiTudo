using System;

namespace Teste7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string secretWord = "giraffe";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 3;
            bool outOfGuesses = false;
            

            while (guess != secretWord && !outOfGuesses) 
            {
                if (guessCount < guessLimit)
                {
                    int guessesLeft = guessLimit - guessCount;
                    Console.WriteLine("Enter guess. Number of Guesses :"+guessesLeft);
                    guess = Console.ReadLine();
                    guessCount++;
                   

                } 
                else
                {
                    outOfGuesses = true;
                }
                
            }
            if (outOfGuesses)
            {
                Console.WriteLine("You Lose");
            }
            else
            {
                Console.WriteLine("You Win!");
            }
            
        }
    }
}

using System;

namespace GuessNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomNum = new Random();
            int randomTarget = randomNum.Next(100) + 1;
            int numGuess = 0;

            while (numGuess != randomTarget)
            {
                Console.WriteLine("Guess a number between 1 and 100: ");
                int.TryParse(Console.ReadLine(), out numGuess);
                if (numGuess > randomTarget)
                {
                    Console.WriteLine("{0} is too high!", numGuess);
                }
                else if (numGuess < randomTarget)
                {
                    Console.WriteLine("{0} is too low!", numGuess);
                }
                else
                {
                    Console.WriteLine("{0} is right congratulations!", numGuess);
                }
            }
        }
    }
}

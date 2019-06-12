using System;

namespace GuessNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomNum = new Random();

            var userAnswer = "";
            var isHigher = "";
            int guess = 0;
            var min = 1;
            var max = 100;
            var lowMax = 50;

            Console.WriteLine("Guess a number between 1 and 100: ");
            Console.WriteLine("Is the number 50 or higher : ");
            isHigher = Console.ReadLine();
            while (userAnswer != "yes")
            {

                if (isHigher == "yes")
                {

                    min = 50;
                    var highTarget = (min + max) / 2;
                    guess = highTarget - 1;
                    max = guess;
                    Console.WriteLine($"Is the number {guess}");
                    userAnswer = Console.ReadLine();
                }
                else
                {
                    min = 1;
                    var lowTarget = (min + lowMax) / 2;
                    guess = lowTarget - 1;
                    lowMax = guess;
                    Console.WriteLine($"Is the number {guess}");
                    userAnswer = Console.ReadLine();
                }
            }
        }
    }
}

using System;

namespace takeAGuess
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randomNum = random.Next(1,200);
            int guessNum;

            Console.WriteLine("Let's take a guess the random number!");

            while(true)
            {
                guessNum = int.Parse(Console.ReadLine());
                if (guessNum.Equals(randomNum))
                {
                    Console.WriteLine("correct!");
                    return;
                }
                else if (guessNum > randomNum)
                {
                    Console.WriteLine("random number is lower than the number");
                }
                else
                {
                    Console.WriteLine("random number is higher than the number");
                }
            } 
        }
    }
}

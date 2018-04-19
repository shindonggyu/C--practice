using System;

namespace makingPiramid
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 8; i ++)
            {
                for (int j = 7; j > i; j --)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k <= i; k ++)
                {
                    Console.Write("*");
                }
                for (int l = 0; l < i; l ++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}

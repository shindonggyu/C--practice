using System;
using System.Collections.Generic;

namespace pickingMaxMin
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = new int[5];
            int max;
            int min;
            Console.WriteLine("Please input 5 numbers in order");
            for (int i = 0; i < 5; i ++)
            {
                Console.Write(i+1 + "'s number:");
                intArray[i] = int.Parse(Console.ReadLine());
            }
            max = intArray[0];
            min = intArray[0];

            for (int i = 1; i < 5 ; i ++)
            {
                if (max < intArray[i])
                {
                    max = intArray[i];
                }
                if (min > intArray[i])
                {
                    min = intArray[i];
                }
            }

            Console.WriteLine("Max number is "+max);
            Console.WriteLine("Min number is "+min);
        }
    }
}

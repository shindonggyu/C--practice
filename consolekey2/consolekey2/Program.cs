using System;

namespace consolekey2
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo info = Console.ReadKey();
            switch (info.Key)
            {
                case ConsoleKey.UpArrow:
                    Console.WriteLine("up arrow");
                    break;

                case ConsoleKey.DownArrow:
                    Console.WriteLine("down arrow");
                    break;

                case ConsoleKey.LeftArrow:
                    Console.WriteLine("left arrow");
                    break;

                case ConsoleKey.RightArrow:
                    Console.WriteLine("right arrow");
                    break;

                default:
                    Console.WriteLine("you input other key");
                    break;
            }
        }
    }
}

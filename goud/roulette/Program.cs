using System;

namespace roulette
{
    class Program
    {
        static int x = 0;
        static int y = 0;
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Hello World!");
            Console.SetCursorPosition(1, 5);
            Console.Write("bo");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\b\bhoi");
            Console.ResetColor();

            while (Console.ReadKey().Key == ConsoleKey.RightArrow) {
            x++;
            Console.Write("\b\b\b" + x);
            
            }
            while (Console.ReadKey().Key == ConsoleKey.LeftArrow) {
            x--;
            Console.Write("\b\b\b" + x);
            }
            Console.Read();
        }
    }
}

using System;

namespace compilethis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Whats your name");
            var myName = Console.ReadLine();
            Console.WriteLine("Hello World my name is " + myName);
        }
    }
}

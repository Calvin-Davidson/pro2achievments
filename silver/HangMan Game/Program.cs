using System;
using System.Collections;
using System.Collections.Generic;
namespace HangMan_Game
{
    class Program
    {
        static ArrayList words = new ArrayList();
        String word;
        static void Main(string[] args)
        {
            LoadWords();

            Console.Clear();

            Console.WriteLine("###################################################################");
            Console.WriteLine("#                           HANG MAN                               #");
            Console.WriteLine("#                       PRESS ENTER TO START                       #");
            Console.WriteLine("###################################################################");
            
            Console.ReadLine();
            
            var Random = new Random();
            var Number = Random.Next(0, 5);

            Console.WriteLine(words[Number]);
        }
        static void LoadWords() {
            words.Add("peer");
            words.Add("appel");
            words.Add("geit");
            words.Add("orange");
            words.Add("banaan");
            words.Add("storm");
        }
    }
}

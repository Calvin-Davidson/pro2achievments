using System;

namespace InVariablesWeTrust
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            char char1 = 'a';
            
            float myFloat = 4;

            bool bool1 = false;
            bool bool2 = bool1;

            int int1 = 5;
            int int2 = 10;
            int int3 = int1 + int2;

            string string1 = "Hoi";
            string string2 = "Hoe gaat het met je";
            string string3 = string1 + " " + string2;

            Console.WriteLine("De char is: " + char1 + " \nFloat is: " + myFloat + " \nDe boolean is: " + bool2 + " \nDe interger is " + int3 + " \nen als laatst de string is: " + string3);

            Console.ReadLine();
                    }
    }
}

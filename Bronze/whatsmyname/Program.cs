using System;

namespace whatsmyname
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Hallo, Vul uw voor en achternaam in");
            var yourName = Console.ReadLine();
            Console.WriteLine("en hoe oud ben je");
            var yourAge = Console.ReadLine();
            Console.WriteLine("wat is de kleur van je ogen?");
            var eyeColor = Console.ReadLine();
            Console.WriteLine("wat is je postcode");
            var postCode = Console.ReadLine();
            Console.WriteLine("in welke stad woon je?");
            var woonPlaats = Console.ReadLine();
            
            Console.WriteLine("Oke geweldig bedankt voor het invullen van alle informatie");
            System.Threading.Thread.Sleep(1500);
            Console.Clear();
            Console.WriteLine("Hallo " + yourName + " wat leuk dat je in " + woonPlaats + " woont. Ik zie dat je postcode " + postCode + " Ik zie ook dat je oog kleur " + eyeColor + " is, wat erg leuk is want ik heb dezelfde kleur ogen. Ik ben wel iets ouder dan " + yourAge);
            Console.ReadLine();
        }
    }
}

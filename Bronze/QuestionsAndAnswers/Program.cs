using System;

namespace QuestionsAndAnswers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();   
            Console.WriteLine("#############################################################");
            Console.WriteLine("Welkom bij de quizzzz are you ready?");
            Console.WriteLine("Druk op enter om verder te gaan en de quiz te starten");
            Console.WriteLine("#############################################################");

            Console.ReadLine();

            Console.WriteLine("Hoe oud is de maker van deze quizzz?");
            var leeftijdansw = Console.ReadLine();
            Console.Clear();
            
            Console.Write("Uit welke stad komt de maker van deze quiz?");
            var stadansw = Console.ReadLine();
            Console.Clear();
            
            Console.WriteLine("Hoelang moet de maker van deze quiz ongeveer reizen");
            var reistijdanws = Console.ReadLine();
            Console.Clear();
            
            Console.WriteLine("Bedankt voor het invullen van de vragen");
            System.Threading.Thread.Sleep(2500);
            Console.Clear();

            Console.WriteLine("########################################");
            Console.WriteLine("De maker van deze quiz is 16 jaar, je hebt " + leeftijdansw + " ingevuld. \nDe maker van de quiz komt uit alkmaar, u heeft " + stadansw + " ingevuld \nDe maker van deze quiz moet 30 minuten reizen uw antwoord was " + reistijdanws);
            Console.WriteLine("########################################");
            Console.ReadLine();
        }
    }
}

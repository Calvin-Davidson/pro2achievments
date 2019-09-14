using System;
using System.Collections;
using System.Collections.Generic;
namespace HangMan_Game
{
    class Program
    {
        static ArrayList words = new ArrayList();
        static ArrayList wordChars = new ArrayList();
        static ArrayList Progress = new ArrayList();

        static int livesLeft;

        static void Main(string[] args)
        {
            Console.Clear();

            Console.WriteLine("###################################################################");
            Console.WriteLine("#                           HANG MAN                              #");
            Console.WriteLine("#                     PRESS ANY KEY AND ENTER                     #");
            Console.WriteLine("###################################################################");
            livesLeft = 5;
            Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Type --  StopGame  -- om de game te stoppen");
            Console.WriteLine("Het typen van het heleword is toegestaan");
            Console.WriteLine("Alle letters moeten in kleineletters - GEEN hoofdletters dus");

            Console.WriteLine("Dit bericht verwijnd over 10 seconden");
            System.Threading.Thread.Sleep(10);
            Console.Clear();
            //Lees alle lines uit het opgegeven txt bestand
            string[] wordsFile = System.IO.File.ReadAllLines(@"C:\Users\calvi\OneDrive\Documenten\ma\bewijzenmap\periode1.1\pro2\pro2achievments\silver\HangMan Game\Words.txt");
            
            //Voor elke Line in de words file add it to an message array.
            foreach (string line in wordsFile)
            {
                // Use a tab to indent each line of the file.
                words.Add(line);
            }
            
            var Random = new Random();
            var Number = Random.Next(0, 6);
            Console.WriteLine("-----TheWord-----");
            char[] theWord = wordsFile[Number].ToCharArray();
            Console.WriteLine(theWord);

            //Voor elke letter in het word voeg een . toe aan progress
            //en voegt voor elk letter in het word ook de letter toe aan de wordChars array 
 
                foreach (char c in theWord)
            {
                var stringLetter = c.ToString();
                wordChars.Add(stringLetter);
                Console.WriteLine(stringLetter);
                Progress.Add(".");
            }
            while(livesLeft != 0) {

                //Stuur het progress van de speler
                foreach(var item in Progress) {
                    Console.WriteLine(item);
                }
            Console.WriteLine("Jouw levens: " + livesLeft);
            Console.WriteLine(theWord);
            Console.WriteLine("Enter a letter");
            var enteredLetter = Console.ReadLine();
            int FoutenLetters = 0;
            int HuidigWord = 0;
            var EnterWordString = enteredLetter.ToString();
            if (EnterWordString.Equals(theWord.ToString())) {
                Console.Clear();
                Console.WriteLine("wouw je hebt het word geraden goed gedaan");
                return;
            }
            //Als de speler stopgame typed stop de game
            if (enteredLetter.Equals("StopGame")) {
                Console.Clear();
                Console.WriteLine("De game is gestopt");
                return;
            }
        int CorrectChecker = 0;
        int CorrectChars = 0;
            foreach (String s in wordChars) {
            if (Progress[CorrectChars] == wordChars[CorrectChars]) {
                CorrectChars++;
                CorrectChecker++;
            } else {
                CorrectChecker++;
            }
        }
        if (CorrectChars == wordChars.Count-1) {
                    Console.WriteLine("Het heleword is goed. goed gedaan.");
                    return;
                }
            
            enteredLetter.ToString().ToCharArray();
        foreach (String s in wordChars) {
            if (enteredLetter == s) {
                Progress[HuidigWord] = s;
                HuidigWord++;
            } else {
                FoutenLetters++;
                HuidigWord++;
            }
        }
        if (FoutenLetters == wordChars.Count) {
            Console.WriteLine("Het was fout");
            livesLeft--;
            System.Threading.Thread.Sleep(2000);
            Console.Clear();
        } else {
            Console.WriteLine("Het was goed");
                 System.Threading.Thread.Sleep(2000);
                 Console.Clear();
                 if (Progress == wordChars) {
                     Console.WriteLine("het word is gevonden");
                     return;
                 }
                }
            }
            if (livesLeft == 0) {
                Console.WriteLine("Je levens zijn op. Jammer dat je het niet gehaald hebt");
            }
        }
    }
}
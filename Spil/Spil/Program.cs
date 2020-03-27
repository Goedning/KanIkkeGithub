using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Spil
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MAX_NUMBER = 10;  // 23-03-2020 Vi begynder på vores gætte spil.

            Random random = new Random();
            int numberToGuess = random.Next(MAX_NUMBER) + 1;
            int userGuess = 0;
            int forsog = 0;
            string playerName;
            string userChoice;
            bool lose = false;
            int score = 0;

            Console.WriteLine("Velkommen til gæt et tal!'");
            Console.WriteLine("tallet ligger i mellem 0 og {0}.", MAX_NUMBER);

            while (!lose)
            {

                
                Console.Write("indtast dit gæt: ");
                
                int.TryParse(Console.ReadLine(), out userGuess);

                if (userGuess > numberToGuess)
                {
                    Console.WriteLine("");
                    Console.WriteLine("{0} er for højt!", userGuess);
                    forsog++;
                    Console.WriteLine("Du har " + (3 - forsog) + " forsøg tilbage ");
                    if (3 - forsog == 0)
                    {
                        lose = true;
                    }
                }
                else if (userGuess < numberToGuess)
                {
                    Console.WriteLine("");
                    Console.WriteLine("{0} er for lavt!", userGuess);
                    forsog++;
                    Console.WriteLine("Du har " + (3 - forsog) + " forsøg tilbage ");
                    if (3 - forsog == 0)
                    {
                        lose = true;
                    }
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("{0} rigtigt svar, Tillykke!", userGuess);
                    score++;
                    Console.WriteLine("Din nuværende score er på " + score);
                    forsog = 0;
                    numberToGuess = random.Next(MAX_NUMBER) + 1; //Vi skal bruge et nyt tal hver gang i gætter tallet korrekt.


                }
                if (lose)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Du tabte, vil du prøve igen? (y/n)");
                    Console.WriteLine("Din endelige score blev " + score);
                    userChoice = Console.ReadLine();
                    if (userChoice == "n")
                    {
                        Console.WriteLine("");
                        Console.WriteLine("oh okay jeg forstår ;( ");
                        Console.WriteLine("");
                        return;
                    }
                    else if (userChoice == "y")
                    {
                        numberToGuess = random.Next(MAX_NUMBER) + 1; //Vi modtager et nyt tal når vi begynder spillet igen   
                        if(userChoice == "y")
                        {
                            forsog = 3 - forsog;
                            score = 0; // Vi nulstiller vores forsøg & score
                        }
                        lose = false;                        
                        Console.Clear(); //Slut note mangler stadig Highscore & Gemme system
                    }
                }

            }
        }
    }
}


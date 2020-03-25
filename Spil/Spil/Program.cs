using System;

namespace Spil
{
    class Program
    {
        static void Main(string[] args)
        {
            int MAX_NUMBER = 10;  // 23-03-2020 Vi begynder på vores gætte spil.

            Random random = new Random();
            int numberToGuess = random.Next(MAX_NUMBER) + 1;
            int userGuess = 0;
            string userChoice;
            bool lose = false;
            int score = 0;

            Console.WriteLine("Velkommen til gæt et tal!'");
            Console.WriteLine("tallet ligger i mellem 0 og {0}.", MAX_NUMBER);

            while (!lose)
            {

                
                Console.WriteLine("indtast dit gæt: ");
                int.TryParse(Console.ReadLine(), out userGuess);

                if (userGuess > numberToGuess)
                {
                    Console.WriteLine("{0} er for højt!", userGuess);
                    Console.WriteLine("Det rigtige svar var  " + numberToGuess);
                    Console.WriteLine("Din score endte på " + score);
                    lose = true;
                }
                else if (userGuess < numberToGuess)
                {
                    Console.WriteLine("{0} er for lavt!", userGuess);
                    Console.WriteLine("Det rigtige svar var  " + numberToGuess);
                    Console.WriteLine("Din score endte på " + score);
                    lose = true;
                }
                else
                {
                    Console.WriteLine("{0} rigtigt svar, Tillykke!", userGuess);
                    score++;
                    Console.WriteLine("Din nuværende score er på " + score);
                    lose = false;

                }
                if (lose)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Du tabte, vil du prøve igen? (y/n)");
                    userChoice = Console.ReadLine();
                    if (userChoice == "n")
                    {
                        Console.WriteLine("");
                        Console.WriteLine("oh okay jeg forstår ;( ");
                        Console.WriteLine("");
                        Environment.Exit(0);
                    }
                    else if (userChoice == "y")
                    {
                        numberToGuess = random.Next(MAX_NUMBER) + 1;
                        lose = false;
                    }
                }
            }
        }
    }
}


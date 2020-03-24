﻿using System;

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
            int score = 0;

            Console.WriteLine("Velkommen til gæt et tal!'");
            Console.WriteLine("tallet ligger i mellem 0 og {0}.", MAX_NUMBER);

            {                

                Console.Write("indtast dit gæt: ");
                int.TryParse(Console.ReadLine(), out userGuess);

                if (userGuess > numberToGuess)
                {
                    Console.WriteLine("{0} er for højt!", userGuess);
                    Console.WriteLine("Det rigtige svar var  " + numberToGuess);
                    Console.WriteLine("Din score endte på " + score);
                }
                else if (userGuess < numberToGuess)
                {
                    Console.WriteLine("{0} er for lavt!", userGuess);
                    Console.WriteLine("Det rigtige svar var  " + numberToGuess);
                    Console.WriteLine("Din score endte på " + score);
                }
                else
                {
                    Console.WriteLine("{0} rigtigt svar, Tillykke!", userGuess);
                    Console.WriteLine("Din nuværende score er på " + score);

                }
            }
        }
    }
}

using System;

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
            int guesses = 0;

        }
    }
}

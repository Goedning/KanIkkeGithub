using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace H2OOP_Geralt_s_Monster_Hunt
{
    public class UserInput //D
    {

        public void velkomst()
        {

            Console.WriteLine("Toss A Coin To Your Witcher? y/n");

            string input = Console.ReadLine();

            if (input == "n")
            {
                Console.WriteLine("Jamen så er du ikke velkommen her!");
                System.Threading.Thread.Sleep(3000);
                Environment.Exit(0);
            }
            else if (input == "y")
            {
                Console.Clear();
                TimeToKill();
            }

        }

        public void TimeToKill()
        {
            Console.WriteLine("Det var bare en hvilken som helst dag for witcheren Geralt, der var på vej for at dræbe en...");
            Console.WriteLine("1) Doppler");
            Console.WriteLine("2) Ghoul");
            Console.WriteLine("3) Bruxa");
            Console.WriteLine("4) Kikimora");
            Console.WriteLine("5) Drage");

            ConsoleKeyInfo tast1 = Console.ReadKey(true);

            if (tast1.Key == ConsoleKey.D1)
            {
                Console.Clear();
                
                
            }
        }

    }
}

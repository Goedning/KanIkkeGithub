using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace H2OOP_Geralt_s_Monster_Hunt
{
     public class UserInput
    {
        string input = "";
        public void start()
        {
            input = Console.ReadLine();
        }

        public void velkomst()
        {

            Console.WriteLine("Toss A Coin To Your Witcher? y/n");

            if (input == "n")
            {
                Console.WriteLine("Jamen så er du ikke velkommen her!");
                System.Threading.Thread.Sleep(4000);
                Environment.Exit(0);
            }
            else if (input == "y")
            {
                Console.WriteLine("Emil er dum!");
            }

        }

    }
}

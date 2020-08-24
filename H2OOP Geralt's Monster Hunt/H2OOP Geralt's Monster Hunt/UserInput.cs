﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace H2OOP_Geralt_s_Monster_Hunt
{

    public class UserInput //D
    {
        static MonsterController monsterController = new MonsterController();

        public void Velkomst()
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
                Mainmenu();
            }

        }

        public void Tilføjmonster()
        {


            bool letsKeepGoing = true;
            while (letsKeepGoing)
            {
                Console.WriteLine("Det var bare en hvilken som helst dag for witcheren Geralt, der var på vej for at dræbe en...");
                Console.WriteLine("1) Doppler");
                Console.WriteLine("2) Ghoul");
                Console.WriteLine("3) Bruxa");
                Console.WriteLine("4) Kikimora");
                Console.WriteLine("5) Drage");
                Console.WriteLine("6) Jeg er færdig for nu");

                ConsoleKeyInfo tast1 = Console.ReadKey(true);
                Monster monster = new Monster();

                switch (tast1.Key)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        monster = new Monster("Doppler", "KENDETEGN: Ingenting ", "ANTAL: 1");
                        Console.WriteLine(monster.Navn);
                        Console.WriteLine(monster.Kendetegn);
                        Console.WriteLine(monster.Antal);
                        Console.WriteLine();
                        Console.WriteLine("DESC: Doppler er utrolige milde væsne, de har hverken kløer eller hugtænder, de kan dog kompenser med deres evne til at skifte udsende på et level hvor det er umuligt at se forskel. Dette gør dem også utrolig frygtet blandt mennesker, sidende kan efterligne dit udsende og alle deres fremtidige handlinger kan falde på dig, doppler efterligner os dog ikke for at gøre nogle fortræd, men i stedet fordi det er nemmere at lever i de indre byer i fred. ");
                        Console.WriteLine();
                        break;
                    case ConsoleKey.D2:
                        Console.Clear();
                        monster = new Monster("Ghoul", "KENDETEGN: Uintelligent. Jagter i flok. Spiser de døde. Hænger ofte omkring slagsmarker", "ANTAL: 5-100");
                        Console.WriteLine(monster.Navn);
                        Console.WriteLine(monster.Kendetegn);
                        Console.WriteLine(monster.Antal);
                        Console.WriteLine("DESC: Ghoulds er hæslige væsner, med en stærk næse, men svage øjne. De spiser med glæde alle skabninger de kan få deres kløer på, både levne og døde, de bor dybt under jorden i kompakte huller. ");
                        Console.WriteLine();
                        break;
                    case ConsoleKey.D3:
                        Console.Clear();
                        monster = new Monster("Bruxa", "KENDETEGN:  Smuk kvinde ligende. Blod tørstig. Hader lugten af løg. Vampyr", "ANTAL 1-5, de kan gå både alene og i små grupper");
                        Console.WriteLine(monster.Navn);
                        Console.WriteLine(monster.Kendetegn);
                        Console.WriteLine(monster.Antal);
                        Console.WriteLine();
                        Console.WriteLine("DESC: ");
                        Console.WriteLine();
                        break;
                    case ConsoleKey.D4:
                        Console.Clear();
                        monster = new Monster("Kikimora", "KENDETEGN: Svampe & Skov boende. Vil angribe alt der kommer nær. Flere typer, arbejde, soldat og dronning", "ANTAL: 10-500");
                        Console.WriteLine(monster.Navn);
                        Console.WriteLine(monster.Kendetegn);
                        Console.WriteLine(monster.Antal);
                        Console.WriteLine();
                        Console.WriteLine("DESC: ");
                        Console.WriteLine();
                        break;
                    case ConsoleKey.D5:
                        Console.Clear();
                        monster = new Monster("Drage", "KENDETEGN: ...Det er en drage...", "ANTAL: 1-3");
                        Console.WriteLine(monster.Navn);
                        Console.WriteLine(monster.Kendetegn);
                        Console.WriteLine(monster.Antal);
                        Console.WriteLine();
                        Console.WriteLine("DESC: ");
                        Console.WriteLine();
                        break;
                    case ConsoleKey.D6:
                        Console.Clear();
                        Mainmenu();
                        break;
                    default:
                        break;
                }
                monsterController.Insertmonster(monster);
                
                Console.WriteLine("For at retuner til start Tryk 1.");
                tast1 = Console.ReadKey(true);

                if (tast1.Key != ConsoleKey.D1)
                {
                    letsKeepGoing = false;
                }
            }
        }
        public void Mainmenu()
        {
            ConsoleKeyInfo tast1;
            do
            {

                Console.WriteLine("1) Tilføj flere monstre");
                Console.WriteLine("2) Fjern et monster fra listen");
                Console.WriteLine("3) Se min to kill list i dag");
                Console.WriteLine("4) Opdater Kendetegn");

                tast1 = Console.ReadKey(true);
                switch (tast1.Key)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        Tilføjmonster();
                        break;
                    case ConsoleKey.D2:
                        Console.Clear();
                        Deletefromlist();
                        break;
                    case ConsoleKey.D3:
                        Console.Clear();
                        Minliste();
                        break;
                    case ConsoleKey.D4:
                        Console.Clear();
                        Updatering();
                        break;
                    default:
                        break;
                }
                Console.Clear();
            }
            while (ConsoleKey.Escape != tast1.Key);
        }
        public void Minliste()
        {
            Console.WriteLine("Her kan vi se de nuværende monstre vi skal efter");
            Console.WriteLine("Når du er færdig her så tryk 1 for at komme tilbage.");
            Console.WriteLine();

            foreach (Monster monster in monsterController.list.monster)
            {

                Console.WriteLine(monster.Navn);
                Console.WriteLine(monster.Kendetegn);
                Console.WriteLine(monster.Antal);
                Console.WriteLine();
            }
            ConsoleKeyInfo tast1 = Console.ReadKey(true);
            switch (tast1.Key)
            {
                case ConsoleKey.D1:
                    Console.Clear();
                    Mainmenu();
                    break;
            }


        }
        public void Deletefromlist()
        {
            Console.WriteLine("Indtast navnet på monsteret der skal væk");
            Console.WriteLine();
            

            foreach (Monster monster in monsterController.list.monster)
            {

                Console.WriteLine(monster.Navn);
                Console.WriteLine(monster.Kendetegn);
                Console.WriteLine(monster.Antal);
                Console.WriteLine();
                
            }
            
            monsterController.list.Remove(monsterController.list.monster.Find(Monster => Monster.Navn == Console.ReadLine()));
            
            
        }
        public void Updatering()
        {
            Console.WriteLine("Her kan vi opdater vores kendetegn");
            Console.WriteLine("Skriv navnet ind på det monster hvis kendetegn skal redigeres(Case sensetive)");


            foreach (Monster monster in monsterController.list.monster)
            {
                Console.WriteLine($"{monster.Navn}: {monster.Kendetegn}");

               
            }

           var DetValgteMonster = monsterController.list.monster.Find(Monster => Monster.Navn == Console.ReadLine());
            DetValgteMonster.Kendetegn = Console.ReadLine();            
        }

    }
}   // Mange Tak til mine konsulenter Daniel, Nikolai & Lasse
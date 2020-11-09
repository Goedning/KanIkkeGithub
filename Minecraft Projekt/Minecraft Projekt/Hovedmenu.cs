using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minecraft_Projekt
{
    class Hovedmenu
    {
        string input = "";
        public void Start()
        {
            Console.WriteLine("Velkommen til mit Minecraft projekt!");
            Console.WriteLine("Hvis du er klar så bekræft venligst på y tasten");


            input = Console.ReadLine();

            if (input == "y")
            {
                Console.Clear();
                GameStart();
            }
            else if (input == "n")
            {
                Environment.Exit(1);
            }

        }

        NMob Nmobs = new NMob();

        public void GameStart() // Her starter spillet indsæt random mob gennem tråde
        {
            
            // Få lagt mobsne over i listen og find en random, de skal alle kører på en tråd. Find en måde at nedarve fra Pig.
            Nmobs = new NMob(" Sheep ", " Neutral ", "Blød ");
            Nmobs = new NMob(" Horse ", " Neutral ", "Blød ");
            Nmobs = new NMob(" Pig ", " Neutral ", "Blød ");
            Nmobs = new NMob(" Piglin ", " Neutral ", "Blød ");
            Nmobs = new NMob(" Zombiefied Piglin ", " Neutral", "Blød ");
            
          //  mob = new Mob(" Creeper ", " Neutral ", "Blød ");
          //  mob = new Mob(" Zombie ", " Neutral ", "Blød ");
          //  mob = new Mob(" Ghast ", " Neutral ", "Blød ");
          //  mob = new Mob(" Husk ", " Neutral ", "Blød ");
          //  mob = new Mob(" Phantom ", " Neutral ", " Blød ");
            

            Console.WriteLine("I afstanden kan du se en mob komme imod dig, det er en" + Nmobs.Name);
            Console.ReadLine();
            Action();
        }

        public void Action()
        {
            // Find en valgt mob gennem en tråd
            ConsoleKeyInfo tast1 = Console.ReadKey(true);
            bool going = true;

            while (going)
            {
                if (Nmobs.Neutral == "Neutral")
                {
                    Console.WriteLine( Nmobs.Name + " Kigger på dig undrene, hvad skal jeg dog gøre? ");
                    Console.WriteLine(" 1: Slå " + Nmobs.Name);
                    Console.WriteLine(" 2: Fodre " + Nmobs.Name);
                    Console.WriteLine(" 3: Skin " + Nmobs.Name);
                    Console.WriteLine(" 4: Gå væk fra " + Nmobs.Name);
                    Console.WriteLine("");


                    switch (tast1.Key)
                    {
                        case ConsoleKey.D1:
                            Console.WriteLine("Slå");
                            break;

                        case ConsoleKey.D2:
                            Console.WriteLine("Fodre");
                            break;

                        case ConsoleKey.D3:
                            Console.WriteLine("Skin");
                            break;

                        case ConsoleKey.D4:
                            Console.WriteLine("Gå væk");
                            break;
                    }
                }

            }

            

        }

    }
}

// Neutralt Monster: Sheep
// Neutralt Monster: Horse
// Neutralt Monster: Pig
// Neutralt Monster: Piglin (Skal arve fra pig)
// Neutralt Monster: Zombiefied Pigling (Skal arve fra pig)

// Hostile Monster: Creeper
// Hostile Monster: Zombie
// Hostile Monster: Ghast
// Hostile Monster: Husk
// Hostile Monster: Phantom

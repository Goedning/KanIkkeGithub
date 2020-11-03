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

        

        public void GameStart() // Her starter spillet indsæt random mob gennem tråde
        {
            Mob mob = new Mob();
            // Få lagt mobsne over i listen og find en random, de skal alle kører på en tråd. Find en måde at nedarve fra Pig.
            mob = new Mob(" Sheep ", "Neutral", "Blød");
            mob = new Mob(" Horse ", "Neutral", "Blød");
            mob = new Mob(" Pig ", "Neutral", "Blød");
            mob = new Mob(" Piglin ", "Neutral", "Blød");
            mob = new Mob(" Zombiefied Piglin ", "Neutral", "Blød");

            Console.WriteLine("I afstanden kan du se en mob komme imod dig, det er en" + mob.Name);
            Console.ReadLine();
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

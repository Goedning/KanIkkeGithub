using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minecraft_Projekt
{
    class Hovedmenu
    {
        char input;
        public void Start()
        {
            Console.WriteLine("Velkommen til mit Minecraft projekt!");
            Console.WriteLine("Hvis du er klar så bekræft venligst på y tasten");


            input = Console.ReadKey(true).KeyChar;

            if (input == 'y')
            {
                Console.Clear();
                // GameStart();
                Console.Write("╓");
                Console.Write(new string('═', 98));
                Console.WriteLine("╗");
                for (int i = 0; i < 27; i++)
                {
                    Console.WriteLine("║");
                }
                Console.Write("╙");
                Console.Write(new string('═', 98));
                Console.WriteLine("╜");
                
                for (int i = 1; i < 28; i++)
                {
                    Console.SetCursorPosition(99, i);
                    Console.WriteLine("║");
                }

                Player mig = new Player();
                mig.Position.PositionX = 27;
                mig.Position.PositionY = 27;

                for (int i = 0; i < 100; i++)
                {
                    Console.SetCursorPosition(mig.Position.PositionX, mig.Position.PositionY);
                    Console.Write(mig.tegn);
                    mig.Move(Console.ReadKey());
                }

                

            }
            else if (input == 'n')
            {
                Environment.Exit(1);
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

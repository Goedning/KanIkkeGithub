using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minecraft_Projekt
{
    public class Player
    {
        public Vector2 Position = new Vector2();

        public char tegn = 'P';
        public int HP
        {
            get;
            private set;
        }

        public Player()
        {
            HP = 20;
        }


        public void DoDamage(int damage)
        {
            HP -= damage;
            if (HP <= 0)
            {
                //die
            }
        }

        public void Move(ConsoleKeyInfo temp)
        {
            switch (temp.Key)
            {
                case ConsoleKey.UpArrow:
                    Position.PositionY--;
                    break;
                case ConsoleKey.DownArrow:
                    Position.PositionY++;
                    break;
                case ConsoleKey.LeftArrow:
                    Position.PositionX--;
                    break;
                case ConsoleKey.RightArrow:
                    Position.PositionX++;
                    break;
            }

        }
    }

    public class Tester
    {
        public Tester()
        {
            Player player = new Player();
            string health = "HP: " + player.HP;
            player.DoDamage(100);
        }
    }



}

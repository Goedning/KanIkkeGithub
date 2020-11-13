using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minecraft_Projekt
{
    public class Player
    {
        Vector2 Position = new Vector2();
        char tegn = 'P';
        //public int HP = 100;
        public int HP
        {
            get;
            private set;
        }

        /// <summary>
        /// Lav damage på player...
        /// </summary>
        /// <param name="damage">Mængde af damage</param>
        public void DoDamage(int damage)
        {
            
        }
    }

    //public class tester
    //{
    //    public tester()
    //    {
    //        Player player = new Player();
    //        string health = "HP: " + player.HP;
    //        player.DoDamage(10);
    //    }
    //}



}

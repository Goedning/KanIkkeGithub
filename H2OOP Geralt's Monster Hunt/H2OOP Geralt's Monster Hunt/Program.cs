using System;
using System.Collections;
using System.Collections.Generic;

namespace H2OOP_Geralt_s_Monster_Hunt
{
    sealed class Monster
    {
        // Tilføj flere sjove variabler folk de sådan elsker
        public string Navn { get; set; }
        public string Kendetegn { get; set; }
        public int Antal { get; set; }
        // Toss a Coin to the witcher?        
    }



    class MonsterListe
    {
        public List<Monster> navne = new List<Monster>();

        public void Add(Monster navn)
        {
           
            
            // navne.Add(navn); Skal laves om
        }

        public void Remove(Monster navn)
        {
           
            
             navne.Remove(navn);
        }

        public List<Monster> Getnavne()
        {
           
            
            return navne;
        }

        
    }

}

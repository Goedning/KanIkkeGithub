using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace H2OOP_Geralt_s_Monster_Hunt
{
    sealed class Monster //A
    {
        // Tilføj flere sjove variabler folk de sådan elsker
        public string Navn { get; set; }
        public string Kendetegn { get; set; }
        public int Antal { get; set; }
        // Toss a Coin to the witcher?        
    }


    class MonsterListe //B
    {
        public List<Monster> navne = new List<Monster>();

        
        public void Add(Monster navn)
        {
                       
            navne.Add(navn);
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

    class MonsterController // C
    {
        public MonsterListe list = new MonsterListe();
    }

}

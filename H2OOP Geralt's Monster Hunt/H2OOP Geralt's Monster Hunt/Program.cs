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
        public string Antal { get; set; }
        // Toss a Coin to the witcher?
        public Monster(string name, string b, string antal)
        {
            Navn = name;
            Kendetegn = b;
            Antal = antal;
        }
        public Monster()
        {

        }
    }


    class MonsterListe //B
    {
        public List<Monster> monster = new List<Monster>();

        
        public void Add(Monster monster)
        {
                       
            this.monster.Add(monster);
        }

        public void Remove(Monster monster)
        {
                      
             this.monster.Remove(monster);
        }

        public List<Monster> Getmonster()
        {
                       
            return monster;
        }

        
    }

    class MonsterController // C
    {
        public MonsterListe list = new MonsterListe();
        public void Insertmonster(Monster monster)
        {
            list.Add(monster);
        }
        public void Removemonster(Monster monster)
        {
            list.Remove(monster);
        }

    }

}

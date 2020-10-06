using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace ABCLibrary
{

    public sealed class Monster : IKillable //A
    {
        // Tilføj flere sjove variabler folk de sådan elsker
        public string Navn { get; set; }
        public string Kendetegn { get; set; }
        public string Antal { get; set; }
        public string Grim { get; set; }
        public string Forbrydelse { get; set; }
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


    public class MonsterListe //B
    {
        private readonly List<IKillable> monster = new List<IKillable>();

        
        public void Add(IKillable monster)
        {
                       
            this.monster.Add(monster);
        }

        public void Remove(IKillable monster)
        {
                      
             this.monster.Remove(monster);
        }

        public List<IKillable> Getmonster()
        {
                      
            return monster;
        }


    }

    public class MonsterController // C
    {
        public MonsterListe list = new MonsterListe();
        public void Insertmonster(Monster monster)
        {
            list.Add(monster);

        }
        public void Insertfjender(Fjender fjender)
        {

            list.Add(fjender);
        }
        public void Removemonster(Monster monster)
        {
            list.Remove(monster);
        }
        public void Removefjender(Fjender fjender)
        {
            list.Remove(fjender);
        }

    }

    public interface IKillable //E
    {
        string Grim { get; set; }
        string Forbrydelse { get; set; }
        string Navn { get; set; }
        string Kendetegn { get; set; }
        string Antal { get; set; }
    }

    public sealed class Fjender: IKillable
    {
        
        public string Grim { get; set; }
        public string Forbrydelse { get; set; }
        public string Navn { get; set; }
        public string Kendetegn { get; set; }
        public string Antal { get; set; }

        public Fjender(string navn, string grim, string forbrydelse)
        {
            Navn = navn;
            Forbrydelse = forbrydelse;
            Grim = grim;
        }
        public Fjender()
        {

        }
    }



}

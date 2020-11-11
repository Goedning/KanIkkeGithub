using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minecraft_Projekt
{
    public class NMob : INeutralMobs
    {
        public string Name { get; set; }
        public string Neutral { get; set; }
        public string Udsene { get; set; }
        public string Hit { get; set; }
        public string Fodrer { get; set; }
        public string Skin { get; set; }


        public NMob(string name, string neutral, string udsene)
        {
            Name = name;
            Neutral = neutral;
            Udsene = udsene;
        }

        public NMob()
        {

        }

    }

    
    public class NeutralList // Vi holder øje med hvilke mobs der er neutrale
    {
        private List<INeutralMobs> Nmobs = new List<INeutralMobs>();


        public void Insert(INeutralMobs Nmobs)
        {
            this.Nmobs.Add(Nmobs);
        }
    }



    public interface INeutralMobs // Her skal jeg have ind hvad de forskellige mobs kan gøre, som f.eks at spise.
    {
        string Hit { get; set; }
        string Fodrer { get; set; }
        string Skin { get; set; }

    }

    public class Weapon
    {
        public string name;
        public int attack;
        public int defend;

        public static List<Weapon> weapons = new List<Weapon>();

        public Weapon(string aName, int aAttack, int aDefend)
        {
            name = aName;
            attack = aAttack;
            defend = aDefend;
        }

        public static void Weapons(string name, int attack, int defend)
        {
            Weapon weapon = new Weapon(name, attack, defend);
            weapons.Add(weapon);
        }

        public static void AllWeaponStats()
        {
            Console.WriteLine("\n Alle tilgængelige våben ");
            foreach (Weapon weapon in Weapon.weapons)
            {
                Console.WriteLine("Navn: \nAttack: \nDefend");

            }
        }

        public static void CurrentWeapon()
        {

        }

    }

    public class Health
    {
        public static Weapon Stick = new Weapon("Gren", 1, 0);

        public string name;
        public int lv = 0;
        public int HP;
        public static Weapon equipped_weapon = Stick;

    }

}

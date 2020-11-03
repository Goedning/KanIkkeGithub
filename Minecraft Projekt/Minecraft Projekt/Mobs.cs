using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minecraft_Projekt
{
    public class Mob 
    {
        public string Name { get; set; }
        public string Neutral { get; set; }
        public string Udsene { get; set; }


        public Mob(string name, string neutral, string udsene)
        {
            Name = name;
            Neutral = neutral;
            Udsene = udsene;
        }

        public Mob()
        {

        }

    }

    

    public class NeutralListe // Vi holder øje med hvilke mobs der er neutrale
    {
        public NeutralListe neutral = new NeutralListe();

        

    }

    public class HostileListe // Vi holder øje med hvilke mobs der er hostile
    {
        public HostileListe hostile = new HostileListe();


    }

    public interface MobsDetails // Her skal jeg have ind hvad de forskellige mobs kan gøre, som fek.s at spise.
    {
        String Name { get; set; }
        String Fodrer { get; set; }
    }

}

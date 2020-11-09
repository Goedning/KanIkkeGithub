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

    
    public class neutralList // Vi holder øje med hvilke mobs der er neutrale
    {
        private List<INeutralMobs> Nmobs = new List<INeutralMobs>();


        public void Insert()
        {
            Nmobs.Add(Nmobs);
        }


    }



    public interface INeutralMobs // Her skal jeg have ind hvad de forskellige mobs kan gøre, som fek.s at spise.
    {
        string Hit { get; set; }
        string Fodrer { get; set; }
        string Skin { get; set; }

    }

}

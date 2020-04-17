using System.Collections.Generic;
using System.Drawing;

namespace SpaceInvaders
{
    class Barrier
    {
        //Samlingen af vores skjolde.
        public List<Column> Columns { get; set; } = new List<Column>();

        //Ødelægger Barrierne hvis fjernder kommer for tæt.
        public float TopY { get; set; } = float.MaxValue;
    }

    class Column
    {
        public List<RectangleF> Rectangles { get; set; } = new List<RectangleF>();
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiUr
{
    public class Timer
    {
        public TimeSpan ts;

        public Stopwatch stopwatch= new Stopwatch();


        public Timer(int hours, int minutes, int seconds)
        {
            ts = new TimeSpan(hours, minutes, seconds);
        }
       

    }
}

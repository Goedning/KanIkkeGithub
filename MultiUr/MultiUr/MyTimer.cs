using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiUr
{
    public class MyTimer
    {
        public TimeSpan ts;

        public Stopwatch stopwatch;

        public TimeSpan Remaining { get => ts - stopwatch.Elapsed; }


        public MyTimer(int hours, int minutes, int seconds)
        {
            ts = new TimeSpan(hours, minutes, seconds);
            stopwatch = new Stopwatch();
        }
       

    }
}

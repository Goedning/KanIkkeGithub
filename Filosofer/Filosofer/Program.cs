using System;
using System.Text;
using System.Threading;
using System.Diagnostics;
using System.Collections.Generic;

namespace Filosofer
{
    public class SpisendFilosofer
    {
        const int PHILOSOPHER_COUNT = 5;

        static void Main(string[] args)
        {
            
            var Filosoferne = InitializeFilosoferne();

            
            Console.WriteLine("Filosoferne begynder at spise!");

            
            var FilosoerneThread = new List<Thread>();
            foreach (var Filosof in Filosoferne)
            {
                var FilosofThread = new Thread(new ThreadStart(Filosof.EatAll));
                FilosoerneThread.Add(FilosofThread);
                FilosofThread.Start();
            }

            
            foreach (var thread in FilosoerneThread)
            {
                thread.Join();
            }

            
            Console.WriteLine("Maden er klar!");
        }

        private static List<Filosofer> InitializeFilosoferne()
        {
            
            var Filosoferne = new List<Filosofer>(PHILOSOPHER_COUNT);
            for (int i = 0; i < PHILOSOPHER_COUNT; i++)
            {
                Filosoferne.Add(new Filosofer(Filosoferne, i));
            }

            
            foreach (var Filosof in Filosoferne)
            {
                
                Filosof.Venstregaffel = Filosof.VenstreFilosof.Højregaffel ?? new Gaffel();

                
                Filosof.Højregaffel = Filosof.HøjreFilosof.Venstregaffel ?? new Gaffel();
            }

            return Filosoferne;
        }
    }

    
    public class Filosofer
    {
        private const int TIMES_TO_EAT = 5;
        private int _timesEaten = 0;
        private readonly List<Filosofer> _alleFilosoferne;
        private readonly int _index;

        public Filosofer(List<Filosofer> allFilosoerne, int index)
        {
            _alleFilosoferne = allFilosoerne;
            _index = index;
            this.Name = string.Format("Filosofer {0}", _index);
            this.State = State.Thinking;
        }

        public string Name { get;  set; }
        public State State { get;  set; }
        public Gaffel Venstregaffel { get; set; }
        public Gaffel Højregaffel { get; set; }

        public Filosofer VenstreFilosof
        {
            get
            {
                if (_index == 0)
                    return _alleFilosoferne[_alleFilosoferne.Count - 1];
                else
                    return _alleFilosoferne[_index - 1];
            }
        }

        public Filosofer HøjreFilosof
        {
            get
            {
                if (_index == _alleFilosoferne.Count - 1)
                    return _alleFilosoferne[0];
                else
                    return _alleFilosoferne[_index + 1];
            }
        }

        public void EatAll()
        {
            
            while (_timesEaten < TIMES_TO_EAT)
            {
                this.Think();
                if (this.PickUp())
                {                    
                    this.Eat();

                   
                    this.PutDownLeft();
                    this.PutDownRight();
                }
            }
        }

        private bool PickUp()
        {
            
            if (Monitor.TryEnter(this.Venstregaffel))
            {
                Console.WriteLine(this.Name + " samler venstre gaffel op.");

                
                if (Monitor.TryEnter(this.Højregaffel))
                {
                    Console.WriteLine(this.Name + " smaler højre gaffel op.");

                    
                    return true;
                }
                else
                {
                    
                    this.PutDownLeft();
                }
            }

            
            return false;
        }

        private void Eat()
        {
            
            this.State = State.Eating;
            _timesEaten++;
            Console.WriteLine(this.Name + " Spiser.");
        }

        private void PutDownLeft()
        {
            Monitor.Exit(this.Venstregaffel);
            Console.WriteLine(this.Name + " putter venstre gaffel ned.");
        }

        private void PutDownRight()
        {
            Monitor.Exit(this.Højregaffel);
            Console.WriteLine(this.Name + " putter højre gaffel ned.");
            
        }


        private void Think()
        {
            this.State = State.Thinking;
        }
    }

    public enum State
    {
        Thinking = 0,
        Eating = 1
    }

    
    public class Gaffel
    {
        private static int _count = 1;
        public string Name { get; private set; }

        public Gaffel()
        {
            this.Name = "gaffel " + _count++;
        }
    }
}

using System;

namespace Nedtæller
{
    class Program
    {
        DateTime d1;
        DateTime d2;

        static void Main(string[] args)
        {
            Console.WriteLine("Hej og velkommen til mit nyeste mini projekt, hvor jeg ville lave nogle få timere til forskellige datoer, nedenunder kan du se vores nuværende dato og tid");
            Console.WriteLine();
            Console.WriteLine(DateTime.Now);
            Console.WriteLine();
            Console.WriteLine("For at finde tiden til d.10 maj Tryk 1");
            Console.WriteLine("For at finde tiden til sommerferie Tryk 2");
            Console.WriteLine("For at finde tiden til juleaften tryk 3");

            ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
            if (consoleKeyInfo.Key == ConsoleKey.D1)
            {
                Console.WriteLine("Debug");
            }
            else if (consoleKeyInfo.Key == ConsoleKey.D2)
            {
                Console.WriteLine("Debug");
            }
            else if (consoleKeyInfo.Key == ConsoleKey.D2)
            {
                Console.WriteLine("Debug");
            }

        }
        public void Nedlukning()
        {
            DateTime strt_date = DateTime.Now;
            DateTime end_date = Convert.ToDateTime("10/5/2020 23:59:59");
            TimeSpan nod = (end_date - strt_date);
            Console.WriteLine(strt_date + "" + end_date + "" + "" + nod.TotalHours + "");
            Console.ReadKey();
        }

    }
}

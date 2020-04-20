using System;

namespace Nedtæller
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Hej og velkommen til mit nyeste mini projekt, hvor jeg ville lave nogle få timere til forskellige datoer, nedenunder kan du se vores nuværende dato og tid");
            Console.WriteLine();
            Console.WriteLine(DateTime.Now);
            Console.WriteLine();
            Console.WriteLine("For at finde tiden til d.10 maj Tryk 1");
            Console.WriteLine("For at finde tiden til sommerferie Tryk 2");
            Console.WriteLine("For at finde tiden til juleaften tryk 3");
            Console.WriteLine();

            ConsoleKeyInfo consoleKeyInfo = Console.ReadKey(true);
            if (consoleKeyInfo.Key == ConsoleKey.D1)
            {
                DateTime skp = new DateTime(2020, 5, 10);
                double dagetilbagetilskp = skp.Subtract(DateTime.Today).TotalDays;
                Console.WriteLine(dagetilbagetilskp);
            }
            else if (consoleKeyInfo.Key == ConsoleKey.D2)
            {
                DateTime skp = new DateTime(2020, 6, 26);
                double dagetilbagetilskp = skp.Subtract(DateTime.Today).TotalDays;
                Console.WriteLine(dagetilbagetilskp);
            }
            else if (consoleKeyInfo.Key == ConsoleKey.D2)
            {
                DateTime skp = new DateTime(2020, 12, 24);
                double dagetilbagetilskp = skp.Subtract(DateTime.Today).TotalDays;
                Console.WriteLine(dagetilbagetilskp);
            }

        }

    }
}

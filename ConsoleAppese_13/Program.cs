using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppese_13
{
    class Program2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inserisci il prezzo: ");
            int spesa1 = int.Parse(Console.ReadLine());
            if (spesa1 > 500)
            {
                double sconto = spesa1 * 20 / 100;
                double totale = spesa1 - sconto;
                Console.WriteLine($"il totale è più conveniente il primo negozio: {totale}");
            }
            else if (spesa1 > 300)
            {
                double sconto = spesa1 * 20 / 100;
                double totaleMaggiore = spesa1 - sconto;
                Console.WriteLine($" il totale è più convenienza al secondo negozio: {totaleMaggiore}");
            }
            Console.ReadLine();
        }
    }
}
        
            
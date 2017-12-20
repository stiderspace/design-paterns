using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Boekhandel boekhandel = new Boekhandel();
            boekhandel.Voegtoe(new Boek(9.59f, "DERPFACE", 3, "derp"));
            boekhandel.Voegtoe(new CD(2.53f, "donald Duck", 5, "slurp"));
            boekhandel.Voegtoe(new Weekblad(88.5f, "donald Duck", 25, "2323"));
            boekhandel.PrintVoorraad();

            Console.WriteLine("");

            boekhandel.items[0].WijzigVoorraad(false, 2);
            boekhandel.items[1].WijzigVoorraad(true, 2);
            boekhandel.PrintVoorraad();
            Console.Read();
        }
    }
}

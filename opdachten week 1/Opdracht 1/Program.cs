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
            boekhandel.Voegtoe(new Boek(9.59, "DERPFACE", 3));
            boekhandel.Voegtoe(new CD(2.99, "donald Duck", 5));
            boekhandel.Voegtoe(new Weekblad(88.5, "donald Duck", 25));
            boekhandel.PrintVoorraad();

            Console.WriteLine("");

            boekhandel.items[0].WijzigVoorraad(false, 2);
            boekhandel.items[1].WijzigVoorraad(true, 2);
            boekhandel.PrintVoorraad();
            Console.Read();
        }
    }
}

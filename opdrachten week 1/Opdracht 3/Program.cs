using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_3
{
    class Program
    {
        static void Main(string[] args)
        {
            IPotlood p = new Potlood(25); // het potlood kan maximaal 20 karakters schrijven
            string boodschap = "Deze regel is meer dan 20 karakters lang.";
            p.Schrijf(boodschap);
            if (!p.IsScherp)
            {
                IPotloodSlijper slijper = new PotloodSlijper();
                slijper.Slijp(p); // in de Slijp-methode wordt "NaGeslepen()" van p aangeroepen
            }
            boodschap = "Potlood is weer ok!";
            p.Schrijf(boodschap);

            boodschap = "Deze regel is meer dan 20 karakters lang.";
            p.Schrijf(boodschap);
            Console.ReadKey();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_2
{
    class Superman : IVliegbaar
    {
        
        public void Landen()
        {
            Console.WriteLine(this.GetType().Name + " aan het landen...");
        }

        public void Opstijgen()
        {
            Console.WriteLine(this.GetType().Name + " aan het opstijgen...");
        }

        public void Vliegen()
        {
            Console.WriteLine(this.GetType().Name + " aan het rondvliegen...");
        }
    }
}

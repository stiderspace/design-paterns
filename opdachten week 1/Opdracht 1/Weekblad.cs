using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_1
{
    class Weekblad:BoekhandelItem
    {

        public Weekblad(double prijs, string title, int aantal)
            : base(prijs, title, aantal)
        {
            this.Prijs = prijs;
            this.Title = title;
            this.Aantal = aantal;
        }

        public int UitgifteDag
        {
            get; set;

        }

        public override string ToString()
        {
            string output = "WEEKBLAD";
            return output;
        }

    }
}

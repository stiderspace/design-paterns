using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_1
{
    class Weekblad:BoekhandelItem
    {

        public Weekblad(float prijs, string title, int aantal, string uitgifte)
            : base(prijs, title, aantal)
        {
            this.UitgifteDag = uitgifte;
        }

        public string UitgifteDag
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

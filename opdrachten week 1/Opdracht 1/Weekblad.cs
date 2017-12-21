using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_1
{
    class Weekblad:BoekhandelItem
    {
        public string UitgifteDag { get; set; }
        public Weekblad(float prijs, string title, int aantal, string uitgifte)
            : base(prijs, title, aantal)
        {
            this.UitgifteDag = uitgifte;
        }

        

    }
}

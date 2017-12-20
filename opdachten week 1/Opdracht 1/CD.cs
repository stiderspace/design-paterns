using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_1
{
    class CD : BoekhandelItem
    {
        public string Artiest { get; set; }
        public CD(float prijs, string title, int aantal, string artiest) : base(prijs, title, aantal)
        {
            this.Artiest = artiest;
        }

        
    }
}

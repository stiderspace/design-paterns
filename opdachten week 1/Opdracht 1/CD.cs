using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_1
{
    class CD : BoekhandelItem
    {
        
        public CD(double prijs, string title, int aantal, string artiest) : base(prijs, title, aantal)
        {
            this.Artiest = artiest;
        }

        public string Artiest{ get; set; }

        public override string ToString()
        {
            string output = "CD";
            return output;
        }
    }
}

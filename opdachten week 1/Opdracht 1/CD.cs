using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_1
{
    class CD : BoekhandelItem
    {
        
        public CD(double prijs, string title, int aantal) : base(prijs, title, aantal)
        {
            this.Prijs = prijs;
            this.Title = title;
            this.Aantal = aantal;
        }

        public int Artiest
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public override string ToString()
        {
            string output = "CD";
            return output;
        }
    }
}

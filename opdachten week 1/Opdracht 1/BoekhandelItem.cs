using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_1
{
    abstract class BoekhandelItem
    {
        public int Aantal { get; set; }
        public float Prijs { get; set; }
        public string Title { get; set; }

        public BoekhandelItem(float prijs, string title, int aantal)
        {
            this.Aantal = aantal;
            this.Prijs = prijs;
            this.Title = title;
        }

        public void WijzigVoorraad(bool Subtract, int aantal)
        {
            if (Subtract)
            {
                this.Aantal = this.Aantal - aantal;
            }
            else
            {
                this.Aantal = this.Aantal + aantal;
            }
        }
    }
}

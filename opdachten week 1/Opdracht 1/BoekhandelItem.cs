using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_1
{
    abstract class BoekhandelItem
    {
        protected int aantal;

        public BoekhandelItem(double prijs, string title, int aantal)
        {
            this.aantal = aantal;
        }

        public int Aantal
        {
            get { return aantal; } protected set { this.aantal = Aantal; }

        }

        public Double Prijs
        {
            get; protected set;

        }

        public string Title
        {
            get; protected set;
        }

        public void WijzigVoorraad(bool Subtract, int aantal)
        {
            if (Subtract)
            {
                this.aantal = this.aantal - aantal;
            }
            else
            {
                this.aantal = this.aantal + aantal;
            }
        }
    }
}

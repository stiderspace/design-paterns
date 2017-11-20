using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_1
{
    class Boek:BoekhandelItem
    {

        public Boek(double prijs, string title, int aantal) : base(prijs, title, aantal)
        {
            this.Prijs = prijs;
            this.Title = title;
            this.Aantal = aantal;
        }

        public int Auteur
        {
            get;
            
        }

        public override string ToString()
        {
            string output = "Boek";
            return output;
        } 
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_1
{
    class Boek:BoekhandelItem
    {
        public string Auteur { get; set; }
        public Boek(float prijs, string title, int aantal,string auteur) : base(prijs, title, aantal)
        {
            this.Auteur = auteur;
        }

        
    }
}

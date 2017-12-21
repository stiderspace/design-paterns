using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_1
{
    class Boekhandel
    {
        public List<BoekhandelItem> items = new List<BoekhandelItem>();

        public Boekhandel()
        {
            
        }

        public void Voegtoe(BoekhandelItem item)
        {
            items.Add(item);
        }

        public void PrintVoorraad()
        {
            foreach(BoekhandelItem book in items)
            {
                Console.WriteLine(book.ToString() + "  {0} : {1} : {2} : {3}", book.Title, book.Prijs, book.Aantal);
            }
        }

        
    }
}

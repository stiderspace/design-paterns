using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_2
{
    
    class GeenKaartStatus : IPinAutomaatStatus
    {
        private PinAutomaat automaat;
        public GeenKaartStatus(PinAutomaat pinAutomaat)
        {
            this.automaat = pinAutomaat;
        }
        public void EjectCard()
        {
            Console.WriteLine("geen kaart aanwezig");
        }

        public void GiveMoney()
        {
            Console.WriteLine("geen kaart aanwezig");
        }

        public void InsertCard()
        {
            Console.WriteLine("Kaart ingevoerd");
            automaat.setAutomaatStatus(automaat.GeefKaartAanwezigStatus());
        }

        public void InsertPin()
        {
            Console.WriteLine("geen kaart aanwezig");
        }
    }
}

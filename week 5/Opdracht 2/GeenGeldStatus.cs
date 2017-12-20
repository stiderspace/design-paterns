using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_2
{
    
    class GeenGeldStatus : IPinAutomaatStatus
    {
        private PinAutomaat automaat;
        public GeenGeldStatus(PinAutomaat pinAutomaat)
        {
            this.automaat = pinAutomaat;
        }
        public void EjectCard()
        {
            Console.WriteLine("kaart uitgeworpen");
            automaat.setAutomaatStatus(automaat.GeefGeenKaartAanwezigStatus());
        }

        public void GiveMoney()
        {
            throw new NotImplementedException();
        }

        public void InsertCard()
        {
            throw new NotImplementedException();
        }

        public void InsertPin()
        {
            throw new NotImplementedException();
        }
    }
}

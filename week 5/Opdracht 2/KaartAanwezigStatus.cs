using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_2
{
    class KaartAanwezigStatus : IPinAutomaatStatus
    {
        private PinAutomaat automaat;
        public KaartAanwezigStatus(PinAutomaat pinAutomaat)
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
            Console.WriteLine("kaart al aanwezig");
        }

        public void InsertPin()
        {
            Console.WriteLine("prin correct");
            automaat.setAutomaatStatus(automaat.GeefCorrectePinStatus());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_2
{
    
    class CorectePinStatus : IPinAutomaatStatus
    {
        private PinAutomaat automaat;
        public CorectePinStatus(PinAutomaat pinAutomaat)
        {
            this.automaat = pinAutomaat;
        }
        public void EjectCard()
        {
            Console.WriteLine("kaart uitgeworpen");
            automaat.setAutomaatStatus(automaat.GeefGeenKaartAanwezigStatus());
        }

        public void GiveMoney(int geld)
        {
            if(geld > automaat.BedragInAutomaat)
            {
                Console.WriteLine(geld + " uitgegeven");

                automaat.BedragInAutomaat = automaat.BedragInAutomaat - geld;
                if(automaat.BedragInAutomaat == 0 )
                {
                    automaat.setAutomaatStatus(automaat.GeefGeenGeldStatus());
                }
                
            }
            Console.WriteLine("kaart uit gegeven");
        }

        public void InsertCard()
        {
            Console.WriteLine("kaart is al ingevoerd");
        }

        public void InsertPin()
        {
            Console.WriteLine("pincode al ingevoerd");
        }
    }
}

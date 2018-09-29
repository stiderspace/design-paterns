using System;

namespace Opdracht_2
{
    internal class PinAutomaat
    {
        private IPinAutomaatStatus automaatStatus;
        private IPinAutomaatStatus kaartNietAanwezig;
        private IPinAutomaatStatus kaartAanwezig;
        private IPinAutomaatStatus geenGeldAanwezig;
        private IPinAutomaatStatus correctePinCodeIngevoerd;

        private float bedragInAutomaat;
        public PinAutomaat(int bedragInAutomaat)
        {
            kaartAanwezig = new KaartAanwezigStatus(this);
            kaartNietAanwezig = new GeenKaartStatus(this);
            geenGeldAanwezig = new GeenGeldStatus(this);
            correctePinCodeIngevoerd = new CorectePinStatus(this);
            this.bedragInAutomaat = bedragInAutomaat;
            if(bedragInAutomaat > 0 )
            {
                automaatStatus = geenGeldAanwezig;
            }
            else
            {
                automaatStatus = kaartNietAanwezig;
            }
        }
        public float BedragInAutomaat { get { return this.bedragInAutomaat; } set { bedragInAutomaat = value} }
        internal IPinAutomaatStatus GeefCorrectePinStatus() { return correctePinCodeIngevoerd; }
        internal IPinAutomaatStatus GeefGeenGeldStatus() { return geenGeldAanwezig; }
        internal IPinAutomaatStatus GeefGeenKaartAanwezigStatus() { return kaartNietAanwezig; }
        internal IPinAutomaatStatus GeefKaartAanwezigStatus() { return kaartAanwezig; }
        internal void KaartUitwerpen() { automaatStatus.EjectCard(); }
        internal void PincodeInvoeren(int v) { automaatStatus.InsertPin(); }
        internal void GeldOpvragen(int v) { automaatStatus.GiveMoney(); }
        internal void KaartInvoeren() { automaatStatus.InsertCard(); }
        internal void setAutomaatStatus(IPinAutomaatStatus status) { automaatStatus = status; }
        internal void setGeldInAutomaat(int geld) { BedragInAutomaat = geld; }

    }
}
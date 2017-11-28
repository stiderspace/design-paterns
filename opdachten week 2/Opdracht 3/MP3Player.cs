using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_3
{
    class MP3Player : ISubject
    {
        private List<Nummer> nummers = new List<Nummer>();
        private List<IObserver> observers = new List<IObserver>();
        public Nummer HuidigNummer { get; private set; }
       
        public MP3Player()
        {
            nummers.Add(new Nummer("pink floyd", "wish you were Here", "03:12"));
            nummers.Add(new Nummer("bruno mars", "billionair", "03:33"));
            nummers.Add(new Nummer("led zepplin", "dazed and condfused", "04:00"));

        }

        public void NummerGewijzigd()
        {
            NotifyObservers();
        }
        public void AddObserver(IObserver observer)
        {
            this.observers.Add(observer);
        }

        public void NotifyObservers()
        {
            Random rnd = new Random();
            int num;
            do
            {
                num = rnd.Next(3);
            } while (nummers[num] == HuidigNummer);
            foreach (IObserver observer in observers)
            {
                observer.Update(nummers[num]);
                HuidigNummer = nummers[num];
            }
        }

        public void RemoveObserver(IObserver observer)
        {
            
        }
    }

}

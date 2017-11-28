using Opdracht_1.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_1.models
{
    public class TreinReis : ITreinReis
    {
        private List<Station> stations;
        private int huidigStation;
        private List<ITreinDisplay> observers;
        private bool returnTrip;
        public TreinReis()
        {
            stations = new List<Station>(); // todo: voeg (hardcoded) Stations toe... 
            huidigStation = 0;
            returnTrip = false;

        }
        public void AddObserver(ITreinDisplay observer)
        {
            this.observers.Add(observer);
            NotifyObservers();
        }
        public void RemoveObserver(ITreinDisplay observer)
        {
            throw new NotImplementedException();
        }
        public void VolgendStation()
        {
            
            if (!returnTrip)
            {
                huidigStation++;
            }
            else
            {
                huidigStation--;
            }
            if (huidigStation == (stations.Count - 1) || huidigStation == 0)
            {
                returnTrip = !returnTrip;
            }

            NotifyObservers();
        }

        public void NotifyObservers()
        {
            foreach(ITreinDisplay observer in observers)
            {
                observer.Update(stations[huidigStation]);
            }
        }


    }
}

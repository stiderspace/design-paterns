using System.Collections.Generic;
using System.Net.NetworkInformation;

namespace Opdracht_3
{
    public interface IObserver
    {
        void Update( Nummer nummer );
    }
}
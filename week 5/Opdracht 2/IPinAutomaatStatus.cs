using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_2
{
    interface IPinAutomaatStatus
    {
        void InsertCard();
        void EjectCard();
        void InsertPin();
        void GiveMoney();
    }
}

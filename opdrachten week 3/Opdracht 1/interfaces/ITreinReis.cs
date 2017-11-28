using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_1.interfaces
{
    public interface ITreinReis
    {
        void AddObserver(ITreinDisplay observer);
        void RemoveObserver(ITreinDisplay observer);
        void VolgendStation();
    }
}

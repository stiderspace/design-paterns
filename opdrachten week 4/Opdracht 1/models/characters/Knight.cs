using Opdracht_1.models.weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_1.models.characters
{
    class Knight : Character
    {
        public Knight()
        {
            this.Weapon = new SwordBehaviour();
        }
    }
}

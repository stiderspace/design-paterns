using Opdracht_1.models.weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_1.models.characters
{
    class King : Character
    {
        public King()
        {
            this.Weapon = new BowAndArrowBehaviour();
        }
    }
}

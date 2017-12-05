using Opdracht_1.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_1.models.characters
{
    class Character 
    {
        private IWeaponBehaviour weapon;
        public IWeaponBehaviour Weapon { get { return weapon; } set { weapon = value; } }

        public Character()
        {

        }
        public void Fight()
        {
            weapon.UseWeapon();
        }
    }
}

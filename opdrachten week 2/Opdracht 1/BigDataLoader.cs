using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_2
{
    public abstract class BigDataLoader
    {
        public void Etl()
        {
            Extract();
            Transform();
            Load();
        }

        public abstract void Load();
        public abstract void Transform();
        public abstract void Extract();
    }
}

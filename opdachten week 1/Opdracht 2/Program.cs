using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_2
{
    class Program
    {
        static void Main(string[] args)
        {
            IVliegbaar s = new Superman();
            IVliegbaar v = new Vliegtuig();
            MaakVlucht(s);
            MaakVlucht(v);
            Console.ReadLine();
        }

        private static void MaakVlucht(IVliegbaar s)
        {
            s.Opstijgen();
            for( int i = 0; i < 3; i ++)
            {
                s.Vliegen();
            }
            s.Landen();
            Console.WriteLine(" ");
        }
    }
}

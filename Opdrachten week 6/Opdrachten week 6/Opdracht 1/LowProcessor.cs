using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_1
{
    class LowProcessor : IProcessor
    {
        public void PreformOperation()
        {
            Console.WriteLine("processing slowly...");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger logger = Logger.GetInstance();
            logger.log("main", "Starting.....");

            MainSystem system = new MainSystem();
            system.DoSomeMainWork();
            logger.log("main", "finished!!");

            Console.Read();
        }
    }
}

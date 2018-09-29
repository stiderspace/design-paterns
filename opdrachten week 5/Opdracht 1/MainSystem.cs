using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_1
{
    class MainSystem
    {
        private SubSystem subsystem;
        private Logger logger;
        public MainSystem()
        {
            subsystem = new SubSystem();
            logger = Logger.GetInstance();
        }

        public void DoSomeMainWork()
        {
            logger.log("MainSystem", "doing some main work");
            subsystem.DoSomeWork();
            subsystem.DoSomeMoreWork();
        }
    }
}

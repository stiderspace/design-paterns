using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_1
{
    class SubSystem
    {
        private Logger logger;
        public SubSystem()
        {
            logger = Logger.GetInstance();
        }

        public void DoSomeWork()
        {
            logger.log("SubSystem", "doing some work");
        }
        public void DoSomeMoreWork()
        {
            logger.log("SubSystem", "doing some more work");
        }
    }
}

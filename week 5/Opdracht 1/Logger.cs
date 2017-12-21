using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_1
{  
    class Logger
    {
        private static Logger uniqueInstance;
        private int numberOfLines;
        public Logger()
        {
            numberOfLines = 0;
        }


        internal void log(string loglocation, string logstring)
        {
            numberOfLines++;
            Console.WriteLine("{0} - [{1}] {2}", numberOfLines, loglocation, logstring);
        }

        public static Logger GetInstance()
        {
            if(uniqueInstance == null)
            {
                uniqueInstance = new Logger();
            }
            return uniqueInstance;
        }
    }
}

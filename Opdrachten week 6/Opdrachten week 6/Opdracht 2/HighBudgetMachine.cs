using System;

namespace Opdracht_2
{
    public class HighBudgetMachine : IMachineFactory
    {
        public  IHardDisk createHarddisk()
        {
            return new HighHardDrive();
        }

        public  IMonitor createMonitor()
        {
            return new HighMonitor();
        }

        public  IProcessor createProcessor()
        {
            return new HighProcessor();
        }
    }
}
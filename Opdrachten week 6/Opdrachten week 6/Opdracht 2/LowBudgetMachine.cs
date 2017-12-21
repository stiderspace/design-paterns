using System;

namespace Opdracht_2
{
    internal class LowBudgetMachine : IMachineFactory
    {
        public  IHardDisk createHarddisk()
        {
            return new LowHardDrive();
        }

        public  IMonitor createMonitor()
        {
            return new LowMonitor();
        }

        public  IProcessor createProcessor()
        {
            return new LowProcessor();
        }
    }
}
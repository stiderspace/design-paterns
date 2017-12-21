using System;

namespace Opdracht_1
{
    internal class HighBudgetShop : ComputerShop
    {
        public override IHardDisk createHarddisk()
        {
            return new HighHardDrive();
        }

        public override IMonitor createMonitor()
        {
            return new HighMonitor();
        }

        public override IProcessor createProcessor()
        {
            return new HighProcessor();
        }
    }
}
using System;

namespace Opdracht_1
{
    internal class LowBudgetShop : ComputerShop
    {
        public override IHardDisk createHarddisk()
        {
            return new LowHardDrive();
        }

        public override IMonitor createMonitor()
        {
            return new LowMonitor();
        }

        public override IProcessor createProcessor()
        {
            return new LowProcessor();
        }
    }
}
using System;

namespace Opdracht_1
{
    public abstract class ComputerShop
    {
        public void AssembleMachine()
        {
            IHardDisk disk = createHarddisk();
            disk.StoreData();
            IMonitor monitor = createMonitor();
            monitor.Display();
            IProcessor cpu = createProcessor();
            cpu.PreformOperation();

        }

        public abstract IHardDisk createHarddisk();
        public abstract IMonitor createMonitor();
        public abstract IProcessor createProcessor();

    }
}
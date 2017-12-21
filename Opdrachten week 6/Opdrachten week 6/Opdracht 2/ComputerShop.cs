using System;

namespace Opdracht_2
{
    public class ComputerShop
    {
        IMachineFactory factory;
        public ComputerShop(IMachineFactory factory)
        {
            this.factory = factory;
        }
        public void AssembleMachine()
        {
            IHardDisk disk = factory.createHarddisk();
            disk.StoreData();
            IMonitor monitor = factory.createMonitor();
            monitor.Display();
            IProcessor cpu = factory.createProcessor();
            cpu.PreformOperation();

        }
    }
}
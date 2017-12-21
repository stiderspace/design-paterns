namespace Opdracht_2
{
    public interface IMachineFactory
    {
        IHardDisk createHarddisk();
        IMonitor createMonitor();
        IProcessor createProcessor();
    }
}
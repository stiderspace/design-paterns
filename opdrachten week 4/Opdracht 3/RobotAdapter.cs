namespace Opdracht_3
{
    internal class RobotAdapter : IAanvaller
    {
        private Robot evilRobot;

        public RobotAdapter(Robot evilRobot)
        {
            this.evilRobot = evilRobot;
        }
    }
}
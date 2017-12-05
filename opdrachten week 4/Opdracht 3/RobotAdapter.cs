using System;

namespace Opdracht_3
{
    internal class RobotAdapter : IAanvaller
    {
        private Robot evilRobot;

        public RobotAdapter(Robot evilRobot)
        {
            this.evilRobot = evilRobot;
        }

        public void GebruikWapen()
        {
            evilRobot.BeukMetHanden();
        }

        public void KoppelBestuurder(string player)
        {
            evilRobot.BeweegViaPersoon(player);
        }

        public void RijNaarVoren()
        {
            evilRobot.LoopNaarVoren();
        }
    }
}
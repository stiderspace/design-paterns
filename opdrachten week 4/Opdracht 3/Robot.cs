using System;

namespace Opdracht_3
{
    class Robot
    {
        public int generator = 10;
        public Robot()
        {

        }

        public void BeukMetHanden() {
            Console.WriteLine("Robot slaat tegenstander en veroorzaakt 8 damage ");
        }
        public void BeweegViaPersoon(string player)
        {
            Console.WriteLine("Robot beweegt via " + player);
        }
        public void LoopNaarVoren() {
            Console.WriteLine("Robot beweegt 3 plaatsen naar voren ");
        }

    }
}
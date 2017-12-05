using System;

namespace Opdracht_3
{
    internal class Tank : IAanvaller
    {
        public void GebruikWapen()
        {
            Console.WriteLine("tank veroorzaakt 8 damage ");
        }

        public void KoppelBestuurder(string player)
        {
            Console.WriteLine("tank beweegt via " + player);
        }

        public void RijNaarVoren()
        {
            Console.WriteLine("tank verplaatst 3 plekken ");
        }
    }
}
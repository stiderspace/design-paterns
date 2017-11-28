using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_3
{
    class Program
    {

        static void Main(string[] args)
        {
            // maak een MP3 player aan
            MP3Player player = new MP3Player();
            // maak de displays aan
            IObserver mp3Display1 = new SimpleMP3Display(player);
            IObserver mp3Display2 = new FancyMP3Display(player);
            // zet player op een nieuw nummer
            // (aangezien er geen hardware is, doen we dat hier...)
            for (int i = 0 ; i < 3; i++)
            {
                player.NummerGewijzigd();
            }
            

            Console.ReadKey();
        }

    }
}


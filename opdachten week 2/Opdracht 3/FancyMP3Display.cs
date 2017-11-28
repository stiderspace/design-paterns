using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_3
{
    class FancyMP3Display : IObserver
    {
        private MP3Player player;
        
        public FancyMP3Display(MP3Player player)
        {
            this.player = player;
            player.AddObserver(this);
            
        }

        public void Update(Nummer nummer)
        {
            Console.WriteLine("Fancy display: '{1}' van {0} ({2})", nummer.artist, nummer.title, nummer.time);
        }
    }
}

﻿using System;
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
        }

        public void Update(Nummer nummer)
        {
            throw new NotImplementedException();
        }
    }
}

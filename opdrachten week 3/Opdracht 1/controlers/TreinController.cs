using Opdracht_1.interfaces;
using Opdracht_1.models;
using Opdracht_1.views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_1.controlers
{
    class TreinController : ITreinController
    {
        public ITreinReis reis;
        public TreinController()
        {
            reis = new TreinReis();
            new ReisInfoDisplay(reis).Show();
        }

        public void NewDisplay()
        {
            new ReisInfoDisplay(reis).Show();
        }

        public void VolgendStation()
        {
            reis.VolgendStation();
        }
    }
}

using Opdracht_1.controlers;
using Opdracht_1.interfaces;
using Opdracht_1.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opdracht_1.views
{
    public partial class ReisInfoDisplay : Form, ITreinDisplay
    {
        ITreinReis reis;
        public ReisInfoDisplay(ITreinReis reis)
        {
            InitializeComponent();
            this.reis = reis;
            this.reis.AddObserver(this);
        }

        public void Update(Station station)
        {
            this.labelStation.Text = station.station;
            this.labelSpoor.Text = station.aankomstSpoor;
        }
    }
}

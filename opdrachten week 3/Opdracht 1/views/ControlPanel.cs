using Opdracht_1.controlers;
using Opdracht_1.interfaces;
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
    public partial class ControlPanel : Form
    {
        ITreinController controller;
        public ControlPanel()
        {
            InitializeComponent();
            controller = new TreinController();
        }
        private void btnVolgendStation_Click(object sender, EventArgs e)
        {
            controller.VolgendStation();
        }

        private void Nieuw_Display_Click(object sender, EventArgs e)
        {
            controller.NewDisplay();
        }
    }
}

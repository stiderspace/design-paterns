﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace ConwayGameOfLife
{
    public partial class Form1 : Form
    {
        private ConwayGameOfLife game;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // create a game
            game = new ConwayGameOfLife();

            // start the timer
            timer1.Enabled = true;
            label1.Text = game.lifeBehaviour.GetType().ToString();

            this.DoubleBuffered = true;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            game.Draw(e.Graphics);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            game.Evolve();
            this.Refresh();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.game.Reset();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if( game.lifeBehaviour is HighLife)
            {
                game.lifeBehaviour = new StandardLife();
            }
            else
            {
                game.lifeBehaviour = new HighLife();
            }
            label1.Text = game.lifeBehaviour.GetType().ToString();
        }
    }
}
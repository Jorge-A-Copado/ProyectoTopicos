﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PathFinder
{
    public partial class Form3123 : Form
    {
        public Form3123()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 formBiblio = new Form2();
            formBiblio.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int game1 = 0;
            game1 = 4;
            this.Hide();
            Form2 regreso = new Form2();
            regreso.impresion(game1);
            regreso.Show();

            barra_carga load = new barra_carga();
            load.juego(game1);
            load.Show();
        }
    }
}

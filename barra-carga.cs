using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace PathFinder
{
    public partial class barra_carga : Form
    {
        public int cont = 0;
        public int cont1 = 0;
        Form2 ret = new Form2();
        public barra_carga()
        {
            InitializeComponent();
            timer1.Interval = 1;
            timer1.Enabled = true;
            timer1.Start();
            iniciarprogressbar();

            ThreadStart nuevohilo = new ThreadStart(hilo1);
            Thread h1 = new Thread(nuevohilo);
            h1.Start();

            
            cont = 1;
            //this.Close();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
        private void iniciarprogressbar()
        {
            progressBar1.Step = 1;

            progressBar1.Value = 0;

            progressBar1.Maximum = 100;

            progressBar1.Minimum = 0;
        }
        private void hilo1()
        {
            for (int i=0;cont1<1000000000;i++)
            {
                cont1++;
            }
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            double tiempo = 0.00;

            if(cont1>1)
            {
                cont++;
                tiempo = ((double)cont1 / 1000000000) * 100;
                progressBar1.Value = (int)tiempo;
            }
           if(progressBar1.Value==progressBar1.Maximum)
            {
               
                    
                timer1.Stop();
                timer1.Dispose();
                MessageBox.Show("DESCARGA COMPLETA", "SE HA COMPLETADO LA DESCARGA", MessageBoxButtons.OK);
                this.Close();
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer1.Dispose();
            this.Close();
            
            
        }
        public void juego(int sel)
        {
            switch (sel)
            {
                case 1:
                    label2.Text = "NEW WORLD";
                    break;
                case 2:
                    label2.Text = "BACK 4 BLOOD";
                    break;
                case 3:
                    label2.Text = "COUNTER STRIKE:GLOBAL OFFENSIVE";
                    break;
                case 4:
                    label2.Text= "BATTLEFIELD V(5)";
                    break;
                default:
                    break;
            }
        }
    }
}

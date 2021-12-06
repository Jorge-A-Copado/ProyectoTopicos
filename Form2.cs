using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }
        

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 NewWorld = new Form3();
            NewWorld.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form31 B4B = new Form31();
            B4B.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form312 csgo = new Form312();
            csgo.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3123 btfv = new Form3123();
            btfv.Show();

        }
        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void tabPageBiblio_Click(object sender, EventArgs e)
        {

        }

        public void impresion(int select)
        {
            switch(select)
            {
                case 1:
                    pictureBox12.Visible=true;
                    panel5.Visible = true;
                    break;
                case 2:
                    pictureBox12.Visible = true;
                    panel5.Visible = true;
                    pictureBox14.Visible = true;
                    panel6.Visible = true;
                    break;
                case 3:
                    pictureBox12.Visible = true;
                    panel5.Visible = true;
                    pictureBox14.Visible = true;
                    panel6.Visible = true;
                    pictureBox16.Visible = true;
                    panel7.Visible = true;
                    break;
                case 4:
                    pictureBox12.Visible = true;
                    panel5.Visible = true;
                    pictureBox14.Visible = true;
                    panel6.Visible = true;
                    pictureBox16.Visible = true;
                    panel7.Visible = true;
                    pictureBox18.Visible = true;
                    panel8.Visible = true;
                    break;
                default:
                    break;
            }
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("NEW WORLD ESTÁ EJECUTANDOSE", "NEW WORLD",MessageBoxButtons.OK);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("BACK 4 BLOOD ESTÁ EJECUTANDOSE", "BACK 4 BLOOD", MessageBoxButtons.OK);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("CS:GO ESTÁ EJECUTANDOSE", "COUNTER STRIKE:GLOBAL OFFENSIVE",  MessageBoxButtons.OK);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("BATTLEFIELD V ESTÁ EJECUTANDOSE", "BATTLEFIELD V",  MessageBoxButtons.OK);
        }
    }
}

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
    public partial class Formlogin : Form
    {
        public Formlogin()
        {
            InitializeComponent();
        }
       
        public void Form1_Load(object sender, EventArgs e)
        {

           

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtuser.Text == " " && txtpassw.Text == " "|| txtuser.Text == "admin" && txtpassw.Text == "password")
            {

              Form2 bliblioteca = new Form2();
              this.Hide();
               bliblioteca.Show();
            }
            else
            {
                MessageBox.Show("El usuario o contraseña es incorrecto", "Error");
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

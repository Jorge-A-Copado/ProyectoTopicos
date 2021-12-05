using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Manipulacion_de_datos_LINQ
{
    public partial class Form1 : Form
    {
        
       
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection conexion = new SqlConnection(@"Data Source = (localdb)\topicos ; Initial Catalog = Juegos; Integrated Security = True");

        void limpiar()
        {
            textBox1.Text = ""; //id
            textBox2.Text = ""; //nombre
            textBox3.Text = ""; //contrasena
            textBox4.Text = ""; //pais
        }

        public void llenar_grid()
        {
            SqlDataAdapter adap = new SqlDataAdapter("Select *from datos",conexion); //adaptador para instruccion dentro de sql
            DataTable mesa = new DataTable();//toma de datos de sql
            adap.Fill(mesa);//se llena el datatable
            dataGridView1.DataSource = mesa; //se presenta en gridview
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'juegosDataSet.datos' table. You can move, or remove it, as needed.
            this.datosTableAdapter.Fill(this.juegosDataSet.datos);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conexion.Open();

            SqlCommand inises = new SqlCommand("insert into datos(id, contra, pais, nombre)" + 
                "values(@id, @contra, @pais, @nombre)", conexion);

            inises.Parameters.AddWithValue("id", textBox1.Text);
            inises.Parameters.AddWithValue("contra", textBox3.Text);
            inises.Parameters.AddWithValue("pais", textBox4.Text);
            inises.Parameters.AddWithValue("nombre", textBox2.Text);

            inises.ExecuteNonQuery();

            llenar_grid();

            limpiar();

            MessageBox.Show("Registro Completado");

            conexion.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand consulta = new SqlCommand("Select *from datos WHERE id=@id", conexion);
            conexion.Open();

            consulta.Parameters.AddWithValue("id", textBox1.Text);

            SqlDataReader leer = consulta.ExecuteReader();

            while(leer.Read())
            {
                textBox1.Text = leer[0].ToString();
                textBox3.Text = leer[1].ToString();
                textBox4.Text = leer[2].ToString();
                textBox2.Text = leer[3].ToString();
            }

            MessageBox.Show("Consulta Completada");

            conexion.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            conexion.Open();

            SqlCommand actualiza = new SqlCommand("update datos set id=@id,contra=@contra,pais=@pais,nombre=@nombre " +
                "where id=@id",conexion);

            actualiza.Parameters.AddWithValue("@id",textBox1.Text);
            actualiza.Parameters.AddWithValue("@contra", textBox3.Text);
            actualiza.Parameters.AddWithValue("@pais", textBox4.Text);
            actualiza.Parameters.AddWithValue("@nombre", textBox2.Text);

            actualiza.ExecuteNonQuery();

            llenar_grid();

            limpiar();

            MessageBox.Show("MODIFICACION COMPLETADA");

            conexion.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            conexion.Open();

            string salir = "delete from datos where id=@id";
            SqlCommand cmdDel = new SqlCommand(salir, conexion);

            cmdDel.Parameters.AddWithValue("@id", textBox1.Text);

            cmdDel.ExecuteNonQuery();

            cmdDel.Dispose();
            cmdDel = null;

            llenar_grid();
            limpiar();
            MessageBox.Show("USUARIO ELIMINADO");

            conexion.Close();
            this.datosTableAdapter.Fill(this.juegosDataSet.datos);
        }
    }
}

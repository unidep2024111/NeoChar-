using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taxis
{
    // Definición de la clase Usuario, que hereda de Form
    public partial class Usuario : Form
    {
        //connstructor de la clase Usuario que recibe un parámetro de tipo string
        public Usuario(string nombre)
        {
            InitializeComponent();// Inicializa los componentes del formulario
           // Asigna un mensaje de bienvenida 
            lblmensaje.Text = "Bienvenido " + nombre;
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            // Crea una nueva instancia del formulario vehiculoTaxi
            vehiculoTaxi registro = new vehiculoTaxi();
            registro.Show();// Muestra el formulario vehiculoTaxi
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbltipoUsuario_Click(object sender, EventArgs e)
        {

        }

        private void Usuario_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }
    }
}

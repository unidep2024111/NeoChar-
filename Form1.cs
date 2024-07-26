using System.Data;
using System.Data.SqlClient;
using System.Linq.Expressions;

namespace taxis
{
    public partial class Form1 : Form
    {
        public Form1()// Constructor de la clase Form1
        {
            InitializeComponent();// Inicializa los componentes 
        }
        //conexión a la base de datos
       SqlConnection con =
       new SqlConnection("Data Source=LAPTOP-HAM48O16\\PRACTICAS;Initial Catalog=registro1;User ID=sa;Password=12345;TrustServerCertificate=true");

        // Método para logear con su nombre de usuario y contraseña
        public void logear(string usuario, string contraseña)
        {
            try
            {
                con.Open();// Abre la conexión a la base de datos
                // Comando SQL para seleccionar el nombre y tipo de usuario donde coincidan el usuario y contraseña
                SqlCommand cmd = new SqlCommand("SELECT nombre,tipo_usuario FROM Usuarios WHERE usuario = @Usuario AND password = @pas", con);
                // Parámetros para evitar inyecciones SQL
                cmd.Parameters.AddWithValue("Usuario", usuario);
                cmd.Parameters.AddWithValue("pas", contraseña);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);// Adaptador para ejecutar el comando y llenar un DataTable
                DataTable dt = new DataTable();// DataTable para almacenar los resultados de la consulta
                sda.Fill(dt);// Llena el DataTable 

                // Verifica si hay exactamente una fila en el DataTable
                if (dt.Rows.Count == 1) {
                   
                    this.Hide();
                    // Asume que la primera fila y primera columna contienen el nombre del usuario
                    string nombre = dt.Rows[0][0].ToString();

                    // Muestra la ventana de Usuario
                    new Usuario(nombre).Show();
                }
                else
                {
                    // Muestra un mensaje de error 
                    MessageBox.Show("usuario y/o password incorrecto");
                }
            }
            catch (Exception e)
            {
                // Muestra un mensaje de error si ocurre alguna excepción
                MessageBox.Show(e.Message);
            }
            finally
            {
                // Cierra la conexión a la base de datos
                con.Close();
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Llama al método logear con los valores
            // de los textboxes textBox1 y textBox2
            logear(this.textBox1.Text, this.textBox2.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

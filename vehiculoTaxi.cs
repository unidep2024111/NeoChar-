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
using System.Drawing.Text;

namespace taxis
{
    // Definición de la clase vehiculoTaxi que hereda de Form
    public partial class vehiculoTaxi : Form
    {
        // Constructor de la clase vehiculoTaxi
        public vehiculoTaxi()
        {
            InitializeComponent();// Inicializa los componentes del formulario
        }
        //cuando se hace clic en button1
        private void button1_Click(object sender, EventArgs e)
        {
          // Cadena de conexión a la base de datos
          SqlConnection cone =
          new SqlConnection("Data Source=LAPTOP-HAM48O16\\PRACTICAS;Initial Catalog=registro1;User ID=sa;Password=12345;TrustServerCertificate=true");
            try
            {

                cone.Open();// Abre la conexión a la base de datos

                // Consulta para insertar un nuevo registro en la tabla TableRE
                string query = "INSERT INTO TableRE (Gremio, Matricula, Nombre, NumeroDeLicencia) VALUES (@Gremio, @Matricula, @Nombre, @NumeroDeLicencia)";
                SqlCommand cmd = new SqlCommand(query, cone);

                // Agrega los parámetros al comando SQL 
                cmd.Parameters.AddWithValue("@Gremio", this.textGremio.Text);
                cmd.Parameters.AddWithValue("@Matricula", this.textMatricula.Text);
                cmd.Parameters.AddWithValue("@Nombre", this.textNombre.Text);
                cmd.Parameters.AddWithValue("@NumeroDeLicencia", this.textLicencia.Text);

                cmd.ExecuteNonQuery();// Ejecuta la consulta
                MessageBox.Show("Registro guardado correctamente");// Muestra un mensaje de éxito
                cone.Close();// Cierra la conexión
                llenarT();// Llama al método llenarT para actualizar el DataGridView
                LimpiarCampos();// Llama al método LimpiarCampos para limpiar los campos del formulario
               
            }
            catch (Exception ex)
            {
               // Muestra un mensaje de error si ocurre alguna excepción
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                cone.Close();// Cierra la conexión a la base de datos
            }
        }

        // Método para llenar el DataGridView con los datos de la tabla TableRE
        public void llenarT()
        {
            // Crea una nueva conexión a la base de datos
            SqlConnection cone = 
            new SqlConnection("Data Source=LAPTOP-HAM48O16\\PRACTICAS;Initial Catalog=registro1;User ID=sa;Password=12345;TrustServerCertificate=true");
            string consulta = "select * from TableRE";// Consulta SQL para seleccionar todos los registros de la tabla TableRE
            // Crea un adaptador SQL para ejecutar la consulta y llenar un DataTable
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, cone);
            DataTable dt = new DataTable(); // Crea un DataTable para almacenar los resultados de la consulta
            adaptador.Fill(dt);// Llena el DataTable con los resultados
            dataGridView1.DataSource = dt; // Asigna el DataTable como origen de datos del DataGridView


        }
        private void vehiculoTaxi_Load(object sender, EventArgs e)
        {
            // Crea una nueva conexión a la base de datos
            SqlConnection cone = 
            new SqlConnection("Data Source=LAPTOP-HAM48O16\\PRACTICAS;Initial Catalog=registro1;User ID=sa;Password=12345;TrustServerCertificate=true");
            string consulta = "select * from TableRE"; // Consulta SQL para seleccionar todos los registros
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, cone); // Adaptador para ejecutar la consulta y llenar un DataTable
            DataTable dt = new DataTable(); // DataTable para almacenar los resultados
            adaptador.Fill(dt); // Llena el DataTable con los resultados
            dataGridView1.DataSource = dt; // Asigna el DataTable como origen de datos del DataGridView

        }


        private void button2_Click(object sender, EventArgs e)
        {
            // Crea una nueva conexión a la base de datos
            SqlConnection cone =
            new SqlConnection("Data Source=LAPTOP-HAM48O16\\PRACTICAS;Initial Catalog=registro1;User ID=sa;Password=12345;TrustServerCertificate=true");
            if (dataGridView1.CurrentRow != null)
            {
                int rowIndex = dataGridView1.CurrentCell.RowIndex; // Obtiene el índice de la fila seleccionada
                int id = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells["Id"].Value); // Obtiene el valor del campo Id de la fila seleccionada
                try
                {
                    cone.Open(); // Abre la conexión a la base de datos

                    // Consulta para eliminar el registro con el Id especificado
                    string query = "DELETE FROM TableRE WHERE Id = @Id";// Consulta SQL para eliminar el registro con el Id especificado
                    // Crea un nuevo comando SQL usando la consulta y la conexión
                    using (SqlCommand cmd = new SqlCommand(query, cone))
                    {
                        cmd.Parameters.AddWithValue("@Id", id); // Agrega el parámetro Id al comando SQL
                        cmd.ExecuteNonQuery(); // Ejecuta la consulta
                    }

                    MessageBox.Show("Registro borrado correctamente"); // Muestra un mensaje de éxito
                    llenarT(); // Llama al método llenarT para actualizar el DataGridView
                }
                catch (Exception ex)
                {
                    // Muestra un mensaje de error si ocurre alguna excepción
                    MessageBox.Show("Error al borrar el registro: " + ex.Message);
                }
            }
            else
            {
                // Muestra un mensaje si no hay ninguna fila seleccionada
                MessageBox.Show("Por favor, selecciona una fila para eliminar.");
            }
        }
        // Método para limpiar los campos del formulario
        private void LimpiarCampos()
        {
            textGremio.Clear();
            textMatricula.Clear();
            textNombre.Clear();
            textLicencia.Clear();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}


        
   


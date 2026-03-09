using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DailyRoutine
{
    public partial class FormTarea : Form
    {
        public FormTarea()
        {
            InitializeComponent();
            CargarComboRutinas();


            // textBox1
            textBox1.Text = placeholder1;
            textBox1.ForeColor = Color.Gray;

            // textBox2
            textBox2.Text = placeholder2;
            textBox2.ForeColor = Color.Gray;



        }

        private void FormTarea_Load(object sender, EventArgs e)
        {

        }

        // cargar rutinas
        private void CargarComboRutinas()
        {
            string connectionString = "Server=localhost;Database=DailyRoutine;Uid=root;Pwd=Adonay14.;";
            // Filtramos por el ID de la sesión global que ya verificamos antes
            string query = "SELECT Id_rutina, Nombre FROM rutina WHERE Id_Usuario = @idUser";

            using (MySqlConnection conexion = new MySqlConnection(connectionString))
            {
                try
                {
                    conexion.Open();
                    MySqlCommand comando = new MySqlCommand(query, conexion);
                    comando.Parameters.AddWithValue("@idUser", UsuarioSesion.IdUsuario);

                    MySqlDataAdapter da = new MySqlDataAdapter(comando);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // 1. Qué valor se guarda internamente (el ID)
                    cmbRutinas.ValueMember = "Id_rutina";

                    // 2. Qué texto ve el usuario (el Nombre de la rutina)
                    cmbRutinas.DisplayMember = "Nombre";

                    // 3. Asignamos la fuente de datos
                    cmbRutinas.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar las rutinas: " + ex.Message);
                }

            }
        }

        // guardar datos

        private void btnGuardarActividad_Click(object sender, EventArgs e)
        {
            // 1. Validaciones básicas para evitar datos vacíos
            if (string.IsNullOrWhiteSpace(textBox1.Text) || cmbRutinas.SelectedValue == null)
            {
                MessageBox.Show("Por favor, ingresa el nombre de la actividad y selecciona una rutina.");
                return;
            }

            // 2. Tu cadena de conexión
            string connectionString = "Server=localhost;Database=DailyRoutine;Uid=root;Pwd=Adonay14.;";

            // 3. Consulta SQL con parámetros
            // Asegúrate de que los nombres de las columnas coincidan exactamente con tu tabla 'actividad'
            string query = "INSERT INTO actividad (Nombre, Descripcion, Hora_Inicio, Id_Rutina) " +
                           "VALUES (@nombre, @desc, @hora, @idRutina)";

            using (MySqlConnection conexion = new MySqlConnection(connectionString))
            {
                try
                {
                    conexion.Open();
                    MySqlCommand comando = new MySqlCommand(query, conexion);

                    // 4. Asignamos los valores de los controles a los parámetros
                    // Nombre de la actividad
                    comando.Parameters.AddWithValue("@nombre", textBox1.Text.Trim());

                    // Descripción de la actividad
                    comando.Parameters.AddWithValue("@desc", textBox2.Text.Trim());

                    // Hora_Inicio desde el DateTimePicker (formato HH:mm:ss para MySQL)
                    comando.Parameters.AddWithValue("@hora", dateTimePicker1.Value.ToString("HH:mm:ss"));

                    // Id_Rutina obtenido del ComboBox (ValueMember)
                    comando.Parameters.AddWithValue("@idRutina", cmbRutinas.SelectedValue);

                    // 5. Ejecutar la operación
                    int filasAffected = comando.ExecuteNonQuery();

                    if (filasAffected > 0)
                    {
                        MessageBox.Show("¡Actividad guardada y asignada a la rutina correctamente!");

                        // Opcional: Limpiar los campos para una nueva entrada
                        LimpiarCampos();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar la actividad: " + ex.Message);
                }
            }
        }

        // Método auxiliar para limpiar controles
        private void LimpiarCampos()
        {
            textBox1.Clear();
            textBox2.Clear();
            dateTimePicker1.Value = DateTime.Now;
            // cmbRutinas.SelectedIndex = -1; // Deselecciona la rutina si lo prefieres
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        // Textbox

        string placeholder1 = "Nombre de la tarea...";
        string placeholder2 = "Descripción...";

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == placeholder1)
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == placeholder2)
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Text = placeholder1;
                textBox1.ForeColor = Color.Gray;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                textBox2.Text = placeholder2;
                textBox2.ForeColor = Color.Gray;                
            }
        }


    }
}

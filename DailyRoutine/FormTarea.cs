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
            // Filtramos por Estado 1 y ordenamos para que sea más fácil de usar
            string query = "SELECT Id_rutina, Nombre, Hora FROM rutina WHERE Id_Usuario = @idUser AND Estado = 1 ORDER BY Hora ASC";

            using (MySqlConnection conexion = new MySqlConnection(connectionString))
            {
                try
                {
                    conexion.Open();
                    MySqlCommand comando = new MySqlCommand(query, conexion);
                    comando.Parameters.AddWithValue("@idUser", UsuarioSesion.IdUsuario);

                    List<RutinaItem> listaRutinas = new List<RutinaItem>();

                    using (MySqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            listaRutinas.Add(new RutinaItem
                            {
                                Id = reader.GetInt32("Id_rutina"),
                                Nombre = reader.GetString("Nombre"),
                                HoraInicio = reader.GetTimeSpan("Hora") // Guardamos la hora para validar
                            });
                        }
                    }

                    // Configuramos el ComboBox
                    cmbRutinas.DataSource = null; // Limpiamos primero
                    cmbRutinas.DisplayMember = "Nombre";
                    cmbRutinas.ValueMember = "Id";
                    cmbRutinas.DataSource = listaRutinas;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar las rutinas: " + ex.Message);
                }
            }
        }

        public class RutinaItem
        {
            public int Id { get; set; }
            public string Nombre { get; set; }
            public TimeSpan HoraInicio { get; set; }

            // Esto es lo que se verá en el ComboBox si no se usa DisplayMember
            public override string ToString() => Nombre;
        }

        // guardar datos

        private void btnGuardarActividad_Click(object sender, EventArgs e)
        {
            // 1. Validaciones básicas y obtención del objeto seleccionado
            var rutinaSeleccionada = (RutinaItem)cmbRutinas.SelectedItem;

            if (string.IsNullOrWhiteSpace(textBox1.Text) || rutinaSeleccionada == null)
            {
                MessageBox.Show("Por favor, ingresa el nombre de la actividad y selecciona una rutina.");
                return;
            }

            // 2. Validación de lógica de tiempo: La tarea debe ser DESPUÉS del inicio de la rutina
            // Usamos .TimeOfDay para obtener solo la hora del selector
            TimeSpan horaTarea = dateTimePicker1.Value.TimeOfDay;

            if (horaTarea <= rutinaSeleccionada.HoraInicio)
            {
                MessageBox.Show($"La actividad debe iniciar después de la hora de la rutina ({rutinaSeleccionada.HoraInicio:hh\\:mm}).");
                return;
            }

            // 3. Cadena de conexión y consulta
            string connectionString = "Server=localhost;Database=DailyRoutine;Uid=root;Pwd=Adonay14.;";
            string query = "INSERT INTO actividad (Nombre, Descripcion, Hora_Inicio, Id_Rutina) " +
                           "VALUES (@nombre, @desc, @hora, @idRutina)";

            using (MySqlConnection conexion = new MySqlConnection(connectionString))
            {
                try
                {
                    conexion.Open();
                    MySqlCommand comando = new MySqlCommand(query, conexion);

                    // 4. Asignación de parámetros corregida para evitar errores de tipo
                    comando.Parameters.AddWithValue("@nombre", textBox1.Text.Trim());
                    comando.Parameters.AddWithValue("@desc", textBox2.Text.Trim());

                    // Enviamos el TimeSpan directamente, MySqlConnector lo mapea correctamente al tipo TIME
                    comando.Parameters.AddWithValue("@hora", horaTarea);

                    comando.Parameters.AddWithValue("@idRutina", rutinaSeleccionada.Id);

                    int filasAffected = comando.ExecuteNonQuery();

                    if (filasAffected > 0)
                    {
                        MessageBox.Show("¡Actividad guardada correctamente!");
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class FormAgregar : Form
    {
        public FormAgregar()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Shown += FormAgregar_Shown;


            // Eliminar parpadeo

            // Activa el doble búfer para el formulario
            this.DoubleBuffered = true;

            // Configuraciones extra para renderizado suave
            this.SetStyle(ControlStyles.AllPaintingInWmPaint |
                          ControlStyles.UserPaint |
                          ControlStyles.OptimizedDoubleBuffer, true);
            this.UpdateStyles();

            // Nombre
            textBox1.Text = placeholder1;
            textBox1.ForeColor = Color.Gray;

            // Descripcion
            textBox2.Text = placeholder2;
            textBox2.ForeColor = Color.Gray;
            


        }

        private void modernContainer2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormAgregar_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FormAgregar_Shown(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        // TextBox

        string placeholder1 = "Nombre de rutina...";
        string placeholder2 = "Descripción de rutina...";

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
                textBox2.UseSystemPasswordChar = false;
            }
        }

        // ingresar datos

        private void btnGuardarRutina_Click(object sender, EventArgs e)
        {
            // 1. Validar que el nombre de la rutina no esté vacío
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Por favor, ingresa el nombre de la rutina.");
                return;
            }

            // 2. Cadena de conexión (Directorio de BD: DailyRoutine)
            string connectionString = "Server=localhost;Database=DailyRoutine;Uid=root;Pwd=Adonay14.;";

            // 3. Consulta SQL MODIFICADA: Agregamos el campo 'Hora'
            string query = "INSERT INTO rutina (Nombre, Descripcion, Fecha, Hora, Id_Usuario) " +
                           "VALUES (@nombre, @desc, @fecha, @hora, @idUser)";

            using (MySqlConnection conexion = new MySqlConnection(connectionString))
            {
                try
                {
                    conexion.Open();
                    MySqlCommand comando = new MySqlCommand(query, conexion);

                    // 4. Asignar los valores de tus controles a los parámetros
                    comando.Parameters.AddWithValue("@nombre", textBox1.Text.Trim());
                    comando.Parameters.AddWithValue("@desc", textBox2.Text.Trim());

                    // Fecha (yyyy-MM-dd)
                    comando.Parameters.AddWithValue("@fecha", dateTimePicker1.Value.ToString("yyyy-MM-dd"));

                    // MODIFICACIÓN: Capturamos la hora del segundo DateTimePicker (formato HH:mm:ss)
                    comando.Parameters.AddWithValue("@hora", dateTimePicker2.Value.ToString("HH:mm:ss"));

                    // 5. ASIGNAR EL ID DEL USUARIO GLOBAL
                    comando.Parameters.AddWithValue("@idUser", UsuarioSesion.IdUsuario);

                    // 6. Ejecutar la inserción
                    comando.ExecuteNonQuery();

                    MessageBox.Show("Rutina guardada con éxito.");

                    // Limpiar los campos después de guardar
                    textBox1.Clear();
                    textBox2.Clear();
                    dateTimePicker1.Value = DateTime.Now;
                    // Reiniciamos el selector de hora a la hora actual
                    dateTimePicker2.Value = DateTime.Now;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hubo un error al guardar: " + ex.Message);
                }
            }
        }


        // Menú de el sistema //


        // Click en "Inicio"


        private void Panel4_Click(object sender, EventArgs e)
        {
            this.Hide();

            FormInicio frm = new FormInicio();
            frm.ShowDialog();

            this.Close();
        }

        // Click en "Agregar"
        

        private void Panel5_Click(object sender, EventArgs e)
        {
            this.Hide();

            FormAgregar frm = new FormAgregar();
            frm.ShowDialog();

            this.Close();
        }

        // Click en "Estadística"
        

        private void Panel6_Click(object sender, EventArgs e)
        {
            this.Hide();

            FormEstadistica frm = new FormEstadistica();
            frm.ShowDialog();

            this.Close();
        }

    }
}

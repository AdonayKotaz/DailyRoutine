using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

// Versión: 1.0.1 - Migración a Dell Latitude 7420
// Cambio: Ajuste de DPI y limpieza de base de datos.
// Autor: Cota

namespace DailyRoutine
{
    public partial class FormRegistro : Form

    {

        // Cadena de conexión 
        string connectionString =
        "Server=localhost;Database=DailyRoutine;User ID=root;Password=Adonay14.;";

        public FormRegistro()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Shown += FormRegistro_Shown;

            textBox2.TextChanged += (s, e) => ValidarContraseñas();
            textBox3.TextChanged += (s, e) => ValidarContraseñas();

            // CORREO
            textBox1.Text = placeholderCorreo;
            textBox1.ForeColor = Color.Gray;

            // CONTRASEÑA
            textBox2.Text = placeholderPass;
            textBox2.ForeColor = Color.Gray;
            textBox2.UseSystemPasswordChar = false;

            // REPETIR CONTRASEÑA
            textBox3.Text = placeholderRepetir;
            textBox3.ForeColor = Color.Gray;
            textBox3.UseSystemPasswordChar = false;

            // LABEL ERROR
            label1.Text = "";
            label1.ForeColor = Color.Red;

        }

        private void FormRegistro_Shown(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void FormRegistro_Load(object sender, EventArgs e)
        {

        }

        private void FormRegistro_Load_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void modernContainer4_Paint(object sender, PaintEventArgs e)
        {

        }

        // textbox

        string placeholderCorreo = "Ingrese su correo electronico";
        string placeholderPass = "Ingrese su contraseña";
        string placeholderRepetir = "Repite la contraseña";

        // eventos enter

        private void textBoxCorreo_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == placeholderCorreo)
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBoxPass_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == placeholderPass)
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void textBoxRepetir_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == placeholderRepetir)
            {
                textBox3.Text = "";
                textBox3.ForeColor = Color.Black;
                textBox3.UseSystemPasswordChar = true;
            }
        }

        // eventos leave 

        private void textBoxCorreo_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Text = placeholderCorreo;
                textBox1.ForeColor = Color.Gray;
            }
        }

        private void textBoxPass_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                textBox2.Text = placeholderPass;
                textBox2.ForeColor = Color.Gray;
                textBox2.UseSystemPasswordChar = false;
            }
        }

        private void textBoxRepetir_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                textBox3.Text = placeholderRepetir;
                textBox3.ForeColor = Color.Gray;
                textBox3.UseSystemPasswordChar = false;
            }
        }

        // Validar similitud de contraseñas

        private void ValidarContraseñas()
        {
            if (textBox2.Text != placeholderPass &&
                textBox3.Text != placeholderRepetir)
            {
                if (textBox2.Text != textBox3.Text)
                {
                    label1.Text = "Las contraseñas no coinciden";
                }
                else
                {
                    label1.Text = "";
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();

            FormLogin frm = new FormLogin();
            frm.ShowDialog();

            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            FormTerminos frm = new FormTerminos();
            frm.ShowDialog();

        }

        // ingreso de datos

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // 1. Validar que no estén vacíos
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Por favor, completa todos los campos.");
                return;
            }

            // 2. Cadena de conexión (Ajusta con tus datos de XAMPP/Workbench)
            string connectionString = "Server=localhost;Database=DailyRoutine;Uid=root;Pwd=Adonay14.;";

            // 3. Consulta SQL con parámetros para evitar Inyección SQL
            string query = "INSERT INTO usuario (Gmail, Contrasena) VALUES (@correo, @pass)";

            using (MySqlConnection conexion = new MySqlConnection(connectionString))
            {
                try
                {
                    conexion.Open();
                    MySqlCommand comando = new MySqlCommand(query, conexion);

                    // 4. Asignar los valores de los TextBox a los parámetros
                    comando.Parameters.AddWithValue("@correo", textBox1.Text.Trim());
                    comando.Parameters.AddWithValue("@pass", textBox2.Text.Trim());

                    // 5. Ejecutar la inserción
                    int filasAfectadas = comando.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("¡Usuario registrado exitosamente!");

                        // Limpiar cajas de texto
                        textBox1.Clear();
                        textBox2.Clear();

                        // Opcional: Mandar al usuario al Form de Login
                        FormLogin login = new FormLogin();
                        login.Show();
                        this.Close();
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error de base de datos: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error general: " + ex.Message);
                }
                // El bloque 'using' cierra la conexión automáticamente al terminar
            }
        }

    }
}

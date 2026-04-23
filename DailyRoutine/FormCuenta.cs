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
    public partial class FormCuenta : Form
    {
        public FormCuenta()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Shown += FormLogin_Shown;

        }

        private void FormLogin_Shown(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        // Nombre usuario 

        private void FormCuenta_Load(object sender, EventArgs e)
        {
            label1.Text = UsuarioSesion.Correo;
        }

        private void modernContainer1_Paint(object sender, PaintEventArgs e)
        {

        }

        // cerrar sesión

        private void btnSalir_Click(object sender, EventArgs e)
        {
            // 1. Confirmación opcional
            DialogResult confirmacion = MessageBox.Show("¿Deseas cerrar sesión?", "Daily Routine",
                                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion == DialogResult.Yes)
            {
                // Limpiamos los datos globales por seguridad
                UsuarioSesion.IdUsuario = 0;
                AdminSesion.IdAdmin = 0;

                // Reinicia la aplicación completa de forma limpia
                Application.Restart();
            }
        }

        // enviar reporte

        private void btnEnviarReporte_Click(object sender, EventArgs e)
        {
            string asunto = richTextBox1.Text.Trim();

            if (string.IsNullOrEmpty(asunto))
            {
                MessageBox.Show("Por favor, escribe el asunto de tu reporte.");
                return;
            }

            string connectionString = "Server=localhost;Database=DailyRoutine;Uid=root;Pwd=Adonay14.;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    // Estado 0 = Pendiente / Activo
                    string query = "INSERT INTO reporte (Id_Usuario, Asunto, Fecha_Creacion) " +
                                   "VALUES (@id, @asunto, @fecha)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", UsuarioSesion.IdUsuario);
                    cmd.Parameters.AddWithValue("@asunto", asunto);
                    cmd.Parameters.AddWithValue("@fecha", DateTime.Now); // Captura la hora justa

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Reporte enviado con éxito. El administrador lo revisará pronto.");
                    richTextBox1.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al enviar reporte: " + ex.Message);
                }
            }
        }

    }
}

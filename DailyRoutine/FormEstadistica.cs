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


namespace DailyRoutine
{

    public partial class FormEstadistica : Form
    {

        // Cadena de conexión 
        string connectionString =
        "Server=localhost;Database=DailyRoutine;User ID=root;Password=Adonay14.;";

        public FormEstadistica()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    MessageBox.Show("Conexión exitosa 😎");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormEstadistica_Load(object sender, EventArgs e)
        {

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

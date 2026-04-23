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
    public partial class FormBaseDeDatos : Form
    {
        public FormBaseDeDatos()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void FormBaseDeDatos_Load(object sender, EventArgs e)
        {
            // Llenamos el combo de tablas manualmente
            comboBox1.Items.AddRange(new string[] { "usuario", "rutina", "actividad" });
            comboBox1.SelectedIndex = 0;

            CargarFiltroUsuarios();
        }

        private void CargarFiltroUsuarios()
        {
            string connectionString = "Server=localhost;Database=DailyRoutine;Uid=root;Pwd=Adonay14.;";
            comboBox2.Items.Clear();
            comboBox2.Items.Add("Todos"); // Opción para no filtrar

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                // En tu tabla no hay nombre, así que usamos Gmail
                string query = "SELECT Gmail FROM usuario";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                using (MySqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        comboBox2.Items.Add(dr["Gmail"].ToString());
                    }
                }
            }
            comboBox2.SelectedIndex = 0;
        }

        private void Consultar()
        {
            string tabla = comboBox1.SelectedItem.ToString();
            string filtroEmail = comboBox2.SelectedItem?.ToString();
            string connectionString = "Server=localhost;Database=DailyRoutine;Uid=root;Pwd=Adonay14.;";

            // Query base
            string query = $"SELECT * FROM {tabla}";

            // Aplicar filtro de usuario si no es "Todos"
            if (!string.IsNullOrEmpty(filtroEmail) && filtroEmail != "Todos")
            {
                if (tabla == "usuario")
                    query += $" WHERE Gmail = '{filtroEmail}'";
                else
                    // Filtramos rutinas o actividades buscando el ID que corresponde a ese Gmail
                    query += $" WHERE Id_Usuario = (SELECT Id_Usuario FROM usuario WHERE Gmail = '{filtroEmail}')";
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt; // El panel gris de tu imagen
            }
        }

        // Llama a Consultar() en los eventos SelectedIndexChanged de ambos ComboBox
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) => Consultar();
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e) => Consultar();


        // Eliminar datos
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            // Obtenemos el ID de la primera celda
            string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string tabla = comboBox1.SelectedItem.ToString();

            // Identificamos el nombre de la columna ID según la tabla
            string colId = (tabla == "usuario") ? "Id_usuario" : (tabla == "rutina") ? "Id_rutina" : "Id_actividad";

            if (MessageBox.Show($"¿Eliminar el registro {id} de {tabla}?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string connectionString = "Server=localhost;Database=DailyRoutine;Uid=root;Pwd=Adonay14.;";
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = $"DELETE FROM {tabla} WHERE {colId} = @id";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
                Consultar(); // Refrescamos la tabla
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog() { Filter = "CSV|*.csv", FileName = "Reporte.csv" };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                var lineas = new List<string>();
                // Encabezados
                lineas.Add(string.Join(",", dataGridView1.Columns.Cast<DataGridViewColumn>().Select(c => c.HeaderText)));
                // Filas
                foreach (DataGridViewRow r in dataGridView1.Rows)
                {
                    if (!r.IsNewRow)
                        lineas.Add(string.Join(",", r.Cells.Cast<DataGridViewCell>().Select(c => c.Value?.ToString().Replace(",", "."))));
                }
                File.WriteAllLines(sfd.FileName, lineas, Encoding.UTF8);
                MessageBox.Show("¡Exportado!");
            }
        }

        // regresar
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            // Al usar Close(), el formulario se cierra y el hilo de ejecución 
            // vuelve al FormAdmin que lo llamó.
            this.Close();
        }


    }
}

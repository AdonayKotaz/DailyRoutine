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
using System.Windows.Forms.DataVisualization.Charting;


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
            this.Shown += FormLogin_Shown;

        }

        private void FormLogin_Shown(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormEstadistica_Load(object sender, EventArgs e)
        {
            CargarComboRutinas();
            ActualizarContadorRutinasHoy();
            ActualizarContadorActividadesHoy();
            ActualizarBarrasProgreso();
            DibujarGraficaManual();
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

        private void progressBar2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        // eliminar rutina

        private void CargarComboRutinas()
        {
            string connectionString = "Server=localhost;Database=DailyRoutine;Uid=root;Pwd=Adonay14.;";
            string query = "SELECT Id_rutina, Nombre FROM rutina WHERE Id_Usuario = @idUser AND Estado = 1";

            using (MySqlConnection conexion = new MySqlConnection(connectionString))
            {
                try
                {
                    conexion.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@idUser", UsuarioSesion.IdUsuario);

                    DataTable dt = new DataTable();
                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }

                    cmbEliminarRutina.DisplayMember = "Nombre";
                    cmbEliminarRutina.ValueMember = "Id_rutina";
                    cmbEliminarRutina.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar rutinas: " + ex.Message);
                }
            }
        }

        private void btnEliminarRutina_Click(object sender, EventArgs e)
        {
            if (cmbEliminarRutina.SelectedValue == null)
            {
                MessageBox.Show("Por favor, selecciona una rutina para eliminar.");
                return;
            }

            int idRutina = (int)cmbEliminarRutina.SelectedValue;
            string nombreRutina = cmbEliminarRutina.Text;

            var confirmacion = MessageBox.Show($"¿Estás seguro de eliminar '{nombreRutina}'? Se borrarán también todas sus actividades.",
                                               "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmacion == DialogResult.Yes)
            {
                string connectionString = "Server=localhost;Database=DailyRoutine;Uid=root;Pwd=Adonay14.;";

                using (MySqlConnection conexion = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conexion.Open();
                        // Usamos una transacción para asegurar que se borre todo o nada
                        MySqlTransaction transaccion = conexion.BeginTransaction();

                        try
                        {
                            // 1. Eliminar actividades de la rutina
                            string deleteActividades = "DELETE FROM actividad WHERE Id_rutina = @id";
                            MySqlCommand cmdAct = new MySqlCommand(deleteActividades, conexion, transaccion);
                            cmdAct.Parameters.AddWithValue("@id", idRutina);
                            cmdAct.ExecuteNonQuery();

                            // 2. Eliminar la rutina
                            string deleteRutina = "DELETE FROM rutina WHERE Id_rutina = @id";
                            MySqlCommand cmdRut = new MySqlCommand(deleteRutina, conexion, transaccion);
                            cmdRut.Parameters.AddWithValue("@id", idRutina);
                            cmdRut.ExecuteNonQuery();

                            transaccion.Commit();
                            MessageBox.Show("Rutina y actividades eliminadas correctamente.");

                            // Refrescar el combo y estadísticas
                            CargarComboRutinas();
                        }
                        catch (Exception)
                        {
                            transaccion.Rollback();
                            throw;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar: " + ex.Message);
                    }
                }
            }
        }

        // cargar total de rutinas

        private void ActualizarContadorRutinasHoy()
        {
            string connectionString = "Server=localhost;Database=DailyRoutine;Uid=root;Pwd=Adonay14.;";
            // Filtramos por el usuario actual y la fecha de hoy
            string query = "SELECT COUNT(*) FROM rutina WHERE Id_Usuario = @idUser AND Fecha = CURDATE()";

            using (MySqlConnection conexion = new MySqlConnection(connectionString))
            {
                try
                {
                    conexion.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@idUser", UsuarioSesion.IdUsuario);

                    // ExecuteScalar es ideal para obtener un único valor (como un conteo)
                    int totalHoy = Convert.ToInt32(cmd.ExecuteScalar());

                    // Mostramos el resultado en el label
                    labelConta.Text = totalHoy.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al contar rutinas: " + ex.Message);
                    labelConta.Text = "0";
                }
            }
        }

        // cargar racha de actividad

        private void ActualizarContadorActividadesHoy()
        {
            string connectionString = "Server=localhost;Database=DailyRoutine;Uid=root;Pwd=Adonay14.;";

            // Usamos un JOIN para filtrar las actividades por la fecha de la rutina
            string query = @"SELECT COUNT(a.Id_actividad) 
                     FROM actividad a
                     INNER JOIN rutina r ON a.Id_rutina = r.Id_rutina
                     WHERE r.Id_Usuario = @idUser 
                     AND r.Fecha = CURDATE()";

            using (MySqlConnection conexion = new MySqlConnection(connectionString))
            {
                try
                {
                    conexion.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@idUser", UsuarioSesion.IdUsuario);

                    int totalActividades = Convert.ToInt32(cmd.ExecuteScalar());

                    // Mostramos el total en el segundo label
                    labelConta2.Text = totalActividades.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al contar actividades: " + ex.Message);
                    labelConta2.Text = "0";
                }
            }
        }

        // Grafica de actividad

        private void DibujarGraficaManual()
        {
            string connectionString = "Server=localhost;Database=DailyRoutine;Uid=root;Pwd=Adonay14.;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"SELECT DATE_FORMAT(r.Fecha, '%d/%m') as Dia, COUNT(a.Id_actividad) as Total
                             FROM actividad a INNER JOIN rutina r ON a.Id_rutina = r.Id_rutina
                             WHERE r.Id_Usuario = @id AND a.Estado = 0 
                             AND r.Fecha >= DATE_SUB(CURDATE(), INTERVAL 6 DAY)
                             GROUP BY r.Fecha ORDER BY r.Fecha ASC";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", UsuarioSesion.IdUsuario);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    panelGrafica.Controls.Clear(); // Limpiamos el panel antes de dibujar

                    int xPos = 20; // Posición inicial horizontal
                    int anchoBarra = 40;
                    int espacio = 20;
                    int alturaMaximaPanel = panelGrafica.Height - 40;

                    foreach (DataRow row in dt.Rows)
                    {
                        int total = Convert.ToInt32(row["Total"]);
                        string dia = row["Dia"].ToString();

                        // Calculamos la altura de la barra (ej: 20 píxeles por actividad)
                        int alturaBarra = Math.Min(total * 20, alturaMaximaPanel);

                        // Creamos la barra como un Panel pequeño
                        Panel barra = new Panel();
                        barra.BackColor = Color.DodgerBlue;
                        barra.Width = anchoBarra;
                        barra.Height = alturaBarra;
                        barra.Location = new Point(xPos, alturaMaximaPanel - alturaBarra + 10);

                        // Etiqueta del día abajo
                        Label lblDia = new Label();
                        lblDia.Text = dia;
                        lblDia.AutoSize = true;
                        lblDia.Location = new Point(xPos, alturaMaximaPanel + 15);
                        lblDia.Font = new Font("Segoe UI", 8);

                        panelGrafica.Controls.Add(barra);
                        panelGrafica.Controls.Add(lblDia);

                        xPos += anchoBarra + espacio; // Movemos la posición para la siguiente barra
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }








        // Barras de progreso

        private int ObtenerProgresoTurno(string horaInicio, string horaFin)
        {
            string connectionString = "Server=localhost;Database=DailyRoutine;Uid=root;Pwd=Adonay14.;";
            int idUser = UsuarioSesion.IdUsuario;

            // Contamos totales vs completadas (Estado 0) en el rango de tiempo
            string query = $@"
        SELECT 
            COUNT(*) as Total,
            SUM(CASE WHEN a.Estado = 0 THEN 1 ELSE 0 END) as Completadas
        FROM actividad a
        INNER JOIN rutina r ON a.Id_rutina = r.Id_rutina
        WHERE r.Id_Usuario = @id 
        AND r.Fecha = CURDATE()
        AND r.Hora BETWEEN '{horaInicio}' AND '{horaFin}'";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", idUser);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read() && reader["Total"] != DBNull.Value && Convert.ToInt32(reader["Total"]) > 0)
                        {
                            int total = Convert.ToInt32(reader["Total"]);
                            int completadas = Convert.ToInt32(reader["Completadas"]);
                            return (completadas * 100) / total;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error en progreso: " + ex.Message);
                }
            }
            return 0;
        }

        private void ActualizarBarrasProgreso()
        {
            // Mañana: 00:00 a 11:59
            pbManana.Value = ObtenerProgresoTurno("00:00:00", "11:59:59");
            label12.Text = pbManana.Value + "%";

            // Tarde: 12:00 a 18:59
            pbTarde.Value = ObtenerProgresoTurno("12:00:00", "18:59:59");
            label13.Text = pbTarde.Value + "%";

            // Noche: 19:00 a 23:59
            pbNoche.Value = ObtenerProgresoTurno("19:00:00", "23:59:59");
            label14.Text = pbNoche.Value + "%";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

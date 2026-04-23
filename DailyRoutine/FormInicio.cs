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
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void FormInicio_Load(object sender, EventArgs e)
        {
            CargarRutinaYActividades();
            CargarProximasRutinas();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        // ir a cuenta

        private void Cuenta_Click(object sender, EventArgs e)
        {

            FormCuenta frm = new FormCuenta();
            frm.ShowDialog();

        }


        // Menú de el sistema //


        // Click en "Inicio"
        private void lblInicio_Click(object sender, EventArgs e)
        {
            this.Hide();

            FormInicio frm = new FormInicio();
            frm.ShowDialog();

            this.Close();
        }


        private void Panel4_Click(object sender, EventArgs e)
        {
            this.Hide();

            FormInicio frm = new FormInicio();
            frm.ShowDialog();

            this.Close();
        }

        // Click en "Agregar"
        private void lblAgregar_Click(object sender, EventArgs e)
        {
            this.Hide();

            FormAgregar frm = new FormAgregar();
            frm.ShowDialog();

            this.Close();
        }

        private void Panel5_Click(object sender, EventArgs e)
        {
            this.Hide();

            FormAgregar frm = new FormAgregar();
            frm.ShowDialog();

            this.Close();
        }

        // Click en "Estadística"
        private void lblEstadistica_Click(object sender, EventArgs e)
        {
            this.Hide();

            FormEstadistica frm = new FormEstadistica();
            frm.ShowDialog();

            this.Close();
        }

        private void Panel6_Click(object sender, EventArgs e)
        {
            this.Hide();

            FormEstadistica frm = new FormEstadistica();
            frm.ShowDialog();

            this.Close();
        }

        private void AgTarea_Click(object sender, EventArgs e)
        {


            FormTarea frm = new FormTarea();
            frm.ShowDialog();


        }

        // cargar datos

        private void CargarRutinaYActividades()
        {
            string connectionString = "Server=localhost;Database=DailyRoutine;Uid=root;Pwd=Adonay14.;";
            int idUsuarioActual = UsuarioSesion.IdUsuario;

            using (MySqlConnection conexion = new MySqlConnection(connectionString))
            {
                try
                {
                    conexion.Open();

                    // 1. Finalizar rutinas antiguas automáticamente
                    string queryFinalizar = @"UPDATE rutina SET Estado = 0 WHERE Id_Usuario = @id AND Estado = 1 
                                      AND ((Fecha < CURDATE()) OR (Fecha = CURDATE() AND Hora < DATE_SUB(CURTIME(), INTERVAL 2 HOUR)))";
                    MySqlCommand cmdFinalizar = new MySqlCommand(queryFinalizar, conexion);
                    cmdFinalizar.Parameters.AddWithValue("@id", idUsuarioActual);
                    cmdFinalizar.ExecuteNonQuery();

                    // 2. Buscar rutina más cercana
                    string queryRutina = @"SELECT Id_rutina, Nombre, Hora, Fecha 
                    FROM rutina 
                    WHERE Id_Usuario = @id 
                    AND Estado = 1
                    AND Fecha = CURDATE() 
                    -- Que no hayan pasado más de 2 horas desde que terminó
                    AND CURTIME() <= ADDTIME(Hora, '02:00:00')
                    ORDER BY Hora ASC LIMIT 1";

                    MySqlCommand cmdRutina = new MySqlCommand(queryRutina, conexion);
                    cmdRutina.Parameters.AddWithValue("@id", idUsuarioActual);

                    using (MySqlDataReader readerRutina = cmdRutina.ExecuteReader())
                    {
                        if (readerRutina.Read())
                        {
                            int idRutina = readerRutina.GetInt32("Id_rutina");
                            labelNombre.Text = readerRutina.GetString("Nombre");

                            object valorHora = readerRutina["Hora"];
                            TimeSpan horaRutina = (valorHora is DateTime dt) ? dt.TimeOfDay : (TimeSpan)valorHora;
                            labelFecha.Text = horaRutina.ToString(@"hh\:mm");

                            readerRutina.Close();

                            // 3. Buscar actividades (Agregamos Id_actividad y filtro de Estado = 1)
                            string queryActividades = @"SELECT Id_actividad, Nombre, Descripcion, Hora_Inicio FROM actividad 
                                                WHERE Id_rutina = @idR AND Estado = 1 ORDER BY Hora_Inicio ASC LIMIT 3";

                            MySqlCommand cmdAct = new MySqlCommand(queryActividades, conexion);
                            cmdAct.Parameters.AddWithValue("@idR", idRutina);

                            using (MySqlDataReader readerAct = cmdAct.ExecuteReader())
                            {
                                int contador = 1;
                                // Importante: Limpiar tags antes de cargar nuevos datos
                                LimpiarBotones();

                                while (readerAct.Read() && contador <= 3)
                                {
                                    object valorHoraAct = readerAct["Hora_Inicio"];
                                    TimeSpan hAct = (valorHoraAct is DateTime dtA) ? dtA.TimeOfDay : (TimeSpan)valorHoraAct;

                                    // Pasamos el Id_actividad al método asignar
                                    AsignarDatosActividad(contador,
                                        readerAct.GetString("Nombre"),
                                        readerAct.GetString("Descripcion"),
                                        hAct,
                                        readerAct.GetInt32("Id_actividad"));
                                    contador++;
                                }
                            }
                        }
                        else
                        {
                            labelNombre.Text = "No hay rutinas próximas";
                            LimpiarBotones();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar datos: " + ex.Message);
                }
            }
        }

        // Modificamos la firma para recibir el idActividad
        private void AsignarDatosActividad(int index, string nombre, string desc, TimeSpan horaInicio, int idActividad)
        {
            TimeSpan ahora = DateTime.Now.TimeOfDay;
            int minutosRestantes = (int)(horaInicio - ahora).TotalMinutes;
            string textoMinutos = minutosRestantes > 0 ? $"- En ({minutosRestantes}) Minutos" : "- En curso o pasada";

            if (index == 1)
            {
                labelActividad1.Text = nombre;
                labelDescripcion1.Text = desc;
                labelMinutos1.Text = textoMinutos;
                modernContainer10.Tag = idActividad; // Guardamos el ID en el botón
                modernContainer11.Tag = idActividad;
            }
            else if (index == 2)
            {
                labelActividad2.Text = nombre;
                labelDescripcion2.Text = desc;
                labelMinutos2.Text = textoMinutos;
                modernContainer5.Tag = idActividad;
                modernContainer12.Tag = idActividad;
            }
            else if (index == 3)
            {
                labelActividad3.Text = nombre;
                labelDescripcion3.Text = desc;
                labelMinutos3.Text = textoMinutos;
                modernContainer14.Tag = idActividad;
                modernContainer15.Tag = idActividad;
            }
        }

        private void LimpiarBotones()
        {
            modernContainer10.Tag = modernContainer5.Tag = modernContainer14.Tag = null;
            modernContainer11.Tag = modernContainer12.Tag = modernContainer15.Tag = null;
        }

        // botones de finalizar y eliminar

        // Evento para los botones verdes (Finalizar)
        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            Control panel = (Control)sender;
            if (panel.Tag == null) return;

            // 1. OBTENER LA HORA DE INICIO
            if (!TimeSpan.TryParse(labelFecha.Text, out TimeSpan horaInicio)) return;

            TimeSpan horaActual = DateTime.Now.TimeOfDay;

            // 2. VALIDACIÓN: ¿Está intentando finalizar antes de que empiece?
            if (horaActual < horaInicio)
            {
                MessageBox.Show($"Aún no puedes finalizar actividades. Esta rutina inicia a las {horaInicio.ToString(@"hh\:mm")}",
                                "Bloqueado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. PROCESO DE ACTUALIZACIÓN
            int idAct = (int)panel.Tag;
            string connectionString = "Server=localhost;Database=DailyRoutine;Uid=root;Pwd=Adonay14.;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE actividad SET Estado = 0 WHERE Id_actividad = @id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", idAct);
                    int filasAfectadas = cmd.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        // MENSAJE DE ÉXITO
                        MessageBox.Show("¡Excelente trabajo! Actividad marcada como finalizada. ✅",
                                        "Progreso Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    CargarRutinaYActividades(); // Refrescar vista para que desaparezca la actividad o se raye
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar: " + ex.Message);
                }
            }
        }

        // Evento para los botones rojos (Eliminar)


        private void botnFinalizar_Click(object sender, EventArgs e)
        {
            // Usamos Control para que funcione con tu ModernContainerPanel
            Control panel = (Control)sender;
            if (panel.Tag == null) return;

            int idAct = (int)panel.Tag;
            string connectionString = "Server=localhost;Database=DailyRoutine;Uid=root;Pwd=Adonay14.;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE actividad SET Estado = 0 WHERE Id_actividad = @id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", idAct);
                    cmd.ExecuteNonQuery();

                    // Refrescamos los datos para que desaparezca la actividad
                    MessageBox.Show("¡Actividad completada!");
                    CargarRutinaYActividades();
                }
                catch (Exception ex) { MessageBox.Show("Error al finalizar: " + ex.Message); }
            }
        }

        // Evento para eliminar (Los paneles con la X roja)
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Control panel = (Control)sender;
            if (panel.Tag == null) return;

            if (MessageBox.Show("¿Eliminar actividad permanentemente?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No) return;

            int idAct = (int)panel.Tag;
            string connectionString = "Server=localhost;Database=DailyRoutine;Uid=root;Pwd=Adonay14.;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM actividad WHERE Id_actividad = @id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", idAct);
                    cmd.ExecuteNonQuery();

                    CargarRutinaYActividades();
                }
                catch (Exception ex) { MessageBox.Show("Error al eliminar: " + ex.Message); }
            }
        }

        // Cargar proximamente

        private void CargarProximasRutinas()
        {
            string connectionString = "Server=localhost;Database=DailyRoutine;Uid=root;Pwd=Adonay14.;";
            // Buscamos rutinas desde hoy hasta mañana (48h) que aún no hayan expirado
            string query = @"SELECT Nombre, Hora, Fecha 
                 FROM rutina 
                 WHERE Id_Usuario = @id AND Estado = 1
                 AND (
                    (Fecha = CURDATE() AND Hora > CURTIME()) 
                    OR 
                    (Fecha > CURDATE() AND Fecha <= DATE_ADD(CURDATE(), INTERVAL 2 DAY))
                 )
                 ORDER BY Fecha ASC, Hora ASC 
                 LIMIT 1, 3"; // Salta la que ya está en el panel grande

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", UsuarioSesion.IdUsuario);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    int contador = 1;

                    // Limpiamos los labels antes de empezar por si no hay 3 rutinas
                    LimpiarLabelsProximos();

                    while (reader.Read())
                    {
                        string nombre = reader["Nombre"].ToString();
                        DateTime fechaRutina = Convert.ToDateTime(reader["Fecha"]);
                        TimeSpan horaRutina = (TimeSpan)reader["Hora"];

                        // Combinamos fecha y hora para el cálculo
                        DateTime fechaHoraCompleta = fechaRutina.Date + horaRutina;
                        TimeSpan diferencia = fechaHoraCompleta - DateTime.Now;

                        string tiempoFaltante = FormatearTiempo(diferencia);

                        // Asignamos a los labels dinámicamente
                        if (contador == 1) { labelProx1.Text = nombre; labelProxT1.Text = tiempoFaltante; }
                        if (contador == 2) { labelProx2.Text = nombre; labelProxT2.Text = tiempoFaltante; }
                        if (contador == 3) { labelProx3.Text = nombre; labelProxT3.Text = tiempoFaltante; }

                        contador++;
                    }
                }
                catch (Exception ex) { MessageBox.Show("Error en proximos: " + ex.Message); }
            }
        }

        // Para que diga "Faltan 5h" o "Mañana a las..."
        private string FormatearTiempo(TimeSpan t)
        {
            if (t.TotalHours < 1) return $"Inicia en {t.Minutes} min";
            if (t.TotalHours < 24) return $"Faltan {Math.Floor(t.TotalHours)}h {t.Minutes}m";
            return $"Mañana (+24h)";
        }

        // Para que si solo hay 1 rutina próxima, los otros labels no digan "labelProx2"
        private void LimpiarLabelsProximos()
        {
            labelProx1.Text = labelProx2.Text = labelProx3.Text = "Sin rutinas";
            labelProxT1.Text = labelProxT2.Text = labelProxT3.Text = "--:--";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            CargarRutinaYActividades();
        }
    }
}

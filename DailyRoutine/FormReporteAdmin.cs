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
    public partial class FormReporteAdmin : Form
    {
        public FormReporteAdmin()
        {
            InitializeComponent();
            CargarReportesRecientes();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void CargarReportesRecientes()
        {
            string connectionString = "Server=localhost;Database=DailyRoutine;Uid=root;Pwd=Adonay14.;";
            // Seleccionamos los 3 más recientes que estén activos (Estado = 1)
            string query = @"SELECT r.Id_Reporte, u.Gmail, r.Asunto 
                     FROM reporte r 
                     JOIN usuario u ON r.Id_Usuario = u.Id_Usuario 
                     WHERE r.Estado = 1 
                     ORDER BY r.Fecha_Creacion DESC LIMIT 3";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        // Limpiamos los labels por si hay menos de 3 reportes
                        labelNombre1.Text = labelNombre2.Text = labelNombre3.Text = "";
                        labelAsunto1.Text = labelAsunto2.Text = labelAsunto3.Text = "Sin reportes pendientes";

                        int i = 1;
                        while (dr.Read())
                        {
                            if (i == 1)
                            {
                                labelNombre1.Text = dr["Gmail"].ToString();
                                labelAsunto1.Text = dr["Asunto"].ToString();
                                modernContainer2.Tag = dr["Id_Reporte"]; // Guardamos el ID en el Tag del botón
                            }
                            if (i == 2)
                            {
                                labelNombre2.Text = dr["Gmail"].ToString();
                                labelAsunto2.Text = dr["Asunto"].ToString();
                                modernContainer4.Tag = dr["Id_Reporte"];
                            }
                            if (i == 3)
                            {
                                labelNombre3.Text = dr["Gmail"].ToString();
                                labelAsunto3.Text = dr["Asunto"].ToString();
                                modernContainer6.Tag = dr["Id_Reporte"];
                            }
                            i++;
                        }
                    }
                }
                catch (Exception ex) { MessageBox.Show("Error al cargar reportes: " + ex.Message); }
            }
        }
        private void btnVisto_Click(object sender, EventArgs e)
        {
            Control controlCliquueado = (Control)sender;
            object idReporteObj = null;

            // Buscamos el ID en el Tag (del botón o del contenedor)
            if (controlCliquueado.Tag != null)
                idReporteObj = controlCliquueado.Tag;
            else if (controlCliquueado.Parent != null && controlCliquueado.Parent.Tag != null)
                idReporteObj = controlCliquueado.Parent.Tag;

            if (idReporteObj == null) return;

            int idReporte = Convert.ToInt32(idReporteObj);
            string connectionString = "Server=localhost;Database=DailyRoutine;Uid=root;Pwd=Adonay14.;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    // Usamos un UPDATE explícito
                    string query = "UPDATE reporte SET Estado = 0 WHERE Id_Reporte = @id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    // Especificamos el tipo de dato para evitar el "Truncated error"
                    cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = idReporte;

                    cmd.ExecuteNonQuery();

                    // Mensaje opcional para confirmar que funcionó
                    // MessageBox.Show("Reporte archivado.");

                    CargarReportesRecientes();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar reporte: " + ex.Message);
                }
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            // Al usar Close(), el formulario se cierra y el hilo de ejecución 
            // vuelve al FormAdmin que lo llamó.
            this.Close();
        }

    }
}

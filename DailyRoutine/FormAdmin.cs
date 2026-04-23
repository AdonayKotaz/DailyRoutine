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
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            // Mostramos el nombre guardado durante el login
            label1.Text = AdminSesion.NombreAdmin;

  
        }

        private void btnAdminBD_Click(object sender, EventArgs e)
        {
            FormBaseDeDatos frmBD = new FormBaseDeDatos();
            this.Hide(); // Ocultamos el menú principal
            frmBD.ShowDialog(); // Abrimos la BD y esperamos a que se cierre
            this.Show(); // Al cerrar FormBaseDeDatos, el menú reaparece
        }

        // Botón: Reportes (modernContainer con el icono de sobre/mensaje)
        private void btnReportesAdmin_Click(object sender, EventArgs e)
        {
            FormReporteAdmin frmRep = new FormReporteAdmin();
            this.Hide(); // Ocultamos el menú principal
            frmRep.ShowDialog(); // Abrimos la BD y esperamos a que se cierre
            this.Show(); // Al cerrar FormBaseDeDatos, el menú reaparece
        }

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

    }
}

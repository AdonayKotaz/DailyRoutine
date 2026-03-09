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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}

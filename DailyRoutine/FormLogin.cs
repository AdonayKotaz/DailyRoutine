using MySqlConnector;

namespace DailyRoutine
{
    public partial class FormLogin : Form
    {

        // Cadena de conexión 
        string connectionString =
        "Server=localhost;Database=DailyRoutine;User ID=root;Password=Adonay14.;";

        public FormLogin()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Shown += FormLogin_Shown;

            // Usuario
            textBox1.Text = placeholderUser;
            textBox1.ForeColor = Color.Gray;

            // Contraseña
            textBox2.Text = placeholderPass;
            textBox2.ForeColor = Color.Gray;
            textBox2.UseSystemPasswordChar = false;

            // Eliminar parpadeo

            // Activa el doble búfer para el formulario
            this.DoubleBuffered = true;

            // Configuraciones extra para renderizado suave
            this.SetStyle(ControlStyles.AllPaintingInWmPaint |
                          ControlStyles.UserPaint |
                          ControlStyles.OptimizedDoubleBuffer, true);
            this.UpdateStyles();

        }

        private void FormLogin_Shown(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        // TextBox

        string placeholderUser = "Ingrese su correo electronico...";
        string placeholderPass = "Ingrese contraseña...";

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == placeholderUser)
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == placeholderPass)
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
                textBox2.UseSystemPasswordChar = true; // ahora oculta
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Text = placeholderUser;
                textBox1.ForeColor = Color.Gray;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                textBox2.Text = placeholderPass;
                textBox2.ForeColor = Color.Gray;
                textBox2.UseSystemPasswordChar = false;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();

            FormRegistro frm = new FormRegistro();
            frm.ShowDialog();

            this.Hide();
        }

        // Iniciar sesión 

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=DailyRoutine;Uid=root;Pwd=Adonay14.;";
            string correoOUser = textBox1.Text.Trim();
            string pass = textBox2.Text.Trim();

            using (MySqlConnection conexion = new MySqlConnection(connectionString))
            {
                try
                {
                    conexion.Open();

                    // --- INTENTO 1: LOGIN COMO USUARIO ---
                    // Agregamos BINARY antes de la columna contrasena
                    string queryUser = "SELECT Id_usuario, Gmail FROM usuario WHERE Gmail = @correo AND BINARY contrasena = @pass";
                    MySqlCommand cmdUser = new MySqlCommand(queryUser, conexion);
                    cmdUser.Parameters.AddWithValue("@correo", correoOUser);
                    cmdUser.Parameters.AddWithValue("@pass", pass);

                    using (MySqlDataReader readerUser = cmdUser.ExecuteReader())
                    {
                        if (readerUser.Read())
                        {
                            UsuarioSesion.IdUsuario = Convert.ToInt32(readerUser["Id_usuario"]);
                            UsuarioSesion.Correo = readerUser["Gmail"].ToString();

                            MessageBox.Show("¡Bienvenido!");
                            new FormInicio().Show();
                            this.Hide();
                            return;
                        }
                    }

                    // --- INTENTO 2: LOGIN COMO ADMINISTRADOR ---
                    // Aplicamos BINARY también en la tabla administrador
                    string queryAdmin = "SELECT Id_Admin, Nombre FROM administrador WHERE Nombre = @nom AND BINARY Contraseña = @pass";
                    MySqlCommand cmdAdmin = new MySqlCommand(queryAdmin, conexion);
                    cmdAdmin.Parameters.AddWithValue("@nom", correoOUser);
                    cmdAdmin.Parameters.AddWithValue("@pass", pass);

                    using (MySqlDataReader readerAdmin = cmdAdmin.ExecuteReader())
                    {
                        if (readerAdmin.Read())
                        {
                            AdminSesion.IdAdmin = Convert.ToInt32(readerAdmin["Id_Admin"]);
                            AdminSesion.NombreAdmin = readerAdmin["Nombre"].ToString();

                            MessageBox.Show("Acceso de Administrador: " + AdminSesion.NombreAdmin);
                            new FormAdmin().Show();
                            this.Hide();
                            return;
                        }
                    }

                    MessageBox.Show("Correo/Usuario o contraseña incorrectos.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error de base de datos: " + ex.Message);
                }
            }
        }

    }
    
}

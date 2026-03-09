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
            // 1. Cadena de conexión
            string connectionString = "Server=localhost;Database=DailyRoutine;Uid=root;Pwd=Adonay14.;";

            // 2. MODIFICACIÓN: Seleccionamos el Id_usuario en lugar de solo contar
            // Asegúrate de que el nombre del campo sea exacto (Id_usuario o Id, según tu tabla)
            string query = "SELECT Id_usuario FROM usuario WHERE Gmail = @correo AND contrasena = @pass";

            using (MySqlConnection conexion = new MySqlConnection(connectionString))
            {
                try
                {
                    conexion.Open();
                    MySqlCommand comando = new MySqlCommand(query, conexion);

                    // 3. Parámetros de seguridad
                    comando.Parameters.AddWithValue("@correo", textBox1.Text.Trim());
                    comando.Parameters.AddWithValue("@pass", textBox2.Text.Trim());

                    // 4. MODIFICACIÓN: Ejecutamos y recibimos el objeto (el ID)
                    object resultado = comando.ExecuteScalar();

                    if (resultado != null) // Si el resultado no es nulo, es que los datos son correctos
                    {
                        // ¡Éxito! GUARDAMOS EL ID EN TU CLASE GLOBAL
                        UsuarioSesion.IdUsuario = Convert.ToInt32(resultado);
                        UsuarioSesion.Correo = textBox1.Text.Trim(); // Opcional: guardar también el correo

                        MessageBox.Show("¡Bienvenido!");

                        // 5. Navegar al FormInicio
                        FormInicio inicio = new FormInicio();
                        inicio.Show();

                        this.Hide();
                    }
                    else
                    {
                        // Si resultado es null, no hubo coincidencias
                        MessageBox.Show("Correo o contraseña incorrectos. Inténtalo de nuevo.");
                        textBox2.Clear();
                        textBox2.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al conectar: " + ex.Message);
                }
            }
        }

    }
    
}

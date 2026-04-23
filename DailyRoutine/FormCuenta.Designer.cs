namespace DailyRoutine
{
    partial class FormCuenta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCuenta));
            mySqlConnection1 = new MySqlConnector.MySqlConnection();
            mySqlConnection2 = new MySqlConnector.MySqlConnection();
            label1 = new Label();
            modernContainer3 = new ModernContainer();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            richTextBox1 = new RichTextBox();
            label2 = new Label();
            modernContainer2 = new ModernContainer();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            modernContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            modernContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // mySqlConnection1
            // 
            mySqlConnection1.ProvideClientCertificatesCallback = null;
            mySqlConnection1.ProvidePasswordCallback = null;
            mySqlConnection1.RemoteCertificateValidationCallback = null;
            // 
            // mySqlConnection2
            // 
            mySqlConnection2.ProvideClientCertificatesCallback = null;
            mySqlConnection2.ProvidePasswordCallback = null;
            mySqlConnection2.RemoteCertificateValidationCallback = null;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(45, 55, 72);
            label1.Location = new Point(24, 115);
            label1.Name = "label1";
            label1.Size = new Size(221, 21);
            label1.TabIndex = 7;
            label1.Text = "Adonaypalma58@gmail.com";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // modernContainer3
            // 
            modernContainer3.BackColor = Color.Transparent;
            modernContainer3.BorderRadius = 20;
            modernContainer3.Controls.Add(label4);
            modernContainer3.Controls.Add(pictureBox2);
            modernContainer3.Cursor = Cursors.Hand;
            modernContainer3.Location = new Point(34, 139);
            modernContainer3.Name = "modernContainer3";
            modernContainer3.PanelColor = Color.IndianRed;
            modernContainer3.ShadowColor = Color.Blue;
            modernContainer3.ShadowOpacity = 90;
            modernContainer3.ShadowSize = 15;
            modernContainer3.Size = new Size(185, 61);
            modernContainer3.TabIndex = 8;
            modernContainer3.Click += btnSalir_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(45, 55, 72);
            label4.Location = new Point(56, 21);
            label4.Name = "label4";
            label4.Size = new Size(98, 20);
            label4.TabIndex = 13;
            label4.Text = "Cerrar sesión";
            label4.Click += btnSalir_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._3;
            pictureBox2.Location = new Point(25, 19);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(25, 24);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            pictureBox2.Click += btnSalir_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(13, 231);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(232, 60);
            richTextBox1.TabIndex = 9;
            richTextBox1.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(45, 55, 72);
            label2.Location = new Point(13, 213);
            label2.Name = "label2";
            label2.Size = new Size(97, 15);
            label2.TabIndex = 10;
            label2.Text = "Enviar un reporte";
            // 
            // modernContainer2
            // 
            modernContainer2.BackColor = Color.Transparent;
            modernContainer2.BorderRadius = 30;
            modernContainer2.Controls.Add(label3);
            modernContainer2.Cursor = Cursors.Hand;
            modernContainer2.Location = new Point(160, 283);
            modernContainer2.Name = "modernContainer2";
            modernContainer2.PanelColor = Color.FromArgb(45, 55, 72);
            modernContainer2.ShadowColor = Color.Black;
            modernContainer2.ShadowOpacity = 90;
            modernContainer2.ShadowSize = 15;
            modernContainer2.Size = new Size(95, 50);
            modernContainer2.TabIndex = 11;
            modernContainer2.Click += btnEnviarReporte_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(28, 17);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 12;
            label3.Text = "Enviar ";
            label3.Click += btnEnviarReporte_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(70, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(123, 124);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // FormCuenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(257, 328);
            Controls.Add(label2);
            Controls.Add(richTextBox1);
            Controls.Add(modernContainer3);
            Controls.Add(label1);
            Controls.Add(modernContainer2);
            Controls.Add(pictureBox1);
            Name = "FormCuenta";
            Text = "Cuenta";
            Load += FormCuenta_Load;
            modernContainer3.ResumeLayout(false);
            modernContainer3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            modernContainer2.ResumeLayout(false);
            modernContainer2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MySqlConnector.MySqlConnection mySqlConnection1;
        private MySqlConnector.MySqlConnection mySqlConnection2;
        private Label label1;
        private ModernContainer modernContainer3;
        private PictureBox pictureBox2;
        private RichTextBox richTextBox1;
        private Label label2;
        private ModernContainer modernContainer2;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox1;
    }
}
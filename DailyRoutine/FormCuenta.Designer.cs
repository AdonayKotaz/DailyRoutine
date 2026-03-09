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
            mySqlConnection1 = new MySqlConnector.MySqlConnection();
            mySqlConnection2 = new MySqlConnector.MySqlConnection();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            modernContainer1 = new ModernContainer();
            modernContainer2 = new ModernContainer();
            pictureBox6 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            modernContainer1.SuspendLayout();
            modernContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
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
            // pictureBox1
            // 
            pictureBox1.Location = new Point(48, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(32, 120);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(28, 33);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(32, 184);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(28, 33);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new Point(32, 249);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(28, 33);
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Location = new Point(32, 310);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(28, 33);
            pictureBox5.TabIndex = 4;
            pictureBox5.TabStop = false;
            // 
            // modernContainer1
            // 
            modernContainer1.BackColor = Color.Transparent;
            modernContainer1.BorderRadius = 30;
            modernContainer1.Controls.Add(pictureBox1);
            modernContainer1.Location = new Point(69, 12);
            modernContainer1.Name = "modernContainer1";
            modernContainer1.PanelColor = Color.FromArgb(245, 245, 245);
            modernContainer1.ShadowColor = Color.Black;
            modernContainer1.ShadowOpacity = 90;
            modernContainer1.ShadowSize = 15;
            modernContainer1.Size = new Size(200, 100);
            modernContainer1.TabIndex = 5;
            modernContainer1.Paint += modernContainer1_Paint;
            // 
            // modernContainer2
            // 
            modernContainer2.BackColor = Color.Transparent;
            modernContainer2.BorderRadius = 20;
            modernContainer2.Controls.Add(pictureBox6);
            modernContainer2.Location = new Point(45, 359);
            modernContainer2.Name = "modernContainer2";
            modernContainer2.PanelColor = Color.Gray;
            modernContainer2.ShadowColor = Color.Blue;
            modernContainer2.ShadowOpacity = 90;
            modernContainer2.ShadowSize = 15;
            modernContainer2.Size = new Size(233, 61);
            modernContainer2.TabIndex = 6;
            // 
            // pictureBox6
            // 
            pictureBox6.Location = new Point(25, 19);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(25, 24);
            pictureBox6.TabIndex = 7;
            pictureBox6.TabStop = false;
            // 
            // FormCuenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(329, 450);
            Controls.Add(modernContainer2);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(modernContainer1);
            Name = "FormCuenta";
            Text = "FormCuenta";
            Load += FormCuenta_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            modernContainer1.ResumeLayout(false);
            modernContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private MySqlConnector.MySqlConnection mySqlConnection1;
        private MySqlConnector.MySqlConnection mySqlConnection2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private ModernContainer modernContainer1;
        private ModernContainer modernContainer2;
        private PictureBox pictureBox6;
    }
}
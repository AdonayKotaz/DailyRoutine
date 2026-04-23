namespace DailyRoutine
{
    partial class FormAgregar
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
            panel2 = new Panel();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            modernContainer1 = new ModernContainer();
            textBox2 = new TextBox();
            modernContainer4 = new ModernContainer();
            label2 = new Label();
            modernContainer2 = new ModernContainer();
            textBox1 = new TextBox();
            panel3 = new Panel();
            label1 = new Label();
            panelContenedor = new Panel();
            panel6 = new Panel();
            LblEstadisticas = new Label();
            panel5 = new Panel();
            LblAgregar = new Label();
            panel4 = new Panel();
            LblInicio = new Label();
            pictureBox1 = new PictureBox();
            panel2.SuspendLayout();
            modernContainer1.SuspendLayout();
            modernContainer4.SuspendLayout();
            modernContainer2.SuspendLayout();
            panel3.SuspendLayout();
            panelContenedor.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(dateTimePicker2);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(modernContainer1);
            panel2.Controls.Add(modernContainer4);
            panel2.Controls.Add(modernContainer2);
            panel2.ForeColor = SystemColors.ButtonFace;
            panel2.Location = new Point(176, 76);
            panel2.Name = "panel2";
            panel2.Size = new Size(590, 347);
            panel2.TabIndex = 1;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CalendarTitleForeColor = Color.Red;
            dateTimePicker2.CustomFormat = "hh:mm tt";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(40, 194);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.ShowUpDown = true;
            dateTimePicker2.Size = new Size(83, 23);
            dateTimePicker2.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarTitleForeColor = Color.Red;
            dateTimePicker1.Location = new Point(40, 165);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(220, 23);
            dateTimePicker1.TabIndex = 4;
            // 
            // modernContainer1
            // 
            modernContainer1.BackColor = Color.Transparent;
            modernContainer1.BorderRadius = 15;
            modernContainer1.Controls.Add(textBox2);
            modernContainer1.Location = new Point(15, 88);
            modernContainer1.Name = "modernContainer1";
            modernContainer1.PanelColor = Color.FromArgb(245, 245, 245);
            modernContainer1.ShadowColor = Color.Black;
            modernContainer1.ShadowOpacity = 150;
            modernContainer1.ShadowSize = 15;
            modernContainer1.Size = new Size(389, 71);
            modernContainer1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.WhiteSmoke;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Location = new Point(25, 27);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(338, 16);
            textBox2.TabIndex = 1;
            textBox2.Enter += textBox2_Enter;
            textBox2.Leave += textBox2_Leave;
            // 
            // modernContainer4
            // 
            modernContainer4.BackColor = Color.White;
            modernContainer4.BorderRadius = 20;
            modernContainer4.Controls.Add(label2);
            modernContainer4.Cursor = Cursors.Hand;
            modernContainer4.Location = new Point(15, 278);
            modernContainer4.Name = "modernContainer4";
            modernContainer4.PanelColor = Color.FromArgb(56, 161, 105);
            modernContainer4.ShadowColor = Color.Black;
            modernContainer4.ShadowOpacity = 150;
            modernContainer4.ShadowSize = 15;
            modernContainer4.Size = new Size(148, 66);
            modernContainer4.TabIndex = 3;
            modernContainer4.Click += btnGuardarRutina_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(38, 22);
            label2.Name = "label2";
            label2.Size = new Size(70, 21);
            label2.TabIndex = 0;
            label2.Text = "Agregar";
            label2.Click += btnGuardarRutina_Click;
            // 
            // modernContainer2
            // 
            modernContainer2.BackColor = Color.Transparent;
            modernContainer2.BorderRadius = 15;
            modernContainer2.Controls.Add(textBox1);
            modernContainer2.Location = new Point(15, 11);
            modernContainer2.Name = "modernContainer2";
            modernContainer2.PanelColor = Color.FromArgb(245, 245, 245);
            modernContainer2.ShadowColor = Color.Black;
            modernContainer2.ShadowOpacity = 150;
            modernContainer2.ShadowSize = 15;
            modernContainer2.Size = new Size(389, 71);
            modernContainer2.TabIndex = 1;
            modernContainer2.Paint += modernContainer2_Paint;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.WhiteSmoke;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(25, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(338, 16);
            textBox1.TabIndex = 0;
            textBox1.Enter += textBox1_Enter;
            textBox1.Leave += textBox1_Leave;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Silver;
            panel3.Controls.Add(label1);
            panel3.ForeColor = Color.White;
            panel3.Location = new Point(176, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(590, 58);
            panel3.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(230, 40);
            label1.TabIndex = 0;
            label1.Text = "NUEVA RUTINA";
            label1.Click += label1_Click_1;
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = Color.FromArgb(44, 55, 72);
            panelContenedor.Controls.Add(panel6);
            panelContenedor.Controls.Add(panel5);
            panelContenedor.Controls.Add(panel4);
            panelContenedor.Controls.Add(pictureBox1);
            panelContenedor.Dock = DockStyle.Left;
            panelContenedor.Location = new Point(0, 0);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(156, 450);
            panelContenedor.TabIndex = 3;
            // 
            // panel6
            // 
            panel6.Controls.Add(LblEstadisticas);
            panel6.Cursor = Cursors.Hand;
            panel6.Location = new Point(0, 235);
            panel6.Name = "panel6";
            panel6.Size = new Size(156, 49);
            panel6.TabIndex = 6;
            panel6.Click += Panel6_Click;
            // 
            // LblEstadisticas
            // 
            LblEstadisticas.AutoSize = true;
            LblEstadisticas.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblEstadisticas.Location = new Point(18, 10);
            LblEstadisticas.Name = "LblEstadisticas";
            LblEstadisticas.Size = new Size(111, 25);
            LblEstadisticas.TabIndex = 6;
            LblEstadisticas.Text = "Estadisticas";
            LblEstadisticas.Click += Panel6_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(60, 74, 99);
            panel5.Controls.Add(LblAgregar);
            panel5.Location = new Point(0, 186);
            panel5.Name = "panel5";
            panel5.Size = new Size(156, 49);
            panel5.TabIndex = 5;
            // 
            // LblAgregar
            // 
            LblAgregar.AutoSize = true;
            LblAgregar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblAgregar.Location = new Point(5, 10);
            LblAgregar.Name = "LblAgregar";
            LblAgregar.Size = new Size(148, 25);
            LblAgregar.TabIndex = 5;
            LblAgregar.Text = "Agregar Rutina";
            LblAgregar.Click += Panel5_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(45, 55, 72);
            panel4.Controls.Add(LblInicio);
            panel4.Cursor = Cursors.Hand;
            panel4.Location = new Point(0, 137);
            panel4.Name = "panel4";
            panel4.Size = new Size(156, 49);
            panel4.TabIndex = 4;
            panel4.Click += Panel4_Click;
            panel4.Paint += panel4_Paint;
            // 
            // LblInicio
            // 
            LblInicio.AutoSize = true;
            LblInicio.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblInicio.ForeColor = Color.FromArgb(217, 217, 217);
            LblInicio.Location = new Point(45, 10);
            LblInicio.Name = "LblInicio";
            LblInicio.Size = new Size(61, 25);
            LblInicio.TabIndex = 4;
            LblInicio.Text = "Inicio";
            LblInicio.Click += Panel4_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._1;
            pictureBox1.Location = new Point(32, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 74);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // FormAgregar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(panelContenedor);
            Controls.Add(panel3);
            Controls.Add(panel2);
            ForeColor = Color.FromArgb(217, 217, 217);
            Name = "FormAgregar";
            Text = "Daily Routine";
            Load += FormAgregar_Load;
            panel2.ResumeLayout(false);
            modernContainer1.ResumeLayout(false);
            modernContainer1.PerformLayout();
            modernContainer4.ResumeLayout(false);
            modernContainer4.PerformLayout();
            modernContainer2.ResumeLayout(false);
            modernContainer2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panelContenedor.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private ModernContainer modernContainer2;
        private ModernContainer modernContainer4;
        private Panel panel3;
        private Label label1;
        private Panel panelContenedor;
        private PictureBox pictureBox1;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
        private Label LblInicio;
        private Label LblEstadisticas;
        private Label LblAgregar;
        private ModernContainer modernContainer1;
        private TextBox textBox1;
        private TextBox textBox2;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private DateTimePicker dateTimePicker2;
    }
}
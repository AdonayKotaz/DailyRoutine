namespace DailyRoutine
{
    partial class FormTarea
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
            modernContainer1 = new ModernContainer();
            label3 = new Label();
            modernContainer4 = new ModernContainer();
            label2 = new Label();
            cmbRutinas = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            modernContainer3 = new ModernContainer();
            textBox2 = new TextBox();
            modernContainer2 = new ModernContainer();
            textBox1 = new TextBox();
            label1 = new Label();
            modernContainer1.SuspendLayout();
            modernContainer4.SuspendLayout();
            modernContainer3.SuspendLayout();
            modernContainer2.SuspendLayout();
            SuspendLayout();
            // 
            // modernContainer1
            // 
            modernContainer1.BackColor = Color.Transparent;
            modernContainer1.BorderRadius = 15;
            modernContainer1.Controls.Add(label3);
            modernContainer1.Controls.Add(modernContainer4);
            modernContainer1.Controls.Add(cmbRutinas);
            modernContainer1.Controls.Add(dateTimePicker1);
            modernContainer1.Controls.Add(modernContainer3);
            modernContainer1.Controls.Add(modernContainer2);
            modernContainer1.Controls.Add(label1);
            modernContainer1.Location = new Point(12, 12);
            modernContainer1.Name = "modernContainer1";
            modernContainer1.PanelColor = Color.FromArgb(224, 224, 224);
            modernContainer1.ShadowColor = Color.Black;
            modernContainer1.ShadowOpacity = 150;
            modernContainer1.ShadowSize = 15;
            modernContainer1.Size = new Size(344, 383);
            modernContainer1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(32, 239);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.No;
            label3.Size = new Size(56, 21);
            label3.TabIndex = 6;
            label3.Text = "Rutina";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // modernContainer4
            // 
            modernContainer4.BackColor = Color.Transparent;
            modernContainer4.BorderRadius = 30;
            modernContainer4.Controls.Add(label2);
            modernContainer4.Cursor = Cursors.Hand;
            modernContainer4.Location = new Point(176, 307);
            modernContainer4.Name = "modernContainer4";
            modernContainer4.PanelColor = Color.FromArgb(45, 55, 72);
            modernContainer4.ShadowColor = Color.Black;
            modernContainer4.ShadowOpacity = 90;
            modernContainer4.ShadowSize = 15;
            modernContainer4.Size = new Size(144, 61);
            modernContainer4.TabIndex = 5;
            modernContainer4.Click += btnGuardarActividad_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(40, 20);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 0;
            label2.Text = "Guardar";
            label2.Click += btnGuardarActividad_Click;
            // 
            // cmbRutinas
            // 
            cmbRutinas.FormattingEnabled = true;
            cmbRutinas.Location = new Point(32, 263);
            cmbRutinas.Name = "cmbRutinas";
            cmbRutinas.Size = new Size(121, 23);
            cmbRutinas.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "HH:mm tt";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(32, 208);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.ShowUpDown = true;
            dateTimePicker1.Size = new Size(84, 23);
            dateTimePicker1.TabIndex = 3;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // modernContainer3
            // 
            modernContainer3.BackColor = Color.Transparent;
            modernContainer3.BorderRadius = 20;
            modernContainer3.Controls.Add(textBox2);
            modernContainer3.Location = new Point(18, 133);
            modernContainer3.Name = "modernContainer3";
            modernContainer3.PanelColor = Color.FromArgb(245, 245, 245);
            modernContainer3.ShadowColor = Color.Black;
            modernContainer3.ShadowOpacity = 90;
            modernContainer3.ShadowSize = 15;
            modernContainer3.Size = new Size(286, 69);
            modernContainer3.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.WhiteSmoke;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Location = new Point(34, 29);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(217, 16);
            textBox2.TabIndex = 1;
            textBox2.TextChanged += textBox2_TextChanged;
            textBox2.Enter += textBox2_Enter;
            textBox2.Leave += textBox2_Leave;
            // 
            // modernContainer2
            // 
            modernContainer2.BackColor = Color.Transparent;
            modernContainer2.BorderRadius = 20;
            modernContainer2.Controls.Add(textBox1);
            modernContainer2.Location = new Point(18, 71);
            modernContainer2.Name = "modernContainer2";
            modernContainer2.PanelColor = Color.FromArgb(245, 245, 245);
            modernContainer2.ShadowColor = Color.Black;
            modernContainer2.ShadowOpacity = 90;
            modernContainer2.ShadowSize = 15;
            modernContainer2.Size = new Size(286, 69);
            modernContainer2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.WhiteSmoke;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(34, 28);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(217, 16);
            textBox1.TabIndex = 0;
            textBox1.Enter += textBox1_Enter;
            textBox1.Leave += textBox1_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(45, 55, 72);
            label1.Location = new Point(32, 34);
            label1.Name = "label1";
            label1.Size = new Size(164, 25);
            label1.TabIndex = 0;
            label1.Text = "Agregar actividad";
            // 
            // FormTarea
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(367, 411);
            Controls.Add(modernContainer1);
            Name = "FormTarea";
            Text = "Agregar Tarea";
            Load += FormTarea_Load;
            modernContainer1.ResumeLayout(false);
            modernContainer1.PerformLayout();
            modernContainer4.ResumeLayout(false);
            modernContainer4.PerformLayout();
            modernContainer3.ResumeLayout(false);
            modernContainer3.PerformLayout();
            modernContainer2.ResumeLayout(false);
            modernContainer2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ModernContainer modernContainer1;
        private DateTimePicker dateTimePicker1;
        private ModernContainer modernContainer3;
        private ModernContainer modernContainer2;
        private Label label1;
        private ComboBox cmbRutinas;
        private ModernContainer modernContainer4;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
    }
}
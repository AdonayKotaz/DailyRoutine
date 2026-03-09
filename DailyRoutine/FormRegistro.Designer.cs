namespace DailyRoutine
{
    partial class FormRegistro
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

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistro));
            panel1 = new Panel();
            label4 = new Label();
            label3 = new Label();
            checkBox1 = new CheckBox();
            pictureBox1 = new PictureBox();
            modernContainer4 = new ModernContainer();
            label2 = new Label();
            modernContainer3 = new ModernContainer();
            label1 = new Label();
            textBox3 = new TextBox();
            modernContainer2 = new ModernContainer();
            textBox2 = new TextBox();
            modernContainer1 = new ModernContainer();
            textBox1 = new TextBox();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            modernContainer4.SuspendLayout();
            modernContainer3.SuspendLayout();
            modernContainer2.SuspendLayout();
            modernContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(modernContainer4);
            panel1.Controls.Add(modernContainer3);
            panel1.Controls.Add(modernContainer2);
            panel1.Controls.Add(modernContainer1);
            panel1.Location = new Point(347, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(407, 426);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Cursor = Cursors.Hand;
            label4.ForeColor = Color.DarkSlateGray;
            label4.Location = new Point(150, 390);
            label4.Name = "label4";
            label4.Size = new Size(92, 15);
            label4.TabIndex = 7;
            label4.Text = "Ya tengo cuenta";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(45, 55, 72);
            label3.Location = new Point(150, 99);
            label3.Name = "label3";
            label3.Size = new Size(98, 25);
            label3.TabIndex = 6;
            label3.Text = "Registrate";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Cursor = Cursors.Help;
            checkBox1.Location = new Point(94, 323);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(208, 19);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "Acepto los terminos y condiciones";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(164, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(72, 77);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // modernContainer4
            // 
            modernContainer4.BackColor = Color.Transparent;
            modernContainer4.BorderRadius = 30;
            modernContainer4.Controls.Add(label2);
            modernContainer4.Cursor = Cursors.Hand;
            modernContainer4.Location = new Point(140, 336);
            modernContainer4.Name = "modernContainer4";
            modernContainer4.PanelColor = Color.FromArgb(45, 55, 72);
            modernContainer4.ShadowColor = Color.Black;
            modernContainer4.ShadowOpacity = 90;
            modernContainer4.ShadowSize = 15;
            modernContainer4.Size = new Size(119, 61);
            modernContainer4.TabIndex = 3;
            modernContainer4.Click += btnRegistrar_Click;
            modernContainer4.Paint += modernContainer4_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(36, 20);
            label2.Name = "label2";
            label2.Size = new Size(45, 21);
            label2.TabIndex = 0;
            label2.Text = "Listo";
            label2.Click += btnRegistrar_Click;
            // 
            // modernContainer3
            // 
            modernContainer3.BackColor = Color.Transparent;
            modernContainer3.BorderRadius = 30;
            modernContainer3.Controls.Add(label1);
            modernContainer3.Controls.Add(textBox3);
            modernContainer3.Location = new Point(42, 256);
            modernContainer3.Name = "modernContainer3";
            modernContainer3.PanelColor = Color.FromArgb(217, 217, 217);
            modernContainer3.ShadowColor = Color.Black;
            modernContainer3.ShadowOpacity = 90;
            modernContainer3.ShadowSize = 15;
            modernContainer3.Size = new Size(331, 61);
            modernContainer3.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(140, 0);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 6;
            label1.Text = "label1";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(217, 217, 217);
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Location = new Point(28, 24);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(265, 16);
            textBox3.TabIndex = 2;
            textBox3.Enter += textBoxRepetir_Enter;
            textBox3.Leave += textBoxRepetir_Leave;
            // 
            // modernContainer2
            // 
            modernContainer2.BackColor = Color.Transparent;
            modernContainer2.BorderRadius = 30;
            modernContainer2.Controls.Add(textBox2);
            modernContainer2.Location = new Point(42, 189);
            modernContainer2.Name = "modernContainer2";
            modernContainer2.PanelColor = Color.FromArgb(217, 217, 217);
            modernContainer2.ShadowColor = Color.Black;
            modernContainer2.ShadowOpacity = 90;
            modernContainer2.ShadowSize = 15;
            modernContainer2.Size = new Size(331, 61);
            modernContainer2.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(217, 217, 217);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Location = new Point(28, 24);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(265, 16);
            textBox2.TabIndex = 1;
            textBox2.Enter += textBoxPass_Enter;
            textBox2.Leave += textBoxPass_Leave;
            // 
            // modernContainer1
            // 
            modernContainer1.BackColor = Color.Transparent;
            modernContainer1.BorderRadius = 30;
            modernContainer1.Controls.Add(textBox1);
            modernContainer1.Location = new Point(42, 122);
            modernContainer1.Name = "modernContainer1";
            modernContainer1.PanelColor = Color.FromArgb(217, 217, 217);
            modernContainer1.ShadowColor = Color.Black;
            modernContainer1.ShadowOpacity = 90;
            modernContainer1.ShadowSize = 15;
            modernContainer1.Size = new Size(331, 61);
            modernContainer1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(217, 217, 217);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(28, 24);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(265, 16);
            textBox1.TabIndex = 0;
            textBox1.Enter += textBoxCorreo_Enter;
            textBox1.Leave += textBoxCorreo_Leave;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ActiveCaption;
            pictureBox2.Image = Properties.Resources.formregisterimage;
            pictureBox2.Location = new Point(0, -2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(302, 453);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // FormRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Name = "FormRegistro";
            Text = "FormRegistro";
            Load += FormRegistro_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            modernContainer4.ResumeLayout(false);
            modernContainer4.PerformLayout();
            modernContainer3.ResumeLayout(false);
            modernContainer3.PerformLayout();
            modernContainer2.ResumeLayout(false);
            modernContainer2.PerformLayout();
            modernContainer1.ResumeLayout(false);
            modernContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }
        private Panel panel1;
        private ModernContainer modernContainer1;
        private ModernContainer modernContainer4;
        private ModernContainer modernContainer3;
        private ModernContainer modernContainer2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private CheckBox checkBox1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label3;
    }
}
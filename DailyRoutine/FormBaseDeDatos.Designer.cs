namespace DailyRoutine
{
    partial class FormBaseDeDatos
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
            dataGridView1 = new DataGridView();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            modernContainer1 = new ModernContainer();
            label3 = new Label();
            modernContainer2 = new ModernContainer();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            modernContainer3 = new ModernContainer();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            modernContainer1.SuspendLayout();
            modernContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            modernContainer3.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(30, 73);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(736, 273);
            dataGridView1.TabIndex = 0;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(30, 370);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 1;
            comboBox1.TextChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(167, 370);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 2;
            comboBox2.TextChanged += comboBox2_SelectedIndexChanged;
            // 
            // modernContainer1
            // 
            modernContainer1.BackColor = Color.Transparent;
            modernContainer1.BorderRadius = 30;
            modernContainer1.Controls.Add(label3);
            modernContainer1.Cursor = Cursors.Hand;
            modernContainer1.Location = new Point(294, 347);
            modernContainer1.Name = "modernContainer1";
            modernContainer1.PanelColor = Color.IndianRed;
            modernContainer1.ShadowColor = Color.Black;
            modernContainer1.ShadowOpacity = 90;
            modernContainer1.ShadowSize = 15;
            modernContainer1.Size = new Size(150, 66);
            modernContainer1.TabIndex = 3;
            modernContainer1.Click += btnEliminar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(39, 22);
            label3.Name = "label3";
            label3.Size = new Size(67, 21);
            label3.TabIndex = 7;
            label3.Text = "Eliminar";
            label3.Click += btnEliminar_Click;
            // 
            // modernContainer2
            // 
            modernContainer2.BackColor = Color.Transparent;
            modernContainer2.BorderRadius = 30;
            modernContainer2.Controls.Add(pictureBox1);
            modernContainer2.Cursor = Cursors.Hand;
            modernContainer2.Location = new Point(431, 347);
            modernContainer2.Name = "modernContainer2";
            modernContainer2.PanelColor = Color.FromArgb(245, 245, 245);
            modernContainer2.ShadowColor = Color.Black;
            modernContainer2.ShadowOpacity = 90;
            modernContainer2.ShadowSize = 15;
            modernContainer2.Size = new Size(150, 66);
            modernContainer2.TabIndex = 4;
            modernContainer2.Click += btnExcel_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Excel;
            pictureBox1.Location = new Point(54, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(38, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += btnExcel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 352);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 5;
            label1.Text = "Elige la tabla";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(167, 352);
            label2.Name = "label2";
            label2.Size = new Size(100, 15);
            label2.TabIndex = 6;
            label2.Text = "Filtrar por usuario";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonFace;
            label4.FlatStyle = FlatStyle.System;
            label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(30, 40);
            label4.Name = "label4";
            label4.Size = new Size(229, 25);
            label4.TabIndex = 7;
            label4.Text = "Consulta la base de datos";
            // 
            // modernContainer3
            // 
            modernContainer3.BackColor = Color.Transparent;
            modernContainer3.BorderRadius = 30;
            modernContainer3.Controls.Add(label5);
            modernContainer3.Cursor = Cursors.Hand;
            modernContainer3.Location = new Point(629, 16);
            modernContainer3.Name = "modernContainer3";
            modernContainer3.PanelColor = Color.FromArgb(245, 245, 245);
            modernContainer3.ShadowColor = Color.Black;
            modernContainer3.ShadowOpacity = 90;
            modernContainer3.ShadowSize = 15;
            modernContainer3.Size = new Size(150, 66);
            modernContainer3.TabIndex = 5;
            modernContainer3.Click += btnRegresar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(48, 25);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 8;
            label5.Text = "Regresar";
            label5.Click += btnRegresar_Click;
            // 
            // FormBaseDeDatos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(modernContainer2);
            Controls.Add(modernContainer1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(dataGridView1);
            Controls.Add(modernContainer3);
            Name = "FormBaseDeDatos";
            Text = "Base de Datos";
            Load += FormBaseDeDatos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            modernContainer1.ResumeLayout(false);
            modernContainer1.PerformLayout();
            modernContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            modernContainer3.ResumeLayout(false);
            modernContainer3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ModernContainer modernContainer1;
        private ModernContainer modernContainer2;
        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
        private Label label4;
        private ModernContainer modernContainer3;
        private Label label5;
    }
}
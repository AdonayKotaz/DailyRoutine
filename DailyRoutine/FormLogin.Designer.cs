namespace DailyRoutine
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            modernContainer1 = new ModernContainer();
            label1 = new Label();
            modernContainer2 = new ModernContainer();
            textBox1 = new TextBox();
            modernContainer3 = new ModernContainer();
            textBox2 = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            modernContainer1.SuspendLayout();
            modernContainer2.SuspendLayout();
            modernContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // modernContainer1
            // 
            modernContainer1.BackColor = Color.Transparent;
            modernContainer1.BorderRadius = 30;
            modernContainer1.Controls.Add(label1);
            modernContainer1.Cursor = Cursors.Hand;
            modernContainer1.Location = new Point(156, 320);
            modernContainer1.Name = "modernContainer1";
            modernContainer1.PanelColor = Color.FromArgb(45, 55, 72);
            modernContainer1.ShadowColor = Color.Black;
            modernContainer1.ShadowOpacity = 90;
            modernContainer1.ShadowSize = 15;
            modernContainer1.Size = new Size(178, 74);
            modernContainer1.TabIndex = 0;
            modernContainer1.Click += btnIngresar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(46, 22);
            label1.Name = "label1";
            label1.Size = new Size(82, 25);
            label1.TabIndex = 0;
            label1.Text = "Ingresar";
            label1.Click += btnIngresar_Click;
            // 
            // modernContainer2
            // 
            modernContainer2.BackColor = Color.Transparent;
            modernContainer2.BorderRadius = 30;
            modernContainer2.Controls.Add(textBox1);
            modernContainer2.Location = new Point(37, 184);
            modernContainer2.Name = "modernContainer2";
            modernContainer2.PanelColor = Color.FromArgb(245, 245, 245);
            modernContainer2.ShadowColor = Color.Black;
            modernContainer2.ShadowOpacity = 90;
            modernContainer2.ShadowSize = 15;
            modernContainer2.Size = new Size(408, 74);
            modernContainer2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.WhiteSmoke;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(33, 30);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(343, 16);
            textBox1.TabIndex = 2;
            textBox1.Enter += textBox1_Enter;
            textBox1.Leave += textBox1_Leave;
            // 
            // modernContainer3
            // 
            modernContainer3.BackColor = Color.Transparent;
            modernContainer3.BorderRadius = 30;
            modernContainer3.Controls.Add(textBox2);
            modernContainer3.Location = new Point(37, 255);
            modernContainer3.Name = "modernContainer3";
            modernContainer3.PanelColor = Color.FromArgb(245, 245, 245);
            modernContainer3.ShadowColor = Color.Black;
            modernContainer3.ShadowOpacity = 90;
            modernContainer3.ShadowSize = 15;
            modernContainer3.Size = new Size(408, 74);
            modernContainer3.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.WhiteSmoke;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Location = new Point(33, 32);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(343, 16);
            textBox2.TabIndex = 1;
            textBox2.Enter += textBox2_Enter;
            textBox2.Leave += textBox2_Leave;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.formloginimage;
            pictureBox1.Location = new Point(504, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(303, 454);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(182, 37);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(141, 127);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Cursor = Cursors.Hand;
            label2.ForeColor = Color.DarkSlateGray;
            label2.Location = new Point(190, 397);
            label2.Name = "label2";
            label2.Size = new Size(106, 15);
            label2.TabIndex = 5;
            label2.Text = "¿No tienes cuenta?";
            label2.Click += label2_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(modernContainer1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(modernContainer3);
            Controls.Add(modernContainer2);
            Name = "FormLogin";
            Text = "Daily Routine";
            modernContainer1.ResumeLayout(false);
            modernContainer1.PerformLayout();
            modernContainer2.ResumeLayout(false);
            modernContainer2.PerformLayout();
            modernContainer3.ResumeLayout(false);
            modernContainer3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ModernContainer modernContainer1;
        private ModernContainer modernContainer2;
        private ModernContainer modernContainer3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
    }
}

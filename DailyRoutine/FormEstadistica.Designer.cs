namespace DailyRoutine
{
    partial class FormEstadistica
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
            button1 = new Button();
            modernContainer1 = new ModernContainer();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(713, 415);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Prueba DB";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // modernContainer1
            // 
            modernContainer1.BackColor = Color.Transparent;
            modernContainer1.BorderRadius = 15;
            modernContainer1.Location = new Point(12, 12);
            modernContainer1.Name = "modernContainer1";
            modernContainer1.PanelColor = Color.FromArgb(245, 245, 245);
            modernContainer1.ShadowColor = Color.Black;
            modernContainer1.ShadowOpacity = 150;
            modernContainer1.ShadowSize = 15;
            modernContainer1.Size = new Size(131, 87);
            modernContainer1.TabIndex = 1;
            // 
            // FormEstadistica
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(modernContainer1);
            Controls.Add(button1);
            Name = "FormEstadistica";
            Text = "FormEstadistica";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private ModernContainer modernContainer1;
    }
}
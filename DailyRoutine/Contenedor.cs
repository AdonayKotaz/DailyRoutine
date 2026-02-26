using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace DailyRoutine
{
    public class ModernContainer : Panel
    {
        [Category("Modern UI")]
        public Color PanelColor { get; set; } = Color.FromArgb(245, 245, 245);
        [Category("Modern UI")]
        public int BorderRadius { get; set; } = 30;
        [Category("Modern UI")]
        public Color ShadowColor { get; set; } = Color.Black;
        [Category("Modern UI")]
        public int ShadowOpacity { get; set; } = 90;
        [Category("Modern UI")]
        public int ShadowSize { get; set; } = 15;

        public ModernContainer()
        {
            this.SetStyle(ControlStyles.UserPaint |
                          ControlStyles.AllPaintingInWmPaint |
                          ControlStyles.OptimizedDoubleBuffer |
                          ControlStyles.ResizeRedraw |
                          ControlStyles.SupportsTransparentBackColor, true);

            this.DoubleBuffered = true;
            this.BackColor = Color.Transparent;
            this.BorderStyle = BorderStyle.None;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality; // Ayuda a evitar el desfase de 1px

            // 1. LIMPIEZA TOTAL
            // Usamos el color del padre para asegurarnos de que no haya basura visual en los bordes
            if (this.Parent != null)
            {
                using (SolidBrush pb = new SolidBrush(this.Parent.BackColor))
                    g.FillRectangle(pb, this.ClientRectangle);
            }

            // 2. DEFINIR RECTÁNGULO (Inflado hacia adentro para que la sombra no se corte)
            // Usamos punto flotante para mayor precisión en el dibujo
            RectangleF rect = new RectangleF(
                ShadowSize,
                ShadowSize,
                this.Width - (ShadowSize * 2),
                this.Height - (ShadowSize * 2));

            if (rect.Width <= 0 || rect.Height <= 0) return;

            // 3. DIBUJAR SOMBRA (Ahora más intensa)
            using (GraphicsPath path = GetRoundedPath(rect, BorderRadius))
            {
                // Aplicamos un ligero desenfoque visual desplazando la sombra
                g.TranslateTransform(0, 2);
                using (PathGradientBrush shadowBrush = new PathGradientBrush(path))
                {
                    shadowBrush.CenterColor = Color.FromArgb(ShadowOpacity, ShadowColor);
                    shadowBrush.SurroundColors = new Color[] { Color.Transparent };
                    shadowBrush.FocusScales = new PointF(0.85f, 0.85f);
                    g.FillPath(shadowBrush, path);
                }
                g.ResetTransform();

                // 4. DIBUJAR EL PANEL INTERNO
                using (SolidBrush brush = new SolidBrush(PanelColor))
                {
                    g.FillPath(brush, path);
                }

                // --- EL TRUCO PARA ELIMINAR LAS LÍNEAS ---
                // Creamos una región basada en el path redondeado + el área de la sombra
                // Esto le dice a Windows: "Solo muestra lo que está aquí adentro"
                // Nota: Si las líneas persisten, comenta la línea de abajo para probar, 
                // pero normalmente esto soluciona el ghosting de los bordes.
                // this.Region = new Region(this.ClientRectangle); 
            }
        }

        private GraphicsPath GetRoundedPath(RectangleF rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float d = radius * 2f;
            if (d > rect.Width) d = rect.Width;
            if (d > rect.Height) d = rect.Height;

            path.AddArc(rect.X, rect.Y, d, d, 180, 90);
            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
            path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
            path.CloseFigure();
            return path;
        }
    }
}
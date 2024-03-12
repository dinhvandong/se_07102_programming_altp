using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
namespace ALTP
{
  

    public class GradientColorPanel : Panel
    {
        public Color StartColor { get; set; }
        public Color EndColor { get; set; }


        private const int BorderWidth = 2;
        private Color borderColor = Color.White;

        public int CornerRadius { get; set; } = 10;

        protected override void OnPaint(PaintEventArgs e)
        {
            using (LinearGradientBrush brush = 
                new LinearGradientBrush
                (this.ClientRectangle, StartColor, EndColor, LinearGradientMode.Horizontal))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }

       

            GraphicsPath path = new GraphicsPath();
              Rectangle rect = new Rectangle(0, 0, Width, Height);

              int diameter = CornerRadius * 2;
              Size size = new Size(diameter, diameter);
              Rectangle arcRect = new Rectangle(rect.Location, size);

              path.AddArc(arcRect, 180, 90); // Top-left corner
              arcRect.X = rect.Right - diameter; // Top-right corner
              path.AddArc(arcRect, 270, 90);
              arcRect.Y = rect.Bottom - diameter; // Bottom-right corner
              path.AddArc(arcRect, 0, 90);
              arcRect.X = rect.Left; // Bottom-left corner
              path.AddArc(arcRect, 90, 90);

              path.CloseFigure();
              this.Region = new Region(path);

          


        }
    }

}

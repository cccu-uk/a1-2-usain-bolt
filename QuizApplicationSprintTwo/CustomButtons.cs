using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApplicationSprintTwo
{
    public class MyButton : Button
    {
        private int Sizing = 0;
        private int Radius = 40;
        private Color Color = Color.PaleVioletRed;

        public MyButton()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(150, 40);
            this.BackColor = Color.MediumSlateBlue;
            this.ForeColor = Color.White;
        }

        private GraphicsPath GetFigure(RectangleF rect, float radius)
        {
            GraphicsPath p = new GraphicsPath();
            p.StartFigure();
            p.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            p.AddArc(rect.Width - radius, rect.Y, radius, radius, 270, 90);
            p.AddArc(rect.Width - radius, rect.Height - radius, radius, radius, 0, 90);
            p.AddArc(rect.X, rect.Height - radius, radius, radius, 90, 90);
            return p;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            Rectangle Surf = this.ClientRectangle;
            Rectangle Border = Rectangle.Inflate(Surf, -Sizing, -Sizing);
            int smoothing = 2;
            if (Sizing > 0)
                smoothing = Sizing;
            if (Radius > 2)
            {
                using (GraphicsPath pSurf = GetFigure(Surf, Radius))
                using (GraphicsPath pBorder = GetFigure(Border, Radius - Sizing))
                using (Pen penSurf = new Pen(this.Parent.BackColor, smoothing))
                using (Pen penBorder = new Pen(Color, Sizing))
                {
                    pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

                    this.Region = new Region(pSurf);

                    pevent.Graphics.DrawPath(penSurf, pSurf);

                    if (Sizing >= 1)

                        pevent.Graphics.DrawPath(penBorder, pBorder);
                }
            }
            else
            {
                pevent.Graphics.SmoothingMode = SmoothingMode.None;

                this.Region = new Region(Surf);

                if (Sizing >= 1)
                {
                    using (Pen penBorder = new Pen(Color, Sizing))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        pevent.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                    }
                }

            }
        }
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
        }
        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }

    }
}

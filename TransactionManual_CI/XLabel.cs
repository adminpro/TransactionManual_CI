using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace TransactionManual_CI
{
    public partial class XLabel : System.Windows.Forms.Label
    {
        public bool IsRequired
        {
            get;
            set;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            this.Invalidate();

            String requiredText = "*";
            Size requiredTextSize = TextRenderer.MeasureText(requiredText, this.Font);
            Size textSize = TextRenderer.MeasureText(this.Text, this.Font);
            Brush brush = new SolidBrush(this.ForeColor);
            StringFormat format = new StringFormat();

            switch (this.TextAlign)
            {
                case ContentAlignment.BottomCenter:
                case ContentAlignment.BottomLeft:
                case ContentAlignment.BottomRight:
                    format.LineAlignment = StringAlignment.Near;
                    break;

                case ContentAlignment.MiddleCenter:
                case ContentAlignment.MiddleLeft:
                case ContentAlignment.MiddleRight:
                    format.LineAlignment = StringAlignment.Center;
                    break;

                case ContentAlignment.TopCenter:
                case ContentAlignment.TopLeft:
                case ContentAlignment.TopRight:
                    format.LineAlignment = StringAlignment.Far;
                    break;
            }

            switch (this.TextAlign)
            {
                case ContentAlignment.BottomCenter:
                case ContentAlignment.MiddleCenter:
                case ContentAlignment.TopCenter:
                    format.Alignment = StringAlignment.Center;
                    break;

                case ContentAlignment.BottomLeft:
                case ContentAlignment.MiddleLeft:
                case ContentAlignment.TopLeft:
                    format.Alignment = StringAlignment.Near;
                    break;

                case ContentAlignment.BottomRight:
                case ContentAlignment.MiddleRight:
                case ContentAlignment.TopRight:
                    format.Alignment = StringAlignment.Far;
                    break;
            }

            Brush background = new SolidBrush(this.BackColor);
            e.Graphics.FillRectangle(background, e.ClipRectangle);

            if (this.IsRequired)
            {
                Rectangle rect = new Rectangle(new Point(e.ClipRectangle.Left, e.ClipRectangle.Top), new Size(e.ClipRectangle.Width - requiredTextSize.Width, e.ClipRectangle.Height));
                Rectangle reqLoc = new Rectangle(rect.Left + rect.Width, rect.Top, requiredTextSize.Width, rect.Height);

                if (this.Enabled)
                {
                    e.Graphics.DrawString(this.Text, this.Font, brush, rect, format);
                    e.Graphics.DrawString(requiredText, this.Font, Brushes.Red, reqLoc, format);
                }
                else
                {
                    ControlPaint.DrawStringDisabled(e.Graphics, this.Text, this.Font, this.BackColor, rect, format);
                    ControlPaint.DrawStringDisabled(e.Graphics, requiredText, this.Font, this.BackColor, reqLoc, format);
                }
            }
            else
            {
                if (this.Enabled)
                {
                    e.Graphics.DrawString(this.Text, this.Font, brush, e.ClipRectangle, format);
                }
                else
                {
                    ControlPaint.DrawStringDisabled(e.Graphics, this.Text, this.Font, this.BackColor, e.ClipRectangle, format);
                }
            }

            brush.Dispose();
            background.Dispose();
        }
    }
}

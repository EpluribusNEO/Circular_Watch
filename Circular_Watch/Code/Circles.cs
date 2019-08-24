using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Circular_Watch.Code
{
    public partial class Circles : UserControl
    {
        private int seconds;
        private int minutes;
        private int hours;

        private Color clrSeconds;
        private Color clrMinutes;
        private Color clrHours;
        private Color clrBackGround;

        Pen pen;
        Rectangle rect;

        public Circles()
        {
            clrSeconds = Color.FromArgb(255, 250, 120, 158);

            clrBackGround = Color.White;

            InitializeComponent();
        }


        public void UpdateTime(int seconds, int minutes, int hours)
        {
            this.seconds = seconds;
            this.minutes = minutes;
            this.hours   = hours;

            this.Invalidate();
        }

        private void Circles_Paint(object sender, PaintEventArgs e)
        {

            /* Секунды */
        
            e.Graphics.TranslateTransform(this.Width / 2, this.Height / 2);
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.RotateTransform(-90);
            pen = new Pen(clrSeconds);
            rect = new Rectangle(0 - this.Width / 2 + 10, 0 - this.Height / 2 + 10, this.Width - 20, this.Height - 20);
            e.Graphics.DrawPie(pen, rect, 0, (int)(this.seconds * 6));
            e.Graphics.FillPie(new SolidBrush(clrSeconds), rect, 0, (int)(this.seconds * 6));
            /* /Секунды */

            /* Минуты */
            /* /Минуты */

            /* Часы */
            /* /Часы */

            /* Центральная заливка */
            pen = new Pen(clrBackGround);
            rect = new Rectangle(0 - this.Width / 2 + 25, 0 - this.Height / 2 + 25, this.Width-50, this.Height - 50);
            e.Graphics.DrawPie(pen, rect, 0, 360);
            e.Graphics.FillPie(new SolidBrush(clrBackGround), rect, 0, 360);
            /* /Центральная заливка */

            /* Текс */
            String strTime = String.Format("{0}", this.seconds);
            StringFormat strFrmt = new StringFormat();
            strFrmt.LineAlignment = StringAlignment.Center;
            strFrmt.Alignment = StringAlignment.Center;
            e.Graphics.RotateTransform(90);
            e.Graphics.DrawString(strTime, new Font("Aria", 22), new SolidBrush(clrSeconds), rect, strFrmt);
            /* /Текст */
        }
    }
}

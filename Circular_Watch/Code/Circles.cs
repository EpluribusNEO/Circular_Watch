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
            seconds = 45;
            minutes = 38;
            hours = 8;

            clrSeconds = Color.Red;//FromArgb(255, 250, 120, 158);
            clrMinutes = Color.Green;
            clrHours   = Color.Blue;
 
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

            e.Graphics.TranslateTransform(this.Width / 2, this.Height / 2);
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.RotateTransform(-90);


            /* Центральная заливка */
            pen = new Pen(clrBackGround);
            rect = new Rectangle(0 - this.Width / 2, 0 - this.Height / 2, this.Width, this.Height);
            e.Graphics.DrawPie(pen, rect, 0, 360);
            e.Graphics.FillPie(new SolidBrush(clrBackGround), rect, 0, 360);
            /* /Центральная заливка */

            /* Секунды */
            pen = new Pen(clrSeconds, 10);
            rect = new Rectangle(0 - this.Width / 2 + 10, 0 - this.Height / 2 + 10, this.Width - 20, this.Height - 20);
            e.Graphics.DrawArc(pen, rect, 0, (int)(this.seconds * 6));
            //e.Graphics.DrawPie(pen, rect, 0, (int)(this.seconds * 6));
            //e.Graphics.FillPie(new SolidBrush(clrSeconds), rect, 0, (int)(this.seconds * 6));
            /* /Секунды */

            /* Минуты */
            pen = new Pen(clrMinutes, 10);
            rect = new Rectangle(0 - this.Width / 2 + 22, 0 - this.Height / 2 + 22, this.Width - 44, this.Height - 44);
            e.Graphics.DrawArc(pen, rect, 0, (int)(this.minutes * 6));
            //e.Graphics.DrawPie(pen, rect, 0, (int)(this.minutes*6));
            //e.Graphics.FillPie(new SolidBrush(clrMinutes), rect, 0, (int)(this.minutes * 6));
            /* /Минуты */

            /* Часы */
            pen = new Pen(clrHours, 10);
            rect = new Rectangle(0 - this.Width / 2 + 34, 0 - this.Height / 2 + 34, this.Width - 68, this.Height - 68);
            e.Graphics.DrawArc(pen, rect, 0, (int)(this.hours * 15));
            //e.Graphics.DrawPie(pen, rect, 0, (int)(this.hours * 15));
            //e.Graphics.FillPie(new SolidBrush(clrHours), rect, 0, (int)(this.hours * 15));
            /* /Часы */

            

            /* Текс */
            String strTime = String.Format("{0}:{1}:{2}", this.hours,this.minutes,this.seconds);
            StringFormat strFrmt = new StringFormat();
            strFrmt.LineAlignment = StringAlignment.Center;
            strFrmt.Alignment = StringAlignment.Center;
            e.Graphics.RotateTransform(90);
            e.Graphics.DrawString(strTime, new Font("Aria", 22), new SolidBrush(clrSeconds), rect, strFrmt);
            /* /Текст */
        }
    }
}

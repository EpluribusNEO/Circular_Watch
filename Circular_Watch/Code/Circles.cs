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
        private Color clrText;
        private Color clrBackGround;

        Pen pen;
        Rectangle rect;

        public Circles()
        {
            seconds = 0;
            minutes = 0;
            hours = 0;

            clrSeconds = Color.FromArgb(255, 255, 50, 90);
            clrMinutes = Color.FromArgb(255, 50, 190, 90);
            clrHours   = Color.FromArgb(255, 50, 150, 200); ;
            clrText = Color.FromArgb(255, 250, 50, 120);
            clrBackGround = Color.Black;
            
            InitializeComponent();

            this.TimeTick();
        }


        public void UpdateTime(int hours, int minutes, int seconds)
        {
            this.seconds = seconds;
            this.minutes = minutes;
            this.hours   = hours;

            this.Invalidate();
        }

        private void Circles_Paint(object sender, PaintEventArgs e)
        {

            /* общие настройки */
            e.Graphics.TranslateTransform(this.Width / 2, this.Height / 2);
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.RotateTransform(-90);
            /* /общие настройки */

            /* Центральная заливка */
            pen = new Pen(clrBackGround);
            rect = new Rectangle(0 - this.Width / 2+5, 0 - this.Height / 2+5, this.Width-10, this.Height-10);
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
            int h = this.hours;
            if ( h > 12)
                h = h - 12;
            e.Graphics.DrawArc(pen, rect, 0, (int)(h * 30));
            //e.Graphics.DrawPie(pen, rect, 0, (int)(this.hours * 15));
            //e.Graphics.FillPie(new SolidBrush(clrHours), rect, 0, (int)(this.hours * 15));
            /* /Часы */

            /* Текс */
            String strTime = String.Format("{0}:{1}:{2}", formatTime(this.hours), formatTime(this.minutes), formatTime(this.seconds));
            StringFormat strFrmt = new StringFormat();
            strFrmt.LineAlignment = StringAlignment.Center;
            strFrmt.Alignment = StringAlignment.Center;
            e.Graphics.RotateTransform(90);
            e.Graphics.DrawString(strTime, new Font("Aria", 20, FontStyle.Bold), new SolidBrush(clrText), rect, strFrmt);
            /* /Текст */
        }

        public void TimeTick()
        {
            hours = DateTime.Now.Hour;
            minutes = DateTime.Now.Minute;
            seconds = DateTime.Now.Second;
            
            this.UpdateTime(hours,minutes,seconds);
            this.Invalidate();
        }

        private string formatTime(int time)
        {
            string res;
            if (time < 10)
                res = "0" + time.ToString();
            else
                res = time.ToString();
            
            return res; 
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Circular_Watch
{
    public partial class frmMain : Form
    {
        private bool _isMouseDown = false;
        private Point _mouseoffset;
        private bool isWindHiden;

        public frmMain()
        {
            InitializeComponent();

            TheTimer.Enabled = true;
            this.ShowInTaskbar = false;
            this.notifyIcon.Visible = true;
            this.isWindHiden = false;

            /* Разместить окно в нужном месте, при старте */
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(SystemInformation.VirtualScreen.Width - this.Width-20,
                SystemInformation.VirtualScreen.Height - this.Height - 50);
        }

        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            // Форма System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            System.Drawing.Drawing2D.GraphicsPath shape;
            shape = new System.Drawing.Drawing2D.GraphicsPath(); 
            shape.AddEllipse(0, 0, this.Width, this.Height);
            this.Region = new System.Drawing.Region(shape);
            // /Форма

            System.Drawing.Drawing2D.GraphicsPath shapeCircle;
            shapeCircle = new System.Drawing.Drawing2D.GraphicsPath();
            shapeCircle.AddEllipse(0, 0, this.circles1.Width, this.circles1.Height);
            this.circles1.Region = new System.Drawing.Region(shapeCircle);
        }

        private void TheTimer_Tick(object sender, EventArgs e)
        {
            this.circles1.TimeTick();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            TheTimer.Enabled = !TheTimer.Enabled;
        }

        private void circles1_DoubleClick(object sender, EventArgs e)
        {
            OverAllForms();
        }

        private void frmMain_MouseDown(object sender, MouseEventArgs e)
        {
            int xOffset;
            int yOffset;

            if(e.Button == MouseButtons.Left)
            {
                xOffset = -e.X - SystemInformation.FrameBorderSize.Width;
                yOffset = -e.Y - SystemInformation.CaptionHeight - SystemInformation.FrameBorderSize.Height;
                _mouseoffset = new Point(xOffset, yOffset);
                _isMouseDown = true;
            }
        }

        private void frmMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (_isMouseDown)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(_mouseoffset.X, _mouseoffset.Y);
                Location = mousePos;
            }
        }

        private void frmMain_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _isMouseDown = false;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void overAllFormsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OverAllForms();
            
        }

        private void OverAllForms()
        {
            this.TopMost = !this.TopMost;
            if(this.TopMost)
                this.overAllFormsToolStripMenuItem.Text = "Under forms";
            else
                this.overAllFormsToolStripMenuItem.Text = "Over forms";

        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.TheTimer.Enabled = false;
            this.notifyIcon.Visible = false;
        }

        private void hideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.isWindHiden)
            {
                this.Show();
                this.hideToolStripMenuItem.Text = "Hide";

            }
            else
            {
                this.Hide();
                this.hideToolStripMenuItem.Text = "Show";
            }
            this.isWindHiden = !this.isWindHiden;
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            hideToolStripMenuItem_Click(sender, e);
        }
    }
}

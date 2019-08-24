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
        public frmMain()
        {
            //TopMost = true;
            InitializeComponent();

            TheTimer.Enabled = true;
        }

        private void TheTimer_Tick(object sender, EventArgs e)
        {
            this.circles1.TimeTick();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            TheTimer.Enabled = !TheTimer.Enabled;
        }

    }
}

namespace Circular_Watch
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.TheTimer = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.myMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.overAllFormsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transparentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.circles1 = new Circular_Watch.Code.Circles();
            this.myMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // TheTimer
            // 
            this.TheTimer.Interval = 500;
            this.TheTimer.Tick += new System.EventHandler(this.TheTimer_Tick);
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.myMenuStrip;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Watch";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // myMenuStrip
            // 
            this.myMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.overAllFormsToolStripMenuItem,
            this.hideToolStripMenuItem,
            this.transparentToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.myMenuStrip.Name = "myMenuStrip";
            this.myMenuStrip.Size = new System.Drawing.Size(138, 98);
            // 
            // overAllFormsToolStripMenuItem
            // 
            this.overAllFormsToolStripMenuItem.Name = "overAllFormsToolStripMenuItem";
            this.overAllFormsToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.overAllFormsToolStripMenuItem.Text = "Over forms";
            this.overAllFormsToolStripMenuItem.Click += new System.EventHandler(this.overAllFormsToolStripMenuItem_Click);
            // 
            // hideToolStripMenuItem
            // 
            this.hideToolStripMenuItem.Name = "hideToolStripMenuItem";
            this.hideToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.hideToolStripMenuItem.Text = "Hide";
            this.hideToolStripMenuItem.Click += new System.EventHandler(this.hideToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(134, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // transparentToolStripMenuItem
            // 
            this.transparentToolStripMenuItem.Name = "transparentToolStripMenuItem";
            this.transparentToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.transparentToolStripMenuItem.Text = "Transparent";
            this.transparentToolStripMenuItem.Click += new System.EventHandler(this.transparentToolStripMenuItem_Click);
            // 
            // circles1
            // 
            this.circles1.BackColor = System.Drawing.Color.Black;
            this.circles1.Location = new System.Drawing.Point(3, 3);
            this.circles1.Name = "circles1";
            this.circles1.Size = new System.Drawing.Size(200, 200);
            this.circles1.TabIndex = 0;
            this.circles1.DoubleClick += new System.EventHandler(this.circles1_DoubleClick);
            this.circles1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseDown);
            this.circles1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseMove);
            this.circles1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseUp);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(206, 206);
            this.Controls.Add(this.circles1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Watch";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseDown);
            this.myMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Code.Circles circles1;
        private System.Windows.Forms.Timer TheTimer;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip myMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem overAllFormsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hideToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem transparentToolStripMenuItem;
    }
}


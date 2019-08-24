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
            this.circles1 = new Circular_Watch.Code.Circles();
            this.SuspendLayout();
            // 
            // circles1
            // 
            this.circles1.Location = new System.Drawing.Point(12, 12);
            this.circles1.Name = "circles1";
            this.circles1.Size = new System.Drawing.Size(200, 200);
            this.circles1.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 339);
            this.Controls.Add(this.circles1);
            this.Name = "frmMain";
            this.Text = "Watch";
            this.ResumeLayout(false);

        }

        #endregion

        private Code.Circles circles1;
    }
}


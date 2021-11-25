
namespace CarServiceCenter
{
    partial class JobCardmain
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
            this.Bottom = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Header = new System.Windows.Forms.Panel();
            this.Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // Bottom
            // 
            this.Bottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Bottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Bottom.Location = new System.Drawing.Point(0, 100);
            this.Bottom.Name = "Bottom";
            this.Bottom.Size = new System.Drawing.Size(1096, 657);
            this.Bottom.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1096, 94);
            this.label1.TabIndex = 0;
            this.label1.Text = "Job Card";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(148)))), ((int)(((byte)(0)))));
            this.Header.Controls.Add(this.label1);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(1096, 100);
            this.Header.TabIndex = 0;
            // 
            // JobCardmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 757);
            this.Controls.Add(this.Bottom);
            this.Controls.Add(this.Header);
            this.Name = "JobCardmain";
            this.Text = "Job_Card";
            this.Load += new System.EventHandler(this.JobCardmain_Load);
            this.Header.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Bottom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Header;
    }
}

namespace CarServiceCenter
{
    partial class PaymentItemAdd
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
            this.Top = new System.Windows.Forms.Panel();
            this.Bottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // Bottom
            // 
            this.Bottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(148)))), ((int)(((byte)(0)))));
            this.Bottom.Controls.Add(this.label1);
            this.Bottom.Dock = System.Windows.Forms.DockStyle.Top;
            this.Bottom.Location = new System.Drawing.Point(0, 0);
            this.Bottom.Name = "Bottom";
            this.Bottom.Size = new System.Drawing.Size(679, 94);
            this.Bottom.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(679, 94);
            this.label1.TabIndex = 0;
            this.label1.Text = "AddItems";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Top
            // 
            this.Top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Top.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Top.Location = new System.Drawing.Point(0, 94);
            this.Top.Name = "Top";
            this.Top.Size = new System.Drawing.Size(679, 655);
            this.Top.TabIndex = 1;
            this.Top.Paint += new System.Windows.Forms.PaintEventHandler(this.Top_Paint);
            // 
            // PaymentItemAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 749);
            this.Controls.Add(this.Top);
            this.Controls.Add(this.Bottom);
            this.Name = "PaymentItemAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PaymentItemAdd";
            this.Bottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Bottom;
        private System.Windows.Forms.Panel Top;
        private System.Windows.Forms.Label label1;
    }
}
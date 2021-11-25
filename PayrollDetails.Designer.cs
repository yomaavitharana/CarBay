
namespace CarServiceCenter
{
    partial class PayrollDetails
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtxtotal = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            this.txtempid = new System.Windows.Forms.TextBox();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.txtbouns = new System.Windows.Forms.TextBox();
            this.txtOtHrs = new System.Windows.Forms.TextBox();
            this.txtbasicSalary = new System.Windows.Forms.TextBox();
            this.emptxt = new System.Windows.Forms.Label();
            this.bstxt = new System.Windows.Forms.Label();
            this.othtxt = new System.Windows.Forms.Label();
            this.bontxt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProviderEmpId = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderBasicSalary = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderOtHrs = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderBonus = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderTotal = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEmpId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderBasicSalary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderOtHrs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderBonus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTotal)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.txtxtotal);
            this.panel1.Controls.Add(this.txtDate);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnsave);
            this.panel1.Controls.Add(this.txtempid);
            this.panel1.Controls.Add(this.txttotal);
            this.panel1.Controls.Add(this.txtbouns);
            this.panel1.Controls.Add(this.txtOtHrs);
            this.panel1.Controls.Add(this.txtbasicSalary);
            this.panel1.Controls.Add(this.emptxt);
            this.panel1.Controls.Add(this.bstxt);
            this.panel1.Controls.Add(this.othtxt);
            this.panel1.Controls.Add(this.bontxt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(427, 518);
            this.panel1.TabIndex = 0;
            // 
            // txtxtotal
            // 
            this.txtxtotal.AutoSize = true;
            this.txtxtotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txtxtotal.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtxtotal.ForeColor = System.Drawing.Color.White;
            this.txtxtotal.Location = new System.Drawing.Point(69, 312);
            this.txtxtotal.Name = "txtxtotal";
            this.txtxtotal.Size = new System.Drawing.Size(39, 16);
            this.txtxtotal.TabIndex = 55;
            this.txtxtotal.Text = "Total";
            this.txtxtotal.Click += new System.EventHandler(this.txtxtotal_Click);
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(188, 340);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(178, 20);
            this.txtDate.TabIndex = 53;
            this.txtDate.ValueChanged += new System.EventHandler(this.txtDate_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(69, 345);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 52;
            this.label2.Text = "Date";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnsave
            // 
            this.btnsave.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnsave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnsave.FlatAppearance.BorderSize = 3;
            this.btnsave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnsave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsave.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.Color.White;
            this.btnsave.Location = new System.Drawing.Point(166, 386);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(58, 28);
            this.btnsave.TabIndex = 51;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtempid
            // 
            this.txtempid.Location = new System.Drawing.Point(188, 163);
            this.txtempid.Name = "txtempid";
            this.txtempid.Size = new System.Drawing.Size(178, 20);
            this.txtempid.TabIndex = 46;
            this.txtempid.TextChanged += new System.EventHandler(this.txtempid_TextChanged);
            this.txtempid.Validating += new System.ComponentModel.CancelEventHandler(this.txtempid_Validating);
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(188, 308);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(178, 20);
            this.txttotal.TabIndex = 50;
            this.txttotal.TextChanged += new System.EventHandler(this.txttot_TextChanged);
            this.txttotal.Validating += new System.ComponentModel.CancelEventHandler(this.txttotal_Validating);
            // 
            // txtbouns
            // 
            this.txtbouns.Location = new System.Drawing.Point(188, 274);
            this.txtbouns.Name = "txtbouns";
            this.txtbouns.Size = new System.Drawing.Size(178, 20);
            this.txtbouns.TabIndex = 49;
            this.txtbouns.TextChanged += new System.EventHandler(this.txtbo_TextChanged);
            this.txtbouns.Validating += new System.ComponentModel.CancelEventHandler(this.txtbouns_Validating);
            // 
            // txtOtHrs
            // 
            this.txtOtHrs.Location = new System.Drawing.Point(188, 237);
            this.txtOtHrs.Name = "txtOtHrs";
            this.txtOtHrs.Size = new System.Drawing.Size(178, 20);
            this.txtOtHrs.TabIndex = 48;
            this.txtOtHrs.TextChanged += new System.EventHandler(this.txtoth_TextChanged);
            this.txtOtHrs.Validating += new System.ComponentModel.CancelEventHandler(this.txtOtHrs_Validating);
            // 
            // txtbasicSalary
            // 
            this.txtbasicSalary.Location = new System.Drawing.Point(188, 198);
            this.txtbasicSalary.Name = "txtbasicSalary";
            this.txtbasicSalary.Size = new System.Drawing.Size(178, 20);
            this.txtbasicSalary.TabIndex = 47;
            this.txtbasicSalary.TextChanged += new System.EventHandler(this.txtbs_TextChanged);
            this.txtbasicSalary.Validating += new System.ComponentModel.CancelEventHandler(this.txtbasicSalary_Validating);
            // 
            // emptxt
            // 
            this.emptxt.AutoSize = true;
            this.emptxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.emptxt.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emptxt.ForeColor = System.Drawing.Color.White;
            this.emptxt.Location = new System.Drawing.Point(69, 163);
            this.emptxt.Name = "emptxt";
            this.emptxt.Size = new System.Drawing.Size(88, 16);
            this.emptxt.TabIndex = 40;
            this.emptxt.Text = "Employee ID";
            this.emptxt.Click += new System.EventHandler(this.label4_Click);
            // 
            // bstxt
            // 
            this.bstxt.AutoSize = true;
            this.bstxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.bstxt.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bstxt.ForeColor = System.Drawing.Color.White;
            this.bstxt.Location = new System.Drawing.Point(69, 202);
            this.bstxt.Name = "bstxt";
            this.bstxt.Size = new System.Drawing.Size(87, 16);
            this.bstxt.TabIndex = 41;
            this.bstxt.Text = "Basic Salary";
            this.bstxt.Click += new System.EventHandler(this.bstxt_Click);
            // 
            // othtxt
            // 
            this.othtxt.AutoSize = true;
            this.othtxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.othtxt.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.othtxt.ForeColor = System.Drawing.Color.White;
            this.othtxt.Location = new System.Drawing.Point(69, 241);
            this.othtxt.Name = "othtxt";
            this.othtxt.Size = new System.Drawing.Size(66, 16);
            this.othtxt.TabIndex = 42;
            this.othtxt.Text = "OT Hours";
            this.othtxt.Click += new System.EventHandler(this.othtxt_Click);
            // 
            // bontxt
            // 
            this.bontxt.AutoSize = true;
            this.bontxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.bontxt.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bontxt.ForeColor = System.Drawing.Color.White;
            this.bontxt.Location = new System.Drawing.Point(69, 278);
            this.bontxt.Name = "bontxt";
            this.bontxt.Size = new System.Drawing.Size(47, 16);
            this.bontxt.TabIndex = 44;
            this.bontxt.Text = "Bonus";
            this.bontxt.Click += new System.EventHandler(this.bontxt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(140, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 41);
            this.label1.TabIndex = 3;
            this.label1.Text = "Details";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // errorProviderEmpId
            // 
            this.errorProviderEmpId.ContainerControl = this;
            // 
            // errorProviderBasicSalary
            // 
            this.errorProviderBasicSalary.ContainerControl = this;
            // 
            // errorProviderOtHrs
            // 
            this.errorProviderOtHrs.ContainerControl = this;
            // 
            // errorProviderBonus
            // 
            this.errorProviderBonus.ContainerControl = this;
            // 
            // errorProviderTotal
            // 
            this.errorProviderTotal.ContainerControl = this;
            // 
            // PayrollDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 516);
            this.Controls.Add(this.panel1);
            this.Name = "PayrollDetails";
            this.Text = "PayrollDetails";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEmpId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderBasicSalary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderOtHrs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderBonus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTotal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label emptxt;
        private System.Windows.Forms.Label bstxt;
        private System.Windows.Forms.Label othtxt;
        private System.Windows.Forms.Label bontxt;
        private System.Windows.Forms.TextBox txtempid;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.TextBox txtbouns;
        private System.Windows.Forms.TextBox txtOtHrs;
        private System.Windows.Forms.TextBox txtbasicSalary;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.DateTimePicker txtDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtxtotal;
        private System.Windows.Forms.ErrorProvider errorProviderEmpId;
        private System.Windows.Forms.ErrorProvider errorProviderBasicSalary;
        private System.Windows.Forms.ErrorProvider errorProviderOtHrs;
        private System.Windows.Forms.ErrorProvider errorProviderBonus;
        private System.Windows.Forms.ErrorProvider errorProviderTotal;
    }
}
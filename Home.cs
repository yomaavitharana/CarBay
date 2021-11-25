using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarServiceCenter
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
           
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            Right.Controls.Add(childForm);
            Right.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
        private void button4_Click(object sender, EventArgs e)
        {
            openChildForm(new EmployeeMain());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new JobCardmain());
        }

        private void Right_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            openChildForm(new Paymentmain());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildForm(new CustomerMain());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openChildForm(new SupplierMain());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            openChildForm(new InventoryMain());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            openChildForm(new PayrollMain());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            openChildForm(new FinanceMain());
        }

		private void panel2_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}

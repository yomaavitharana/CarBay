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
    public partial class PayrollDetails : Form
    {
        private readonly PayrollMain _parent;
        private readonly int sid;
        public string  empID, otHrs, basicSal, bonus, total;
        internal string date;

        public PayrollDetails(PayrollMain parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        
        public void UpdateInfo()
        {
            label1.Text = "Update Details";
            btnsave.Text = "Update";
            txtempid.Text =empID;
            txtOtHrs.Text = otHrs;
            txtbasicSalary.Text = basicSal;
            txtbouns.Text = bonus;
            txttotal.Text = empID;


        }

        public void SaveInfo()
        {
            label1.Text = "Add Details";
            btnsave.Text = "Save";
        }
        public void Clear()
        {
            txtempid.Text = txtbasicSalary.Text = txtOtHrs.Text = txtbouns.Text = txttotal.Text = string.Empty;
        }

        private void txtempid_TextChanged(object sender, EventArgs e)
        {

        }

        private void txttot_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtxtotal_Click(object sender, EventArgs e)
        {

        }

        private void bstxt_Click(object sender, EventArgs e)
        {

        }

        private void othtxt_Click(object sender, EventArgs e)
        {

        }

        private void bontxt_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //validation
        private void txtempid_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtempid.Text.Trim()))
            {
                errorProviderEmpId.SetError(txtempid, "ID is required.");
            }
            else
            {
                errorProviderEmpId.SetError(txtempid, string.Empty);
            }
        }

        private void txtbasicSalary_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtbasicSalary.Text.Trim()))
            {
                errorProviderEmpId.SetError(txtbasicSalary, "Basic Salary is required.");
            }
        
            else
            {
                errorProviderEmpId.SetError(txtbasicSalary, string.Empty);
            }

        }

        private void txtOtHrs_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtOtHrs.Text.Trim()))
            {
                errorProviderOtHrs.SetError(txtOtHrs, "OTHours are required.");
            }

            else
            {
                errorProviderOtHrs.SetError(txtOtHrs, string.Empty);
            }
        }

        private void txtbouns_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtbouns.Text.Trim()))
            {
                errorProviderBonus.SetError(txtbouns, "Bonus required.");
            }

            else
            {
                errorProviderBonus.SetError(txtbouns, string.Empty);
            }
        }

        private void txttotal_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txttotal.Text.Trim()))
            {
                errorProviderTotal.SetError(txttotal, "Total required.");
            }

            else
            {
                errorProviderTotal.SetError(txttotal, string.Empty);
            }
        
        }

        private void txtoth_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbs_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            



            if (String.IsNullOrEmpty(txtempid.Text))
            {
                MessageBox.Show("Employee ID is Empty (>1).");
                return;
            }
            if (String.IsNullOrEmpty(txtbasicSalary.Text))
            {
                MessageBox.Show("Basic Salary is Empty (>1).");
                return;
            }
            if (String.IsNullOrEmpty(txtOtHrs.Text))
            {
                MessageBox.Show("OT Hours is Empty (>1).");
                return;
            }
            if (String.IsNullOrEmpty(txtbouns.Text))
            {
                MessageBox.Show("Bonus is Empty (>1).");
                return;
            }
            if (String.IsNullOrEmpty(txttotal.Text))
            {
                MessageBox.Show("Total is Empty (>1).");
                return;
            }
            if (btnsave.Text == "Save") //insert
            {
                PayrollModel pay = new PayrollModel(int.Parse(txtempid.Text.Trim()), 0, double.Parse(txtbasicSalary.Text.Trim()), int.Parse(txtOtHrs.Text.Trim()), double.Parse(txtbouns.Text.Trim()), DateTime.Parse(txtDate.Text.Trim()), double.Parse(txttotal.Text.Trim()));
                PayrollModel.AddPayroll(pay);
                Clear();
                //                    }
                //    if(btnsave.Text == "Update")
                //    {
                //        //PayrollModel pay = new PayrollModel(int.Parse(txtempid.Text.Trim()), 0, double.Parse(txtbasicSalary.Text.Trim()), int.Parse(txtOtHrs.Text.Trim()), double.Parse(txtbouns.Text.Trim()), DateTime.Parse(txtDate.Text.Trim()), double.Parse(txtTotal.Text.Trim()));
                //        //PayrollModel.AddPayroll(pay ,sid);

            }
            _parent.Display();

            //}

            //private void tottxt_Click(object sender, EventArgs e)
            //{

        }
    }
}

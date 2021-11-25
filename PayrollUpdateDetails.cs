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
    public partial class PayrollUpdateDetails : Form //update
    {
        private int sid;
        public PayrollUpdateDetails(int empID, int sid, double basicSalary,double bonus,double total, DateTime date, int otHours)
        {
            InitializeComponent();
            textempid.Text = empID.ToString();
            this.sid = sid;
            textbasicsalary.Text = basicSalary.ToString();
            textbonus.Text = bonus.ToString();
            texttotal.Text = total.ToString();
            textdate.Text = date.ToString();
            textOtHrs.Text = otHours.ToString();



        }

        private void btnupdate_Click(object sender, EventArgs e)
        {

            
            int otHours = Convert.ToInt32(textOtHrs.Text);
            double basicSalary = Convert.ToDouble(textbasicsalary.Text);
            double bonus = Convert.ToDouble(textbonus.Text);
            double total = Convert.ToDouble(texttotal.Text);
            DateTime date = Convert.ToDateTime(textdate.Text);
            int empId = Convert.ToInt32(textempid.Text);
            PayrollModel payrollModel = new PayrollModel(empId, sid, basicSalary, otHours, bonus, date, total);
            PayrollModel.UpdatePayroll(payrollModel);

            

        }

        private void Textbasicsalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            // accept numbers / decimals/ floats
            Console.WriteLine("INSIDE KEYPRESS");
            //char ch = e.KeyChar;


            //if (ch == 46 && textbasicsalary.Text.IndexOf('.') != -1)
            //{
            //    e.Handled = true;
            //    return;
            //}

            //if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            //{
            //    e.Handled = true;
            //}


        }

        private void textbasicsalary_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine("INSIDE TEXT CHANGE");
        }
    }
}

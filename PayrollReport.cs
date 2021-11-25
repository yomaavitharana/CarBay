using Microsoft.Reporting.WinForms;
using MySql.Data.MySqlClient;
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
    public partial class PayrollReport : Form
    {
        public PayrollReport()
        {
            InitializeComponent();
        }

        public PayrollReport(ReadOnlySpan<char> readOnlySpan)
        {
           
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            PayrollMain Pay = new PayrollMain();
            Pay.Show();
            //DBConnection.GetConnection();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PayrollReport_Load(object sender, EventArgs e)
        {
            this.payroleTableAdapter.Fill(this.carservicecenterDataSet.payrole);
            this.reportViewer1.RefreshReport();
           
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load_1(object sender, EventArgs e)
        {

        }

        private void btnsearch1_Click(object sender, EventArgs e) //retrieve
        {
            DateTime fromDateValue = this.fromDate.Value.Date;
            Console.WriteLine("FROM VALUE : " +  fromDateValue);
            string sql = "Select * from payrole where date = @from";


            try
            {
                MySqlConnection MyConn2 = DBConnection.GetConnection();
                MySqlCommand MyCommand2 = new MySqlCommand(sql, MyConn2);
                MyCommand2.Parameters.AddWithValue("@from", fromDateValue);

                DataTable dataTable = new DataTable();
                dataTable.Load(MyCommand2.ExecuteReader());


                ReportDataSource reportDataSource = new ReportDataSource("PayRoleDataSet", dataTable);
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                this.reportViewer1.LocalReport.Refresh();
                this.reportViewer1.RefreshReport();

               MyConn2.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("No data. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

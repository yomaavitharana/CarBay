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
    public partial class PayrollMain : Form
    {


        PayrollDetails form;
        public PayrollMain()
        {
            InitializeComponent();
           
            string sql = "Select * from payrole";
            //  MySqlConnection con = DBConnection.GetConnection().CreateCommand();


            try
            {
                MySqlConnection MyConn2 = DBConnection.GetConnection();
                MySqlCommand MyCommand2 = new MySqlCommand(sql, MyConn2);
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();
                mySqlDataAdapter.SelectCommand = MyCommand2;
                DataTable dataTable = new DataTable();
                mySqlDataAdapter.Fill(dataTable);
                dataGridView.DataSource = dataTable;
                MyConn2.Close();
            }
            catch (MySqlException ex) //error
            {
                MessageBox.Show("No data. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            
        }

            public void Display()
        {
            //DBConnection.DisplayAndSearch("SELECT sid,basicSal,bonus, total, data, empID FROM Payrole", dataGridView);
        }

      
      
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "Select * from payrole";
            //  MySqlConnection con = DBConnection.GetConnection().CreateCommand();


            try
            {
                MySqlConnection MyConn2 = DBConnection.GetConnection();
                MySqlCommand MyCommand2 = new MySqlCommand(sql, MyConn2);
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();
                mySqlDataAdapter.SelectCommand = MyCommand2;
                DataTable dataTable = new DataTable();
                mySqlDataAdapter.Fill(dataTable);
                dataGridView.DataSource = dataTable;
                MyConn2.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("No data. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e) //search
        {
            if(txtsearch.Text.Trim() != null && txtsearch.Text.Length != 0)
            {
                int searchBySid = (int)Int64.Parse(txtsearch.Text);
                string sql = "Select * from payrole where sid like @sid";
                //  MySqlConnection con = DBConnection.GetConnection().CreateCommand();


                try
                {
                    MySqlConnection MyConn2 = DBConnection.GetConnection();
                    MySqlCommand MyCommand2 = new MySqlCommand(sql, MyConn2);
                    MyCommand2.Parameters.AddWithValue("@sid", searchBySid);
                    MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();
                    mySqlDataAdapter.SelectCommand = MyCommand2;

                    DataTable dataTable = new DataTable();
                    mySqlDataAdapter.Fill(dataTable);
                    dataGridView.DataSource = dataTable;
                    MyConn2.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("No data. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                txtsearch.Text = "";
                Refresh.PerformClick();
            }
               
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
          
        }

        private void btnview_Click(object sender, EventArgs e)
        {
            PayrollReport form = new PayrollReport();
            form.ShowDialog();
        }

        private void btngeneratepay_Click(object sender, EventArgs e)
        {

            PayrollDetails form = new PayrollDetails(this);
            form.ShowDialog();
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            
               

            
        }

        private void btndelete_Click(object sender, EventArgs e)
        {

        }

        int sid;
        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int sid;
               
     
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int sid;

            if (e.ColumnIndex == 0)
            {
                Console.WriteLine("INSIDE EDIT");


                sid = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString());
                int otHours = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString());
                double basicSalary = Convert.ToDouble(dataGridView.Rows[e.RowIndex].Cells[4].Value.ToString());
                double bonus = Convert.ToDouble(dataGridView.Rows[e.RowIndex].Cells[5].Value.ToString());
                double total = Convert.ToDouble(dataGridView.Rows[e.RowIndex].Cells[6].Value.ToString());
                DateTime date = Convert.ToDateTime(dataGridView.Rows[e.RowIndex].Cells[7].Value.ToString());
                int empId = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells[8].Value.ToString());

                PayrollUpdateDetails updateView = new PayrollUpdateDetails(empId, sid, basicSalary, bonus, total, date, otHours);
                updateView.ShowDialog();



            }
            else if (e.ColumnIndex == 1)
            {
                Console.WriteLine("INSIDE DELETE"); //delete


                sid = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString());
             
                PayrollModel.DeletePayroll(sid);
                Refresh.PerformClick();
            }


        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void txtsearch_KeyPress(object sender, KeyPressEventArgs e) 
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }


        }

        private void PayrollMain_Load(object sender, EventArgs e)
        {

        }
       

    }
}

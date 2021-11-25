using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarServiceCenter
{
    class PayrollModel
    {
        public PayrollModel(int employeeID, int payrollID, double basicSalary, int oTHours, double bonus, DateTime date, double total)
        {
            EmployeeID = employeeID;
            PayrollID = payrollID;
            BasicSalary = basicSalary;
            OTHours = oTHours;
            Bonus = bonus;
            Date = date;
            Total = total;
        }

        public int EmployeeID { get; set; }

        public int PayrollID { get; set; }

        public double BasicSalary { get; set; }

        public int OTHours { get; set; }

        public double Bonus { get; set; }

        public DateTime Date { get; set; }

        public double Total { get; set; }

        //Insert
        public static void AddPayroll(PayrollModel pay)
        {
            string sql = "INSERT INTO Payrole(otHrs,basicSal,bonus,total,date,empID) VALUES(@otHrs, @basicsal, @bonus, @total, @date, @empID)";
          //  MySqlConnection con = DBConnection.GetConnection().CreateCommand();
            MySqlCommand cmd = DBConnection.GetConnection().CreateCommand();
            cmd.CommandText = sql;
            //cmd.Parameters.Add("@sid", MySqlDbType.Int16).Value = pay.PayrollID;
            cmd.Parameters.Add("@otHrs", MySqlDbType.Int64).Value = pay.OTHours;
            cmd.Parameters.Add("@basicsal", MySqlDbType.Double).Value = pay.BasicSalary;
            cmd.Parameters.Add("@bonus", MySqlDbType.Double).Value = pay.Bonus;
            cmd.Parameters.Add("@total", MySqlDbType.Double).Value = pay.Total;
            cmd.Parameters.Add("@date", MySqlDbType.DateTime).Value = pay.Date;
            cmd.Parameters.Add("@empID", MySqlDbType.Int64).Value = pay.EmployeeID;



            /* cmd.Parameters.AddWithValue("@otHrs", pay.OTHours);
             cmd.Parameters.AddWithValue("@basicsal",pay.BasicSalary);
             cmd.Parameters.AddWithValue("@bonus", pay.Bonus);
             cmd.Parameters.AddWithValue("@total", pay.Total);
             cmd.Parameters.AddWithValue("@date", pay.Date);
             cmd.Parameters.AddWithValue("@empID", pay.EmployeeID);*/


            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added pay Employee.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Pay bill not Insert. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cmd.Connection.Close();
            }
           
        }

        public static void UpdatePayroll (PayrollModel pay)
        {
           
       


            try
            {
                string sql = "UPDATE Payrole SET sid=@sid, otHrs=@otHrs, basicSal=@basicsal, bonus=@bonus, total=@total, date=@date, empID=@empID WHERE sid =@sid";
                MySqlConnection MyConn2 = DBConnection.GetConnection();
                MySqlCommand MyCommand2 = new MySqlCommand(sql, MyConn2);
                MySqlDataReader MyReader2;

                MyCommand2.CommandType = CommandType.Text;
                MyCommand2.Parameters.AddWithValue("@sid", pay.PayrollID);
                MyCommand2.Parameters.AddWithValue("@otHrs",  pay.OTHours);
                MyCommand2.Parameters.AddWithValue("@basicsal", pay.BasicSalary);
                MyCommand2.Parameters.AddWithValue("@bonus",  pay.Bonus);
                MyCommand2.Parameters.AddWithValue("@total", pay.Total);
                MyCommand2.Parameters.AddWithValue("@date", pay.Date);
                MyCommand2.Parameters.AddWithValue("@empID",  pay.EmployeeID);

                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Data Updated");
                while (MyReader2.Read())
                {

                }
                MyConn2.Close();//Connection closed here  

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("No data. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        public static void DeletePayroll(int sid)
        {
            try
            {
                string sql = "DELETE FROM Payrole WHERE sid=@sid";
                MySqlConnection MyConn2 = DBConnection.GetConnection();
                MySqlCommand MyCommand2 = new MySqlCommand(sql, MyConn2);
                MySqlDataReader MyReader2;

                MyCommand2.CommandType = CommandType.Text;
                MyCommand2.Parameters.AddWithValue("@sid", sid);
              

                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Record Deleted");
                while (MyReader2.Read())
                {

                }
                MyConn2.Close();//Connection closed here  

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("No data. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        ////Update
        //public static void UpdatePayroll(PayrollModel pay, int sid)
        //{
        //string sql = "UPDATE Payrole SET PayrollID=@sid, OTHours=@otHrs, BasicSalary=@basicsal, Bonus=@bonus, Total=@total, Date=@date, EmployeeID=@empID WHERE PayrollID =@sid)";

        //cmd.CommandType = CommandType.Text;
        //    cmd.Parameters.Add("@sid", MySqlDbType.Int16).Value = pay.PayrollID;
        //    cmd.Parameters.Add("@otHrs", MySqlDbType.Int16).Value = pay.OTHours;
        //    cmd.Parameters.Add("@basicsal", MySqlDbType.Double).Value = pay.BasicSalary;
        //    cmd.Parameters.Add("@bonus", MySqlDbType.Double).Value = pay.Bonus;
        //    cmd.Parameters.Add("@total", MySqlDbType.VarChar).Value = pay.Total;
        //    cmd.Parameters.Add("@date", MySqlDbType.DateTime).Value = pay.Date;
        //    cmd.Parameters.Add("@empID", MySqlDbType.Int16).Value = pay.EmployeeID;

        //    try
        //    {
        //        cmd.ExecuteNonQuery();
        //        MessageBox.Show("Updated pay Employee.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //    catch (MySqlException ex)
        //    {
        //        MessageBox.Show("Pay bill not Update. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    con.Close();


        //public static void DeletePayroll(PayrollModel pay, int sid)
        //{
        //    string sql = "DELETE FROM Payrole WHERE PayrollID=@sid";
        //    MySqlConnection con = DBConnection.GetConnection();
        //    MySqlCommand cmd = new MySqlCommand(sql, con);
        //    cmd.CommandType = CommandType.Text;
        //    cmd.Parameters.Add("@sid", MySqlDbType.Int16).Value =pay.PayrollID;

        //    try
        //    {
        //        cmd.ExecuteNonQuery();
        //        MessageBox.Show("Deleted pay Employee.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //    catch (MySqlException ex)
        //    {
        //        MessageBox.Show("pay bill not Delete. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    con.Close();

        //}

        //public static void DisplayAndSearch(string query, DataGridView dgv)
        //{
        //    string sql = query;
        //    MySqlConnection con = DBConnection.GetConnection();
        //    MySqlCommand cmd = new MySqlCommand(sql, con);
        //    MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
        //    DataTable tb1 = new DataTable();
        //    adp.Fill(tb1);
        //    con.Close();


        //}

        // }
    }
}



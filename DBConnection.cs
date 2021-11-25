using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnitsNet;

namespace CarServiceCenter
{
     class DBConnection
    {

        public static MySqlConnection GetConnection() 
        {
            String sql = "datasource=localhost;port=3306;username=root;password=1234;database=CarServiceCenter";
            MySqlConnection con = new MySqlConnection(sql);
            try
            {
                con.Open();
                Console.WriteLine(con.State.ToString());
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MySQl Connection  \n" + ex.Message, "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            return con;
        }

                  
     }

   }

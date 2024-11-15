using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace IM_System
{
    public class Database
    {
        public static string constring = "Data Source=LAPTOP-QIU652T7\\SQLEXPRESS;Integrated Security=True";
        public static SqlConnection con = new SqlConnection(constring);
        private SqlCommand com = new SqlCommand();
        public Database()
        {
            Open();
        }

        private void Open()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }
        private void Close()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

        public void Execute(string query)
        {
            try
            {
                com = new SqlCommand(query, con);
                if (com.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("query executed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("FAILED! error : " + ex.Message);
            }
            finally
            {
                Close();
            }
        }

        public DataTable dtfill (string command)
        {
            Open();
            com = new SqlCommand(command, con);
            SqlDataAdapter ada = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            Close();
            return dt;
        }
    }
}


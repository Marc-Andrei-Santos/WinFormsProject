using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace IM_System
{
    public partial class SalesModule : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-QIU652T7\SQLEXPRESS;Integrated Security=True");
        SqlCommand com = new SqlCommand();
        public SalesModule()
        {
            InitializeComponent();
        }

        private void orderTXTBOX2_TextChanged(object sender, EventArgs e)
        {

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            Clear();
            clearButton.Enabled = true;
        }
        public void Clear()
        {
            
            salesTXTBOX1.Clear();
            salesTXTBOX2.Clear();
            salesTXTBOX3.Clear();
            month.Items.Clear();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to add this report?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    com = new SqlCommand("INSERT INTO Sales_db (Month,Day,Year,Sales)VALUES(@month,@day,@year,@sales)", con);
                    com.Parameters.AddWithValue("@month", month.Text);
                    com.Parameters.AddWithValue("@day", salesTXTBOX1.Text);
                    com.Parameters.AddWithValue("@year", salesTXTBOX2.Text);
                    com.Parameters.AddWithValue("@sales", salesTXTBOX3.Text);
                    con.Open();
                    com.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Report has been added.");
                    Clear();
                    this.Hide();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Exit2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

       
    }
}


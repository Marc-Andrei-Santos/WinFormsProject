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
    public partial class CustomerModule : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-QIU652T7\SQLEXPRESS;Integrated Security=True");
        SqlCommand com = new SqlCommand();


        public CustomerModule()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

            
            try
            {
                if (MessageBox.Show("Are you sure you want to save this user?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    com = new SqlCommand("INSERT INTO Customers_db (CustomerID,Name,Address,MobileNumber)VALUES(@CustomerID,@Name,@Address,@MobileNum)", con);
                    com.Parameters.AddWithValue("@CustomerID", textBox1.Text);
                    com.Parameters.AddWithValue("@Name", textBox2.Text);
                    com.Parameters.AddWithValue("@Address", textBox3.Text);
                    com.Parameters.AddWithValue("@MobileNum", textBox4.Text);
                    con.Open();
                    com.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Your record has been saved.");
                    Clear();
                    this.Hide();
                    
                }


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void clearButton_Click(object sender, EventArgs e)
        {
            Clear();
            clearButton.Enabled = true;
        }

        
        public void Clear()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void closebutton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Exit2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}

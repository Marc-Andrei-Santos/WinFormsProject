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
    public partial class UserModuleForm : Form
    {
        SqlConnection SqlCon = new SqlConnection(@"Data Source=LAPTOP-QIU652T7\SQLEXPRESS;Integrated Security=True");
        SqlCommand SqlCom = new SqlCommand();
       
        public UserModuleForm()
        {
            InitializeComponent();
           
        }
        



            private void closebutton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to save this account?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SqlCon.Open();
                    SqlCom = new SqlCommand("INSERT INTO Accounts_db(Username,Fullname,Password,MobileNumber) VALUES(@username,@fullname,@password,@mobilenum)", SqlCon);
                    SqlCom.Parameters.AddWithValue("@username", accTXTBOX1.Text);
                    SqlCom.Parameters.AddWithValue("@fullname", accTXTBOX2.Text);
                    SqlCom.Parameters.AddWithValue("@password", accTXTBOX3.Text);
                    SqlCom.Parameters.AddWithValue("@mobilenum", accTXTBOX4.Text);
                    SqlCom.ExecuteNonQuery();
                    SqlCon.Close();
                    MessageBox.Show("Your account has been saved.");
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
            accTXTBOX1.Clear();
            accTXTBOX2.Clear();
            accTXTBOX3.Clear();
            accTXTBOX4.Clear();
        }

       

        private void UserModule_Load(object sender, EventArgs e)
        {

        }

        private void Exit2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}


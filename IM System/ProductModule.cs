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
    public partial class ProductModule : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-QIU652T7\SQLEXPRESS;Integrated Security=True");
        SqlCommand com = new SqlCommand();
        public ProductModule()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to add this product?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    com = new SqlCommand("INSERT INTO Products_db (ProductID,Product_Name,Quantity,Price)VALUES(@ProductID,@Product_Name,@Quantity,@Price)", con);
                    com.Parameters.AddWithValue("@ProductID", prodTXTBOX1.Text);
                    com.Parameters.AddWithValue("@Product_Name", prodTXTBOX2.Text);
                    com.Parameters.AddWithValue("@Quantity", prodTXTBOX3.Text);
                    com.Parameters.AddWithValue("@Price", prodTXTBOX4.Text);
                    con.Open();
                    com.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Product has been saved.");
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
            prodTXTBOX1.Clear();
            prodTXTBOX2.Clear();
            prodTXTBOX3.Clear();
            prodTXTBOX4.Clear();
        }

        private void Exit2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}

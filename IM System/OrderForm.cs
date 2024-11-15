using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IM_System
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            Database db = new Database();
            dataGridView1.DataSource = db.dtfill("SELECT Product_Name,Quantity,Price FROM Products_db");
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Database db = new Database();
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                string itemname = row.Cells["Product_Name"].Value.ToString();
                string quantity = row.Cells["Quantity"].Value.ToString();
                string price = row.Cells["Price"].Value.ToString();

                int updatedQuantity = int.Parse(quantity) - 1;
                row.Cells["Quantity"].Value = updatedQuantity.ToString();
                

                dataGridView2.Rows.Add(itemname, "1", price);
            }

        }
        private void dataGridView2_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            t = 0;
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                if (dataGridView2.Rows[i].Cells[2].Value != null)
                {
                    if (double.TryParse(dataGridView2.Rows[i].Cells[2].Value.ToString(), out result))
                    {
                        t += result;
                    }
                }
            }
            label2.Text = t.ToString("F2");
        }
        public double t = 0.00, result;

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ordREMOVE_Click(object sender, EventArgs e)
        {
            try
            {
                if(dataGridView2.SelectedCells.Count > 0)
                {
                    int selectedRowIndex = dataGridView2.SelectedCells[0].RowIndex;
                    dataGridView2.Rows.RemoveAt(selectedRowIndex);
                }
                else
                {
                    MessageBox.Show("You don't have an order that can be removed. Please select your order first.");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ordCHECKOUT_Click(object sender, EventArgs e)
        {
            string[] namevalues = new string[dataGridView2.Rows.Count];
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                if(dataGridView2.Rows[i].Cells[0].Value != null)
                {
                    namevalues[i] = dataGridView2.Rows[i].Cells[0].Value.ToString();
                }
            }
            string set = "";
            foreach(string arr in namevalues)
            {
                set += arr + ",";
            }
            string title = "Receipt";
            string receipt = $"PRODUCTS : '" + set + "'\nTotal Amount : '" + label2.Text + "'";
            MessageBox.Show(receipt, title);
            dataGridView2.Rows.Clear();
        }

        private void dataGridView2_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            t = 0.00;
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                if (dataGridView2.Rows[i].Cells[2].Value != null)
                {
                    if (double.TryParse(dataGridView2.Rows[i].Cells[2].Value.ToString(), out result))
                    {
                        t += result;
                    }
                }
            }
            label2.Text = t.ToString("F2");
        }
    }
}

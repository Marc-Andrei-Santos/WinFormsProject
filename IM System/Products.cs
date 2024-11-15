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
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
            displayRecords();
        }
        private void displayRecords()
        {
            Database db = new Database();
            dgvCUST.DataSource = db.dtfill("SELECT * FROM Products_db");
            dgvCUST.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Products_Load(object sender, EventArgs e)
        {
            timer3.Start();
        }

        private void dgvPRODUCT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
         


        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
           

        }

        private void prodADD_Click(object sender, EventArgs e)
        {
            new OrderForm().Show();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            displayRecords();
            timer3.Start();
        }

        private void prodUPDATE_Click(object sender, EventArgs e)
        {
           
    }

        private void dgvCUST_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

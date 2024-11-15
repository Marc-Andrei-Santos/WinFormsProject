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
    public partial class Sales : Form
    {
        public Sales()
        {
            InitializeComponent();
            displayRecords();
            timer5.Start();
        }
            private void displayRecords()
        {
            Database db = new Database();
            dgvSales.DataSource = db.dtfill("SELECT * FROM Sales_db");
            dgvSales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            displayRecords();
            timer5.Start();
        }

 
        private void reportADD_Click(object sender, EventArgs e)
        {
            new SalesModule().Show();
        }
    }
}

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
    public partial class Customers : Form
    {

        SqlConnection SqlCon = new SqlConnection(@"Data Source=LAPTOP-QIU652T7\SQLEXPRESS;Integrated Security=True");
        SqlCommand SqlCom = new SqlCommand();
        SqlDataReader dr;
        public Customers()
        {
            InitializeComponent();
            displayRecords();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            this.Hide();
        }
        private void displayRecords()
        {
            Database db = new Database();
            dgvCUST.DataSource = db.dtfill("SELECT * FROM Customers_db");
            dgvCUST.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new CustomerModule().Show();
            timer2.Start();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void dgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Customers_Load(object sender, EventArgs e)
        {
            timer2.Start();
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            displayRecords();
            timer2.Start();
        }

        private void dgvCUST_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

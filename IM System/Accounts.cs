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
    public partial class Accounts : Form
    {

        SqlConnection SqlCon = new SqlConnection(@"Data Source=LAPTOP-QIU652T7\SQLEXPRESS;Integrated Security=True");
        SqlCommand SqlCom = new SqlCommand();
        SqlDataReader dr;

        public Accounts()
        {
            InitializeComponent();
            displayRecords();
          
        }

        private void displayRecords()
        {
            Database db = new Database();
            dgvACC.DataSource = db.dtfill("SELECT * FROM Accounts_db");
            dgvACC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void addBUTTON_Click(object sender, EventArgs e)
        {
            new UserModuleForm().Show();

        }

        private void Accounts_Load(object sender, EventArgs e)
        {
            displayRecords();
            timer1.Start();
             
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            displayRecords();
            timer1.Start();

        }

        private void accDELETE_Click(object sender, EventArgs e)
        {

        }

        private void dgvACC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvACC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        }
    }


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
    public partial class Orders : Form
    {
        public Orders()
        {
            InitializeComponent();
            displayRecords();
            timer4.Start();
        }

        private void displayRecords()
        {
            string query = "SELECT * FROM Orders_db";
            Database db = new Database();
            dgvORDER.DataSource = db.dtfill(query);
        }
       
        private void timer4_Tick(object sender, EventArgs e)
        {
            displayRecords();
            timer4.Start();
        }
    }
}

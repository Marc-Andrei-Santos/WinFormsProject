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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }



        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Create_Click(object sender, EventArgs e)
        {
            
        }
           

        private void CreateHere_Click(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void closebutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    }

       
    



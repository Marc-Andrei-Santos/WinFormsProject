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
    public partial class Form2 : Form
    {
       

        public Form2()
        {
            InitializeComponent();
            Minimized2 = new PictureBox();
            Minimized2.Text = "Minimize";
            Minimized2.Location = new Point(1233, 730);
            Minimized2.Click += new EventHandler(Minimized2_Click);
            Controls.Add(Minimized2);

            panel4.Height = userBUTTON.Height;
            panel4.Top = userBUTTON.Top;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void closebutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Customers_Click(object sender, EventArgs e)
        {
            new Customers().Show();
            this.Hide();
        }
        private void accBUTTON_Click(object sender, EventArgs e)
        {
            Accounts acc = new Accounts();
            acc.TopLevel = false;
            panel5.Controls.Add(acc);
            acc.BringToFront();
            acc.Show();
            //
            panel4.Height = userBUTTON.Height;
            panel4.Top = userBUTTON.Top;
        }

        private void prodBUTTON_Click(object sender, EventArgs e)
        {
            Products prod = new Products();
            prod.TopLevel = false;
            panel5.Controls.Add(prod);
            prod.BringToFront();
            prod.Show();
            //
            panel4.Height = userBUTTON.Height;
            panel4.Top = userBUTTON.Top;
        }


        private void custBUTTON_Click(object sender, EventArgs e)
        {
            Customers cust = new Customers();
            cust.TopLevel = false;
            panel5.Controls.Add(cust);
            cust.BringToFront();
            cust.Show();
            //
            panel4.Height = custBUTTON.Height;
            panel4.Top = custBUTTON.Top;
        }
        private void Exit2_Click(object sender, EventArgs e)
        {

            try
            {
                if (MessageBox.Show("Are you sure you want to Exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Application.Exit();
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            
        }

        private void logoutBUTTON_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to Logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    new Form1().Show();
                    this.Hide();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void salesBUTTON_Click(object sender, EventArgs e)
        {
            Sales sa = new Sales();
            sa.TopLevel = false;
            panel5.Controls.Add(sa);
            sa.BringToFront();
            sa.Show();
            //
            panel4.Height = salesBUTTON.Height;
            panel4.Top = salesBUTTON.Top;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void Minimized2_Click(object sender, EventArgs e)
        {
            Minimized2.Location = new Point(1233, 730);
            this.WindowState = FormWindowState.Minimized;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
            label2.Text = DateTime.Now.ToLongDateString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Form2 f = new Form2();
            Products p = new Products();
            OrderForm of = new OrderForm();
            while(of.Visible == true)
            {
                f.Hide();
                p.Hide();
            }
        }
    }
}

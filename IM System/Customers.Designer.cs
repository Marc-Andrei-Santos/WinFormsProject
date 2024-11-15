namespace IM_System
{
    partial class Customers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.custADD = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCUSTOMER = new System.Windows.Forms.DataGridView();
            this.dgvCUST = new System.Windows.Forms.DataGridView();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCUSTOMER)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCUST)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.custADD);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 709);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1105, 84);
            this.panel1.TabIndex = 46;
            // 
            // custADD
            // 
            this.custADD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.custADD.BackColor = System.Drawing.Color.DarkGreen;
            this.custADD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.custADD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.custADD.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.custADD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.custADD.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custADD.ForeColor = System.Drawing.Color.White;
            this.custADD.Location = new System.Drawing.Point(724, 11);
            this.custADD.Margin = new System.Windows.Forms.Padding(4);
            this.custADD.Name = "custADD";
            this.custADD.Size = new System.Drawing.Size(352, 63);
            this.custADD.TabIndex = 38;
            this.custADD.Text = "Add Customers";
            this.custADD.UseVisualStyleBackColor = false;
            this.custADD.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 28);
            this.label1.TabIndex = 42;
            this.label1.Text = "Manage Customers";
            // 
            // dgvCUSTOMER
            // 
            this.dgvCUSTOMER.BackgroundColor = System.Drawing.Color.White;
            this.dgvCUSTOMER.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCUSTOMER.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCUSTOMER.ColumnHeadersHeight = 40;
            this.dgvCUSTOMER.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCUSTOMER.EnableHeadersVisualStyles = false;
            this.dgvCUSTOMER.Location = new System.Drawing.Point(0, 0);
            this.dgvCUSTOMER.Name = "dgvCUSTOMER";
            this.dgvCUSTOMER.ReadOnly = true;
            this.dgvCUSTOMER.RowTemplate.Height = 24;
            this.dgvCUSTOMER.Size = new System.Drawing.Size(1105, 709);
            this.dgvCUSTOMER.TabIndex = 47;
            this.dgvCUSTOMER.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUser_CellContentClick);
            // 
            // dgvCUST
            // 
            this.dgvCUST.AllowUserToAddRows = false;
            this.dgvCUST.AllowUserToDeleteRows = false;
            this.dgvCUST.AllowUserToResizeColumns = false;
            this.dgvCUST.AllowUserToResizeRows = false;
            this.dgvCUST.BackgroundColor = System.Drawing.Color.White;
            this.dgvCUST.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCUST.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCUST.ColumnHeadersHeight = 40;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCUST.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCUST.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCUST.EnableHeadersVisualStyles = false;
            this.dgvCUST.Location = new System.Drawing.Point(0, 0);
            this.dgvCUST.Name = "dgvCUST";
            this.dgvCUST.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCUST.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCUST.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgvCUST.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvCUST.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Red;
            this.dgvCUST.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvCUST.RowTemplate.Height = 24;
            this.dgvCUST.Size = new System.Drawing.Size(1105, 709);
            this.dgvCUST.TabIndex = 49;
            this.dgvCUST.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCUST_CellContentClick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1100;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 793);
            this.Controls.Add(this.dgvCUST);
            this.Controls.Add(this.dgvCUSTOMER);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Customers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customers";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCUSTOMER)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCUST)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button custADD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCUSTOMER;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.DataGridView dgvCUST;
    }
}
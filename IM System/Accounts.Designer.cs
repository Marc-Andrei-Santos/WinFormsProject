namespace IM_System
{
    partial class Accounts
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.accADD = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvACC = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvACC)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.accADD);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 709);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1105, 84);
            this.panel1.TabIndex = 47;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // accADD
            // 
            this.accADD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.accADD.BackColor = System.Drawing.Color.DarkGreen;
            this.accADD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.accADD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.accADD.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.accADD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.accADD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accADD.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accADD.ForeColor = System.Drawing.Color.White;
            this.accADD.Location = new System.Drawing.Point(722, 11);
            this.accADD.Margin = new System.Windows.Forms.Padding(4);
            this.accADD.Name = "accADD";
            this.accADD.Size = new System.Drawing.Size(352, 63);
            this.accADD.TabIndex = 38;
            this.accADD.Text = "Add User";
            this.accADD.UseVisualStyleBackColor = false;
            this.accADD.Click += new System.EventHandler(this.addBUTTON_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(32, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 28);
            this.label1.TabIndex = 42;
            this.label1.Text = "Manage Users";
            // 
            // dgvACC
            // 
            this.dgvACC.BackgroundColor = System.Drawing.Color.White;
            this.dgvACC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvACC.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvACC.ColumnHeadersHeight = 40;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvACC.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvACC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvACC.EnableHeadersVisualStyles = false;
            this.dgvACC.Location = new System.Drawing.Point(0, 0);
            this.dgvACC.Name = "dgvACC";
            this.dgvACC.ReadOnly = true;
            this.dgvACC.RowTemplate.Height = 24;
            this.dgvACC.Size = new System.Drawing.Size(1105, 709);
            this.dgvACC.TabIndex = 48;
            this.dgvACC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvACC_CellClick);
            this.dgvACC.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvACC_CellContentClick);
            // 
            // timer1
            // 
            this.timer1.Interval = 1100;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Accounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 793);
            this.Controls.Add(this.dgvACC);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Accounts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accounts";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Accounts_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvACC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button accADD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvACC;
        private System.Windows.Forms.Timer timer1;
    }
}
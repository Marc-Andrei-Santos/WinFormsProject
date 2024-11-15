namespace IM_System
{
    partial class Products
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.prodADD = new System.Windows.Forms.Button();
            this.dgvPRODUCT = new System.Windows.Forms.DataGridView();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.dgvCUST = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPRODUCT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCUST)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.prodADD);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 709);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1105, 84);
            this.panel1.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(35, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 28);
            this.label1.TabIndex = 42;
            this.label1.Text = "Products";
            // 
            // prodADD
            // 
            this.prodADD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.prodADD.BackColor = System.Drawing.Color.DarkGreen;
            this.prodADD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.prodADD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.prodADD.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.prodADD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.prodADD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prodADD.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodADD.ForeColor = System.Drawing.Color.White;
            this.prodADD.Location = new System.Drawing.Point(719, 11);
            this.prodADD.Margin = new System.Windows.Forms.Padding(4);
            this.prodADD.Name = "prodADD";
            this.prodADD.Size = new System.Drawing.Size(352, 63);
            this.prodADD.TabIndex = 51;
            this.prodADD.Text = "Order";
            this.prodADD.UseVisualStyleBackColor = false;
            this.prodADD.Click += new System.EventHandler(this.prodADD_Click);
            // 
            // dgvPRODUCT
            // 
            this.dgvPRODUCT.BackgroundColor = System.Drawing.Color.White;
            this.dgvPRODUCT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPRODUCT.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPRODUCT.ColumnHeadersHeight = 40;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPRODUCT.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPRODUCT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPRODUCT.EnableHeadersVisualStyles = false;
            this.dgvPRODUCT.Location = new System.Drawing.Point(0, 0);
            this.dgvPRODUCT.Name = "dgvPRODUCT";
            this.dgvPRODUCT.ReadOnly = true;
            this.dgvPRODUCT.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dgvPRODUCT.RowTemplate.Height = 24;
            this.dgvPRODUCT.Size = new System.Drawing.Size(1105, 709);
            this.dgvPRODUCT.TabIndex = 48;
            this.dgvPRODUCT.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPRODUCT_CellClick);
            this.dgvPRODUCT.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUser_CellContentClick);
            // 
            // timer3
            // 
            this.timer3.Interval = 1100;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // dgvCUST
            // 
            this.dgvCUST.BackgroundColor = System.Drawing.Color.White;
            this.dgvCUST.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCUST.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvCUST.ColumnHeadersHeight = 40;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCUST.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvCUST.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCUST.EnableHeadersVisualStyles = false;
            this.dgvCUST.Location = new System.Drawing.Point(0, 0);
            this.dgvCUST.Name = "dgvCUST";
            this.dgvCUST.ReadOnly = true;
            this.dgvCUST.RowTemplate.Height = 24;
            this.dgvCUST.Size = new System.Drawing.Size(1105, 709);
            this.dgvCUST.TabIndex = 50;
            this.dgvCUST.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCUST_CellContentClick);
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 793);
            this.Controls.Add(this.dgvCUST);
            this.Controls.Add(this.dgvPRODUCT);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Products";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Products";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Products_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPRODUCT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCUST)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPRODUCT;
        private System.Windows.Forms.Button prodADD;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.DataGridView dgvCUST;
    }
}
namespace IM_System
{
    partial class Orders
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
            this.label1 = new System.Windows.Forms.Label();
            this.orderADD = new System.Windows.Forms.Button();
            this.dgvORDER = new System.Windows.Forms.DataGridView();
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvORDER)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.orderADD);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 709);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1105, 84);
            this.panel1.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(32, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 28);
            this.label1.TabIndex = 42;
            this.label1.Text = "Manage Orders";
            // 
            // orderADD
            // 
            this.orderADD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.orderADD.BackColor = System.Drawing.Color.DarkGreen;
            this.orderADD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.orderADD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.orderADD.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.orderADD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orderADD.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderADD.ForeColor = System.Drawing.Color.White;
            this.orderADD.Location = new System.Drawing.Point(719, 11);
            this.orderADD.Margin = new System.Windows.Forms.Padding(4);
            this.orderADD.Name = "orderADD";
            this.orderADD.Size = new System.Drawing.Size(352, 63);
            this.orderADD.TabIndex = 51;
            this.orderADD.Text = "Add Order";
            this.orderADD.UseVisualStyleBackColor = false;
           
            // 
            // dgvORDER
            // 
            this.dgvORDER.BackgroundColor = System.Drawing.Color.White;
            this.dgvORDER.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvORDER.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvORDER.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvORDER.ColumnHeadersHeight = 40;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvORDER.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvORDER.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvORDER.EnableHeadersVisualStyles = false;
            this.dgvORDER.Location = new System.Drawing.Point(0, 0);
            this.dgvORDER.Name = "dgvORDER";
            this.dgvORDER.ReadOnly = true;
            this.dgvORDER.RowTemplate.Height = 24;
            this.dgvORDER.Size = new System.Drawing.Size(1105, 709);
            this.dgvORDER.TabIndex = 51;
            // 
            // timer4
            // 
            this.timer4.Interval = 1100;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 793);
            this.Controls.Add(this.dgvORDER);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Orders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orders";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvORDER)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button orderADD;
        private System.Windows.Forms.DataGridView dgvORDER;
        private System.Windows.Forms.Timer timer4;
    }
}
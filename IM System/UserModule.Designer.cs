namespace IM_System
{
    partial class UserModuleForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Exit2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Users = new System.Windows.Forms.Button();
            this.Orders = new System.Windows.Forms.Button();
            this.Customers = new System.Windows.Forms.Button();
            this.Products = new System.Windows.Forms.Button();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.accTXTBOX1 = new System.Windows.Forms.TextBox();
            this.accTXTBOX2 = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.accTXTBOX3 = new System.Windows.Forms.TextBox();
            this.fullnameLabel = new System.Windows.Forms.Label();
            this.accTXTBOX4 = new System.Windows.Forms.TextBox();
            this.mobileLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Exit2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(63)))), ((int)(((byte)(69)))));
            this.panel1.Controls.Add(this.Exit2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Users);
            this.panel1.Controls.Add(this.Orders);
            this.panel1.Controls.Add(this.Customers);
            this.panel1.Controls.Add(this.Products);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(520, 56);
            this.panel1.TabIndex = 1;
            // 
            // Exit2
            // 
            this.Exit2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit2.BackColor = System.Drawing.Color.Transparent;
            this.Exit2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit2.Image = global::IM_System.Properties.Resources.Screenshot_2023_01_21_141856_removebg_preview__1_;
            this.Exit2.Location = new System.Drawing.Point(476, 2);
            this.Exit2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Exit2.Name = "Exit2";
            this.Exit2.Size = new System.Drawing.Size(44, 34);
            this.Exit2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Exit2.TabIndex = 51;
            this.Exit2.TabStop = false;
            this.Exit2.Click += new System.EventHandler(this.Exit2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 23);
            this.label1.TabIndex = 40;
            this.label1.Text = "Account Module";
            // 
            // Users
            // 
            this.Users.BackColor = System.Drawing.Color.Transparent;
            this.Users.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Users.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Users.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Users.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Users.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Users.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Users.Location = new System.Drawing.Point(979, 83);
            this.Users.Margin = new System.Windows.Forms.Padding(4);
            this.Users.Name = "Users";
            this.Users.Size = new System.Drawing.Size(97, 33);
            this.Users.TabIndex = 47;
            this.Users.Text = "Users";
            this.Users.UseVisualStyleBackColor = false;
            // 
            // Orders
            // 
            this.Orders.BackColor = System.Drawing.Color.Transparent;
            this.Orders.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Orders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Orders.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Orders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Orders.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Orders.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Orders.Location = new System.Drawing.Point(868, 83);
            this.Orders.Margin = new System.Windows.Forms.Padding(4);
            this.Orders.Name = "Orders";
            this.Orders.Size = new System.Drawing.Size(97, 33);
            this.Orders.TabIndex = 46;
            this.Orders.Text = "Orders";
            this.Orders.UseVisualStyleBackColor = false;
            // 
            // Customers
            // 
            this.Customers.BackColor = System.Drawing.Color.Transparent;
            this.Customers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Customers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Customers.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Customers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Customers.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customers.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Customers.Location = new System.Drawing.Point(724, 81);
            this.Customers.Margin = new System.Windows.Forms.Padding(4);
            this.Customers.Name = "Customers";
            this.Customers.Size = new System.Drawing.Size(129, 33);
            this.Customers.TabIndex = 46;
            this.Customers.Text = "Customers";
            this.Customers.UseVisualStyleBackColor = false;
            // 
            // Products
            // 
            this.Products.BackColor = System.Drawing.Color.Transparent;
            this.Products.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Products.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Products.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Products.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Products.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Products.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Products.Location = new System.Drawing.Point(603, 81);
            this.Products.Margin = new System.Windows.Forms.Padding(4);
            this.Products.Name = "Products";
            this.Products.Size = new System.Drawing.Size(97, 33);
            this.Products.TabIndex = 37;
            this.Products.Text = "Products";
            this.Products.UseVisualStyleBackColor = false;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.usernameLabel.Location = new System.Drawing.Point(25, 90);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(121, 23);
            this.usernameLabel.TabIndex = 41;
            this.usernameLabel.Text = "User Name :";
            // 
            // accTXTBOX1
            // 
            this.accTXTBOX1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accTXTBOX1.Location = new System.Drawing.Point(201, 87);
            this.accTXTBOX1.Name = "accTXTBOX1";
            this.accTXTBOX1.Size = new System.Drawing.Size(294, 30);
            this.accTXTBOX1.TabIndex = 42;
            // 
            // accTXTBOX2
            // 
            this.accTXTBOX2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accTXTBOX2.Location = new System.Drawing.Point(201, 139);
            this.accTXTBOX2.Name = "accTXTBOX2";
            this.accTXTBOX2.Size = new System.Drawing.Size(294, 30);
            this.accTXTBOX2.TabIndex = 44;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.passwordLabel.Location = new System.Drawing.Point(25, 195);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(106, 23);
            this.passwordLabel.TabIndex = 43;
            this.passwordLabel.Text = "Password :";
            // 
            // accTXTBOX3
            // 
            this.accTXTBOX3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accTXTBOX3.Location = new System.Drawing.Point(201, 190);
            this.accTXTBOX3.MaxLength = 50;
            this.accTXTBOX3.Name = "accTXTBOX3";
            this.accTXTBOX3.Size = new System.Drawing.Size(294, 30);
            this.accTXTBOX3.TabIndex = 46;
            this.accTXTBOX3.UseSystemPasswordChar = true;
            // 
            // fullnameLabel
            // 
            this.fullnameLabel.AutoSize = true;
            this.fullnameLabel.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullnameLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.fullnameLabel.Location = new System.Drawing.Point(25, 143);
            this.fullnameLabel.Name = "fullnameLabel";
            this.fullnameLabel.Size = new System.Drawing.Size(112, 23);
            this.fullnameLabel.TabIndex = 45;
            this.fullnameLabel.Text = "Full Name :";
            // 
            // accTXTBOX4
            // 
            this.accTXTBOX4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accTXTBOX4.Location = new System.Drawing.Point(201, 239);
            this.accTXTBOX4.MaxLength = 11;
            this.accTXTBOX4.Name = "accTXTBOX4";
            this.accTXTBOX4.Size = new System.Drawing.Size(294, 30);
            this.accTXTBOX4.TabIndex = 48;
            // 
            // mobileLabel
            // 
            this.mobileLabel.AutoSize = true;
            this.mobileLabel.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobileLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.mobileLabel.Location = new System.Drawing.Point(25, 245);
            this.mobileLabel.Name = "mobileLabel";
            this.mobileLabel.Size = new System.Drawing.Size(163, 23);
            this.mobileLabel.TabIndex = 47;
            this.mobileLabel.Text = "Mobile Number :";
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(1)))), ((int)(((byte)(44)))));
            this.saveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.saveButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ForeColor = System.Drawing.Color.White;
            this.saveButton.Location = new System.Drawing.Point(201, 311);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(131, 46);
            this.saveButton.TabIndex = 49;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(1)))), ((int)(((byte)(44)))));
            this.clearButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.clearButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.ForeColor = System.Drawing.Color.White;
            this.clearButton.Location = new System.Drawing.Point(364, 311);
            this.clearButton.Margin = new System.Windows.Forms.Padding(4);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(131, 46);
            this.clearButton.TabIndex = 50;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // UserModuleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 411);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.accTXTBOX4);
            this.Controls.Add(this.mobileLabel);
            this.Controls.Add(this.accTXTBOX3);
            this.Controls.Add(this.fullnameLabel);
            this.Controls.Add(this.accTXTBOX2);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.accTXTBOX1);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserModuleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.UserModule_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Exit2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Users;
        private System.Windows.Forms.Button Orders;
        private System.Windows.Forms.Button Customers;
        private System.Windows.Forms.Button Products;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox accTXTBOX1;
        private System.Windows.Forms.TextBox accTXTBOX2;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox accTXTBOX3;
        private System.Windows.Forms.Label fullnameLabel;
        private System.Windows.Forms.TextBox accTXTBOX4;
        private System.Windows.Forms.Label mobileLabel;
        public System.Windows.Forms.Button saveButton;
        public System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.PictureBox Exit2;
    }
}
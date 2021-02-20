namespace WindowsFormsApplication1
{
    partial class admin_main_menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin_main_menu));
            this.minimize_button = new System.Windows.Forms.Label();
            this.exit_button = new System.Windows.Forms.Label();
            this.welcome = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gradientPanel1 = new WindowsFormsApplication1.GradientPanel();
            this.Reports_button = new System.Windows.Forms.Button();
            this.Log_out_button = new System.Windows.Forms.Button();
            this.Bookings_button = new System.Windows.Forms.Button();
            this.Customer_Inquiry_button = new System.Windows.Forms.Button();
            this.Employee_Inquiry_button = new System.Windows.Forms.Button();
            this.Stock_Inquiry_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Admin_header = new System.Windows.Forms.Label();
            this.employee_pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employee_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // minimize_button
            // 
            this.minimize_button.AutoSize = true;
            this.minimize_button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimize_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.minimize_button.Location = new System.Drawing.Point(518, 7);
            this.minimize_button.Name = "minimize_button";
            this.minimize_button.Size = new System.Drawing.Size(17, 19);
            this.minimize_button.TabIndex = 16;
            this.minimize_button.Text = "_";
            this.minimize_button.Click += new System.EventHandler(this.minimize_button_Click);
            // 
            // exit_button
            // 
            this.exit_button.AutoSize = true;
            this.exit_button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.exit_button.Location = new System.Drawing.Point(541, 7);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(20, 19);
            this.exit_button.TabIndex = 15;
            this.exit_button.Text = "X";
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // welcome
            // 
            this.welcome.AutoSize = true;
            this.welcome.BackColor = System.Drawing.Color.Transparent;
            this.welcome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.welcome.Location = new System.Drawing.Point(106, 71);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(190, 38);
            this.welcome.TabIndex = 17;
            this.welcome.Text = "Because life\'s too short \r\nto rent ordinary cars";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(304, 84);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Angle = 90F;
            this.gradientPanel1.BottomColor = System.Drawing.SystemColors.Desktop;
            this.gradientPanel1.Controls.Add(this.Reports_button);
            this.gradientPanel1.Controls.Add(this.Log_out_button);
            this.gradientPanel1.Controls.Add(this.Bookings_button);
            this.gradientPanel1.Controls.Add(this.Customer_Inquiry_button);
            this.gradientPanel1.Controls.Add(this.Employee_Inquiry_button);
            this.gradientPanel1.Controls.Add(this.Stock_Inquiry_button);
            this.gradientPanel1.Controls.Add(this.label1);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 137);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(568, 413);
            this.gradientPanel1.TabIndex = 19;
            this.gradientPanel1.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            // 
            // Reports_button
            // 
            this.Reports_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Reports_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Reports_button.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reports_button.ForeColor = System.Drawing.Color.White;
            this.Reports_button.Image = ((System.Drawing.Image)(resources.GetObject("Reports_button.Image")));
            this.Reports_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Reports_button.Location = new System.Drawing.Point(74, 274);
            this.Reports_button.Name = "Reports_button";
            this.Reports_button.Size = new System.Drawing.Size(427, 49);
            this.Reports_button.TabIndex = 30;
            this.Reports_button.Text = "Reports";
            this.Reports_button.UseVisualStyleBackColor = false;
            this.Reports_button.Click += new System.EventHandler(this.Reports_button_Click);
            // 
            // Log_out_button
            // 
            this.Log_out_button.BackColor = System.Drawing.Color.PaleVioletRed;
            this.Log_out_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Log_out_button.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Log_out_button.ForeColor = System.Drawing.Color.White;
            this.Log_out_button.Image = ((System.Drawing.Image)(resources.GetObject("Log_out_button.Image")));
            this.Log_out_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Log_out_button.Location = new System.Drawing.Point(438, 352);
            this.Log_out_button.Name = "Log_out_button";
            this.Log_out_button.Size = new System.Drawing.Size(123, 49);
            this.Log_out_button.TabIndex = 23;
            this.Log_out_button.Text = "Logout";
            this.Log_out_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Log_out_button.UseVisualStyleBackColor = false;
            this.Log_out_button.Click += new System.EventHandler(this.Log_out_button_Click);
            // 
            // Bookings_button
            // 
            this.Bookings_button.BackColor = System.Drawing.Color.Firebrick;
            this.Bookings_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Bookings_button.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bookings_button.ForeColor = System.Drawing.Color.White;
            this.Bookings_button.Image = ((System.Drawing.Image)(resources.GetObject("Bookings_button.Image")));
            this.Bookings_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Bookings_button.Location = new System.Drawing.Point(74, 3);
            this.Bookings_button.Name = "Bookings_button";
            this.Bookings_button.Size = new System.Drawing.Size(427, 49);
            this.Bookings_button.TabIndex = 26;
            this.Bookings_button.Text = "Bookings [as Admin]";
            this.Bookings_button.UseVisualStyleBackColor = false;
            this.Bookings_button.Click += new System.EventHandler(this.Bookings_button_Click);
            // 
            // Customer_Inquiry_button
            // 
            this.Customer_Inquiry_button.BackColor = System.Drawing.Color.Chocolate;
            this.Customer_Inquiry_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Customer_Inquiry_button.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customer_Inquiry_button.ForeColor = System.Drawing.Color.White;
            this.Customer_Inquiry_button.Image = ((System.Drawing.Image)(resources.GetObject("Customer_Inquiry_button.Image")));
            this.Customer_Inquiry_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Customer_Inquiry_button.Location = new System.Drawing.Point(74, 74);
            this.Customer_Inquiry_button.Name = "Customer_Inquiry_button";
            this.Customer_Inquiry_button.Size = new System.Drawing.Size(427, 49);
            this.Customer_Inquiry_button.TabIndex = 23;
            this.Customer_Inquiry_button.Text = "Customer Inquiry";
            this.Customer_Inquiry_button.UseVisualStyleBackColor = false;
            this.Customer_Inquiry_button.Click += new System.EventHandler(this.Customer_Inquiry_button_Click);
            // 
            // Employee_Inquiry_button
            // 
            this.Employee_Inquiry_button.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.Employee_Inquiry_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Employee_Inquiry_button.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Employee_Inquiry_button.ForeColor = System.Drawing.Color.White;
            this.Employee_Inquiry_button.Image = ((System.Drawing.Image)(resources.GetObject("Employee_Inquiry_button.Image")));
            this.Employee_Inquiry_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Employee_Inquiry_button.Location = new System.Drawing.Point(74, 141);
            this.Employee_Inquiry_button.Name = "Employee_Inquiry_button";
            this.Employee_Inquiry_button.Size = new System.Drawing.Size(427, 49);
            this.Employee_Inquiry_button.TabIndex = 24;
            this.Employee_Inquiry_button.Text = "Employee Inquiry";
            this.Employee_Inquiry_button.UseVisualStyleBackColor = false;
            this.Employee_Inquiry_button.Click += new System.EventHandler(this.Employee_Inquiry_button_Click);
            // 
            // Stock_Inquiry_button
            // 
            this.Stock_Inquiry_button.BackColor = System.Drawing.Color.Indigo;
            this.Stock_Inquiry_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Stock_Inquiry_button.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stock_Inquiry_button.ForeColor = System.Drawing.Color.White;
            this.Stock_Inquiry_button.Image = ((System.Drawing.Image)(resources.GetObject("Stock_Inquiry_button.Image")));
            this.Stock_Inquiry_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Stock_Inquiry_button.Location = new System.Drawing.Point(74, 207);
            this.Stock_Inquiry_button.Name = "Stock_Inquiry_button";
            this.Stock_Inquiry_button.Size = new System.Drawing.Size(427, 49);
            this.Stock_Inquiry_button.TabIndex = 25;
            this.Stock_Inquiry_button.Text = "Stock Inquiry";
            this.Stock_Inquiry_button.UseVisualStyleBackColor = false;
            this.Stock_Inquiry_button.Click += new System.EventHandler(this.Stock_Inquiry_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(53, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(472, 24);
            this.label1.TabIndex = 29;
            this.label1.Text = "__________________________________________";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(283, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(351, 24);
            this.label4.TabIndex = 20;
            this.label4.Text = "_______________________________";
            // 
            // Admin_header
            // 
            this.Admin_header.AutoSize = true;
            this.Admin_header.BackColor = System.Drawing.Color.Transparent;
            this.Admin_header.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin_header.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Admin_header.Location = new System.Drawing.Point(394, 28);
            this.Admin_header.Name = "Admin_header";
            this.Admin_header.Size = new System.Drawing.Size(126, 48);
            this.Admin_header.TabIndex = 21;
            this.Admin_header.Text = "Admin\r\nMain Menu\r\n";
            // 
            // employee_pictureBox
            // 
            this.employee_pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.employee_pictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("employee_pictureBox.BackgroundImage")));
            this.employee_pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.employee_pictureBox.Location = new System.Drawing.Point(332, 12);
            this.employee_pictureBox.Name = "employee_pictureBox";
            this.employee_pictureBox.Size = new System.Drawing.Size(63, 68);
            this.employee_pictureBox.TabIndex = 22;
            this.employee_pictureBox.TabStop = false;
            // 
            // admin_main_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(568, 550);
            this.Controls.Add(this.employee_pictureBox);
            this.Controls.Add(this.gradientPanel1);
            this.Controls.Add(this.welcome);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.minimize_button);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.Admin_header);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "admin_main_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "admin_main_menu";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.admin_main_menu_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.admin_main_menu_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employee_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label minimize_button;
        private System.Windows.Forms.Label exit_button;
        private System.Windows.Forms.Label welcome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private GradientPanel gradientPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Admin_header;
        private System.Windows.Forms.PictureBox employee_pictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Bookings_button;
        private System.Windows.Forms.Button Customer_Inquiry_button;
        private System.Windows.Forms.Button Employee_Inquiry_button;
        private System.Windows.Forms.Button Stock_Inquiry_button;
        private System.Windows.Forms.Button Log_out_button;
        private System.Windows.Forms.Button Reports_button;
    }
}
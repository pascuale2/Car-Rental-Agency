namespace WindowsFormsApplication1
{
    partial class reports_menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(reports_menu));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.employee_pictureBox = new System.Windows.Forms.PictureBox();
            this.welcome = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Admin_header = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.minimize_button = new System.Windows.Forms.Label();
            this.exit_button = new System.Windows.Forms.Label();
            this.gradientPanel1 = new WindowsFormsApplication1.GradientPanel();
            this.generated_report_label = new System.Windows.Forms.Label();
            this.report_GRID_VIEW = new System.Windows.Forms.DataGridView();
            this.report_clear_button = new System.Windows.Forms.Button();
            this.Reports_button = new System.Windows.Forms.Button();
            this.main_menu_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.report_combo_box = new System.Windows.Forms.ComboBox();
            this.start_date_label = new System.Windows.Forms.Label();
            this.end_date_label = new System.Windows.Forms.Label();
            this.date_panel = new System.Windows.Forms.Panel();
            this.end_date_box = new System.Windows.Forms.DateTimePicker();
            this.start_date_box = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.employee_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.report_GRID_VIEW)).BeginInit();
            this.date_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // employee_pictureBox
            // 
            this.employee_pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.employee_pictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("employee_pictureBox.BackgroundImage")));
            this.employee_pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.employee_pictureBox.Location = new System.Drawing.Point(332, 12);
            this.employee_pictureBox.Name = "employee_pictureBox";
            this.employee_pictureBox.Size = new System.Drawing.Size(63, 68);
            this.employee_pictureBox.TabIndex = 27;
            this.employee_pictureBox.TabStop = false;
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
            this.welcome.TabIndex = 23;
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
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // Admin_header
            // 
            this.Admin_header.AutoSize = true;
            this.Admin_header.BackColor = System.Drawing.Color.Transparent;
            this.Admin_header.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin_header.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Admin_header.Location = new System.Drawing.Point(397, 34);
            this.Admin_header.Name = "Admin_header";
            this.Admin_header.Size = new System.Drawing.Size(262, 33);
            this.Admin_header.TabIndex = 26;
            this.Admin_header.Text = "Reports [as Admin]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(283, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(494, 24);
            this.label4.TabIndex = 25;
            this.label4.Text = "____________________________________________";
            // 
            // minimize_button
            // 
            this.minimize_button.AutoSize = true;
            this.minimize_button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimize_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.minimize_button.Location = new System.Drawing.Point(642, 12);
            this.minimize_button.Name = "minimize_button";
            this.minimize_button.Size = new System.Drawing.Size(17, 19);
            this.minimize_button.TabIndex = 29;
            this.minimize_button.Text = "_";
            this.minimize_button.Click += new System.EventHandler(this.minimize_button_Click);
            // 
            // exit_button
            // 
            this.exit_button.AutoSize = true;
            this.exit_button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.exit_button.Location = new System.Drawing.Point(665, 12);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(20, 19);
            this.exit_button.TabIndex = 28;
            this.exit_button.Text = "X";
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Angle = 90F;
            this.gradientPanel1.BottomColor = System.Drawing.SystemColors.Desktop;
            this.gradientPanel1.Controls.Add(this.generated_report_label);
            this.gradientPanel1.Controls.Add(this.report_GRID_VIEW);
            this.gradientPanel1.Controls.Add(this.report_clear_button);
            this.gradientPanel1.Controls.Add(this.Reports_button);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gradientPanel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 217);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(697, 501);
            this.gradientPanel1.TabIndex = 30;
            this.gradientPanel1.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            // 
            // generated_report_label
            // 
            this.generated_report_label.AutoSize = true;
            this.generated_report_label.BackColor = System.Drawing.Color.Transparent;
            this.generated_report_label.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generated_report_label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.generated_report_label.Location = new System.Drawing.Point(233, 152);
            this.generated_report_label.Name = "generated_report_label";
            this.generated_report_label.Size = new System.Drawing.Size(237, 28);
            this.generated_report_label.TabIndex = 57;
            this.generated_report_label.Text = "Generated Report:";
            // 
            // report_GRID_VIEW
            // 
            this.report_GRID_VIEW.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.report_GRID_VIEW.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.report_GRID_VIEW.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.report_GRID_VIEW.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.report_GRID_VIEW.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.report_GRID_VIEW.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.report_GRID_VIEW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.report_GRID_VIEW.DefaultCellStyle = dataGridViewCellStyle2;
            this.report_GRID_VIEW.Location = new System.Drawing.Point(21, 183);
            this.report_GRID_VIEW.Name = "report_GRID_VIEW";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.report_GRID_VIEW.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.report_GRID_VIEW.Size = new System.Drawing.Size(654, 234);
            this.report_GRID_VIEW.TabIndex = 59;
            // 
            // report_clear_button
            // 
            this.report_clear_button.BackColor = System.Drawing.Color.Firebrick;
            this.report_clear_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.report_clear_button.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.report_clear_button.ForeColor = System.Drawing.Color.White;
            this.report_clear_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.report_clear_button.Location = new System.Drawing.Point(439, 438);
            this.report_clear_button.Name = "report_clear_button";
            this.report_clear_button.Size = new System.Drawing.Size(236, 49);
            this.report_clear_button.TabIndex = 58;
            this.report_clear_button.Text = "Clear";
            this.report_clear_button.UseVisualStyleBackColor = false;
            this.report_clear_button.Click += new System.EventHandler(this.report_clear_button_Click);
            // 
            // Reports_button
            // 
            this.Reports_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Reports_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Reports_button.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reports_button.ForeColor = System.Drawing.Color.White;
            this.Reports_button.Image = ((System.Drawing.Image)(resources.GetObject("Reports_button.Image")));
            this.Reports_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Reports_button.Location = new System.Drawing.Point(21, 438);
            this.Reports_button.Name = "Reports_button";
            this.Reports_button.Size = new System.Drawing.Size(412, 49);
            this.Reports_button.TabIndex = 57;
            this.Reports_button.Text = "Generate Report";
            this.Reports_button.UseVisualStyleBackColor = false;
            this.Reports_button.Click += new System.EventHandler(this.Reports_button_Click);
            // 
            // main_menu_button
            // 
            this.main_menu_button.BackColor = System.Drawing.Color.Maroon;
            this.main_menu_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.main_menu_button.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.main_menu_button.ForeColor = System.Drawing.Color.White;
            this.main_menu_button.Image = ((System.Drawing.Image)(resources.GetObject("main_menu_button.Image")));
            this.main_menu_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.main_menu_button.Location = new System.Drawing.Point(489, 94);
            this.main_menu_button.Name = "main_menu_button";
            this.main_menu_button.Size = new System.Drawing.Size(196, 41);
            this.main_menu_button.TabIndex = 23;
            this.main_menu_button.Text = "Main Menu  ";
            this.main_menu_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.main_menu_button.UseVisualStyleBackColor = false;
            this.main_menu_button.Click += new System.EventHandler(this.main_menu_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(126, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(449, 66);
            this.label1.TabIndex = 31;
            this.label1.Text = "Please select the type of reports \r\n         you want to generate:";
            // 
            // report_combo_box
            // 
            this.report_combo_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.report_combo_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.report_combo_box.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.report_combo_box.ForeColor = System.Drawing.Color.White;
            this.report_combo_box.FormattingEnabled = true;
            this.report_combo_box.Items.AddRange(new object[] {
            "1) Branch ID With The Highest Average Employee Salaries",
            "2) Customers With The Highest Rental Transactions (Regular Customer)",
            "3) Branch ID With The Lowest Rental Transactions ",
            "4) Branch ID With The Most Cars Rented Between Dates (Year):",
            "5) Most Popular Car Rented Out Between Dates (Year):"});
            this.report_combo_box.Location = new System.Drawing.Point(12, 217);
            this.report_combo_box.Name = "report_combo_box";
            this.report_combo_box.Size = new System.Drawing.Size(673, 30);
            this.report_combo_box.TabIndex = 32;
            this.report_combo_box.SelectedIndexChanged += new System.EventHandler(this.report_combo_box_SelectedIndexChanged);
            // 
            // start_date_label
            // 
            this.start_date_label.AutoSize = true;
            this.start_date_label.BackColor = System.Drawing.Color.Transparent;
            this.start_date_label.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_date_label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.start_date_label.Location = new System.Drawing.Point(53, 14);
            this.start_date_label.Name = "start_date_label";
            this.start_date_label.Size = new System.Drawing.Size(116, 24);
            this.start_date_label.TabIndex = 32;
            this.start_date_label.Text = "Start Date:";
            // 
            // end_date_label
            // 
            this.end_date_label.AutoSize = true;
            this.end_date_label.BackColor = System.Drawing.Color.Transparent;
            this.end_date_label.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.end_date_label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.end_date_label.Location = new System.Drawing.Point(59, 62);
            this.end_date_label.Name = "end_date_label";
            this.end_date_label.Size = new System.Drawing.Size(110, 24);
            this.end_date_label.TabIndex = 55;
            this.end_date_label.Text = "End Date:";
            // 
            // date_panel
            // 
            this.date_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.date_panel.Controls.Add(this.end_date_box);
            this.date_panel.Controls.Add(this.start_date_box);
            this.date_panel.Controls.Add(this.end_date_label);
            this.date_panel.Controls.Add(this.start_date_label);
            this.date_panel.Location = new System.Drawing.Point(12, 253);
            this.date_panel.Name = "date_panel";
            this.date_panel.Size = new System.Drawing.Size(673, 100);
            this.date_panel.TabIndex = 57;
            this.date_panel.Visible = false;
            // 
            // end_date_box
            // 
            this.end_date_box.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.end_date_box.Location = new System.Drawing.Point(189, 62);
            this.end_date_box.Name = "end_date_box";
            this.end_date_box.Size = new System.Drawing.Size(408, 27);
            this.end_date_box.TabIndex = 59;
            // 
            // start_date_box
            // 
            this.start_date_box.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_date_box.Location = new System.Drawing.Point(189, 17);
            this.start_date_box.Name = "start_date_box";
            this.start_date_box.Size = new System.Drawing.Size(408, 27);
            this.start_date_box.TabIndex = 58;
            // 
            // reports_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(697, 718);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.minimize_button);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.employee_pictureBox);
            this.Controls.Add(this.report_combo_box);
            this.Controls.Add(this.main_menu_button);
            this.Controls.Add(this.welcome);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Admin_header);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.date_panel);
            this.Controls.Add(this.gradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "reports_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.reports_menu_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.reports_menu_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.employee_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.report_GRID_VIEW)).EndInit();
            this.date_panel.ResumeLayout(false);
            this.date_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox employee_pictureBox;
        private System.Windows.Forms.Label welcome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Admin_header;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label minimize_button;
        private System.Windows.Forms.Label exit_button;
        private GradientPanel gradientPanel1;
        private System.Windows.Forms.Button main_menu_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox report_combo_box;
        private System.Windows.Forms.Label start_date_label;
        private System.Windows.Forms.Label end_date_label;
        private System.Windows.Forms.Button report_clear_button;
        private System.Windows.Forms.Button Reports_button;
        private System.Windows.Forms.Label generated_report_label;
        private System.Windows.Forms.DataGridView report_GRID_VIEW;
        private System.Windows.Forms.Panel date_panel;
        private System.Windows.Forms.DateTimePicker end_date_box;
        private System.Windows.Forms.DateTimePicker start_date_box;
    }
}
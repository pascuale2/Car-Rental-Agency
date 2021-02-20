namespace WindowsFormsApplication1
{
    partial class Documentation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Documentation));
            this.welcome = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.minimize_button = new System.Windows.Forms.Label();
            this.exit_button = new System.Windows.Forms.Label();
            this.axAcroPDF1 = new AxAcroPDFLib.AxAcroPDF();
            this.gradientPanel1 = new WindowsFormsApplication1.GradientPanel();
            this.open_pdf = new System.Windows.Forms.Button();
            this.Employee_header = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.back_main_menu = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).BeginInit();
            this.SuspendLayout();
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
            this.welcome.TabIndex = 2;
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
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // minimize_button
            // 
            this.minimize_button.AutoSize = true;
            this.minimize_button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimize_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.minimize_button.Location = new System.Drawing.Point(947, 12);
            this.minimize_button.Name = "minimize_button";
            this.minimize_button.Size = new System.Drawing.Size(17, 19);
            this.minimize_button.TabIndex = 5;
            this.minimize_button.Text = "_";
            this.minimize_button.Click += new System.EventHandler(this.minimize_button_Click);
            // 
            // exit_button
            // 
            this.exit_button.AutoSize = true;
            this.exit_button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.exit_button.Location = new System.Drawing.Point(970, 12);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(20, 19);
            this.exit_button.TabIndex = 4;
            this.exit_button.Text = "X";
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // axAcroPDF1
            // 
            this.axAcroPDF1.Enabled = true;
            this.axAcroPDF1.Location = new System.Drawing.Point(45, 151);
            this.axAcroPDF1.Name = "axAcroPDF1";
            this.axAcroPDF1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF1.OcxState")));
            this.axAcroPDF1.Size = new System.Drawing.Size(908, 749);
            this.axAcroPDF1.TabIndex = 6;
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Angle = 90F;
            this.gradientPanel1.BottomColor = System.Drawing.SystemColors.Desktop;
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 196);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(1002, 726);
            this.gradientPanel1.TabIndex = 12;
            this.gradientPanel1.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            // 
            // open_pdf
            // 
            this.open_pdf.BackColor = System.Drawing.Color.Olive;
            this.open_pdf.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.open_pdf.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.open_pdf.ForeColor = System.Drawing.Color.White;
            this.open_pdf.Location = new System.Drawing.Point(330, 94);
            this.open_pdf.Name = "open_pdf";
            this.open_pdf.Size = new System.Drawing.Size(305, 51);
            this.open_pdf.TabIndex = 20;
            this.open_pdf.Text = "Open PDF";
            this.open_pdf.UseVisualStyleBackColor = false;
            this.open_pdf.Click += new System.EventHandler(this.open_pdf_Click);
            // 
            // Employee_header
            // 
            this.Employee_header.AutoSize = true;
            this.Employee_header.BackColor = System.Drawing.Color.Transparent;
            this.Employee_header.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Employee_header.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Employee_header.Location = new System.Drawing.Point(322, 12);
            this.Employee_header.Name = "Employee_header";
            this.Employee_header.Size = new System.Drawing.Size(307, 44);
            this.Employee_header.TabIndex = 26;
            this.Employee_header.Text = "Documentation";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(349, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(547, 38);
            this.label1.TabIndex = 27;
            this.label1.Text = "- On How To Use Exxoticar Systems";
            // 
            // back_main_menu
            // 
            this.back_main_menu.BackColor = System.Drawing.Color.Goldenrod;
            this.back_main_menu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.back_main_menu.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_main_menu.ForeColor = System.Drawing.Color.White;
            this.back_main_menu.Location = new System.Drawing.Point(641, 94);
            this.back_main_menu.Name = "back_main_menu";
            this.back_main_menu.Size = new System.Drawing.Size(312, 51);
            this.back_main_menu.TabIndex = 28;
            this.back_main_menu.Text = "Back To Sign-In";
            this.back_main_menu.UseVisualStyleBackColor = false;
            this.back_main_menu.Click += new System.EventHandler(this.back_main_menu_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Documentation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(1002, 922);
            this.Controls.Add(this.back_main_menu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Employee_header);
            this.Controls.Add(this.open_pdf);
            this.Controls.Add(this.axAcroPDF1);
            this.Controls.Add(this.minimize_button);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.welcome);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Documentation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Documentation";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label minimize_button;
        private System.Windows.Forms.Label exit_button;
        private AxAcroPDFLib.AxAcroPDF axAcroPDF1;
        private GradientPanel gradientPanel1;
        private System.Windows.Forms.Button open_pdf;
        private System.Windows.Forms.Label Employee_header;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button back_main_menu;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
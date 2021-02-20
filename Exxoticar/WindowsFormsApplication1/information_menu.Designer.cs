namespace WindowsFormsApplication1
{
    partial class information_menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(information_menu));
            this.welcome = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contact_pictureBox = new System.Windows.Forms.PictureBox();
            this.contact_header = new System.Windows.Forms.Label();
            this.exit_button_info = new System.Windows.Forms.Label();
            this.minimize_button_info = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gradientPanel1 = new WindowsFormsApplication1.GradientPanel();
            this.main_menu_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.information_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contact_pictureBox)).BeginInit();
            this.gradientPanel1.SuspendLayout();
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
            // contact_pictureBox
            // 
            this.contact_pictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("contact_pictureBox.BackgroundImage")));
            this.contact_pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.contact_pictureBox.Location = new System.Drawing.Point(322, 12);
            this.contact_pictureBox.Name = "contact_pictureBox";
            this.contact_pictureBox.Size = new System.Drawing.Size(66, 64);
            this.contact_pictureBox.TabIndex = 6;
            this.contact_pictureBox.TabStop = false;
            // 
            // contact_header
            // 
            this.contact_header.AutoSize = true;
            this.contact_header.BackColor = System.Drawing.Color.Transparent;
            this.contact_header.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contact_header.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.contact_header.Location = new System.Drawing.Point(394, 28);
            this.contact_header.Name = "contact_header";
            this.contact_header.Size = new System.Drawing.Size(127, 48);
            this.contact_header.TabIndex = 3;
            this.contact_header.Text = "Contact\r\nInformation";
            // 
            // exit_button_info
            // 
            this.exit_button_info.AutoSize = true;
            this.exit_button_info.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_button_info.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.exit_button_info.Location = new System.Drawing.Point(541, 12);
            this.exit_button_info.Name = "exit_button_info";
            this.exit_button_info.Size = new System.Drawing.Size(20, 19);
            this.exit_button_info.TabIndex = 7;
            this.exit_button_info.Text = "X";
            this.exit_button_info.Click += new System.EventHandler(this.exit_button_info_Click);
            // 
            // minimize_button_info
            // 
            this.minimize_button_info.AutoSize = true;
            this.minimize_button_info.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimize_button_info.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.minimize_button_info.Location = new System.Drawing.Point(518, 12);
            this.minimize_button_info.Name = "minimize_button_info";
            this.minimize_button_info.Size = new System.Drawing.Size(17, 19);
            this.minimize_button_info.TabIndex = 8;
            this.minimize_button_info.Text = "_";
            this.minimize_button_info.Click += new System.EventHandler(this.minimize_button_info_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(294, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(285, 24);
            this.label4.TabIndex = 16;
            this.label4.Text = "_________________________";
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Angle = 90F;
            this.gradientPanel1.BottomColor = System.Drawing.SystemColors.Desktop;
            this.gradientPanel1.Controls.Add(this.main_menu_button);
            this.gradientPanel1.Controls.Add(this.label2);
            this.gradientPanel1.Controls.Add(this.label1);
            this.gradientPanel1.Controls.Add(this.information_label);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 102);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(567, 400);
            this.gradientPanel1.TabIndex = 10;
            this.gradientPanel1.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            // 
            // main_menu_button
            // 
            this.main_menu_button.BackColor = System.Drawing.Color.Transparent;
            this.main_menu_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("main_menu_button.BackgroundImage")));
            this.main_menu_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.main_menu_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.main_menu_button.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.main_menu_button.ForeColor = System.Drawing.Color.White;
            this.main_menu_button.Location = new System.Drawing.Point(350, 359);
            this.main_menu_button.Name = "main_menu_button";
            this.main_menu_button.Size = new System.Drawing.Size(205, 29);
            this.main_menu_button.TabIndex = 4;
            this.main_menu_button.Text = "Main Menu";
            this.main_menu_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.main_menu_button.UseVisualStyleBackColor = false;
            this.main_menu_button.Click += new System.EventHandler(this.main_menu_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(93, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Reach us At:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(56, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Any Questions and Concerns?";
            // 
            // information_label
            // 
            this.information_label.AutoSize = true;
            this.information_label.BackColor = System.Drawing.Color.Transparent;
            this.information_label.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.information_label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.information_label.Location = new System.Drawing.Point(131, 81);
            this.information_label.Name = "information_label";
            this.information_label.Size = new System.Drawing.Size(226, 286);
            this.information_label.TabIndex = 0;
            this.information_label.Text = "Phone Number:\r\n(123) 987-6543\r\n\r\nFax Number:\r\n1-123-456-7890\r\n\r\nEmail:\r\nexxoticar" +
    "@info.com\r\n\r\nAddress:\r\n10700 104 Ave NW\r\nEdmonton, AB Canada\r\nT5J 4S2";
            // 
            // information_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(567, 502);
            this.Controls.Add(this.minimize_button_info);
            this.Controls.Add(this.exit_button_info);
            this.Controls.Add(this.contact_header);
            this.Controls.Add(this.contact_pictureBox);
            this.Controls.Add(this.welcome);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gradientPanel1);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "information_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "information_menu";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.information_menu_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.information_menu_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contact_pictureBox)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button main_menu_button;
        private System.Windows.Forms.PictureBox contact_pictureBox;
        private System.Windows.Forms.Label contact_header;
        private System.Windows.Forms.Label exit_button_info;
        private System.Windows.Forms.Label minimize_button_info;
        private GradientPanel gradientPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label information_label;
        private System.Windows.Forms.Label label4;
    }
}
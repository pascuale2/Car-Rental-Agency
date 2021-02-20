using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class Main_Menu : Form
    {
        public Main_Menu()
        {
            InitializeComponent();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@SQL_conString.connection_String);
            SqlCommand cmd = new SqlCommand("Select * From LoginInformation where userName = '" + user_login_text_box.Text + "'and password ='" + password_text_box.Text + "'",con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
      
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i]["usertype"].ToString() == "Employee") // IF USER TYPE IS EMPLOYEE
                    {
                        MessageBox.Show("You are logged in as " + dt.Rows[i][3]);
                        employee_main_menu emm = new employee_main_menu();
                        emm.Show();
                        this.Hide();
                        con.Close();
                    }
                    else if (dt.Rows[i]["usertype"].ToString() == "Admin") // IF USER TYPE IS ADMIN
                    {
                        MessageBox.Show("You are logged in as " + dt.Rows[i][3]);
                        admin_main_menu amm = new admin_main_menu();
                        amm.Show();
                        this.Hide();
                        con.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("   ERROR: WRONG USERNAME OR PASSWORD");
            }
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void Main_Menu_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        Point lastPoint;
        private void Main_Menu_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void user_login_text_box_Click(object sender, EventArgs e)
        {
            user_login_text_box.Clear();
            username_label.ForeColor = Color.FromArgb(0, 128, 128);
            user_login_text_box.ForeColor = Color.FromArgb(0, 128, 128);

            password_text_box.ForeColor = Color.WhiteSmoke;
            password_label.ForeColor = Color.WhiteSmoke;
        }

        private void password_text_box_Click(object sender, EventArgs e)
        {
            password_text_box.Clear();
            username_label.ForeColor = Color.WhiteSmoke;
            user_login_text_box.ForeColor = Color.WhiteSmoke;

            password_text_box.ForeColor = Color.FromArgb(0, 128, 128);
            password_label.ForeColor = Color.FromArgb(0, 128, 128);
            password_text_box.PasswordChar = '*';
        }

        private void password_text_box_TextChanged(object sender, EventArgs e)
        {
            password_text_box.PasswordChar = '*';
        }

        private void Question_Button_Click(object sender, EventArgs e)
        {
            Documentation d = new Documentation();
            d.Show();
            this.Hide();
        }
    }
}
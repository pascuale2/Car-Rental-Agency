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
    public partial class employee_inquiry : Form
    {
        public employee_inquiry()
        {
            InitializeComponent();
        }

        private void Admin_menu_Click(object sender, EventArgs e)
        {
            admin_main_menu amm = new admin_main_menu();
            amm.Show();
            this.Hide();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimize_button_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void employee_inquiry_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        Point lastPoint;
        private void employee_inquiry_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void employee_text_box_TextChanged(object sender, EventArgs e)
        {
            employee_text_box.MaxLength = 5;
        }

        private void employee_text_box_Click(object sender, EventArgs e)
        {
            employee_text_box.Clear();
            employee_text_box.ForeColor = Color.FromArgb(0, 128, 128);
            employee_label2.ForeColor = Color.FromArgb(0, 128, 128);
        }

        private void employee_clear_button_Click(object sender, EventArgs e)
        {
            employee_text_box.Text = "[Enter Employee ID]";
            employee_text_box.ForeColor = Color.Gray;
            employee_label2.ForeColor = Color.WhiteSmoke;

            employee_GRID_VIEW.DataSource = null;
            name_box.Text = "";
            branchID_box.Text = "";
            salary_box.Text = "";
            phone_box.Text = "";
        }

        private void employee_search_button_Click(object sender, EventArgs e)
        {
            if ((employee_text_box.Text == "") || (employee_text_box.Text == "[Enter Employee ID]"))
            {
                MessageBox.Show("    ERROR: PLEASE ENTER A VALID DRIVERS LICENSE");
            }
            else
            {
                SqlConnection con = new SqlConnection(@SQL_conString.connection_String);  // calls class which contains the connection string
                SqlCommand cmd = new SqlCommand("Select * From Employees where empID = '" + employee_text_box.Text + "'", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    name_box.Text = dt.Rows[0]["fName"].ToString() + " " + dt.Rows[0]["lName"].ToString();
                    branchID_box.Text = dt.Rows[0]["branchID"].ToString();
                    salary_box.Text = dt.Rows[0]["salary"].ToString();
                    phone_box.Text = dt.Rows[0]["phoneNumber"].ToString();

                    SqlCommand cmd2 = new SqlCommand("Select * From RentalTransactions where authorizingEmpID = '" + employee_text_box.Text + "'", con);
                    SqlDataAdapter sda2 = new SqlDataAdapter(cmd2);
                    DataTable dt2 = new DataTable();
                    sda2.Fill(dt2);

                    if (dt2.Rows.Count > 0)
                    {
                        employee_GRID_VIEW.DataSource = dt2;
                    }
                    else
                    {
                        MessageBox.Show("   NOTE: This Employee Has No Rental Transactions Authorized \n  Under His Name.");
                    }
                }
                else
                {
                    MessageBox.Show("      ERROR: CUSTOMER DOES NOT EXIST");
                }


                con.Close();
            }
        }

        private void search_all_employees_button_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            info.Visible = false;
            back_button.Visible = true;

            employee_search_button.Visible = false;
            employee_clear_button.Visible = false;

            search_all_employees_button.Visible = false;

            employee_text_box.Visible = false;
            employee_label2.Visible = false;
            Customer_label.Visible = false;

            SEARCH_ALL_EMP.Visible = true;
            add_d_emp_button.Visible = false;

            LOG_label.Text = "All Employee INFO";

            SqlConnection con = new SqlConnection(@SQL_conString.connection_String);  // calls class which contains the connection string
            SqlCommand cmd = new SqlCommand("Select * From Employees", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            employee_GRID_VIEW.DataSource = dt;
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            info.Visible = true;
            back_button.Visible = false;

            employee_search_button.Visible = true;
            employee_clear_button.Visible = true;

            search_all_employees_button.Visible = true;

            employee_text_box.Visible = true;
            employee_label2.Visible = true;
            Customer_label.Visible = true;

            SEARCH_ALL_EMP.Visible = false;
            add_d_emp_button.Visible = true;

            LOG_label.Text = "Employee Rental Transactions LOG";
            employee_GRID_VIEW.DataSource = null;
        }

        private void add_d_emp_button_Click(object sender, EventArgs e)
        {
            add_delete_employee_info_admin adeia = new add_delete_employee_info_admin();
            adeia.Show();
            this.Hide();
        }
    }
}

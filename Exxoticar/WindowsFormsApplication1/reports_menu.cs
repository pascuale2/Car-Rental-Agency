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
    public partial class reports_menu : Form
    {
        public reports_menu()
        {
            InitializeComponent();
        }

        private void main_menu_button_Click(object sender, EventArgs e)
        {
            admin_main_menu amm = new admin_main_menu();
            amm.Show();
            this.Hide();
        }

        private void reports_menu_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        Point lastPoint;
        private void reports_menu_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void minimize_button_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //-------------------------------------------------------------------------------------------------------------------------------//
        private void report_combo_box_SelectedIndexChanged(object sender, EventArgs e)
        {   if (report_combo_box.SelectedIndex == 0)
            {
                SqlConnection con = new SqlConnection(@SQL_conString.connection_String);
                con.Open();

                SqlCommand cmd = new SqlCommand(" Select BranchID, avg(salary) as avgSalary FROM Employees GROUP BY branchID; ", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                report_GRID_VIEW.DataSource = dt;
                con.Close();
            }
            if (report_combo_box.SelectedIndex == 3)
            {
                date_panel.Visible = true;
            }
            else if (report_combo_box.SelectedIndex == 4)
            {
                date_panel.Visible = true;
            }
        }

        private void report_clear_button_Click(object sender, EventArgs e) //--------CLEAR BUTTON---------//
        {
            date_panel.Visible = false;
            report_GRID_VIEW.DataSource = null;
            report_combo_box.ResetText();
        }

        private void Reports_button_Click(object sender, EventArgs e)
        {
            if (report_combo_box.Text != "")
            {
                //SQL CODE GOES HERE------------------------------------------------------------------------------//
            }
            if (report_combo_box.SelectedIndex == 3)
            {
                SqlConnection con = new SqlConnection(@SQL_conString.connection_String);
                con.Open();
                SqlCommand cmd = new SqlCommand("  select branchID, count(transID) as countTransID from RentalTransactions where datePicked BETWEEN '" + start_date_box.Value.ToShortDateString() + " ' AND '" + end_date_box.Value.ToShortDateString() + "' group by branchID   order by countTransID DESC ", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                report_GRID_VIEW.DataSource = dt;
                con.Close();
            }

            if (report_combo_box.SelectedIndex == 4)
            {
                SqlConnection con = new SqlConnection(@SQL_conString.connection_String);
                con.Open();
                SqlCommand cmd = new SqlCommand("select model, count(*) as [Num Rented] from RentalTransactions R JOIN Cars C on R.vin = C.vin where datePicked BETWEEN '" + start_date_box.Value.ToShortDateString() + " ' AND '" + end_date_box.Value.ToShortDateString() + "' group by model, R.vin order by count(*) desc; ", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                report_GRID_VIEW.DataSource = dt;
                con.Close();
            }
        }
    }
}

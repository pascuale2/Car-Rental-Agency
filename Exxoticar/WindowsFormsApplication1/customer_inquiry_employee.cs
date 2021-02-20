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
    public partial class customer_inquiry_employee : Form
    {
        public customer_inquiry_employee()
        {
            InitializeComponent();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimize_button_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void customer_text_box_TextChanged(object sender, EventArgs e)
        {
            customer_text_box.MaxLength = 9;
        }

        private void customer_text_box_Click(object sender, EventArgs e)
        {
            customer_text_box.Clear();
            customer_text_box.ForeColor = Color.FromArgb(0, 128, 128);
            customer_label2.ForeColor = Color.FromArgb(0, 128, 128);
        }

        private void customer_search_button_Click(object sender, EventArgs e)
        {
            if ((customer_text_box.TextLength < 9) || (customer_text_box.Text == "") || (customer_text_box.Text == "[Enter Customer Drivers License]"))
            {
                MessageBox.Show("    ERROR: PLEASE ENTER A VALID DRIVERS LICENSE");
            }
            else
            {
                SqlConnection con = new SqlConnection(@SQL_conString.connection_String);  // calls class which contains the connection string
                SqlCommand cmd = new SqlCommand("Select * From Customers where driversLicense = '" + customer_text_box.Text + "'", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    name_box.Text = dt.Rows[0]["fName"].ToString() + " " + dt.Rows[0]["lName"].ToString();
                    gender_box.Text = dt.Rows[0]["gender"].ToString();
                    dob_box.Text = dt.Rows[0]["dob"].ToString();
                    phone_box.Text = dt.Rows[0]["phoneNumber"].ToString();
                }
                else
                {
                    MessageBox.Show("      ERROR: CUSTOMER DOES NOT EXIST");
                }

                SqlCommand cmd2 = new SqlCommand("Select * From RentalTransactions where driversLicense = '" + customer_text_box.Text + "'", con);
                SqlDataAdapter sda2 = new SqlDataAdapter(cmd2);
                DataTable dt2 = new DataTable();
                sda2.Fill(dt2);

                if (dt2.Rows.Count > 0)
                {
                    customer_GRID_VIEW.DataSource = dt2;
                }

                c_lt_check_box.Visible = true;
                c_pt_check_box.Visible = true;
                filter_by2.Visible = true;
                con.Close();
            }
        }

        private void customer_clear_button_Click(object sender, EventArgs e)
        {
            customer_text_box.Text = "[Enter Customer Drivers License]";
            customer_text_box.ForeColor = Color.Gray;
            customer_label2.ForeColor = Color.WhiteSmoke;

            customer_GRID_VIEW.DataSource = null;
            name_box.Clear();
            gender_box.Clear();
            dob_box.Clear();
            phone_box.Clear();

            c_lt_check_box.Visible = false;
            c_pt_check_box.Visible = false;
            filter_by2.Visible = false;
        }

        private void customer_inquiry_admin_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        Point lastPoint;
        private void customer_inquiry_admin_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void search_all_customers_button_Click(object sender, EventArgs e)
        {
            // FILTER BY LABELS VISIBILITY
            Filter_label.Visible = true;
            Transactions_label.Visible = true;
            status_label.Visible = true;

            // BASIC CUSTOMER INFO VISIBILITY
            panel1.Visible = false;
            info.Visible = false;

            // LABEL VISIBILITY
            Customer_label.Visible = false;
            customer_text_box.Visible = false;
            customer_label2.Visible = false;

            // CHECK BOX VISIBILITY
            ct_check_box.Visible = true;
            pt_check_box.Visible = true;
            gs_check_box.Visible = true;

            // BUTTON VISIBILITY
            customer_search_button.Visible = false;
            customer_clear_button.Visible = false;
            back_button.Visible = true;
            search_all_customers_button.Visible = false;

            LOG_label.Text = "ALL Customer Transactions LOG";

            SqlConnection con = new SqlConnection(@SQL_conString.connection_String);  // calls class which contains the connection string
            SqlCommand cmd = new SqlCommand("Select * From RentalTransactions", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            customer_GRID_VIEW.DataSource = dt;
            con.Close();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            // FILTER BY LABELS VISIBILITY
            Filter_label.Visible = false;
            Transactions_label.Visible = false;
            status_label.Visible = false;

            // BASIC CUSTOMER INFO VISIBILITY
            panel1.Visible = true;
            info.Visible = true;

            // LABEL VISIBILITY
            Customer_label.Visible = true;
            customer_text_box.Visible = true;
            customer_label2.Visible = true;

            // CHECK BOX VISIBILITY
            ct_check_box.Visible = false;
            pt_check_box.Visible = false;
            gs_check_box.Visible = false;

            // BUTTON VISIBILITY
            customer_search_button.Visible = true;
            customer_clear_button.Visible = true;
            back_button.Visible = false;
            search_all_customers_button.Visible = true;

            // CHECK STATE OF THE CHECKBOXES
            ct_check_box.Checked = false;
            pt_check_box.Checked = false;
            gs_check_box.Checked = false;

            customer_GRID_VIEW.DataSource = null;
            LOG_label.Text = "Customer Rental Transactions LOG";

            customer_GRID_VIEW.Height = Convert.ToInt32(316);
            customer_GRID_VIEW.DataSource = null; 

        }

        private void Admin_menu_Click(object sender, EventArgs e)
        {
            employee_main_menu emm = new employee_main_menu();
            emm.Show();
            this.Hide();
        }

        private void ct_check_box_CheckedChanged(object sender, EventArgs e) // CURRENT TRANSACTIONS ALL CUSTOMERS
        {
            if (ct_check_box.Checked == true)
            {
                pt_check_box.Enabled = false;

                SqlConnection con = new SqlConnection(@SQL_conString.connection_String);  // calls class which contains the connection string
                SqlCommand cmd = new SqlCommand("Select * From RentalTransactions R Where dateDropped = (select max(dateDropped) from RentalTransactions where driversLicense = R.driversLicense)", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                customer_GRID_VIEW.DataSource = dt;
                con.Close();
            }

            if (ct_check_box.Checked == false)
            {
                pt_check_box.Enabled = true;
                SqlConnection con = new SqlConnection(@SQL_conString.connection_String);  // calls class which contains the connection string
                SqlCommand cmd = new SqlCommand("Select * From RentalTransactions", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                customer_GRID_VIEW.DataSource = dt;
                con.Close();
            }
        }

        private void pt_check_box_CheckedChanged(object sender, EventArgs e) // PAST TRANSACTIONS ALL CUSTOMERS
        {
            if (pt_check_box.Checked == true)
            {
                ct_check_box.Enabled = false;
                SqlConnection con = new SqlConnection(@SQL_conString.connection_String);  // calls class which contains the connection string
                SqlCommand cmd = new SqlCommand("(select * from RentalTransactions) except (select * from RentalTransactions R where dateDropped = (select max(dateDropped) from RentalTransactions where driversLicense = R.driversLicense))", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                customer_GRID_VIEW.DataSource = dt;
                con.Close();

            }

            if (pt_check_box.Checked == false)
            {
                ct_check_box.Enabled = true;
                SqlConnection con = new SqlConnection(@SQL_conString.connection_String);  // calls class which contains the connection string
                SqlCommand cmd = new SqlCommand("Select * From RentalTransactions", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                customer_GRID_VIEW.DataSource = dt;
                con.Close();
            }
        }

        private void gs_check_box_CheckedChanged(object sender, EventArgs e) // GOLD STATUS ALL CUSTOMERS
        {
            if (gs_check_box.Checked == true)
            {
                customer_GRID_VIEW.Height = Convert.ToInt32(161);

                gs_label.Visible = true;
                gs_c_GRID_VIEW.Visible = true;

                SqlConnection con = new SqlConnection(@SQL_conString.connection_String);  // calls class which contains the connection string
                SqlCommand cmd = new SqlCommand("Select R.driversLicense, count(transID) as [Transaction Count] From RentalTransactions R join Customers C on (R.driversLicense = C.driversLicense) group by R.driversLicense having count(transID) >= 3", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                gs_c_GRID_VIEW.DataSource = dt;

                con.Close();
            }

            if (gs_check_box.Checked == false)
            {
                customer_GRID_VIEW.Height = Convert.ToInt32(316);

                gs_label.Visible = false;
                gs_c_GRID_VIEW.Visible = false;
            }
        }

        private void c_lt_check_box_CheckedChanged(object sender, EventArgs e) // SINGLE CUSTOMER ONLY LATEST TRANSACTIONS
        {
            if (c_lt_check_box.Checked == true)
            {
                c_pt_check_box.Enabled = false;
                SqlConnection con = new SqlConnection(@SQL_conString.connection_String);  // calls class which contains the connection string
                SqlCommand cmd = new SqlCommand("Select * From RentalTransactions where driversLicense = '" + customer_text_box.Text + "'", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    MessageBox.Show("    ERROR: CUSTOMER ONLY HAS ONE TRANSACTION.\n CANNOT SORT TRANSACTIONS IF THERE IS ONLY ONE");
                    c_lt_check_box.Checked = false;
                }
                else
                {
                    SqlCommand cmd2 = new SqlCommand("Select * From RentalTransactions R Where dateDropped = (select max(dateDropped) from RentalTransactions where driversLicense = '" + customer_text_box.Text + "')", con);
                    SqlDataAdapter sda2 = new SqlDataAdapter(cmd2);
                    DataTable dt2 = new DataTable();
                    sda2.Fill(dt2);

                    customer_GRID_VIEW.DataSource = dt2;
                }
                con.Close();
            }

            if (c_lt_check_box.Checked == false)
            {
                c_pt_check_box.Enabled = true;
                SqlConnection con = new SqlConnection(@SQL_conString.connection_String);  // calls class which contains the connection string
                SqlCommand cmd = new SqlCommand("Select * From RentalTransactions where driversLicense = '" + customer_text_box.Text + "'", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                customer_GRID_VIEW.DataSource = dt;
                con.Close();
            }
        }

        private void c_pt_check_box_CheckedChanged(object sender, EventArgs e) // SINGLE CUSTOMER ONLY PAST TRANSACTIONS
        {
            if (c_pt_check_box.Checked == true)
            {
                c_lt_check_box.Enabled = false;
                SqlConnection con = new SqlConnection(@SQL_conString.connection_String);  // calls class which contains the connection string
                SqlCommand cmd = new SqlCommand("Select * From RentalTransactions where driversLicense = '" + customer_text_box.Text + "'", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    MessageBox.Show("    ERROR: CUSTOMER ONLY HAS ONE TRANSACTION.\n CANNOT SORT TRANSACTIONS IF THERE IS ONLY ONE");
                    c_pt_check_box.Checked = false;
                }
                else
                {
                    SqlConnection con2 = new SqlConnection(@SQL_conString.connection_String);  // calls class which contains the connection string
                    SqlCommand cmd2 = new SqlCommand("(select * from RentalTransactions where driversLicense = '" + customer_text_box.Text + "') except (select * from RentalTransactions where dateDropped = (select max(dateDropped) from RentalTransactions where driversLicense = '" + customer_text_box.Text + "'))", con);
                    SqlDataAdapter sda2 = new SqlDataAdapter(cmd2);
                    DataTable dt2 = new DataTable();
                    sda2.Fill(dt2);

                    customer_GRID_VIEW.DataSource = dt2;
                
                }
            }

            if (c_pt_check_box.Checked == false)
            {
                c_lt_check_box.Enabled = true;
                SqlConnection con = new SqlConnection(@SQL_conString.connection_String);  // calls class which contains the connection string
                SqlCommand cmd = new SqlCommand("Select * From RentalTransactions where driversLicense = '" + customer_text_box.Text + "'", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                customer_GRID_VIEW.DataSource = dt;
            }
        }

        private void add_update_c_button_Click(object sender, EventArgs e)
        {
            add_update_customer_info_admin aucia = new add_update_customer_info_admin();
            aucia.Show();
            this.Hide();
        }
    }
}

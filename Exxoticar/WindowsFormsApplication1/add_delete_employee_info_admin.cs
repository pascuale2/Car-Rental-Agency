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
    public partial class add_delete_employee_info_admin : Form
    {
        public add_delete_employee_info_admin()
        {
            InitializeComponent();
        }

        private void minimize_button_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            employee_inquiry ei = new employee_inquiry();
            ei.Show();
            this.Hide();
        }

        private void add_update_customer_info_admin_MouseMove(object sender, MouseEventArgs e)  // CODE to make window draggable
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        Point lastPoint;
        private void add_update_customer_info_admin_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void employee_text_box_TextChanged(object sender, EventArgs e)
        {
            employee_text_box.MaxLength = 5;
            if (System.Text.RegularExpressions.Regex.IsMatch(employee_text_box.Text, "  ^ [0-9]")) // if regular expression matches alphabetic characters
            {
                employee_text_box.Text = "";
            }
            else
            {
                if (button1.Visible == false)
                {
                    SqlConnection con = new SqlConnection(@SQL_conString.connection_String);  // calls class which contains the connection string
                    SqlCommand cmd = new SqlCommand("Select * From Employees where empID = '" + employee_text_box.Text + "'", con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    if (dt.Rows.Count > 0) // if Row Count > 0 
                    {
                        MessageBox.Show("Employee Name: " + dt.Rows[0]["fName"].ToString() + " " + dt.Rows[0]["lName"].ToString());  // display the full name of the employee

                        employee_text_box.ReadOnly = true;     //------------------------------------//
                        delete_employee.Visible = true;        // display buttons that were invisible//
                        button1.Visible = true;                //------------------------------------//

                    }
                    con.Close();
                }
            }
        }

        private void employee_text_box_Click(object sender, EventArgs e)
        {
            if (employee_text_box.ReadOnly == false)
            {
                employee_text_box.Clear();
            }
        }

        private void employee_text_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)  // CLEAR FIELDS BUTTON!!!!!!!!!
        {
            employee_text_box.Text = "[Enter Employee Drivers License]";
            employee_text_box.ReadOnly = false;
            delete_employee.Visible = false;
            button1.Visible = false;
        }

        private void delete_employee_Click(object sender, EventArgs e) // DELETE BUTTON CODE
        {
            {
                SqlCommand cm;
                SqlDataReader sdr;
                SqlConnection con = new SqlConnection(@SQL_conString.connection_String);

                String SqlStatement = "DELETE FROM Employees WHERE empID = '" + employee_text_box.Text + "';";

                try
                {
                    con.Open();
                    cm = new SqlCommand(SqlStatement, con);

                    sdr = cm.ExecuteReader();
                    MessageBox.Show("    Employee INFO SUCCESSFULLY DELETED");
                    while (sdr.Read())
                    {
                    }

                    con.Close();
                    String SqlStatement2 = "DELETE FROM LoginInformation WHERE loginID = '" + employee_text_box.Text + "';";
                    try
                    {
                        
                        con.Open();
                        cm = new SqlCommand(SqlStatement2, con);

                        sdr = cm.ExecuteReader();
                        MessageBox.Show("    Employee LOGIN INFO SUCCESSFULLY DELETED");
                        while (sdr.Read())
                        {
                        }
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                con.Close();
            }

            //-----------INSERT DELETE EMPLOYEE CODE HERE------------//


        }

        private void emp_id_text_box_TextChanged(object sender, EventArgs e)
        {
            emp_id_text_box.MaxLength = 5;
            if (System.Text.RegularExpressions.Regex.IsMatch(emp_id_text_box.Text, "  ^ [0-9]"))
            {
                emp_id_text_box.Text = "";
            }
        }

        private void fn_text_box_TextChanged(object sender, EventArgs e)
        {
            fn_text_box.MaxLength = 15;
        }

        private void ln_text_box_TextChanged(object sender, EventArgs e)
        {
            ln_text_box.MaxLength = 15;
        }

        private void salary_box_TextChanged(object sender, EventArgs e)
        {
            salary_box.MaxLength = 9;
            if (System.Text.RegularExpressions.Regex.IsMatch(salary_box.Text, "  ^ [0-9]"))
            {
                salary_box.Text = "";
            }
        }

        private void phone_num_text_box_TextChanged(object sender, EventArgs e)
        {
            phone_num_text_box.MaxLength = 9;
            if (System.Text.RegularExpressions.Regex.IsMatch(phone_num_text_box.Text, "  ^ [0-9]"))
            {
                phone_num_text_box.Text = "";
            }
        }

        private void c_name_TextChanged(object sender, EventArgs e)
        {
            c_name.MaxLength = 15;
        }

        private void p_name_TextChanged(object sender, EventArgs e)
        {
            p_name.MaxLength = 15;
        }

        private void zip_num_TextChanged(object sender, EventArgs e)
        {
            zip_num.MaxLength = 6;
            zip_num.CharacterCasing = CharacterCasing.Upper;
        }

        private void branch_id_TextChanged(object sender, EventArgs e)
        {
            branch_id.MaxLength = 3;
            if (System.Text.RegularExpressions.Regex.IsMatch(branch_id.Text, "  ^ [0-9]"))
            {
                branch_id.Text = "";
            }
        }

        private void street_num_TextChanged(object sender, EventArgs e)
        {
            street_num.MaxLength = 8;
            if (System.Text.RegularExpressions.Regex.IsMatch(street_num.Text, "  ^ [0-9]"))
            {
                street_num.Text = "";
            }
        }

        private void street_name_TextChanged(object sender, EventArgs e)
        {
            street_name.MaxLength = 25;
        }

        private void apt_num_TextChanged(object sender, EventArgs e)
        {
            apt_num.MaxLength = 8;
            if (System.Text.RegularExpressions.Regex.IsMatch(apt_num.Text, "  ^ [0-9]"))
            {
                apt_num.Text = "";
            }
        }

        private void building_num_TextChanged(object sender, EventArgs e)
        {
            building_num.MaxLength = 25;
        }


        private void fn_text_box_Click(object sender, EventArgs e)
        {
            fn_text_box.Clear();
        }

        private void ln_text_box_Click(object sender, EventArgs e)
        {
            ln_text_box.Clear();
        }

        private void phone_num_text_box_Click(object sender, EventArgs e)
        {
            phone_num_text_box.Clear();
        }

        private void c_name_Click(object sender, EventArgs e)
        {
            c_name.Clear();
        }

        private void p_name_Click(object sender, EventArgs e)
        {
            p_name.Clear();
        }

        private void zip_num_Click(object sender, EventArgs e)
        {
            zip_num.Clear();
        }

        private void branch_id_Click(object sender, EventArgs e)
        {
            branch_id.Clear();
        }

        private void street_num_Click(object sender, EventArgs e)
        {
            street_num.Clear();
        }

        private void street_name_Click(object sender, EventArgs e)
        {
            street_name.Clear();
        }

        private void apt_num_Click(object sender, EventArgs e)
        {
            apt_num.Clear();
        }

        private void building_num_Click(object sender, EventArgs e)
        {
            building_num.Clear();
        }

        private void emp_id_text_box_Click(object sender, EventArgs e)
        {
            emp_id_text_box.Clear();
        }

        private void salary_box_Click(object sender, EventArgs e)
        {
            salary_box.Clear();
        }

        private void reside_apt_house_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (reside_apt_house.SelectedIndex == 0)
            {
                apt_num_label.Visible = true;
                bldg_num_label.Visible = true;

                apt_num.Visible = true;
                building_num.Visible = true;
            }
            else if (reside_apt_house.SelectedIndex == 1)
            {
                apt_num_label.Visible = false;
                bldg_num_label.Visible = false;

                apt_num.Visible = false;
                building_num.Visible = false;
            }
        }

        //--------------------------- BUTTONS FOR ADD TAB----------------------------------------------/
        private void clear_customer_Click(object sender, EventArgs e)
        {
            emp_id_text_box.Text = "[ 5 Digits Long ]";
            fn_text_box.Text = "[ 15 Characters MAX ]";
            ln_text_box.Text = "[ 15 Characters MAX ]";
            gender_box.Text = "";

            salary_box.Text = "[ 9 Digits Max ]";

            dob_picker.ResetText();

            c_name.Text = "[ 15 Characters MAX ]";
            p_name.Text = "[ 15 Characters MAX ]";

            phone_num_text_box.Text = "[ 10 Digits Long ]";
            reside_apt_house.Text = "";

            //second column info
            reside_apt_house.Text = "";
            street_num.Text = "[ Numbers ONLY ]";
            street_name.Text = "[ 25 Characters MAX ]";

            apt_num.Text = "[ Numbers ONLY ]";
            building_num.Text = "[ 25 Characters MAX ]";


            zip_num.Text = "[ 6 CHARACTERS LONG ]";
            branch_id.Text = "[ 3 Digits Long ]";

            //Visibility of labels and text boxes
            apt_num_label.Visible = false;
            bldg_num_label.Visible = false;

            apt_num.Visible = false;
            building_num.Visible = false;
        }

        private void add_employee_info_Click(object sender, EventArgs e)
        {
            SqlCommand cm;
            SqlDataReader sdr;
            SqlConnection con = new SqlConnection(@SQL_conString.connection_String);

            if (emp_id_text_box.Text != "" && emp_id_text_box.Text != "[9 Digits Long]" && emp_id_text_box.TextLength == 5 && fn_text_box.Text != "" && fn_text_box.Text != "[ 15 Characters MAX ]" && gender_box.Text != "" && reside_apt_house.Text != "" && street_num.Text != "" && street_num.Text != "[ Numbers ONLY ]" && street_name.Text != "" && street_name.Text != "[ 25 Characters MAX ]" && phone_num_text_box.Text != "" && phone_num_text_box.Text != "[ 10 Digits Long ]" && c_name.Text != "" && c_name.Text != "[ 15 Characters MAX ]" && p_name.Text != "" && p_name.Text != "[ 15 Characters MAX ]" && zip_num.Text != "" && zip_num.Text != "[ 6 Characters Long ]" && zip_num.TextLength == 6 && salary_box.Text != "" && salary_box.Text != "[ 9 Digits Max ]")
            {

                if (reside_apt_house.SelectedIndex == 1)
                {
                    //INSERT INTO LOGIN INFORMATION FIRST
                    //WE CREATE A LOGIN FOR EMPLOYEES FIRST
                    String SqlStatement = "INSERT INTO LoginInformation (loginID, userName, password, usertype) VALUES ('" + emp_id_text_box.Text + "', '" + fn_text_box.Text + "_" + ln_text_box.Text + "', '" + fn_text_box.Text + "_" + ln_text_box.Text + "', 'Employee' );";
                    try
                    {
                        con.Open();
                        cm = new SqlCommand(SqlStatement, con);

                        sdr = cm.ExecuteReader();
                        MessageBox.Show("    LOGIN INFORMATION FOR EMPLOYEE SUCCESSFULLY CREATED");
                        while (sdr.Read())
                        {
                        }

                        con.Close();
                        //AND THEN WE CREATE THE EMPLOYEE INFORMATION AFTER
                        String SqlStatement2 = "INSERT INTO Employees (empID, fname, lname, gender, dob, phoneNumber, streetNumber, streetName, aptNumber, bldgNumber, city, province, zip, branchID, salary) VALUES ('" + emp_id_text_box.Text + "', '" + fn_text_box.Text + "', '" + ln_text_box.Text + "', '" + gender_box.Text.ToLower() + "', '" + dob_picker.Value.ToShortDateString() + "', '" + phone_num_text_box.Text + "', '" + street_num.Text + "', '" + street_name.Text + "', null, null, '" + c_name.Text + "', '" + p_name.Text + "', '" + zip_num.Text + "', '" + branch_id.Text + "', '" + salary_box.Text + "');";

                        try
                        {
                            con.Open();
                            cm = new SqlCommand(SqlStatement2, con);

                            sdr = cm.ExecuteReader();
                            MessageBox.Show("    EMPLOYEE SUCCESSFULLY ADDED TO DATABASE");
                            while (sdr.Read())
                            {
                            }

                            clear_customer.PerformClick();
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.Message);
                        }
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                    con.Close();



                }
                else if (reside_apt_house.SelectedIndex == 0)
                {
                    //INSERT INTO LOGIN INFORMATION FIRST
                    //WE CREATE A LOGIN FOR EMPLOYEES FIRST
                    String SqlStatement3 = "INSERT INTO LoginInformation (loginID, userName, password, usertype) VALUES ('" + emp_id_text_box.Text + "', '" + fn_text_box.Text + "_" + ln_text_box.Text + "', '" + fn_text_box.Text + "_" + ln_text_box.Text + "', 'Employee' );";
                    try
                    {
                        con.Open();
                        cm = new SqlCommand(SqlStatement3, con);

                        sdr = cm.ExecuteReader();
                        MessageBox.Show("    LOGIN INFORMATION FOR EMPLOYEE SUCCESSFULLY CREATED");
                        while (sdr.Read())
                        {
                        }

                        con.Close();
                        //AND THEN WE CREATE THE EMPLOYEE INFORMATION AFTER
                        String SqlStatement4 = "INSERT INTO Employees (empID, fname, lname, gender, dob, phoneNumber, streetNumber, streetName, aptNumber, bldgNumber, city, province, zip, branchID, salary) VALUES ('" + emp_id_text_box.Text + "', '" + fn_text_box.Text + "', '" + ln_text_box.Text + "', '" + gender_box.Text.ToLower() + "', '" + dob_picker.Value.ToShortDateString() + "', '" + phone_num_text_box.Text + "', '" + street_num.Text + "', '" + street_name.Text + "','" + apt_num.Text + "','" + building_num.Text + "', '" + c_name.Text + "', '" + p_name.Text + "', '" + zip_num.Text + "', '" + branch_id.Text + "', '" + salary_box.Text + "');";

                        try
                        {
                            con.Open();
                            cm = new SqlCommand(SqlStatement4, con);

                            sdr = cm.ExecuteReader();
                            MessageBox.Show("    EMPLOYEE SUCCESSFULLY ADDED TO DATABASE");
                            while (sdr.Read())
                            {
                            }


                            clear_customer.PerformClick();
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.Message);
                        }
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                    con.Close();


                }
            }
            else
            {
                MessageBox.Show("    ERROR: MAKE SURE YOU FILLED THE FIELDS CORRECTLY\n       DOUBLE CHECK YOUR INFORMATION!!!!!!");
            }
        }
    }
}

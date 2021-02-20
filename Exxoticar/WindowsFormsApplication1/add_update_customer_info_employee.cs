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
    public partial class add_update_customer_info_employee : Form
    {
        public add_update_customer_info_employee()
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
            customer_inquiry_employee cie = new customer_inquiry_employee();
            cie.Show();
            this.Hide();
        }

        private void add_update_customer_info_admin_MouseMove(object sender, MouseEventArgs e)
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

        //--------------- TEXTBOX TEXTCHANGED CODE--------------------------------------------------------//

        private void drivers_license_text_box_TextChanged(object sender, EventArgs e)
        {
            drivers_license_text_box.MaxLength = 9;
            if (System.Text.RegularExpressions.Regex.IsMatch(drivers_license_text_box.Text, "  ^ [0-9]"))
            {
                drivers_license_text_box.Text = "";
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

        private void c_name_TextChanged(object sender, EventArgs e)
        {
            c_name.MaxLength = 15;
        }

        private void phone_num_text_box_TextChanged(object sender, EventArgs e)
        {
            phone_num_text_box.MaxLength = 10;
            if (System.Text.RegularExpressions.Regex.IsMatch(phone_num_text_box.Text, "  ^ [0-9]"))
            {
                phone_num_text_box.Text = "";
            }
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

        private void cc_num_TextChanged(object sender, EventArgs e)
        {
            cc_num.MaxLength = 16;
            if (System.Text.RegularExpressions.Regex.IsMatch(cc_num.Text, "  ^ [0-9]"))
            {
                cc_num.Text = "";
            }
        }

        private void street_num_TextChanged(object sender, EventArgs e)
        {
            street_num.MaxLength = 6;
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
            apt_num.MaxLength = 6;
            if (System.Text.RegularExpressions.Regex.IsMatch(apt_num.Text, "  ^ [0-9]"))
            {
                apt_num.Text = "";
            }
        }

        private void building_num_TextChanged(object sender, EventArgs e)
        {
            building_num.MaxLength = 25;
        }


        //--------------- TEXTBOX TEXTCHANGED CODE END----------------------------------------------------//

        
        private void clear_customer_Click(object sender, EventArgs e)   //--------------- CLEAR BUTTON CODE----------------//
        {
            drivers_license_text_box.Text = "[ 9 Digits Long ]";
            fn_text_box.Text = "[ 15 Characters MAX ]";
            ln_text_box.Text = "[ 15 Characters MAX ]";
            gender_box.Text = "";

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

            policy_box.Text = "";

            zip_num.Text = "[ 6 Characters Long ]";
            cc_num.Text = "[ 16 Digits Long ]";

            //Visibility of labels and text boxes
            apt_num_label.Visible = false;
            bldg_num_label.Visible = false;
            apt_num.Visible = false;
            building_num.Visible = false;
            label23.Visible = false;
            label21.Visible = false;
        }

        private void drivers_license_text_box_Click(object sender, EventArgs e)
        {
            drivers_license_text_box.Clear();
        }

        private void phone_num_text_box_Click_1(object sender, EventArgs e)
        {
            phone_num_text_box.Clear();
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

        private void zip_num_Click(object sender, EventArgs e)
        {
            zip_num.Clear();
        }

        private void cc_num_Click(object sender, EventArgs e)
        {
            cc_num.Clear();
        }

        private void reside_apt_house_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (reside_apt_house.SelectedIndex == 1)
            {
                apt_num_label.Visible = false;
                bldg_num_label.Visible = false;
                apt_num.Visible = false;
                building_num.Visible = false;
                label23.Visible = false;
                label21.Visible = false;

                apt_num.Text = "null";
                building_num.Text = "null";
            }
            else if (reside_apt_house.SelectedIndex == 0)
            {
                apt_num_label.Visible = true;
                bldg_num_label.Visible = true;
                apt_num.Visible = true;
                building_num.Visible = true;
                label23.Visible = true;
                label21.Visible = true;

                apt_num.Text = "[ Numbers ONLY ]";
                building_num.Text = "[ 25 Characters MAX ]";
            }
        }

        // KEY PRESS CODE FUNCTIONS-----------------------------------------------------------------//

        private void phone_num_text_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void street_num_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void apt_num_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void cc_num_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void drivers_license_text_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }


        //--------------------------------------------------ADD CUSTOMER INFORMATION BUTTON CODE------------------------------------------//
        private void add_customer_info_Click(object sender, EventArgs e)
        {
            SqlCommand cm;
            SqlDataReader sdr;
            SqlConnection con = new SqlConnection(@SQL_conString.connection_String);            

            int type_policy_id = 0;

            if (drivers_license_text_box.Text != "" && drivers_license_text_box.Text != "[9 Digits Long]" && drivers_license_text_box.TextLength == 9 && fn_text_box.Text != "" && fn_text_box.Text != "[ 15 Characters MAX ]" && gender_box.Text != "" && policy_box.Text != "" && reside_apt_house.Text != "" && street_num.Text != "" && street_num.Text != "[ Numbers ONLY ]" && street_name.Text != "" && street_name.Text != "[ 25 Characters MAX ]" &&  phone_num_text_box.Text != "" && phone_num_text_box.Text != "[ 10 Digits Long ]" && c_name.Text != "" && c_name.Text != "[ 15 Characters MAX ]" && p_name.Text != "" && p_name.Text != "[ 15 Characters MAX ]" && zip_num.Text != "" && zip_num.Text != "[ 6 Characters Long ]" && zip_num.TextLength == 6 && cc_num.Text != "" && cc_num.Text != "[ 16 Digits Long ]" && cc_num.TextLength == 16)
            {
                //-------------------------------------- changes policy_id.Text into its policy id number-------------------------------//
                if (policy_box.SelectedIndex == 0)
                {
                    type_policy_id = 10001;
                }
                else if (policy_box.SelectedIndex == 1)
                {
                    type_policy_id = 10002;
                }

                if (reside_apt_house.SelectedIndex == 1)
                {
                    String SqlStatement = "INSERT INTO Customers (driversLicense, fname, lname, gender, dob, phoneNumber, streetNumber, streetName, aptNumber, bldgNumber, city, province, zip, creditCard, policyID) VALUES ('" + drivers_license_text_box.Text + "', '" + fn_text_box.Text + "', '" + ln_text_box.Text + "', '" + gender_box.Text + "', '" + dob_picker.Value.ToShortDateString() + "', '" + phone_num_text_box.Text + "', '" + street_num.Text + "', '" + street_name.Text + "', null, null, '" + c_name.Text + "', '" + p_name.Text + "', '" + zip_num.Text + "', '" + cc_num.Text + "', '" + type_policy_id + "');";

                    try
                    {
                        con.Open();
                        cm = new SqlCommand(SqlStatement, con);

                        sdr = cm.ExecuteReader();
                        MessageBox.Show("    Saved");
                        while (sdr.Read())
                        {
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
                    String SqlStatement = "INSERT INTO Customers (driversLicense, fname, lname, gender, dob, phoneNumber, streetNumber, streetName, aptNumber, bldgNumber, city, province, zip, creditCard, policyID) VALUES ('" + drivers_license_text_box.Text + "', '" + fn_text_box.Text + "', '" + ln_text_box.Text + "', '" + gender_box.Text + "', '" + dob_picker.Value.ToShortDateString() + "', '" + phone_num_text_box.Text + "', '" + street_num.Text + "', '" + street_name.Text + "', '" + apt_num.Text + "','" + building_num.Text + "', '" + c_name.Text + "', '" + p_name.Text + "', '" + zip_num.Text + "', '" + cc_num.Text + "', '" + type_policy_id + "');";

                    try
                    {
                        con.Open();
                        cm = new SqlCommand(SqlStatement, con);

                        sdr = cm.ExecuteReader();
                        MessageBox.Show("    Saved");
                        while (sdr.Read())
                        {
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

        //----------------------------------------UPDATE CUSTOMER INFORMATION CODE------------------------------------------------------------------------------------------------------------------------------------//
        private void update_street_num_TextChanged(object sender, EventArgs e)
        {
            update_street_num.MaxLength = 7;
            if (System.Text.RegularExpressions.Regex.IsMatch(update_street_num.Text, "  ^ [0-9]")) // if regular expression matches alphabetic characters
            {
                update_street_num.Text = "";
            }
        }

        private void update_apt_num_TextChanged(object sender, EventArgs e)
        {
            update_apt_num.MaxLength = 7;
            if (System.Text.RegularExpressions.Regex.IsMatch(update_apt_num.Text, "  ^ [0-9]")) // if regular expression matches alphabetic characters
            {
                update_apt_num.Text = "";
            }
        }

        private void field_box_Click(object sender, EventArgs e)
        {
            field_box.Clear();
        }

        private void update_street_name_TextChanged(object sender, EventArgs e)
        {
            update_street_name.MaxLength = 25;
        }

        private void update_bldg_num_TextChanged(object sender, EventArgs e)
        {
            update_bldg_num.MaxLength = 25;
        }

        private void update_street_num_Click(object sender, EventArgs e)
        {
            update_street_num.Clear();
        }

        private void update_street_name_Click(object sender, EventArgs e)
        {
            update_street_name.Clear();
        }

        private void update_apt_num_Click(object sender, EventArgs e)
        {
            update_apt_num.Clear();
        }

        private void update_bldg_num_Click(object sender, EventArgs e)
        {
            update_bldg_num.Clear();
        }

        private void update_street_num_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void update_apt_num_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void customer_text_box_Click(object sender, EventArgs e)
        {
            customer_text_box.Clear();
        }

        private void customer_text_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void customer_text_box_TextChanged(object sender, EventArgs e)
        {
            customer_text_box.MaxLength = 9;
            if (System.Text.RegularExpressions.Regex.IsMatch(customer_text_box.Text, "  ^ [0-9]")) // if regular expression matches alphabetic characters
            {
                customer_text_box.Text = "";
            }
            else
            {
                if (update_clear_fields.Visible == false)
                {
                    SqlConnection con = new SqlConnection(@SQL_conString.connection_String);  // calls class which contains the connection string
                    SqlCommand cmd = new SqlCommand("Select * From Customers where driversLicense = '" + customer_text_box.Text + "'", con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    if (dt.Rows.Count > 0) // if Row Count > 0 
                    {
                        MessageBox.Show("Employee Name: " + dt.Rows[0]["fName"].ToString() + " " + dt.Rows[0]["lName"].ToString());  // display the full name of the employee

                        select_info_label.Visible = true;
                        update_combo_box.Visible = true;
                    }
                    con.Close();
                }
            }
        }

        private void update_combo_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (update_combo_box.SelectedIndex == 0) //First Name
            {
                label20.Visible = true;
                field_box.Visible = true;
            }
            else if (update_combo_box.SelectedIndex == 1) //Last Name
            {
                label20.Visible = true;
                field_box.Visible = true;
            }
            else if (update_combo_box.SelectedIndex == 2) //Gender
            {
                label20.Visible = true;
                gender_combo_box.Visible = true;
            }
            else if (update_combo_box.SelectedIndex == 3) //Residence
            {
                Residence_panel.Visible = true;

            }
            else if (update_combo_box.SelectedIndex == 4) //Phone #
            {
                label20.Visible = true;
                field_box.Visible = true;
            }
            else if (update_combo_box.SelectedIndex == 5) //City
            {
                label20.Visible = true;
                field_box.Visible = true;
            }
            else if (update_combo_box.SelectedIndex == 6) //Province
            {
                label20.Visible = true;
                field_box.Visible = true;
            }
            else if (update_combo_box.SelectedIndex == 7)
            {
                label20.Visible = true;
                policy_type_box.Visible = true;
            }

            customer_text_box.ReadOnly = true;     //------------------------------------//
            update_customer_info.Visible = true;   // display buttons that were invisible//
            update_clear_fields.Visible = true;    //------------------------------------//
        }

        private void update_reside_apt_house_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (update_reside_apt_house.SelectedIndex == 0)
            {
                label26.Visible = true;
                label22.Visible = true;

                update_apt_num.Visible = true;
                update_bldg_num.Visible = true;
            }
            else if (update_reside_apt_house.SelectedIndex == 1)
            {
                label26.Visible = false;
                label22.Visible = false;

                update_apt_num.Visible = false;
                update_bldg_num.Visible = false;
            }
        }

        private void update_clear_fields_Click(object sender, EventArgs e)
        {

            customer_text_box.ReadOnly = false;
            update_customer_info.Visible = false;
            update_clear_fields.Visible = false;

            field_box.Visible = false;
            Residence_panel.Visible = false;
            gender_combo_box.Visible = false;

            customer_text_box.Text = "";

            label20.Visible = false;
            update_combo_box.Visible = false;
            policy_type_box.Visible = false;

            select_info_label.Visible = false;
            update_combo_box.Visible = false;
        }

        private void field_box_TextChanged(object sender, EventArgs e)
        {
            if (update_combo_box.SelectedIndex == 0) //First Name
            {
                field_box.MaxLength = 15;
            }
            else if (update_combo_box.SelectedIndex == 1) //Last Name
            {
                field_box.MaxLength = 15;
            }
            else if (update_combo_box.SelectedIndex == 4) //Phone #
            {
                field_box.MaxLength = 10;
                if (System.Text.RegularExpressions.Regex.IsMatch(field_box.Text, "  ^ [0-9]"))
                {
                    field_box.Text = "";
                }
            }
            else if (update_combo_box.SelectedIndex == 5) //City
            {
                field_box.MaxLength = 15;
            }
            else if (update_combo_box.SelectedIndex == 6) //Province
            {
                field_box.MaxLength = 15;
            }
        }

        private void field_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (update_combo_box.SelectedIndex == 4) //Phone #
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                {
                    e.Handled = true;
                }
            }
        }

        public int num_policyID = 10001;

        private void policy_type_box_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (policy_type_box.SelectedIndex == 0)
            {
                num_policyID = 10001;
            }
            else if (policy_type_box.SelectedIndex == 1)
            {
                num_policyID = 10002;
            }
        }

        private void update_customer_info_Click(object sender, EventArgs e)
        {
            if (update_combo_box.SelectedIndex == 0) //First Name----------------------------------------------------------------------------------------//
            {
                SqlCommand cm;
                SqlDataReader sdr;
                SqlConnection con = new SqlConnection(@SQL_conString.connection_String);

                String SqlStatement = "UPDATE Customers SET fName ='" + field_box.Text + "' where driversLicense = '" + customer_text_box.Text + "'";
                try
                {
                    con.Open();
                    cm = new SqlCommand(SqlStatement, con);

                    sdr = cm.ExecuteReader();
                    MessageBox.Show("    Saved");
                    while (sdr.Read())
                    {
                    }

                    update_clear_fields.PerformClick();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            else if (update_combo_box.SelectedIndex == 1) //Last Name----------------------------------------------------------------------------------------//
            {
                SqlCommand cm;
                SqlDataReader sdr;
                SqlConnection con = new SqlConnection(@SQL_conString.connection_String);

                String SqlStatement = "UPDATE Customers SET lName ='" + field_box.Text + "' where driversLicense = '" + customer_text_box.Text + "'";
                try
                {
                    con.Open();
                    cm = new SqlCommand(SqlStatement, con);

                    sdr = cm.ExecuteReader();
                    MessageBox.Show("    Saved");
                    while (sdr.Read())
                    {
                    }

                    update_clear_fields.PerformClick();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            else if (update_combo_box.SelectedIndex == 2) //Gender
            {
                SqlCommand cm;
                SqlDataReader sdr;
                SqlConnection con = new SqlConnection(@SQL_conString.connection_String);

                String SqlStatement = "UPDATE Customers SET gender ='" + gender_combo_box.Text.ToLower() + "' where driversLicense = '" + customer_text_box.Text + "'";
                try
                {
                    con.Open();
                    cm = new SqlCommand(SqlStatement, con);

                    sdr = cm.ExecuteReader();
                    MessageBox.Show("    Saved");
                    while (sdr.Read())
                    {
                    }

                    update_clear_fields.PerformClick();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            else if (update_combo_box.SelectedIndex == 3) //Residence
            {
                if (update_reside_apt_house.SelectedIndex == 0)
                {
                    SqlCommand cm;
                    SqlDataReader sdr;
                    SqlConnection con = new SqlConnection(@SQL_conString.connection_String);

                    String SqlStatement = "UPDATE Customers SET streetNumber ='" + update_street_num.Text + "', streetName = '" + update_street_name.Text + "', aptNumber = '" + update_apt_num.Text + "', bldgNumber = '" + update_bldg_num.Text + "' where driversLicense = '" + customer_text_box.Text + "'";
                    try
                    {
                        con.Open();
                        cm = new SqlCommand(SqlStatement, con);

                        sdr = cm.ExecuteReader();
                        MessageBox.Show("    Saved");
                        while (sdr.Read())
                        {
                        }

                        update_clear_fields.PerformClick();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                }
                else if (update_reside_apt_house.SelectedIndex == 1)
                {
                    SqlCommand cm;
                    SqlDataReader sdr;
                    SqlConnection con = new SqlConnection(@SQL_conString.connection_String);

                    String SqlStatement = "UPDATE Customers SET streetNumber ='" + update_street_num.Text + "', streetName = '" + update_street_name.Text + "', aptNumber = null, bldgNumber = null where driversLicense = '" + customer_text_box.Text + "'";
                    try
                    {
                        con.Open();
                        cm = new SqlCommand(SqlStatement, con);

                        sdr = cm.ExecuteReader();
                        MessageBox.Show("    Saved");
                        while (sdr.Read())
                        {
                        }

                        update_clear_fields.PerformClick();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else if (update_combo_box.SelectedIndex == 4) //Phone #
            {
                SqlCommand cm;
                SqlDataReader sdr;
                SqlConnection con = new SqlConnection(@SQL_conString.connection_String);

                String SqlStatement = "UPDATE Customers SET phoneNumber ='" + field_box.Text + "' where driversLicense = '" + customer_text_box.Text + "'";
                try
                {
                    con.Open();
                    cm = new SqlCommand(SqlStatement, con);

                    sdr = cm.ExecuteReader();
                    MessageBox.Show("    Saved");
                    while (sdr.Read())
                    {
                    }

                    update_clear_fields.PerformClick();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            else if (update_combo_box.SelectedIndex == 5) //City
            {
                SqlCommand cm;
                SqlDataReader sdr;
                SqlConnection con = new SqlConnection(@SQL_conString.connection_String);

                String SqlStatement = "UPDATE Customers SET city ='" + field_box.Text + "' where driversLicense = '" + customer_text_box.Text + "'";
                try
                {
                    con.Open();
                    cm = new SqlCommand(SqlStatement, con);

                    sdr = cm.ExecuteReader();
                    MessageBox.Show("    Saved");
                    while (sdr.Read())
                    {
                    }

                    update_clear_fields.PerformClick();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            else if (update_combo_box.SelectedIndex == 6) //Province
            {
                SqlCommand cm;
                SqlDataReader sdr;
                SqlConnection con = new SqlConnection(@SQL_conString.connection_String);

                String SqlStatement = "UPDATE Customers SET province ='" + field_box.Text + "' where driversLicense = '" + customer_text_box.Text + "'";
                try
                {
                    con.Open();
                    cm = new SqlCommand(SqlStatement, con);

                    sdr = cm.ExecuteReader();
                    MessageBox.Show("    Saved");
                    while (sdr.Read())
                    {
                    }

                    update_clear_fields.PerformClick();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            else if (update_combo_box.SelectedIndex == 7) //Policy Type
            {
                SqlCommand cm;
                SqlDataReader sdr;
                SqlConnection con = new SqlConnection(@SQL_conString.connection_String);

                String SqlStatement = "UPDATE Customers SET policyID ='" + num_policyID + "' where driversLicense = '" + customer_text_box.Text + "'";
                try
                {
                    con.Open();
                    cm = new SqlCommand(SqlStatement, con);

                    sdr = cm.ExecuteReader();
                    MessageBox.Show("    Saved");
                    while (sdr.Read())
                    {
                    }

                    update_clear_fields.PerformClick();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }
    }

}
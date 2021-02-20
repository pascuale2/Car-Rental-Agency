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

    public partial class stock_inquiry_employee : Form
    {

        public stock_inquiry_employee()
        {
            InitializeComponent();
        }

        private void stock_inquiry_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        Point lastPoint;
        private void stock_inquiry_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimize_button_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Admin_menu_Click(object sender, EventArgs e)
        {
            employee_main_menu emm = new employee_main_menu();
            emm.Show();
            this.Hide();
        }

        //----------------------------------------------------VIEW TAB CODE-------------------------------------------------------//
        private void View_Combo_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (View_Combo_box.SelectedIndex == 0)
            {
                Search_term_label.Text = "Enter \nVIN";
                textBox1.Visible = true;
                Body_Type_BOX.Visible = false;
                Status_BOX.Visible = false;
            }
            else if(View_Combo_box.SelectedIndex == 1)
            { 
                Search_term_label.Text = "Enter \nLicense \nPlate";
                textBox1.Visible = true;
                Body_Type_BOX.Visible = false;
                Status_BOX.Visible = false;
            }
            else if (View_Combo_box.SelectedIndex == 2)
            {
                Search_term_label.Text = "Enter \nModel";
                textBox1.Visible = true;
                Body_Type_BOX.Visible = false;
                Status_BOX.Visible = false;
            }
            else if (View_Combo_box.SelectedIndex == 3)
            {
                Search_term_label.Text = "Select \nBody \nType";
                textBox1.Visible = false;
                Body_Type_BOX.Visible = true;
                Status_BOX.Visible = false;
            }
            else if (View_Combo_box.SelectedIndex == 4)
            {
                Search_term_label.Text = "Enter \nYear";
                textBox1.Visible = true;
                Body_Type_BOX.Visible = false;
                Status_BOX.Visible = false;
            }
            else if (View_Combo_box.SelectedIndex == 5)
            {
                Search_term_label.Text = "Enter \nBranch \nID";
                textBox1.Visible = true;
                Body_Type_BOX.Visible = false;
                Status_BOX.Visible = false;
            }
            else if (View_Combo_box.SelectedIndex == 6)
            {
                Search_term_label.Text = "Select \nStatus";
                textBox1.Visible = false;
                Body_Type_BOX.Visible = false;
                Status_BOX.Visible = true;
            }
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            View_Combo_box.Text = "";
            Body_Type_BOX.Text = "";
            Status_BOX.Text = "";
            textBox1.Clear();

            textBox1.Visible = false;
            Body_Type_BOX.Visible = false;
            Status_BOX.Visible = false;
            include_pricing.Visible = false;

            Search_term_label.Text = "Search \n Term";
            GRID_VIEW.DataSource = null;
            GRID_VIEW.Refresh();
        }
        private void Search_Button_Click(object sender, EventArgs e)
        {
            include_pricing.Checked = false;

            if (View_Combo_box.Text != "" && (Status_BOX.Text != "" || Body_Type_BOX.Text != "" || textBox1.Text != ""))
            {
                SqlConnection con = new SqlConnection(@SQL_conString.connection_String);

                if (View_Combo_box.SelectedIndex == 0 && textBox1.Text != "")  //VIN NUMBER
                {
                    
                    SqlCommand cmd = new SqlCommand("Select * From Cars where vin = '" + textBox1.Text + "'", con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        GRID_VIEW.DataSource = dt;
                        include_pricing.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("    ERROR: ITEM DOES NOT EXIST");
                    }
                    con.Close();
                }
                else if (View_Combo_box.SelectedIndex == 1 && textBox1.Text != "")  //LICENSE PLATE
                {

                    SqlCommand cmd = new SqlCommand("Select * From Cars where licensePlate = '" + textBox1.Text + "'", con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        GRID_VIEW.DataSource = dt;
                        include_pricing.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("    ERROR: ITEM DOES NOT EXIST");
                    }
                    con.Close();
                }
                else if (View_Combo_box.SelectedIndex == 2 && textBox1.Text != "")  //MODEL NOT WORKING
                {

                    SqlCommand cmd = new SqlCommand("Select * From Cars where model = '%" + textBox1.Text + "'or model ='" + textBox1.Text + "%'", con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        GRID_VIEW.DataSource = dt;
                        include_pricing.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("    ERROR: ITEM DOES NOT EXIST");
                    }
                    con.Close();
                }
                else if (View_Combo_box.SelectedIndex == 3)  //BODY TYPE
                {
                    SqlCommand cmd = new SqlCommand("Select * From Cars where bodyType = '" + Body_Type_BOX.Text + "'", con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        GRID_VIEW.DataSource = dt;
                        include_pricing.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("    ERROR: ITEM DOES NOT EXIST");
                    }
                    con.Close();
                }
                else if (View_Combo_box.SelectedIndex == 4 && textBox1.Text != "")  //YEAR
                {
                    SqlCommand cmd = new SqlCommand("Select * From Cars where year = '" + textBox1.Text + "'", con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        GRID_VIEW.DataSource = dt;
                        include_pricing.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("    ERROR: ITEM DOES NOT EXIST");
                    }
                    con.Close();
                }
                else if (View_Combo_box.SelectedIndex == 5 && textBox1.Text != "")  //BRANCH ID
                {
                    SqlCommand cmd = new SqlCommand("Select * From Cars where branchId = '" + textBox1.Text + "'", con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        GRID_VIEW.DataSource = dt;
                        include_pricing.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("    ERROR: ITEM DOES NOT EXIST");
                    }
                    con.Close();
                }
                else if (View_Combo_box.SelectedIndex == 6)  //STATUS
                {
                    SqlCommand cmd = new SqlCommand("Select * From Cars where rentStatus = '" + Status_BOX.Text + "'", con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    GRID_VIEW.DataSource = dt;
                    include_pricing.Visible = true;

                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("     ERROR: MAKE SURE YOU FILLED IN THE FIELDS CORRECTLY!");
            }
        }

        private void search_all_button_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@SQL_conString.connection_String);
            SqlCommand cmd = new SqlCommand("Select * From Cars", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            GRID_VIEW.DataSource = dt;

            con.Close();
        }

        private void add_clear_button_Click(object sender, EventArgs e)
        {
            vin_text_box.Text = "[ 17 Characters Long ]";
            lp_text_box.Text = "[  6 Characters Long ]";
            model_text_box.Text = "[ e.g. 'Audi R8 ']";
            bID_text_box.Text = "[  e.g. '101', 3 Characters Long]";

            add_bt_box.Text = "";
            add_status_combo_box.Text = "";
            year_combo_box.Text = "";

        }

        private void vin_text_box_Click(object sender, EventArgs e)
        {
            vin_text_box.Clear();
            vin_text_box.ForeColor = Color.FromArgb(0, 128, 128);
            vin_label.ForeColor = Color.FromArgb(0, 128, 128);

            lp_text_box.ForeColor = Color.Gray;
            lp_label.ForeColor = Color.WhiteSmoke;

            model_text_box.ForeColor = Color.Gray;
            m_label.ForeColor = Color.WhiteSmoke;

            bID_text_box.ForeColor = Color.Gray;
            bID_label.ForeColor = Color.WhiteSmoke;

        }

        private void lp_text_box_Click(object sender, EventArgs e)
        {
            vin_text_box.ForeColor = Color.Gray;
            vin_label.ForeColor = Color.WhiteSmoke;

            lp_text_box.Clear();
            lp_text_box.ForeColor = Color.FromArgb(0, 128, 128);
            lp_label.ForeColor = Color.FromArgb(0, 128, 128);

            model_text_box.ForeColor = Color.Gray;
            m_label.ForeColor = Color.WhiteSmoke;

            bID_text_box.ForeColor = Color.Gray;
            bID_label.ForeColor = Color.WhiteSmoke;
        }

        private void model_text_box_Click(object sender, EventArgs e)
        {
            vin_text_box.ForeColor = Color.Gray;
            vin_label.ForeColor = Color.WhiteSmoke;

            lp_text_box.ForeColor = Color.Gray;
            lp_label.ForeColor = Color.WhiteSmoke;

            model_text_box.Clear();
            model_text_box.ForeColor = Color.FromArgb(0, 128, 128);
            m_label.ForeColor = Color.FromArgb(0, 128, 128);


            bID_text_box.ForeColor = Color.Gray;
            bID_label.ForeColor = Color.WhiteSmoke;
        }

        private void bID_text_box_Click(object sender, EventArgs e)
        {
            vin_text_box.ForeColor = Color.Gray;
            vin_label.ForeColor = Color.WhiteSmoke;

            lp_text_box.ForeColor = Color.Gray;
            lp_label.ForeColor = Color.WhiteSmoke;

            model_text_box.ForeColor = Color.Gray;
            m_label.ForeColor = Color.WhiteSmoke;

            bID_text_box.Clear();
            bID_text_box.ForeColor = Color.FromArgb(0, 128, 128);
            bID_label.ForeColor = Color.FromArgb(0, 128, 128);
        }

        private void vin_text_box_TextChanged(object sender, EventArgs e)
        {
            vin_text_box.MaxLength = 17;
        }

        private void lp_text_box_TextChanged(object sender, EventArgs e)
        {
            lp_text_box.MaxLength = 6;
        }

        private void bID_text_box_TextChanged(object sender, EventArgs e)
        {
            bID_text_box.MaxLength = 3;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (View_Combo_box.SelectedIndex == 0)
            {
                textBox1.MaxLength = 17;
            }
            else if (View_Combo_box.SelectedIndex == 1)
            {
                textBox1.MaxLength = 6;
            }
            else if (View_Combo_box.SelectedIndex == 2)
            {
                textBox1.MaxLength = 35;
            }
            else if (View_Combo_box.SelectedIndex == 4)
            {
                textBox1.MaxLength = 4;
            }
            else if (View_Combo_box.SelectedIndex == 5)
            {
                textBox1.MaxLength = 3;
            }
        }

        private void include_pricing_CheckedChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@SQL_conString.connection_String);

            if (include_pricing.Checked == false)
            {
                if (View_Combo_box.SelectedIndex == 0 && textBox1.Text != "")  //VIN NUMBER
                {

                    SqlCommand cmd = new SqlCommand("Select * From Cars where vin = '" + textBox1.Text + "'", con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        GRID_VIEW.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("    ERROR: ITEM DOES NOT EXIST");
                    }
                    con.Close();
                }
                else if (View_Combo_box.SelectedIndex == 1 && textBox1.Text != "")  //LICENSE PLATE
                {

                    SqlCommand cmd = new SqlCommand("Select * From Cars where licensePlate = '" + textBox1.Text + "'", con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        GRID_VIEW.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("    ERROR: ITEM DOES NOT EXIST");
                    }
                    con.Close();
                }
                else if (View_Combo_box.SelectedIndex == 2 && textBox1.Text != "")  //MODEL NOT WORKING
                {

                    SqlCommand cmd = new SqlCommand("Select * From Cars where model = '%" + textBox1.Text + "'or model ='" + textBox1.Text + "%'", con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        GRID_VIEW.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("    ERROR: ITEM DOES NOT EXIST");
                    }
                    con.Close();
                }
                else if (View_Combo_box.SelectedIndex == 3)  //BODY TYPE
                {
                    SqlCommand cmd = new SqlCommand("Select * From Cars where bodyType = '" + Body_Type_BOX.Text + "'", con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        GRID_VIEW.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("    ERROR: ITEM DOES NOT EXIST");
                    }
                    con.Close();
                }
                else if (View_Combo_box.SelectedIndex == 4 && textBox1.Text != "")  //YEAR
                {
                    SqlCommand cmd = new SqlCommand("Select * From Cars where year = '" + textBox1.Text + "'", con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        GRID_VIEW.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("    ERROR: ITEM DOES NOT EXIST");
                    }
                    con.Close();
                }
                else if (View_Combo_box.SelectedIndex == 5 && textBox1.Text != "")  //BRANCH ID
                {
                    SqlCommand cmd = new SqlCommand("Select * From Cars where branchId = '" + textBox1.Text + "'", con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        GRID_VIEW.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("    ERROR: ITEM DOES NOT EXIST");
                    }
                    con.Close();
                }
                else if (View_Combo_box.SelectedIndex == 6)  //STATUS
                {
                    GRID_VIEW.DataSource = null;

                    SqlCommand cmd = new SqlCommand("Select * From Cars where rentStatus = '" + Status_BOX.Text + "'", con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    GRID_VIEW.DataSource = dt;

                    con.Close();
                }
            }

            if (include_pricing.Checked == true)
            {
                if (View_Combo_box.SelectedIndex == 0 && textBox1.Text != "")  //VIN NUMBER
                {

                    SqlCommand cmd = new SqlCommand("Select * From Cars C join CarTypes T on (C.bodyType = T.bodyType) where vin = '" + textBox1.Text + "'", con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        GRID_VIEW.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("    ERROR: ITEM DOES NOT EXIST");
                    }
                    con.Close();
                }
                else if (View_Combo_box.SelectedIndex == 1 && textBox1.Text != "")  //LICENSE PLATE
                {

                    SqlCommand cmd = new SqlCommand("Select * From Cars C join CarTypes T on (C.bodyType = T.bodyType) where licensePlate = '" + textBox1.Text + "'", con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        GRID_VIEW.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("    ERROR: ITEM DOES NOT EXIST");
                    }
                    con.Close();
                }
                else if (View_Combo_box.SelectedIndex == 2 && textBox1.Text != "")  //MODEL NOT WORKING
                {

                    SqlCommand cmd = new SqlCommand("Select * From Cars C join CarTypes T on (C.bodyType = T.bodyType) where model = '%" + textBox1.Text + "'or model ='" + textBox1.Text + "%'", con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        GRID_VIEW.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("    ERROR: ITEM DOES NOT EXIST");
                    }
                    con.Close();
                }
                else if (View_Combo_box.SelectedIndex == 3)  //BODY TYPE
                {
                    SqlCommand cmd = new SqlCommand("Select * From Cars C join CarTypes T on (C.bodyType = T.bodyType) where C.bodyType = '" + Body_Type_BOX.Text + "'", con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        GRID_VIEW.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("    ERROR: ITEM DOES NOT EXIST");
                    }
                    con.Close();
                }
                else if (View_Combo_box.SelectedIndex == 4 && textBox1.Text != "")  //YEAR
                {
                    SqlCommand cmd = new SqlCommand("Select * From Cars C join CarTypes T on (C.bodyType = T.bodyType) where year = '" + textBox1.Text + "'", con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        GRID_VIEW.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("    ERROR: ITEM DOES NOT EXIST");
                    }
                    con.Close();
                }
                else if (View_Combo_box.SelectedIndex == 5 && textBox1.Text != "")  //BRANCH ID
                {
                    SqlCommand cmd = new SqlCommand("Select * From Cars C join CarTypes T on (C.bodyType = T.bodyType) where branchId = '" + textBox1.Text + "'", con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        GRID_VIEW.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("    ERROR: ITEM DOES NOT EXIST");
                    }
                    con.Close();
                }
                else if (View_Combo_box.SelectedIndex == 6)  //STATUS
                {
                    SqlCommand cmd = new SqlCommand("Select * From Cars C join CarTypes T on (C.bodyType = T.bodyType) where rentStatus = '" + Status_BOX.Text + "'", con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    GRID_VIEW.DataSource = dt;

                    con.Close();
                }
            }
        }

        private void delete_vin_text_box_Click(object sender, EventArgs e)
        {
            delete_vin_text_box.Clear();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            SqlCommand cm;
            SqlDataReader sdr;
            SqlConnection con = new SqlConnection(@SQL_conString.connection_String);

            String SqlStatement = "INSERT INTO Cars (vin, licensePlate, bodyType, model, gasType, [year], branchID, rentStatus) VALUES ('" + vin_text_box.Text + "', '" + lp_text_box.Text + "', '" +add_bt_box.Text  +"', '" + model_text_box.Text + "', 'premium unleaded', " + year_combo_box.Text.ToString() + ", " + bID_text_box.Text.ToString() + ", '" + add_status_combo_box.Text + "');";
     
            try
            {
                con.Open();
                cm = new SqlCommand(SqlStatement, con);

                sdr = cm.ExecuteReader();
                MessageBox.Show("Saved");
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

        private void delete_clear_button_Click(object sender, EventArgs e)
        {
            delete_vin_text_box.Text = "[Enter Vehicle VIN Number]";
            delete_vin_text_box.ReadOnly = false;

            Delete_button.Visible = false;
            delete_clear_button.Visible = false;
        }

        private void delete_vin_text_box_TextChanged(object sender, EventArgs e)
        {
            delete_vin_text_box.MaxLength = 17;
            if (Delete_button.Visible == false)
            {
                SqlConnection con = new SqlConnection(@SQL_conString.connection_String);  // calls class which contains the connection string
                SqlCommand cmd = new SqlCommand("Select * From Cars where vin = '" + delete_vin_text_box.Text + "'", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Car Name: " + dt.Rows[0]["model"].ToString() );
                    delete_vin_text_box.ReadOnly = true;

                    Delete_button.Visible = true;
                    delete_clear_button.Visible = true;
                }
                con.Close();
            }

        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            SqlCommand cm;
            SqlDataReader sdr;
            SqlConnection con = new SqlConnection(@SQL_conString.connection_String);

            String SqlStatement = "DELETE FROM Cars WHERE vin = '" + delete_vin_text_box.Text + "';";

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
}

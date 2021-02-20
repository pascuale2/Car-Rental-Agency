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
    public partial class bookings_menu : Form
    {
        public static string pickUpDate = "";
        public static string pickUpDateDT = "";
        public static string dropOffDate = "";
        public static string dropOffDateDT = "";

        public static string pickUpLocation = "";
        public static string dropOffLocation = "";
        public static string dropOffBranchID = "";

        public static int dateDifference;


        public bookings_menu()
        {
            InitializeComponent();
        }

        //LOADING THE FORM/NEXT AND BACK BUTTONS
        /******************************************************************************************************************************************************/
        private void bookings_menu_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@SQL_conString.connection_String);
            SqlCommand cmd = new SqlCommand("Select * from Branches", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            DataTable dt2 = new DataTable();
            sda.Fill(dt);
            sda.Fill(dt2);

            pick_up_box.DataSource = dt;
            pick_up_box.DisplayMember = "city";
            pick_up_box.ValueMember = "branchID";

            drop_off_box.DataSource = dt2;
            drop_off_box.DisplayMember = "city";
            drop_off_box.ValueMember = "branchID";

            con.Close();
        }

        private void find_cars_bookings_Click(object sender, EventArgs e)
        {
            if (pick_up_box.Text != "" && drop_off_box.Text != "")
            {
                //set the pickUp and dropOff public strings
                pickUpLocation = pick_up_box.SelectedValue.ToString();
                dropOffLocation = drop_off_box.SelectedValue.ToString();
                dropOffBranchID = drop_off_box.ValueMember.ToString();

                //set public DateTime variables
                pickUpDateDT = pick_up_date_pick.Value.ToShortDateString();
                dropOffDateDT = drop_off_date_pick.Value.ToShortDateString();


                //calculate difference in dates
                DateTime startDate = pick_up_date_pick.Value.Date;
                DateTime endDate = drop_off_date_pick.Value.Date;
                TimeSpan timeSpan = endDate - startDate;

                //set the public variable to the difference in days
                dateDifference = timeSpan.Days;

                //load new form
                bookings_menu1 bm1 = new bookings_menu1();
                this.Hide();
                bm1.Show();
            }
            else
            {
                MessageBox.Show("    ERROR: MAKE SURE YOU FILLED THE FIELDS CORRECTLY");
            }
        }

        private void clear_button_bookings_Click(object sender, EventArgs e)
        {
            pick_up_date_text_box.Text = "";
            drop_off_text_box.Text = "";

            pick_up_box.SelectedIndex = 0;
            drop_off_box.SelectedIndex = 0;

        }

        /******************************************************************************************************************************************************/

        //MAKING THE EXIT, MINIMIZE, AND MOUSEMOVE 
        /******************************************************************************************************************************************************/

        private void exit_button_bookings_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimize_button_bookings_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void bookings_menu_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        Point lastPoint;
        private void bookings_menu_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        /******************************************************************************************************************************************************/

        //VIEW TAB CONTRTOLS AND SQL STATEMENTS
        /******************************************************************************************************************************************************/

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox4.Text != "")
            {
                String sqlStatement = textBox4.Text;

                SqlConnection con = new SqlConnection(@SQL_conString.connection_String);
                SqlCommand cmd = new SqlCommand("Select * from RentalTransactions where transID = '" + sqlStatement + "'", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);


                dataGridView2.DataSource = dt;

                con.Close();
            }
            else
            {
                MessageBox.Show("    ERROR: MAKE SURE YOU FILL IN THE FIELDS CORRECTLY");
            }
        
        }
        /******************************************************************************************************************************************************/

        //ADD TAB CONTROLS AND SQL STATEMENTS
        /******************************************************************************************************************************************************/
        private void pick_up_date_pick_ValueChanged(object sender, EventArgs e)
        {
            pick_up_date_text_box.Text = pick_up_date_pick.Text;
            pickUpDate = pick_up_date_pick.Text;
        }

        private void drop_off_date_pick_ValueChanged(object sender, EventArgs e)
        {
            drop_off_text_box.Text = drop_off_date_pick.Text;
            dropOffDate = drop_off_date_pick.Text;

        }
        /******************************************************************************************************************************************************/
        //UPDATE TAB CONTROLS AND SQL STATEMENTS
        /******************************************************************************************************************************************************/

        private void button6_Click(object sender, EventArgs e)
        {
            //start connection
            SqlConnection con = new SqlConnection(@SQL_conString.connection_String);
            String SqlStatement = "UPDATE RentalTransactions SET dateDropped ='" + textBox10.Text + "' WHERE transID = '" + search_transID.Text + "'";
            String SqlStatement2 = "UPDATE Returning SET empID ='" + textBox11.Text + "' FROM Returning JOIN RentalTransactions ON RentalTransactions.transID = Returning.transID  WHERE RentalTransactions.transID = '" + search_transID.Text + "'";
            String SqlStatement3 = "UPDATE Returning SET destinationBranchID ='" + textBox9.Text + "' FROM Returning JOIN RentalTransactions ON RentalTransactions.transID = Returning.transID  WHERE RentalTransactions.transID = '" + search_transID.Text + "'";
            String SqlStatement4 = "UPDATE Returning SET returnDate ='" + textBox10.Text + "' FROM Returning JOIN RentalTransactions ON RentalTransactions.transID = Returning.transID  WHERE RentalTransactions.transID = '" + search_transID.Text + "'";

            //can we make all these strings into one large sql statement using UNION ??!?!?

            SqlCommand cm;
            SqlDataReader sdr;
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
            try
            {
                con.Open();
                cm = new SqlCommand(SqlStatement2, con);

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
            try
            {
                con.Open();
                cm = new SqlCommand(SqlStatement3, con);

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
            try
            {
                con.Open();
                cm = new SqlCommand(SqlStatement4, con);

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

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@SQL_conString.connection_String);
            SqlCommand cmd = new SqlCommand("Select * from RentalTransactions where transID = '" + search_transID.Text + "'", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            sda.Fill(dt);

            dataGridView2.DataSource = dt;


        }
        //UPDATE CONTROLS AND SQL FILES
        /******************************************************************************************************************************************************/

        private void button6_Click_1(object sender, EventArgs e)
        {
            //start connection
            SqlConnection con = new SqlConnection(@SQL_conString.connection_String);
            String SqlStatement = "UPDATE RentalTransactions SET dateDropped ='" + textBox10.Text + "' WHERE transID = '" + search_transID.Text + "'";
            String SqlStatement2 = "UPDATE Returning SET empID ='" + textBox11.Text + "' FROM Returning JOIN RentalTransactions ON RentalTransactions.transID = Returning.transID  WHERE RentalTransactions.transID = '" + search_transID.Text + "'";
            String SqlStatement3 = "UPDATE Returning SET destinationBranchID ='" + textBox9.Text + "' FROM Returning JOIN RentalTransactions ON RentalTransactions.transID = Returning.transID  WHERE RentalTransactions.transID = '" + search_transID.Text + "'";
            String SqlStatement4 = "UPDATE Returning SET returnDate ='" + textBox10.Text + "' FROM Returning JOIN RentalTransactions ON RentalTransactions.transID = Returning.transID  WHERE RentalTransactions.transID = '" + search_transID.Text + "'";

            //can we make all these strings into one large sql statement using UNION ??!?!?

            SqlCommand cm;
            SqlDataReader sdr;
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
            try
            {
                con.Open();
                cm = new SqlCommand(SqlStatement2, con);

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
            try
            {
                con.Open();
                cm = new SqlCommand(SqlStatement3, con);

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
            try
            {
                con.Open();
                cm = new SqlCommand(SqlStatement4, con);

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

        private void update_search_button_Click(object sender, EventArgs e)
        {
         
            SqlConnection con = new SqlConnection(@SQL_conString.connection_String);
            SqlCommand cmd = new SqlCommand("Select * from RentalTransactions where transID = '" + search_transID.Text + "'", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            sda.Fill(dt);

            dataGridView1.DataSource = dt;
        }



        /******************************************************************************************************************************************************/


        private void search_transID_TextChanged(object sender, EventArgs e)
        {
            search_transID.MaxLength = 5;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox4.MaxLength = 5;
        }
    }

}


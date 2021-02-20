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

    public partial class bookings_menu1 : Form
    {
        //ALL STRINGS WILL BE SENT TO BOOKINGMENUE3 FOR INSERT STATEMENTS
        /******************************************************************************************************************************************************/
        public static string vehicleVin = "";
        public static string vehicleName = "";
        public static string bodyType = "";
        public static string gasType = "";
        public static string carYear = "";

        public static string totalBill = "";


        /******************************************************************************************************************************************************/

        public bookings_menu1() 
        {
            InitializeComponent();
        }
        
        //LOADING THE FORM/NEXT AND BACK BUTTONS
        /******************************************************************************************************************************************************/
        private void Form3_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@SQL_conString.connection_String);
            con.Open();

            SqlCommand cmd = new SqlCommand("Select * from Cars where rentStatus = 'available' ", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "model";
            comboBox1.ValueMember = "vin";

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            vehicleVin = comboBox1.SelectedValue.ToString();
            bodyType = textBox1.Text;
            gasType = textBox5.Text;
            carYear = textBox2.Text;
            totalBill = textBox14.Text;
            vehicleName = comboBox1.Text;

            bookings_menu2 bm2 = new bookings_menu2();
            this.Hide();
            bm2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bookings_menu bm = new bookings_menu();
            this.Hide();
            bm.Show();
        }

        /******************************************************************************************************************************************************/


        //MAKING THE EXIT, MINIMIZE, AND MOUSEMOVE 
        /******************************************************************************************************************************************************/
        private void exit_button_bookings_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimize_button_bookings_Click_1(object sender, EventArgs e)
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
        
        //VIEW TAB BUTTONS AND SQL STATEMENTS
        /******************************************************************************************************************************************************/

        private void button4_Click(object sender, EventArgs e)
        {
            string conString = "Data Source=AKHI-LAPTOP;Initial Catalog=TemporaryTest;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            String sqlStatement = textBox4.Text;

            SqlConnection con = new SqlConnection(@conString);
            SqlCommand cmd = new SqlCommand("Select * from RentalTransactions where transID = " + sqlStatement, con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            sda.Fill(dt);

            dataGridView1.DataSource = dt;

            con.Close();
        }

        /******************************************************************************************************************************************************/

        //ADD TAB CONTROLS AND SQL STATEMENTS
        /******************************************************************************************************************************************************/
        private void button5_Click(object sender, EventArgs e)
        {
            //start connection
            SqlConnection con = new SqlConnection(@"Data Source = AKHI-LAPTOP; Initial Catalog = TemporaryTest; Integrated Security = True; Connect Timeout = 15; Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            String sqlStatement = comboBox1.SelectedValue.ToString();
            con.Open();

            SqlCommand cmd = new SqlCommand("Select bodyType from Cars where vin = '" + sqlStatement + "'", con);
            textBox1.Text = cmd.ExecuteScalar().ToString();

            SqlCommand cmd1 = new SqlCommand("Select gasType from Cars where vin = '" + sqlStatement + "'", con);
            textBox5.Text = cmd1.ExecuteScalar().ToString();

            SqlCommand cmd2 = new SqlCommand("Select year from Cars where vin = '" + sqlStatement + "'", con);
            textBox2.Text = cmd2.ExecuteScalar().ToString();

            SqlCommand cmd3 = new SqlCommand("Select normalRate from CarTypes JOIN Cars ON Cars.bodyType= CarTypes.bodyType where vin = '" + sqlStatement + "'", con);
            textBox8.Text = cmd3.ExecuteScalar().ToString();

            SqlCommand cmd4 = new SqlCommand("Select branchFees from CarTypes JOIN Cars ON Cars.bodyType= CarTypes.bodyType where vin = '" + sqlStatement + "'", con);
            textBox7.Text = cmd4.ExecuteScalar().ToString();

            SqlCommand cmd5 = new SqlCommand("Select penaltyRate from CarTypes JOIN Cars ON Cars.bodyType= CarTypes.bodyType where vin = '" + sqlStatement + "'", con);
            textBox6.Text = cmd5.ExecuteScalar().ToString();

            //calculating the rate * days wanted for rent
            textBox12.Text = (int.Parse(this.textBox8.Text) * bookings_menu.dateDifference).ToString();
            textBox13.Text = textBox7.Text;
            //display the total rate + branch fees
            textBox14.Text = (int.Parse(textBox12.Text) + int.Parse(textBox13.Text)).ToString();
            

            con.Close();
        }

        /******************************************************************************************************************************************************/

        //UPDATE TAB CONTROLS AND SQL STATEMENTS
        /******************************************************************************************************************************************************/
        private void button6_Click(object sender, EventArgs e)
        {
            //start connection
            SqlConnection con = new SqlConnection(@"Data Source = AKHI-LAPTOP; Initial Catalog = TemporaryTest; Integrated Security = True; Connect Timeout = 15; Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            String SqlStatement = "UPDATE RentalTransactions SET dateDropped ='" + textBox10.Text + "' WHERE transID = '" + search_transID.Text + "'";
            String SqlStatement2 = "UPDATE Returning SET empID ='" + textBox11.Text + "' FROM Returning JOIN RentalTransactions ON RentalTransactions.transID = Returning.transID  WHERE RentalTransactions.transID = '" + search_transID.Text + "'";
            String SqlStatement3 = "UPDATE Returning SET destinationBranchID ='" + textBox9.Text + "' FROM Returning JOIN RentalTransactions ON RentalTransactions.transID = Returning.transID  WHERE RentalTransactions.transID = '" + search_transID.Text + "'";
            String SqlStatement4 = "UPDATE Returning SET returnDate ='" + textBox10.Text + "' FROM Returning JOIN RentalTransactions ON RentalTransactions.transID = Returning.transID  WHERE RentalTransactions.transID = '" + search_transID.Text + "'";

            //can we make all these strings into one large sql statement using UNION ??!?!?

            SqlCommand cm;
            SqlDataReader sdr;
            try{
                con.Open();
                cm = new SqlCommand(SqlStatement, con);

                sdr = cm.ExecuteReader();
                MessageBox.Show("Saved");
                while (sdr.Read())
                {
                }
              }catch (Exception ex) { 
            
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
            string conString = "Data Source=AKHI-LAPTOP;Initial Catalog=TemporaryTest;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            SqlConnection con = new SqlConnection(@conString);
            SqlCommand cmd = new SqlCommand("Select * from RentalTransactions where transID = '" + search_transID.Text + "'" , con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            sda.Fill(dt);

            dataGridView2.DataSource = dt;

         
        }



        /******************************************************************************************************************************************************/

    }
    
}

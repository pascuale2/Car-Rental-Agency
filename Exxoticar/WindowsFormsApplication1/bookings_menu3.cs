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
    public partial class bookings_menu3 : Form
    {
        public static int maxTransID;

    
        public bookings_menu3()
        {
            InitializeComponent();
        }
        //LOADING TH FORM/NEXT AND BACK BUTTONS
        /******************************************************************************************************************************************************/
        private void bookings_menu3_Load(object sender, EventArgs e)
        {
            textBox1.Text = bookings_menu2.authorizingEmployee;
            textBox2.Text = bookings_menu.pickUpLocation;
            textBox5.Text = bookings_menu.dropOffLocation;
            textBox3.Text = ("Pickup Date: " + bookings_menu.pickUpDate + " Drop Off Date: " + bookings_menu.dropOffDate);
            textBox6.Text = bookings_menu1.vehicleName;
            textBox7.Text = bookings_menu1.totalBill;
            textBox15.Text = bookings_menu2.driversLicense.ToString();
            textBox14.Text = bookings_menu2.fname;
            textBox13.Text = bookings_menu2.lname;
            textBox12.Text = bookings_menu2.gender;
            textBox11.Text = bookings_menu2.province;
            textBox10.Text = bookings_menu2.city;
            textBox9.Text = bookings_menu2.phoneNumber.ToString();
            textBox8.Text = bookings_menu2.creditCard.ToString();

            //getting the max transID 
            string conString = "Data Source=AKHI-LAPTOP;Initial Catalog=TemporaryTest;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            String sqlStatement = textBox4.Text;

            SqlConnection con = new SqlConnection(@conString);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT MAX(transID) FROM RentalTransactions;", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            //setting the max trans ID and inprementing it 1
            maxTransID = int.Parse(cmd.ExecuteScalar().ToString()) +1 ;

            con.Close();
            MessageBox.Show(maxTransID.ToString());
        }


        private void button2_Click(object sender, EventArgs e)
        {
            bookings_menu2 bm2 = new bookings_menu2();
            this.Hide();
            bm2.Show();
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

        //VIEW TAB CONTROLS AND SQL STATEMENT
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
        private void button1_Click_1(object sender, EventArgs e)
        {
           
            String SqlStatement = "INSERT INTO Customers (driversLicense, fname, lname, gender, dob, phoneNumber, streetNumber, streetName, aptNumber, bldgNumber, city, province, zip, creditCard, policyID) values (" + bookings_menu2.driversLicense.ToString()+ ", '" + bookings_menu2.fname + "', '" + bookings_menu2.lname + "', '" + bookings_menu2.gender + "', '" + bookings_menu2.dob.ToString() + "', " + bookings_menu2.phoneNumber.ToString() + ", " + bookings_menu2.streetNumber.ToString() + ", '" + bookings_menu2.streetName + "', " + bookings_menu2.aptNumber.ToString() + ", " + bookings_menu2.bldgNumber.ToString() + ", '" + bookings_menu2.city + "', '" + bookings_menu2.province + "', '" + bookings_menu2.zip + "', " + bookings_menu2.creditCard.ToString() + ", " + bookings_menu2.policyID.ToString() +");" ;
           // String SqlStatement = "UPDATE RentalTransactions SET dateDropped ='" + textBox10.Text + "' WHERE transID = '" + textBox3.Text + "'";

            String SqlStatement2 = "UPDATE Cars SET rentStatus ='rented' WHERE vin ='" +bookings_menu1.vehicleVin+"' ;" ;
            String SqlStatement3 = "INSERT INTO RentalTransactions (transID, authorizingEmpID, branchID, datePaid, datePicked, dateDropped, vin, driversLicense) VALUES (" + maxTransID.ToString() + ", " + bookings_menu2.authorizingEmployee + ", " + bookings_menu2.branchID + ", '" + bookings_menu.pickUpDateDT.ToString()+ "', '" + bookings_menu.dropOffDateDT.ToString() + "', '" + bookings_menu.dropOffDateDT.ToString() + "', '" + bookings_menu1.vehicleVin + "', " + bookings_menu2.driversLicense.ToString() + ");";
            MessageBox.Show(SqlStatement2);
            MessageBox.Show(SqlStatement3);

            SqlConnection con = new SqlConnection(@"Data Source = AKHI-LAPTOP; Initial Catalog = TemporaryTest; Integrated Security = True; Connect Timeout = 15; Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
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

        }

        //UPDATE TAB CONTROLS AND SQL STATEMENTS
        /******************************************************************************************************************************************************/

        private void button3_Click(object sender, EventArgs e)
        {
            string conString = "Data Source=AKHI-LAPTOP;Initial Catalog=TemporaryTest;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            SqlConnection con = new SqlConnection(@conString);
            SqlCommand cmd = new SqlCommand("Select * from RentalTransactions where transID = '" + textBox3.Text + "'", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            sda.Fill(dt);

            dataGridView2.DataSource = dt;
        }

        private void button6_Click(object sender, EventArgs e)
        {

            //start connection
            SqlConnection con = new SqlConnection(@"Data Source = AKHI-LAPTOP; Initial Catalog = TemporaryTest; Integrated Security = True; Connect Timeout = 15; Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            String SqlStatement = "UPDATE RentalTransactions SET dateDropped ='" + textBox10.Text + "' WHERE transID = '" + textBox3.Text + "'";
            String SqlStatement2 = "UPDATE Returning SET empID ='" + textBox11.Text + "' FROM Returning JOIN RentalTransactions ON RentalTransactions.transID = Returning.transID  WHERE RentalTransactions.transID = '" + textBox3.Text + "'";
            String SqlStatement3 = "UPDATE Returning SET destinationBranchID ='" + textBox9.Text + "' FROM Returning JOIN RentalTransactions ON RentalTransactions.transID = Returning.transID  WHERE RentalTransactions.transID = '" + textBox3.Text + "'";
            String SqlStatement4 = "UPDATE Returning SET returnDate ='" + textBox10.Text + "' FROM Returning JOIN RentalTransactions ON RentalTransactions.transID = Returning.transID  WHERE RentalTransactions.transID = '" + textBox3.Text + "'";

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

        private void exit_button_bookings_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimize_button_bookings_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }



        /******************************************************************************************************************************************************/
    }
}

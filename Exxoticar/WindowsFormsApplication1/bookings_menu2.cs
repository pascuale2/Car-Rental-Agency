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
    public partial class bookings_menu2 : Form
    {
        //ALL STRINGS WILL BE SENT TO BOOKINGMENUE3 FOR INSERT STATEMENTS
        /******************************************************************************************************************************************************/
        public static string authorizingEmployee = "";
        public static int driversLicense;
        public static string fname = "";
        public static string lname = "";
        public static string gender = "";
        public static string dob = "";
        public static int phoneNumber;
        public static int streetNumber;
        public static string streetName;
        public static int aptNumber;
        public static int bldgNumber;
        public static string city = "";
        public static string province = "";
        public static string zip = "";
        public static int creditCard;
        public static int policyID;
        public static int branchID;


        /******************************************************************************************************************************************************/


        public bookings_menu2()
        {

            InitializeComponent();
        }

        //LOADING THE FORM/NEXT AND BACK BUTTONS
        /******************************************************************************************************************************************************/
        private void bookings_menu2_Load(object sender, EventArgs e)
        {
            textBox23.Text = bookings_menu1.vehicleName;
            textBox3.Text = bookings_menu1.bodyType;
            textBox20.Text = bookings_menu1.gasType;
            textBox16.Text = bookings_menu1.carYear;
            textBox24.Text = bookings_menu1.totalBill;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            bookings_menu1 bm1 = new bookings_menu1();
            this.Hide();
            bm1.Show();
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

        //ADD TAB CONTROLS AND SQL STATEMENTS
        /******************************************************************************************************************************************************/
        private void button1_Click_1(object sender, EventArgs e)
        {
            authorizingEmployee = textBox22.Text;

            driversLicense = int.Parse(textBox21.Text);
            fname = textBox2.Text;
            lname = textBox1.Text;
            gender = textBox6.Text;
            dob = textBox15.Text; //need to implement dob
            phoneNumber = int.Parse(textBox5.Text);
            streetNumber = int.Parse(textBox11.Text);
            streetName = textBox12.Text;
            aptNumber = int.Parse(textBox13.Text);
            bldgNumber = int.Parse(textBox10.Text);
            city = textBox8.Text;
            province = textBox7.Text;
            zip = textBox9.Text;
            creditCard = int.Parse(textBox14.Text);
            branchID = int.Parse(textBox17.Text);
            policyID = 10001;
            //MessageBox.Show(driversLicense.ToString());


          
        
            bookings_menu3 bm3 = new bookings_menu3();
            this.Hide();
            bm3.Show();

        }
        /******************************************************************************************************************************************************/

        //VIEW TAB CONTROLS AND SQL STATEMENTS
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

        private void exit_button_bookings_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimize_button_bookings_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }



        /******************************************************************************************************************************************************/
        //UPDATE TAB CONTROLS AND SQL STATEMENTS
        /******************************************************************************************************************************************************/


        /******************************************************************************************************************************************************/

    }
}

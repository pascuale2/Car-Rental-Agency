using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class admin_main_menu : Form
    {
        public admin_main_menu()
        {
            InitializeComponent();
        }

        private void Bookings_button_Click(object sender, EventArgs e)
        {
            bookings_menu bm = new bookings_menu();
            bm.Show();
            this.Hide();
        }

        private void Information_button_Click(object sender, EventArgs e)
        {
            information_menu im = new information_menu();
            im.Show();
            this.Hide();
        }

        private void admin_main_menu_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        Point lastPoint;
        private void admin_main_menu_MouseDown(object sender, MouseEventArgs e)
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

        private void Log_out_button_Click(object sender, EventArgs e)
        {
            Main_Menu mm = new Main_Menu();
            mm.Show();
            this.Hide();
        }

        private void Stock_Inquiry_button_Click(object sender, EventArgs e)
        {
            stock_inquiry_admin sm = new stock_inquiry_admin();
            sm.Show();
            this.Hide();
        }

        private void Customer_Inquiry_button_Click(object sender, EventArgs e)
        {
            customer_inquiry_admin cia = new customer_inquiry_admin();
            cia.Show();
            this.Hide();
        }

        private void Employee_Inquiry_button_Click(object sender, EventArgs e)
        {
            employee_inquiry ei = new employee_inquiry();
            ei.Show();
            this.Hide();
        }

        private void Reports_button_Click(object sender, EventArgs e)
        {
            reports_menu rm = new reports_menu();
            rm.Show();
            this.Hide();
        }
    }
}

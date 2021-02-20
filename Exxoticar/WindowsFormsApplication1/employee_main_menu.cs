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
    public partial class employee_main_menu : Form
    {
        public employee_main_menu()
        {
            InitializeComponent();
        }

        private void employee_main_menu_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        Point lastPoint;
        private void employee_main_menu_MouseDown(object sender, MouseEventArgs e)
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
            stock_inquiry_employee sie = new stock_inquiry_employee();
            sie.Show();
            this.Hide();
        }

        private void Information_button_Click(object sender, EventArgs e)
        {
            information_menu im = new information_menu();
            im.Show();
            this.Hide();
        }

        private void Customer_Inquiry_button_Click(object sender, EventArgs e)
        {
            customer_inquiry_employee cie = new customer_inquiry_employee();
            cie.Show();
            this.Hide();
        }
    }
}

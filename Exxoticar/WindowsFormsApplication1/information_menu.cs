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
    public partial class information_menu : Form
    {
        public information_menu()
        {
            InitializeComponent();
        }

        private void main_menu_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            employee_main_menu emm = new employee_main_menu();
            emm.Show();
        }

        private void exit_button_info_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimize_button_info_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void information_menu_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        Point lastPoint;
        private void information_menu_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
    }
}

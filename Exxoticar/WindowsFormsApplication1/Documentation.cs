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
    public partial class Documentation : Form
    {
        public Documentation()
        {
            InitializeComponent();
        }

        private void open_pdf_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "PDF Files |*.pdf";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                axAcroPDF1.src = openFileDialog1.FileName;
            }

        }

        private void back_main_menu_Click(object sender, EventArgs e)
        {
            Main_Menu m_m = new Main_Menu();
            m_m.Show();
            this.Hide();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimize_button_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}

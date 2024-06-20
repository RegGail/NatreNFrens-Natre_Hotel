using NatreHote_.PAGES.ABOUT_US;
using NatreHote_.PAGES.ADMINMANAGER_SIDE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NatreHote_.PAGES.ADMIN_SIDE
{
    public partial class ADMIN_LOGIN : Form
    {
        public ADMIN_LOGIN()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            shadow.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        //Login Button
        private void button1_Click(object sender, EventArgs e)
        {
            ADMIN_mDashboard admindash = new ADMIN_mDashboard();
            admindash.Show();
            this.Hide();
        }
    }
}

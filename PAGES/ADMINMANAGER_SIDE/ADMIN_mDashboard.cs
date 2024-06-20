using NatreHote_.PAGES.ABOUT_US;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NatreHote_.PAGES.ADMINMANAGER_SIDE
{
    public partial class ADMIN_mDashboard : Form
    {
        public ADMIN_mDashboard()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Line1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void transparentTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void ADMIN_mDashboard_Load(object sender, EventArgs e)
        {

        }

        private void sPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        //Sidebar Controls
        private void label3_Click(object sender, EventArgs e)
        {
            ADMIN_mStaffList adminstaff = new ADMIN_mStaffList();
            adminstaff.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HOMEPAGE homepage1 = new HOMEPAGE();
            homepage1.Show();
            this.Hide();
        }
    }
}

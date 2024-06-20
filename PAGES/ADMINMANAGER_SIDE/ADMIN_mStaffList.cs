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
    public partial class ADMIN_mStaffList : Form
    {
        public ADMIN_mStaffList()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        //Tab Control Buttons
        //Active Employees
        private void label42_Click(object sender, EventArgs e)
        {
            PageEmployees.SelectTab(PageEmp_ALL);
        }

        private void label41_Click(object sender, EventArgs e)
        {
            PageEmployees.SelectTab(PageEmp_INACT);
        }

        //Inactive Employees
        private void label74_Click(object sender, EventArgs e) 
        {
            PageEmployees.SelectTab(PageEmp_ALL);
        }

        private void label75_Click(object sender, EventArgs e)
        {
            PageEmployees.SelectTab(PageEmp_ACT);
        }

        //All Employees
        private void label39_Click(object sender, EventArgs e)
        {
            PageEmployees.SelectTab(PageEmp_ACT);
        }

        private void label40_Click(object sender, EventArgs e)
        {
            PageEmployees.SelectTab(PageEmp_INACT);
        }

        //Sidebar Controls
        private void label3_Click(object sender, EventArgs e)
        {
            ADMIN_mDashboard admindash1 = new ADMIN_mDashboard();
            admindash1.Show();
            this.Hide();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HOMEPAGE homepage = new HOMEPAGE();
            homepage.Show();
            this.Hide();
            this.Close();
        }
    }
}

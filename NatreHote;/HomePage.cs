using NatreHote_.PAGES.ABOUT_US;
using NatreHote_.PAGES.ADMIN_SIDE;
using NatreHote_.PAGES.FACILITIES;
using NatreHote_.PAGES.LOCATION;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NatreHote_
{
    public partial class HOMEPAGE : Form
    {
        public HOMEPAGE()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            panel3.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        //menu controls
        private void label2_Click_1(object sender, EventArgs e)
        {
            facilities_new faci = new facilities_new();
            faci.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            AboutUs1 about1 = new AboutUs1();
            about1.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            location_new loc = new location_new();
            loc.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            BOOKINGpg1 book1 = new BOOKINGpg1();
            book1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ADMIN_LOGIN adminlogin = new ADMIN_LOGIN();
            adminlogin.Show();
            this.Hide();
        }
    }
}

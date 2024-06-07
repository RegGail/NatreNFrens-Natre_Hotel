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
    public partial class BOOKINGpg1 : Form
    {
        public BOOKINGpg1()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            panel3.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void sPanel1_Paint(object sender, PaintEventArgs e)
        {
            sPanel1.BackColor = Color.FromArgb(65, 245, 234, 230);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }

}

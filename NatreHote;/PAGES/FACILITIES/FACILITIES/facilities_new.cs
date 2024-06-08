using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NatreHote_.PAGES.FACILITIES
{
    public partial class facilities_new : Form
    {
        public facilities_new()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void sPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
    public class TouchScroll
    {
        private Panel mouseDownPoint;
        private FlowLayoutPanel parentpanel;
        public TouchScroll(FlowlayoutPanel panel)
        {
            parentPanel = panel;
        }
        private void AssignEvent(Control control)
        {
            control.MouseDown += MouseDown;
            control.MouseMove += MouseMove;
            foreach (Control control )
        }

        private void MouseDown(object sender, MouseEventArgs e) 
        {
          throww new NotImplementedExeption();
        }
    }
}

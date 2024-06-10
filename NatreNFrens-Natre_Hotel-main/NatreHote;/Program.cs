using NatreHote_.PAGES.ABOUT_US;
using NatreHote_.PAGES.FACILITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NatreHote_
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new HOMEPAGE());
            //Application.Run(new BOOKINGpg1());
            //Application.Run(new BOOKINGprocess());
            Application.Run(new AboutUs1());
            //Application.Run(new AboutUs2());
            //Application.Run(new facilities_new());
        }
    }
}

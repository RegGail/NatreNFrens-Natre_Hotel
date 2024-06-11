using NatreHote_.PAGES.ABOUT_US;
using NatreHote_.PAGES.BOOKING;
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
            //HOMEPAGE
            //Application.Run(new HOMEPAGE());

            //BOOKING PAGES
            //Application.Run(new BOOKINGpg1());
            //Application.Run(new BOOKINGpg2());
            Application.Run(new BOOKINGpg3());

            //ABOUT US PAGES
            //Application.Run(new AboutUs1());
            //Application.Run(new AboutUs2());
            //Application.Run(new AboutUs3());
            //Application.Run(new AboutUs4());

            //FACILITIES PAGES
            //Application.Run(new facilities_new());
        }
    }
}

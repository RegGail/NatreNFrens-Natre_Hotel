using NatreHote_.PAGES.ABOUT_US;
using NatreHote_.PAGES.ADMIN_SIDE;
using NatreHote_.PAGES.ADMINMANAGER_SIDE;
using NatreHote_.PAGES.BOOKING;
using NatreHote_.PAGES.FACILITIES;
using NatreHote_.PAGES.LOCATION;
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
            //JUN 19, 2024

            //HOMEPAGE
            Application.Run(new HOMEPAGE());

            //BOOKING PAGES
            //Application.Run(new BOOKINGpg1());
            //Application.Run(new BOOKINGpg2());
            //Application.Run(new BOOKINGpg3());

            //ABOUT US PAGES
            //Application.Run(new AboutUs1());
            //Application.Run(new AboutUs2());
            //Application.Run(new AboutUs3());
            //Application.Run(new AboutUs4());

            //FACILITIES PAGES
            //Application.Run(new facilities_new());

            //LOCATION PAGE
            //Application.Run(new location_new());

            //ADMIN MANAGER PAGE
            //Application.Run(new ADMIN_LOGIN());
            //Application.Run(new ADMIN_mDashboard());
            //Application.Run(new ADMIN_mStaffList());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PremierCare_Clinic_App.Appointment;
using PremierCare_Clinic_App.Login;
using PremierCare_Clinic_App.Patient;

namespace PremierCare_Clinic_App
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StaffLoginForm());
        }
    }
}

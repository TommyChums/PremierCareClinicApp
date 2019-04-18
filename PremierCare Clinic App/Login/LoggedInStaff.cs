using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierCare_Clinic_App.Login
{
    public static class LoggedInStaff {
	    public static Staff loggedInStaff { get; set; }
		public static Doctor.Doctor loggedInDoctor { get; set; }
    }
}

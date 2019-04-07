using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierCare_Clinic_App
{
    class StaffService {
        StaffDAO staffDAO = new StaffDAO();

        public List<Staff> GetStaff() {
	        return staffDAO.GetStaff();
        }

        public Staff GetStaffById(int id) {
	        return staffDAO.GetStaffById(id);
        }

        public List<Staff> GetStaff(string term) {
	        return staffDAO.GetStaff(term);
        }
    }
}

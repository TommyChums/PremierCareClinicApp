using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierCare_Clinic_App
{
    public class DoctorService {
        DoctorDAO DoctorDAO = new DoctorDAO();

        public bool CreateDoctor(Doctor doctor) {
	        return DoctorDAO.CreateDoctor(doctor);
        }

        public List<Doctor> GetDoctors() {
	        return DoctorDAO.GetDoctors();
        }

        public List<Doctor> GetDoctors(string term) {
	        return DoctorDAO.GetDoctors(term);
        }

        public bool UpdateDoctor(Doctor doctor) {
	        return DoctorDAO.UpdateDoctor(doctor);
        }

        public bool DeleteDoctor(Doctor doctor) {
	        return DoctorDAO.DeleteDoctor(doctor);
        }
    }
}

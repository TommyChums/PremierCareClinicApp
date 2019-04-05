using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierCare_Clinic_App
{
    public class DoctorService {
        DoctorDAO doctorDAO = new DoctorDAO();

        public bool CreateDoctor(Doctor doctor) {
	        return doctorDAO.CreateDoctor(doctor);
        }

        public List<Doctor> GetDoctors() {
	        return doctorDAO.GetDoctors();
        }

        public Doctor GetDoctorById(int id) {
	        return doctorDAO.GetDoctorById(id);
        }

        public List<Doctor> GetDoctors(string term) {
	        return doctorDAO.GetDoctors(term);
        }

        public bool UpdateDoctor(Doctor doctor) {
	        return doctorDAO.UpdateDoctor(doctor);
        }

        public bool DeleteDoctor(Doctor doctor) {
	        return doctorDAO.DeleteDoctor(doctor);
        }
    }
}

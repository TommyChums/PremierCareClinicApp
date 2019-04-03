using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierCare_Clinic_App
{
	//Service Implementation for the Patient Class
	//For Business Logic as well as DAO operations
	public class PatientService {
		PatientDAO patientDAO = new PatientDAO();

		public bool CreatePatient(Patient patient) {
			return patientDAO.CreatePatient(patient);
		}

		public List<Patient> GetPatients() {
			return patientDAO.GetPatients();
		}

		public List<Patient> GetPatients(string term) {
			return patientDAO.GetPatients(term);
		}

		public bool UpdatePatient(Patient patient) {
			return patientDAO.UpdatePatient(patient);
		}

		public bool DeletePatient(Patient patient) {
			return patientDAO.DeletePatient(patient);
		}
	}
}

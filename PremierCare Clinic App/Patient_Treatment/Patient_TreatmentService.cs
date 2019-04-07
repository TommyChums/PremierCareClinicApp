using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierCare_Clinic_App
{
    public class Patient_TreatmentService {
	    private Patient_TreatmentDAO treatmentDAO = new Patient_TreatmentDAO();

	    public bool CreatePatientTreatment(Patient_Treatment treatment) {
		    return treatmentDAO.CreatePatientTreatment(treatment);
	    }

	    public List<Patient_Treatment> GetPatientTreatments() {
		    return treatmentDAO.GetPatientTreatments();
	    }

	    public Patient_Treatment GetPatientTreatmentById(int id) {
		    return treatmentDAO.GetPatientTreatmentById(id);
	    }

	    public List<Patient_Treatment> GetPatientTreatmentByPatientId(int id) {
		    return treatmentDAO.GetPatientTreatmentsByPatientId(id);
	    }

	    public bool UpdatePatientTreatment(Patient_Treatment treatment) {
		    return treatmentDAO.UpdatePatientTreatment(treatment);
	    }

	    public bool DeletePatientTreatment(Patient_Treatment treatment) {
		    return treatmentDAO.DeletePatientTreatment(treatment);
	    }
    }
}

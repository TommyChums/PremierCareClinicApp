using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierCare_Clinic_App.Prescription
{
    public class PrescriptionService {
	    private PrescriptionDAO PrescriptionDAO = new PrescriptionDAO();

	    public bool CreatePatientPrescription(Prescription Prescription) {
		    return PrescriptionDAO.CreatePatientPrescription(Prescription);
	    }

	    public List<Prescription> GetPatientPrescriptions() {
		    return PrescriptionDAO.GetPatientPrescriptions();
	    }

	    public Prescription GetPatientPrescriptionById(int id) {
		    return PrescriptionDAO.GetPatientPrescriptionById(id);
	    }

	    public List<Prescription> GetPatientPrescriptionByPatientId(int id) {
		    return PrescriptionDAO.GetPatientPrescriptionsByPatientId(id);
	    }

	    public bool UpdatePatientPrescription(Prescription prescription) {
		    return PrescriptionDAO.UpdatePatientPrescription(prescription);
	    }

	    public bool DeletePatientPrescription(Prescription prescription) {
		    return PrescriptionDAO.DeletePatientPrescription(prescription);
	    }
    }
}

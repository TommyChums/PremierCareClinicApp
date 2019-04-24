using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierCare_Clinic_App.Patient
{
    public class PatientRecordModel {
	    public Patient Patient { get; set; }
	    public List<Prescription.Prescription> Prescriptions { get; set; }
	    public List<Appointment.Appointment> Appointments { get; set; }
	    public List<Invoice.Invoice> Invoices { get; set; }
    }
    
}

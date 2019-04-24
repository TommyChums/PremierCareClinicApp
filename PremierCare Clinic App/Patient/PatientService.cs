﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PremierCare_Clinic_App.Appointment;
using PremierCare_Clinic_App.Invoice;
using PremierCare_Clinic_App.Prescription;

namespace PremierCare_Clinic_App.Patient
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

		public Patient GetPatientById(int id) {
			return patientDAO.GetPatientById(id);
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

		public PatientRecordModel GetPatientRecord(Patient patient) {
			var recordModel = new PatientRecordModel() {
				Patient = patient,
				Prescriptions = new PrescriptionService().GetPatientPrescriptionRecords(patient.patient_id),
				Invoices = new InvoiceService().GetInvoicesByPatientId(patient.patient_id),
				Appointments = new AppointmentService().GetAppointmentsByPatientId(patient.patient_id)
			};

			return recordModel;
		}
	}
}

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using MySql.Data.MySqlClient;

namespace PremierCare_Clinic_App.Patient
{
    public class PatientRecordModel {
	    public Patient Patient { get; set; }
	    public List<PrescriptionRecord> Prescriptions { get; set; }
	    public List<AppointmentRecord> Appointments { get; set; }
	    public List<InvoiceRecord> Invoices { get; set; }
    }

    public class PrescriptionRecord {
	    public int PID { get; set; }
	    public string Patient { get; set; }
	    public string Medication { get; set; }
	    public string Dosage { get; set; }
	    public string Duration { get; set; }
	    public string Doctor { get; set; }
    }

    public class InvoiceRecord {
	    public int InvID { get; set; }
	    public string InvDate { get; set; }
	    public string Patient { get; set; }
	    public string Service { get; set; }
	    public string Medications { get; set; }
	    public double Cost { get; set; }
    }

    public class AppointmentRecord {
	    public int AppID { get; set; }
	    public string AppDate { get; set; }
	    public string AppTime { get; set; }
	    public string Details { get; set; }
	    public string Patient { get; set; }
	    public string Doctor { get; set; }
	    public string CSR { get; set; }
	    public string Service { get; set; }
	    public bool Completed { get; set; }
    }

    public class PatientRecordDAO {
	    public List<PrescriptionRecord> GetPrescriptionRecords(int id) {
		    using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["premierCare"].ConnectionString)) {
			    const string sql = "GetPrescriptions";

			    return connection.Query<PrescriptionRecord>(sql, new {pID = id}, commandType: CommandType.StoredProcedure).AsList();
		    }
		}

	    public List<InvoiceRecord> GetInvoiceRecords(int id) {
		    using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["premierCare"].ConnectionString)) { 
			    const string sql = "GetInvoices";

			    return connection.Query<InvoiceRecord>(sql, new { pID = id }, commandType: CommandType.StoredProcedure).AsList();
		    }
        }

	    public List<AppointmentRecord> GetAppointmentRecords(int id) {
		    using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["premierCare"].ConnectionString)) {
				const string sql = "GetPatientAppointments";

			    return connection.Query<AppointmentRecord>(sql, new { pID = id }, commandType: CommandType.StoredProcedure).AsList();
		    }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Dapper;

namespace PremierCare_Clinic_App.Prescription
{
    public class Prescription {
		public int prescription_id { get; set; }
		public int dosage_per_day { get; set; }
		public int duration_in_days { get; set; }
        public int patient_id { get; set; }
        public int drug_id { get; set; }
        public int doctor_id { get; set; }
    }

    public class PrescriptionDAO {
	    public bool CreatePatientPrescription(Prescription prescription) {
		    using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["premierCare"].ConnectionString)) {
			    const string sql = "INSERT INTO Prescription(dosage_per_day, duration_in_days, patient_id, drug_id, doctor_id) VALUES(@dosage, @duration, @patient, @drug, @doctor)";

			    var rowsAffected =
				    connection.Execute(sql, new {dosage = prescription.dosage_per_day, duration = prescription.duration_in_days, patient = prescription.patient_id, drug = prescription.drug_id, doctor = prescription.doctor_id});

			    return rowsAffected > 0;
		    }

        }

	    public List<Prescription> GetPatientPrescriptions() {
		    using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["premierCare"].ConnectionString)) {
			    const string sql = "SELECT * FROM Prescription";

			    return connection.Query<Prescription>(sql).AsList();
		    }
        }

	    public Prescription GetPatientPrescriptionById(int id) {
		    using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["premierCare"].ConnectionString)) {
			    const string sql = "SELECT * FROM Prescription WHERE prescription_id = @id";

			    return connection.QuerySingle<Prescription>(sql, new {id = id});
		    }
        }

	    public List<Prescription> GetPatientPrescriptionsByPatientId(int id) {
		    using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["premierCare"].ConnectionString)) {
			    const string sql = "SELECT * FROM Prescription WHERE patient_id = @id";

			    return connection.Query<Prescription>(sql, new {id = id}).AsList();
		    }
        }

	    public bool UpdatePatientPrescription(Prescription prescription) {
		    using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["premierCare"].ConnectionString)) {
			    const string sql = "UPDATE Prescription SET dosage_per_day = @dosage, duration_in_days = @duration, drug_id = @drug WHERE prescription_id = @prescription";

                var rowsAffected =
                    connection.Execute(sql, new { dosage = prescription.dosage_per_day, duration = prescription.duration_in_days, drug = prescription.drug_id, prescription = prescription.prescription_id });

                return rowsAffected > 0;
		    }
        }

	    public bool DeletePatientPrescription(Prescription prescription) {
		    using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["premierCare"].ConnectionString)) {
			    const string sql = "DELETE FROM Prescription WHERE prescription_id = @id";

			    var rowsAffected = connection.Execute(sql, new {id = prescription.prescription_id});

			    return rowsAffected > 0;
		    }
        }
    }
}

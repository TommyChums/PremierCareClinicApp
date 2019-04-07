using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Dapper;

namespace PremierCare_Clinic_App
{
    public class Patient_Treatment {
		public int treatment_id { get; set; }
        public int patient_id { get; set; }
        public int drug_id { get; set; }
    }

    public class Patient_TreatmentDAO {
	    public bool CreatePatientTreatment(Patient_Treatment treatment) {
		    using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["premierCare"].ConnectionString)) {
			    const string sql = "INSERT INTO Patient_Treatment(patient_id, drug_id) VALUES(@patient, @drug)";

			    var rowsAffected =
				    connection.Execute(sql, new {patient = treatment.patient_id, drug = treatment.drug_id});

			    return rowsAffected > 0;
		    }

        }

	    public List<Patient_Treatment> GetPatientTreatments() {
		    using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["premierCare"].ConnectionString)) {
			    const string sql = "SELECT * FROM Patient_Treatment";

			    return connection.Query<Patient_Treatment>(sql).AsList();
		    }
        }

	    public Patient_Treatment GetPatientTreatmentById(int id) {
		    using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["premierCare"].ConnectionString)) {
			    const string sql = "SELECT * FROM Patient_Treatment WHERE treatment_id = @id";

			    return connection.QuerySingle<Patient_Treatment>(sql, new {id = id});
		    }
        }

	    public List<Patient_Treatment> GetPatientTreatmentsByPatientId(int id) {
		    using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["premierCare"].ConnectionString)) {
			    const string sql = "SELECT * FROM Patient_Treatment WHERE patient_id = @id";

			    return connection.Query<Patient_Treatment>(sql, new {id = id}).AsList();
		    }
        }

	    public bool UpdatePatientTreatment(Patient_Treatment treatment) {
		    using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["premierCare"].ConnectionString)) {
			    const string sql = "UPDATE Patient_Treatment SET patient_id = @patient, drug_id = @drug WHERE treatment_id = @treatment";

                var rowsAffected =
                    connection.Execute(sql, new { patient = treatment.patient_id, drug = treatment.drug_id, treatment = treatment.treatment_id });

                return rowsAffected > 0;
		    }
        }

	    public bool DeletePatientTreatment(Patient_Treatment treatment) {
		    using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["premierCare"].ConnectionString)) {
			    const string sql = "DELETE FROM Patient_Treatment WHERE treatment_id = @id";

			    var rowsAffected = connection.Execute(sql, new {id = treatment.treatment_id});

			    return rowsAffected > 0;
		    }
        }
    }
}

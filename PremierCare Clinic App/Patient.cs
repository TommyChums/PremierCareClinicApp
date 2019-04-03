using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using MySql.Data.MySqlClient;

namespace PremierCare_Clinic_App
{
    public class Patient {
	    public int patient_id { get; set; }
	    public string patient_name { get; set; }
	    public string contact_no { get; set; }
	    public string address { get; set; }
	    public string DOB { get; set; }
	    public string allergies { get; set; }
	    public string blood_type { get; set; }
    }

    public class PatientDAO {
	    public bool CreatePatient(Patient patient) {
            using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["premierCare"].ConnectionString)) {
                const string sql = "INSERT INTO Patient(patient_name, contact_no, address, DOB, allergies, blood_type) VALUES(@patient_name, @contact_no, @address, @DOB, @allergies, @blood_type)";

                var parameters = new DynamicParameters();

                parameters.Add("@patient_name", patient.patient_name, DbType.String, ParameterDirection.Input);
                parameters.Add("@contact_no", patient.contact_no, DbType.String, ParameterDirection.Input);
                parameters.Add("@address", patient.address, DbType.String, ParameterDirection.Input);
                parameters.Add("@DOB", patient.DOB, DbType.String, ParameterDirection.Input);
                parameters.Add("@allergies", patient.allergies, DbType.String, ParameterDirection.Input);
                parameters.Add("@blood_type", patient.blood_type, DbType.String, ParameterDirection.Input);

                var rowsAffected = connection.Execute(sql, parameters);

                return rowsAffected > 0;
            }

        }

	    public List<Patient> GetPatients() {
		    using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["premierCare"].ConnectionString)) {
			    const string sql = "SELECT * FROM Patient";
			    return connection.Query<Patient>(sql).AsList();
		    }
	    }

	    public List<Patient> GetPatients(string term) {
		    using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["premierCare"].ConnectionString)) {
			    const string sql = "SELECT * FROM Patient " +
			                       "WHERE patient_name LIKE %@term% OR contact_no LIKE %@term% OR address LIKE %@term% OR DOB LIKE %@term% OR allergies LIKE %@term% OR blood_type LIKE %@term%";

			    return connection.Query<Patient>(sql, new {term = term}).AsList();
		    }
        }

	    public bool UpdatePatient(Patient patient) {
		    using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["premierCare"].ConnectionString)) {
			    const string sql = "UPDATE Patient SET patient_name = @patient_name, contact_no = @contact_no, address = @address, DOB = @DOB, allergies = @allergies, blood_type = @blood_type " +
			                       "WHERE patient_id = @patient_id";

			    var rowsAffected = connection.Execute(sql, new {
				    patient_name = patient.patient_name,
				    contact_no = patient.contact_no,
				    address = patient.address,
				    DOB = patient.DOB,
				    allergies = patient.allergies,
				    blood_type = patient.blood_type,
				    patient_id = patient.patient_id
			    });

			    return rowsAffected > 0;
		    }
	    }

	    public bool DeletePatient(Patient patient) {
		    using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["premierCare"].ConnectionString)) {
			    const string sql = "DELETE FROM Patient WHERE patient_id = @patient_id";

			    var rowsAffected = connection.Execute(sql, new {patient_id = patient.patient_id});

			    return rowsAffected > 0;
		    }
	    }
    }
}

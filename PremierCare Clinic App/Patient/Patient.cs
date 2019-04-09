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

namespace PremierCare_Clinic_App.Patient
{
	//Patient Model with attributes matching Database
    public class Patient {
	    public int patient_id { get; set; }
	    public string patient_name { get; set; }
	    public string contact_no { get; set; }
	    public string address { get; set; }
	    public string DOB { get; set; }
	    public string allergies { get; set; }
	    public string blood_type { get; set; }
    }

	//Patient Data Access Object for accessing and performing database operations
    public class PatientDAO {
		//Method to Insert a Patient into the database
	    public bool CreatePatient(Patient patient) {
			//Connect to database using the connection string from App.config
			//Using a 'using' block to terminate the connection after we're finished with it
            using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["premierCare"].ConnectionString)) {
				//SQL code to insert the patient into the database
                const string sql = "INSERT INTO Patient(patient_name, contact_no, address, DOB, allergies, blood_type) VALUES(@patient_name, @contact_no, @address, @DOB, @allergies, @blood_type)";

				//Adding parameters to the code to prevent against SQL injection
                var parameters = new DynamicParameters();

                parameters.Add("@patient_name", patient.patient_name, DbType.String, ParameterDirection.Input);
                parameters.Add("@contact_no", patient.contact_no, DbType.String, ParameterDirection.Input);
                parameters.Add("@address", patient.address, DbType.String, ParameterDirection.Input);
                parameters.Add("@DOB", patient.DOB, DbType.String, ParameterDirection.Input);
                parameters.Add("@allergies", patient.allergies, DbType.String, ParameterDirection.Input);
                parameters.Add("@blood_type", patient.blood_type, DbType.String, ParameterDirection.Input);

				//Executing the SQL code with added parameters. Returns number of Rows affected
                var rowsAffected = connection.Execute(sql, parameters);

				//A successful insert will affect at least 1 Row and will return true
				//An unsuccessful insert will return 0 and therefore return false
                return rowsAffected > 0;
            }

        }

		//Method to Retrieve all Patients in the Database
	    public List<Patient> GetPatients() {
		    //Connect to database using the connection string from App.config
		    //Using a 'using' block to terminate the connection after we're finished with it
            using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["premierCare"].ConnectionString)) {
				//SQL code to select all patients from the Patient table
			    const string sql = "SELECT * FROM Patient";
				
				//Queries the database executing the SQL code and returns it as a list of patients
			    return connection.Query<Patient>(sql).AsList();
		    }
	    }

	    //Method to retrieve a Patient by their id
	    public Patient GetPatientById(int id) {
		    //Connect to database using the connection string from App.config
		    //Using a 'using' block to terminate the connection after we're finished with it
		    using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["premierCare"].ConnectionString)) {
			    //SQL code to select the patient from the Patient table by id
			    const string sql = "SELECT * FROM Patient WHERE patient_id = @patient_id";

			    //Adding parameters to the code to prevent against SQL injection
			    //Queries the database executing the SQL code and returns the Patient
			    return connection.QuerySingle<Patient>(sql, new { patient_id = id });
		    }
	    }

        //Method to Retrieve all Patients in the Database that have a field containing the term
        public List<Patient> GetPatients(string term) {
		    //Connect to database using the connection string from App.config
		    //Using a 'using' block to terminate the connection after we're finished with it
            using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["premierCare"].ConnectionString)) {
				//SQL code to select all patients from the Patient table where any field contains the term
			    const string sql = "SELECT * FROM Patient " +
			                       "WHERE patient_name LIKE @term OR contact_no LIKE @term OR address LIKE @term OR DOB LIKE @term OR allergies LIKE @term OR blood_type LIKE @term";

			    //Adding parameters to the code to prevent against SQL injection
                //Queries the database executing the SQL code and returns it as a list of patients
                return connection.Query<Patient>(sql, new {term = "%" + term + "%"}).AsList();
		    }
        }

		//Method to Update the given patient's records
	    public bool UpdatePatient(Patient patient) {
		    //Connect to database using the connection string from App.config
		    //Using a 'using' block to terminate the connection after we're finished with it
            using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["premierCare"].ConnectionString)) {
				//SQL code to Update the given patient
			    const string sql = "UPDATE Patient SET patient_name = @patient_name, contact_no = @contact_no, address = @address, DOB = @DOB, allergies = @allergies, blood_type = @blood_type " +
			                       "WHERE patient_id = @patient_id";

			    //Adding parameters to the code to prevent against SQL injection
                //Executing the SQL code with added parameters. Returns number of Rows affected
                var rowsAffected = connection.Execute(sql, new {
				    patient_name = patient.patient_name,
				    contact_no = patient.contact_no,
				    address = patient.address,
				    DOB = patient.DOB,
				    allergies = patient.allergies,
				    blood_type = patient.blood_type,
				    patient_id = patient.patient_id
			    });

                //A successful update will affect at least 1 Row and will return true
                //An unsuccessful update will return 0 and therefore return false
                return rowsAffected > 0;
		    }
	    }

		//Method to Delete a Patient from the database
	    public bool DeletePatient(Patient patient) {
		    //Connect to database using the connection string from App.config
		    //Using a 'using' block to terminate the connection after we're finished with it
            using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["premierCare"].ConnectionString)) {
				//SQL code to Delete the given patient
			    const string sql = "DELETE FROM Patient WHERE patient_id = @patient_id";

			    //Adding parameters to the code to prevent against SQL injection
                //Executing the SQL code with added parameters. Returns number of Rows affected
                var rowsAffected = connection.Execute(sql, new {patient_id = patient.patient_id});

                //A successful delete will affect at least 1 Row and will return true
                //An unsuccessful delete will return 0 and therefore return false
                return rowsAffected > 0;
		    }
	    }
    }
}

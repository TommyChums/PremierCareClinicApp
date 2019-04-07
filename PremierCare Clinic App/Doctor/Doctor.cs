using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using MySql.Data.MySqlClient;

namespace PremierCare_Clinic_App
{
    public class Doctor {
	    public int doctor_id { get; set; }
	    public string doctor_name { get; set; }
	    public string doctor_contact_number { get; set; }
	    public string doctor_address { get; set; }
		public string doctor_specialty { get; set; }
    }

    public class DoctorDAO {
	    public bool CreateDoctor(Doctor doctor) {
		    using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["premierCare"].ConnectionString)) {
			    const string sql =
				    "INSERT INTO Doctor(doctor_name, doctor_contact_number, doctor_address, doctor_specialty) VALUES(@doctor_name, @doctor_contact_number, @doctor_address, @doctor_specialty)";

			    var rowsAffected = connection.Execute(sql,
				    new {
					    doctor_name = doctor.doctor_name, doctor_contact_number = doctor.doctor_contact_number,
					    doctor_address = doctor.doctor_address, doctor_specialty = doctor.doctor_specialty
				    });

			    return rowsAffected > 0;
		    }
	    }

	    public List<Doctor> GetDoctors() {
		    using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["premierCare"].ConnectionString)) {
			    const string sql = "SELECT * FROM Doctor";

			    return connection.Query<Doctor>(sql).AsList();
		    }
        }

	    public Doctor GetDoctorById(int id) {
		    using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["premierCare"].ConnectionString)) {
			    const string sql = "SELECT * FROM Doctor WHERE doctor_id = @doctor_id";

			    return connection.QuerySingle<Doctor>(sql, new {doctor_id = id});
		    }
	    }

	    public List<Doctor> GetDoctors(string term) {
		    using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["premierCare"].ConnectionString)) {
			    const string sql =
				    "SELECT * FROM Doctor WHERE doctor_name LIKE %@term% OR doctor_contact_number LIKE %@term% OR doctor_address LIKE %@term% OR doctor_specialty LIKE %@term%";

			    return connection.Query<Doctor>(sql, new {term = term}).AsList();
		    }
        }

	    public bool UpdateDoctor(Doctor doctor) {
		    using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["premierCare"].ConnectionString)) {
			    const string sql =
				    "UPDATE Doctor SET doctor_name = @doctor_name, doctor_contact_number = @doctor_contact_number, doctor_address = @doctor_address, doctor_specialty = @doctor_specialty WHERE doctor_id = @doctor_id";

			    var rowsAffected = connection.Execute(sql,
				    new {
					    doctor_name = doctor.doctor_name, doctor_contact_number = doctor.doctor_contact_number,
					    doctor_address = doctor.doctor_address, doctor_specialty = doctor.doctor_specialty
				    });

			    return rowsAffected > 0;
		    }
        }

	    public bool DeleteDoctor(Doctor doctor) {
		    using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["premierCare"].ConnectionString)) {
			    const string sql = "DELETE FROM Doctor WHERE doctor_id = @doctor_id";

			    var rowsAffected = connection.Execute(sql, new {doctor_id = doctor.doctor_id});

			    return rowsAffected > 0;
		    }
        }
	}
}

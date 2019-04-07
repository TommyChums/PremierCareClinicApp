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
    public class Appointment {
	    public int appointment_id { get; set; }
	    public string appointment_date { get; set; }
	    public string appointment_time { get; set; }
	    public string appointment_details { get; set; }
	    public int patient_id { get; set; }
	    public int doctor_id { get; set; }
	    public int staff_id { get; set; }
	    public bool appointment_completed { get; set; }
    }

    public class AppointmentDAO {
	    public bool CreateAppointment(Appointment appointment) {
		    using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["premierCare"].ConnectionString)) {
                const string sql =
                    "INSERT INTO Appointment(appointment_date, appointment_time, appointment_details, patient_id, doctor_id, staff_id, appointment_completed) " +
                    "VALUES(@date, @time, @details, @patient, @doctor, @staff, @completed";

                var rowsAffected = connection.Execute(sql,
	                new {
		                date = appointment.appointment_date, time = appointment.appointment_time,
		                details = appointment.appointment_details, patient = appointment.patient_id,
		                doctor = appointment.doctor_id, staff = appointment.staff_id,
		                completed = appointment.appointment_completed
	                });

                return rowsAffected > 0;
		    }
	    }

	    public List<Appointment> GetAppointments() {
		    using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["premierCare"].ConnectionString)) {
			    const string sql = "SELECT * FROM Appointment";

			    return connection.Query<Appointment>(sql).AsList();
		    }
        }

	    public List<Appointment> GetAppointments(Staff csr) {
		    using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["premierCare"].ConnectionString)) {
			    const string sql = "SELECT * FROM Appointment WHERE staff_id = @staffId";

			    return connection.Query<Appointment>(sql, new {staffId = csr.staff_id}).AsList();
		    }
	    }

        public Appointment GetAppointmentById(int id) {
		    using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["premierCare"].ConnectionString)) {
			    const string sql = "SELECT * FROM Appointment WHERE appointment_id = @appointment_id";

			    return connection.QuerySingle<Appointment>(sql, new {appointment_id = id});
		    }
        }

	    public bool UpdateAppointment(Appointment appointment) {
		    using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["premierCare"].ConnectionString)) {
			    const string sql =
				    "UPDATE Appointment SET appointment_date = @date, appointment_time = @time, appointment_details = @details, appointment_completed = @completed";

			    var rowsAffected = connection.Execute(sql,
				    new {
					    date = appointment.appointment_date, time = appointment.appointment_time,
					    details = appointment.appointment_details, completed = appointment.appointment_completed
				    });

			    return rowsAffected > 0;
		    }
        }

	    public bool DeleteAppointment(Appointment appointment) {
		    using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["premierCare"].ConnectionString)) {
			    const string sql = "DELETE FROM Appointment WHERE appointment_id = @id";

			    var rowsAffected = connection.Execute(sql, new {id = appointment.appointment_id});

			    return rowsAffected > 0;
		    }
	    }
    }
}

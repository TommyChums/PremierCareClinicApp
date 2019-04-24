using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using Dapper;
using MySql.Data.MySqlClient;
using NHibernate.Linq.Functions;

namespace PremierCare_Clinic_App.Appointment
{
    public class Appointment {
	    public int appointment_id { get; set; }
	    public string appointment_date { get; set; }
	    public string appointment_time { get; set; }
	    public string appointment_details { get; set; }
	    public int patient_id { get; set; }
	    public int doctor_id { get; set; }
	    public int staff_id { get; set; }
		public int service_id { get; set; }
	    public bool appointment_completed { get; set; }
    }

    public class DisplayedAppointment {
	    public int appointment_id { get; set; }
	    public string patient_name { get; set; }
	    public string appointment_date { get; set; }
	    public string appointment_time { get; set; }
	    public string service_category { get; set; }
	    public string doctor_name { get; set; }
	    public bool appointment_completed { get; set; }
    }

    public class AppointmentDAO {
	    public bool CreateAppointment(Appointment appointment) {
		    using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["premierCare"].ConnectionString)) {
                const string sql =
                    "INSERT INTO Appointment(appointment_date, appointment_time, appointment_details, patient_id, doctor_id, staff_id, service_id, appointment_completed) " +
                    "VALUES(@date, @time, @details, @patient, @doctor, @staff, @service, @completed)";

                var rowsAffected = connection.Execute(sql,
	                new {
		                date = appointment.appointment_date, time = appointment.appointment_time,
		                details = appointment.appointment_details, patient = appointment.patient_id,
		                doctor = appointment.doctor_id, staff = appointment.staff_id,
						service = appointment.service_id, completed = appointment.appointment_completed
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

	    public List<DisplayedAppointment> GetAppointments(Staff csr) {
		    using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["premierCare"].ConnectionString)) {
			    const string sql = "GetAppointments";
				
			    return connection.Query<DisplayedAppointment>(sql, new {staff = csr.staff_id}, commandType: CommandType.StoredProcedure).AsList();
		    }
	    }

        public Appointment GetAppointmentById(int id) {
		    using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["premierCare"].ConnectionString)) {
			    const string sql = "SELECT * FROM Appointment WHERE appointment_id = @appointment_id";

			    return connection.QuerySingle<Appointment>(sql, new {appointment_id = id});
		    }
        }

        public List<Appointment> GetAppointmentsByPatientId(int id) {
	        using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["premierCare"].ConnectionString)) {
		        const string sql = "SELECT * FROM Appointment WHERE patient_id = @patient_id";

		        return connection.Query<Appointment>(sql, new { patient_id = id }).AsList();
	        }
        }

        public bool UpdateAppointment(Appointment appointment) {
		    using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["premierCare"].ConnectionString)) {
			    const string sql =
				    "UPDATE Appointment SET appointment_date = @date, appointment_time = @time, appointment_details = @details, appointment_completed = @completed " +
				    "WHERE appointment_id = @id";

			    var rowsAffected = connection.Execute(sql,
				    new {
					    date = appointment.appointment_date, time = appointment.appointment_time,
					    details = appointment.appointment_details, completed = appointment.appointment_completed,
					    id = appointment.appointment_id
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

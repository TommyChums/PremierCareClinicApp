using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PremierCare_Clinic_App.Appointment;

namespace PremierCare_Clinic_App.Appointment
{
    public class AppointmentService {
	    public AppointmentDAO appointmentDAO = new AppointmentDAO();

	    public bool CreateAppointment(Appointment appointment) {
		    return appointmentDAO.CreateAppointment(appointment);
	    }

	    public List<Appointment> GetAppointments() {
		    return appointmentDAO.GetAppointments();
	    }

	    public List<DisplayedAppointment> GetAppointments(Staff staff) {
		    return appointmentDAO.GetAppointments(staff);
	    }

	    public Appointment GetAppointmentById(int id) {
		    return appointmentDAO.GetAppointmentById(id);
	    }

	    public List<Appointment> GetAppointmentsByPatientId(int id) {
		    return appointmentDAO.GetAppointmentsByPatientId(id);
	    }

        public bool UpdateAppointment(Appointment appointment) {
		    return appointmentDAO.UpdateAppointment(appointment);
	    }

	    public bool DeleteAppointment(Appointment appointment) {
		    return appointmentDAO.DeleteAppointment(appointment);
	    }

	    public List<DisplayedAppointment> GetAppointments(Staff staff, string term, string date, bool dateActive) {
            var appointments = appointmentDAO.GetAppointments(staff);

            var displayedAppointments = new List<DisplayedAppointment>();

            foreach (var appointment in appointments) {
	            if (!dateActive) {
		            if (appointment.patient_name.ToLower().Contains(term) || appointment.service_category.ToLower().Contains(term) ||
		                appointment.doctor_name.ToLower().Contains(term) || appointment.appointment_date.ToLower().Contains(term) ||
		                appointment.appointment_time.ToLower().Contains(term)) {
			            displayedAppointments.Add(appointment);
		            }
                }
	            else {
		            if ((appointment.patient_name.ToLower().Contains(term) || appointment.service_category.ToLower().Contains(term) ||
		                appointment.doctor_name.ToLower().Contains(term) || appointment.appointment_time.ToLower().Contains(term)) && appointment.appointment_date.ToLower().Equals(date)) {
			            displayedAppointments.Add(appointment);
		            }
                }
            }

            return displayedAppointments;
	    }

	    public List<DisplayedAppointment> GetAppointmentsByDate(Staff staff, string date) {
		    var appointments = appointmentDAO.GetAppointments(staff);

		    var displayedAppointments = new List<DisplayedAppointment>();

		    foreach (var appointment in appointments) {
			    if (appointment.appointment_date.Equals(date)) {
					displayedAppointments.Add(appointment);
			    }
		    }

		    return displayedAppointments;
	    }

	    public bool UpdateCompletionStatus(Appointment appointment) {
		    appointment.appointment_completed = !appointment.appointment_completed;

		    return appointmentDAO.UpdateAppointment(appointment);
	    }
    }
}

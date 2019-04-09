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

	    public List<Appointment> GetAppointments(Staff staff) {
		    return appointmentDAO.GetAppointments(staff);
	    }

	    public Appointment GetAppointmentById(int id) {
		    return appointmentDAO.GetAppointmentById(id);
	    }

	    public bool UpdateAppointment(Appointment appointment) {
		    return appointmentDAO.UpdateAppointment(appointment);
	    }

	    public bool DeleteAppointment(Appointment appointment) {
		    return appointmentDAO.DeleteAppointment(appointment);
	    }
    }
}

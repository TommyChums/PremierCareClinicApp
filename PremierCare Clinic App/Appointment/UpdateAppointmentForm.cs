using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PremierCare_Clinic_App.Appointment
{
	public partial class UpdateAppointmentForm : Form {

		private AppointmentService appointmentService = new AppointmentService();
		private DisplayedAppointment displayedAppointment;
		private Appointment appointment1;

		public void Appointments(DisplayedAppointment appointment, Appointment appointment2) {
            displayedAppointment = appointment;
            appointment1 = appointment2;
		}

        public UpdateAppointmentForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e) {
	        toolTip1.SetToolTip(pictureBox1, "Close this form");
        }

        private void UpdatePatientForm_Load(object sender, EventArgs e) {
	        patientTxtBox.Text = displayedAppointment.patient_name;
	        doctorTxtBox.Text = displayedAppointment.doctor_name;
	        serviceTxtBox.Text = displayedAppointment.service_category;
	        detailsTxtBox.Text = appointmentService.GetAppointmentById(displayedAppointment.appointment_id)
		        .appointment_details;

	        updateDate.Text = displayedAppointment.appointment_date;
	        updateTime.Text = displayedAppointment.appointment_time;
	        chkBxCompleted.Checked = displayedAppointment.appointment_completed;
        }

        private void pictureBox1_Click(object sender, EventArgs e) {
            var viewAppointmentForm = new ViewAppointmentsForm();
			viewAppointmentForm.Show();
	        this.Close();
        }

        private void updateButton_Click(object sender, EventArgs e) {
	        appointment1.appointment_details = detailsTxtBox.Text;
	        appointment1.appointment_time = updateTime.Text;
	        appointment1.appointment_date = updateDate.Text;
	        appointment1.appointment_completed = chkBxCompleted.Checked;

            var updated = appointmentService.UpdateAppointment(appointment1);

            MessageBox.Show(updated ? "Appointment Successfully Updated" : "Failed to Update Appointment");

            if (!updated) return;

            var viewAppointmentForm = new ViewAppointmentsForm();
            viewAppointmentForm.Show();
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PremierCare_Clinic_App.Login;

namespace PremierCare_Clinic_App.Appointment
{
    public partial class ViewAppointmentsForm : Form
    {
        private AppointmentService appointmentService = new AppointmentService();
		AppointmentDAO AppointmentDAO = new AppointmentDAO();

		List<DisplayedAppointment> appointmentsToDisplay = new List<DisplayedAppointment>();

		private Appointment appointment = null;

		private DisplayedAppointment displayedAppointment = null;

		private int switchNum = 0;

        public ViewAppointmentsForm()
        {
            InitializeComponent();
        }

        private void ViewAppointments_Load(object sender, EventArgs e) {
            appointmentsToDisplay = appointmentService.GetAppointments(LoggedInStaff.loggedInStaff);
            appointmentGridView.DataSource = appointmentsToDisplay;
            dateTimePicker1.Checked = false;
        }

        private void appointmentSearch_TextChanged(object sender, EventArgs e) {
            appointmentsToDisplay = appointmentService.GetAppointments(LoggedInStaff.loggedInStaff, appointmentSearch.Text.ToLower(), dateTimePicker1.Text.ToLower(), dateTimePicker1.Checked);
            appointmentGridView.DataSource = appointmentsToDisplay;
            switchNum = 1;
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e) {
	        toolTip1.SetToolTip(pictureBox1, "Close this form");
        }

        private void pictureBox1_Click(object sender, EventArgs e) {
	        this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) {

            switchNum = dateTimePicker1.Checked ? 2 : 1;
			
            switch (switchNum) {
		        case 1:
		            appointmentsToDisplay = appointmentService.GetAppointments(LoggedInStaff.loggedInStaff, appointmentSearch.Text.ToLower(), dateTimePicker1.Text.ToLower(), dateTimePicker1.Checked);
		            break;
	            case 2:
		            appointmentsToDisplay = appointmentService.GetAppointmentsByDate(LoggedInStaff.loggedInStaff, dateTimePicker1.Text.ToLower());
		            break;
	            default:
		            appointmentsToDisplay = appointmentService.GetAppointments(LoggedInStaff.loggedInStaff);
		            break;
            }

            appointmentGridView.DataSource = appointmentsToDisplay;
        }

        private void appointmentGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e) {
            appointment = appointmentService.GetAppointmentById(int.Parse(appointmentGridView.Rows[e.RowIndex].Cells[0].Value.ToString()));
            var appointmentId = int.Parse(appointmentGridView.Rows[e.RowIndex].Cells[0].Value.ToString());

            foreach (var dApp in appointmentsToDisplay) {
	            if (dApp.appointment_id == appointmentId) {
		            displayedAppointment = dApp;
	            }
            }
        }

        private void updateAppointmentBtn_Click(object sender, EventArgs e) {
	        if (appointment == null || displayedAppointment == null) return;

            var updateAppointmentForm = new UpdateAppointmentForm();
			updateAppointmentForm.Appointments(displayedAppointment, appointment);
            updateAppointmentForm.Show();
			this.Hide();
        }

        private void appointmentCompleteBtn_Click(object sender, EventArgs e) {
	        if (appointment == null) return;
	        appointmentService.UpdateCompletionStatus(appointment);

	        switch (switchNum) {
                case 1: appointmentsToDisplay = appointmentService.GetAppointments(LoggedInStaff.loggedInStaff, appointmentSearch.Text.ToLower(), dateTimePicker1.Text.ToLower(), dateTimePicker1.Checked);
	                break;
                case 2: appointmentsToDisplay = appointmentService.GetAppointmentsByDate(LoggedInStaff.loggedInStaff, dateTimePicker1.Text.ToLower());
	                break;
                default: appointmentsToDisplay = appointmentService.GetAppointments(LoggedInStaff.loggedInStaff);
	                break;
            }
	        appointmentGridView.DataSource = appointmentsToDisplay;
        }
    }
}

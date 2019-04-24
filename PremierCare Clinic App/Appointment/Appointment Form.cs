using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PremierCare_Clinic_App.Doctor;
using PremierCare_Clinic_App.Login;
using PremierCare_Clinic_App.Patient;
using PremierCare_Clinic_App.Service;

namespace PremierCare_Clinic_App.Appointment
{
    public partial class Appointment_Form : Form {

	    private DoctorService doctorService = new DoctorService();
	    private Doctor.Doctor selectedDoctor;

		private ServiceService serviceService = new ServiceService();

		private Patient.Patient selectedPatient;

		private AppointmentService appointmentService = new AppointmentService();
		private Appointment appointment;

        public Appointment_Form()
        {
            InitializeComponent();
        }

        public void SelectPatient(Patient.Patient patient) {
	        selectedPatient = patient;

	        patientTxtBox.Text = patient.patient_name;
	        contactNoTxtBox.Text = patient.contact_no;
	        addressTxtBox.Text = patient.address;
	        dobTxtBox.Text = patient.DOB;
	        allergiesTxtBox.Text = patient.allergies;
	        bloodTypeTxtBox.Text = patient.blood_type;
        }

        private void DisplayDoctorInfo(Doctor.Doctor doctor) {
	        if (doctor == null) return;
	        doctorContactNumberTxtBox.Text = doctor.doctor_contact_number;
	        doctorAddressTxtBox.Text = doctor.doctor_address;
	        doctorSpecialtyTxtBox.Text = doctor.doctor_specialty;
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e) {
	        var LinkedForm = StaffLoginForm.LinkedForm;

	        LinkedForm.SetPanelForm(new ViewPatientsForm());
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e) {
	        toolTip1.SetToolTip(pictureBox1, "Close this form");
        }

        private void Appointment_Form_Load(object sender, EventArgs e) {
	        doctorBox.DataSource = doctorService.GetDoctors();
	        doctorBox.DisplayMember = "doctor_name";
	        doctorBox.ValueMember = "doctor_id";

	        selectedDoctor = doctorService.GetDoctorById(int.Parse(doctorBox.SelectedValue.ToString()));
			DisplayDoctorInfo(selectedDoctor);

			serviceBox.DataSource = serviceService.GetServices();
			serviceBox.DisplayMember = "service_category";
			serviceBox.ValueMember = "service_id";
        }

        private void doctorBox_SelectedValueChanged(object sender, EventArgs e) {
	        try {
		        selectedDoctor = doctorService.GetDoctorById(int.Parse(doctorBox.SelectedValue.ToString()));
		        DisplayDoctorInfo(selectedDoctor);
	        }
	        catch (Exception ex) {
				Console.WriteLine(ex.Message);
		        return;
	        }
        }

        private void makeAppointmentBtn_Click(object sender, EventArgs e) {
			errorProvider1.Clear();
	        if (detailsTxtBox.Text.Trim().Equals("")) {
                errorProvider1.SetError(appointmentDetailsLabel, "Field can't be empty");
                return;
	        }

	        if (selectedPatient == null) {
		        return;
	        }

	        appointment = new Appointment() {
		        appointment_date = appointmentDate.Text,
		        appointment_time = appointmentTime.Text,
		        appointment_details = detailsTxtBox.Text.Trim(),
		        patient_id = selectedPatient.patient_id,
		        doctor_id = int.Parse(doctorBox.SelectedValue.ToString()),
		        staff_id = LoggedInStaff.loggedInStaff.staff_id,
				service_id = int.Parse(serviceBox.SelectedValue.ToString()),
		        appointment_completed = false
	        };

	        var createdAppointment = appointmentService.CreateAppointment(appointment);

	        MessageBox.Show(createdAppointment ? "Appointment Successfully Created" : "Failed to create appointment");

	        if (createdAppointment) {
				var viewPatientForm = new ViewPatientsForm();

				StaffLoginForm.LinkedForm.SetPanelForm(viewPatientForm);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e) {
	        var LinkedForm = StaffLoginForm.LinkedForm;

			LinkedForm.SetPanelForm(new ViewPatientsForm());
        }
    }
}

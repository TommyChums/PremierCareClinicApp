using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PremierCare_Clinic_App.Appointment;

namespace PremierCare_Clinic_App.Patient
{
    public partial class ViewPatientsForm : Form
    {
		PatientService patientService = new PatientService();
		private Patient selectedPatient;


        public ViewPatientsForm() {
	        
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {
	        patientGridView.DataSource = patientService.GetPatients(textBox1.Text);
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e) {
	        toolTip1.SetToolTip(pictureBox2, "Close this form");
        }

        private void pictureBox2_Click(object sender, EventArgs e) {
	        this.Close();
        }

        private void ViewPatientsForm_Load(object sender, EventArgs e) {
	        patientGridView.DataSource = patientService.GetPatients();
        }

        private void patientGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e) {
	        selectedPatient = patientService.GetPatientById(int.Parse(patientGridView.Rows[e.RowIndex].Cells[0].Value.ToString()));
        }

        private void updatePatientBtn_Click(object sender, EventArgs e) {
	        if (selectedPatient == null) return;
            var PatientForm = new PatientForm();

            PatientForm.UpdatePatient(selectedPatient);
			PatientForm.Show();
			this.Hide();
        }

        private void patientGridView_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e) {
	        selectedPatient = patientService.GetPatientById(int.Parse(patientGridView.Rows[e.RowIndex].Cells[0].Value.ToString()));
            updatePatientBtn_Click(sender, e);
        }

        private void createAppointment_Click(object sender, EventArgs e) {
	        if (selectedPatient == null) return;

            var appointmentForm = new Appointment_Form();
			appointmentForm.SelectPatient(selectedPatient);
			appointmentForm.Show();
			this.Hide();
        }

        private void treatmentBtn_Click(object sender, EventArgs e) {
	        var treatmentForm = new PatientTreatmentForm();
			treatmentForm.setPatient(selectedPatient);
            treatmentForm.Show();
			this.Hide();
        }
    }
}

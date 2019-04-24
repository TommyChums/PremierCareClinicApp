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
using PremierCare_Clinic_App.Login;
using PremierCare_Clinic_App.Prescription;

namespace PremierCare_Clinic_App.Patient
{
    public partial class ViewPatientsForm : Form
    {
		PatientService patientService = new PatientService();
		private Patient selectedPatient;
		private bool isStaff = LoggedInStaff.loggedInDoctor == null;

        public ViewPatientsForm() {
	        
            InitializeComponent();
        }

        private void setColumns() {
	        patientGridView.Columns[0].HeaderText = "ID";
	        patientGridView.Columns[0].Width = 50;
	        patientGridView.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
	        patientGridView.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

	        patientGridView.Columns[1].HeaderText = "Name";
	        patientGridView.Columns[1].Width = 250;
	        patientGridView.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
	        patientGridView.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

	        patientGridView.Columns[2].HeaderText = "Contact";
	        patientGridView.Columns[2].Width = 140;
	        patientGridView.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
	        patientGridView.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

	        patientGridView.Columns[3].HeaderText = "Address";
	        patientGridView.Columns[3].Width = 240;
	        patientGridView.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
	        patientGridView.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

	        patientGridView.Columns[4].HeaderText = "DOB";
	        patientGridView.Columns[4].Width = 125;
	        patientGridView.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
	        patientGridView.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

	        patientGridView.Columns[5].HeaderText = "Allergies";
	        patientGridView.Columns[5].Width = 200;
	        patientGridView.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
	        patientGridView.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

	        patientGridView.Columns[6].HeaderText = "Blood Type";
	        patientGridView.Columns[6].Width = 126;
	        patientGridView.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
	        patientGridView.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        public void isStaffMember(bool staff) {
	        isStaff = staff;
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {
	        patientGridView.DataSource = patientService.GetPatients(textBox1.Text);
			setColumns();
        }

        private void ViewPatientsForm_Load(object sender, EventArgs e) {
			patientGridView.Font = new Font(new FontFamily("Trebuchet MS"), 14, FontStyle.Regular);
            patientGridView.DataSource = patientService.GetPatients();

	        if (!isStaff) createAppointment.Enabled = false;
	        if (!isStaff) updatePatientBtn.Enabled = false;
	        if (isStaff) treatmentBtn.Enabled = false;

			setColumns();
        }

        private void patientGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e) {
	        selectedPatient = patientService.GetPatientById(int.Parse(patientGridView.Rows[e.RowIndex].Cells[0].Value.ToString()));
        }

        private void updatePatientBtn_Click(object sender, EventArgs e) {
	        if (selectedPatient == null) return;
	        var PatientForm = new PatientForm();

	        var LinkedForm = StaffLoginForm.LinkedForm;

            PatientForm.UpdatePatient(selectedPatient);
			LinkedForm.SetPanelForm(PatientForm);
        }

        private void patientGridView_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e) {
	        selectedPatient = patientService.GetPatientById(int.Parse(patientGridView.Rows[e.RowIndex].Cells[0].Value.ToString()));
            updatePatientBtn_Click(sender, e);
        }

        private void createAppointment_Click(object sender, EventArgs e) {
            if (selectedPatient == null) return;

            var appointmentForm = new Appointment_Form();
            var LinkedForm = StaffLoginForm.LinkedForm;


            appointmentForm.SelectPatient(selectedPatient);
			LinkedForm.SetPanelForm(appointmentForm);
        }

        private void treatmentBtn_Click(object sender, EventArgs e) {
	        if (selectedPatient == null) return;
	        var treatmentForm = new PrescriptionForm();
	        var LinkedForm = StaffLoginForm.LinkedForm;

            treatmentForm.setPatient(selectedPatient);
			LinkedForm.SetPanelForm(treatmentForm);
        }

        private void patientRecordsBtn_Click(object sender, EventArgs e) {
	        var recordForm = new PatientRecordForm();
			recordForm.setRecordModel(selectedPatient);
			recordForm.Show();
        }
    }
}

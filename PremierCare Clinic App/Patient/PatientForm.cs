using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using PremierCare_Clinic_App.Patient;

namespace PremierCare_Clinic_App.Patient
{
    public partial class PatientForm : Form
    {
		PatientService patientService = new PatientService();

		private Patient patientToUpdate = null;

		private bool updatePatient = false;

        public PatientForm() {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e) {
	        if (updatePatient) {
		        var ViewPatientsForm = new ViewPatientsForm();
		        ViewPatientsForm.Show();
            }
	        this.Close(); 
        }

        public void UpdatePatient(Patient patient) {
	        updatePatient = true;
	        patientToUpdate = patient;
	        patientIDLabel.Visible = true;
	        patientIDTxtBox.Visible = true;
	        patientIDTxtBox.Text = patient.patient_id.ToString();

	        patientNameTxtBox.Text = patient.patient_name;
	        contactNoTxtBox.Text = patient.contact_no;
	        addressTxtBox.Text = patient.address;
	        DOBTxtBox.Text = patient.DOB;
	        allergiesTxtBox.Text = patient.allergies;
	        bloodTypeTxtBox.Text = patient.blood_type;
        }

        private void addPatientBtn_Click(object sender, EventArgs e) {
	        errorProvider1.Clear();
	        var nameLength = patientNameTxtBox.Text.Trim().Length;
	        var contactLength = contactNoTxtBox.Text.Trim().Length;
	        var addressLength = addressTxtBox.Text.Trim().Length;
	        var dobLength = DOBTxtBox.Text.Trim().Length;

	        if (nameLength < 1 || contactLength < 1 || addressLength < 1 || dobLength < 1) {
		        //MessageBox.Show(@"Please Fill out all Required Fields
		        if (nameLength < 1) {
			        errorProvider1.SetError(patientNameTxtBox, "Required Field!");
			        errorProvider1.SetIconPadding(patientNameTxtBox, 4);
		        }

		        if (contactLength < 1) {
			        errorProvider1.SetError(contactNoTxtBox, "Required Field!");
			        errorProvider1.SetIconPadding(contactNoTxtBox, 4);
		        }

		        if (addressLength < 1) {
			        errorProvider1.SetError(addressTxtBox, "Required Field!");
			        errorProvider1.SetIconPadding(addressTxtBox, 4);
		        }

		        if (dobLength < 1) {
			        errorProvider1.SetError(DOBTxtBox, "Required Field!");
			        errorProvider1.SetIconPadding(DOBTxtBox, 4);
		        }

		        return;
	        }

	        if (errorProvider2.GetError(contactNoTxtBox).Length >= 1) return;

	        if (patientToUpdate == null && !updatePatient) {
		        patientToUpdate = new Patient() {
			        patient_name = patientNameTxtBox.Text.Trim(),
			        contact_no = contactNoTxtBox.Text.Trim(),
			        address = addressTxtBox.Text.Trim(),
			        DOB = DOBTxtBox.Text.Trim(),
			        allergies = allergiesTxtBox.Text.Trim(),
			        blood_type = bloodTypeTxtBox.Text.Trim()
		        };

		        var patientCreated = patientService.CreatePatient(patientToUpdate);

		        MessageBox.Show(patientCreated
			        ? @"Patient Successfully Registered"
			        : @"Error Registering Patient. Please Try Again");

		        if (!patientCreated) return;
	        }
	        else {
		        errorProvider2.Clear();
		        if (!Regex.Match(contactNoTxtBox.Text, @"^((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}$").Success) {
			        errorProvider2.SetError(contactNoTxtBox, "Invalid Phone Number");
			        errorProvider2.SetIconPadding(contactNoTxtBox, 4);
		        }
		        if (errorProvider2.GetError(contactNoTxtBox).Length >= 1) return;
                patientToUpdate.patient_name = patientNameTxtBox.Text.Trim();
				patientToUpdate.contact_no = contactNoTxtBox.Text.Trim();
				patientToUpdate.address = addressTxtBox.Text.Trim();
				patientToUpdate.DOB = DOBTxtBox.Text.Trim();
				patientToUpdate.allergies = allergiesTxtBox.Text.Trim();
				patientToUpdate.blood_type = bloodTypeTxtBox.Text.Trim();

                var patientUpdated = patientService.UpdatePatient(patientToUpdate);
				MessageBox.Show(patientUpdated
		        ? @"Patient Successfully Updated"
		        : @"Error Updating Patient. Please Try Again");

				if (!patientUpdated) return;
				patientIDLabel.Visible = false;
				patientIDTxtBox.Visible = false;
				this.Close();
				var ViewPatientsForm = new ViewPatientsForm();
				ViewPatientsForm.Show();
	        }


			patientNameTxtBox.Clear();
	        contactNoTxtBox.Clear();
	        addressTxtBox.Clear();
	        DOBTxtBox.ResetText();
	        allergiesTxtBox.Clear();
	        bloodTypeTxtBox.ResetText();
        }

        private void contactNoTxtBox_Validating(object sender, CancelEventArgs e) {
			errorProvider2.Clear();
	        if (!Regex.Match(contactNoTxtBox.Text, @"^((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}$").Success) {
				errorProvider2.SetError(contactNoTxtBox,"Invalid Phone Number");
				errorProvider2.SetIconPadding(contactNoTxtBox, 4);
            }
        }

        private void backBtn_MouseHover(object sender, EventArgs e) {
	        toolTip1.SetToolTip(backBtn, "Close this form");
        }

        private void addPatientBtn_MouseHover(object sender, EventArgs e) {
	        toolTip2.SetToolTip(addPatientBtn,"Add Patient to database");
        }
		
    }
}

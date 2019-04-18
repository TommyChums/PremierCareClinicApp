using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PremierCare_Clinic_App.Drug;
using PremierCare_Clinic_App.Login;
using PremierCare_Clinic_App.Prescription;

namespace PremierCare_Clinic_App.Patient
{
	public partial class PrescriptionForm : Form {

		private DrugService drugService = new DrugService();
		private PrescriptionService prescriptionService = new PrescriptionService();
		private Patient patient = null;
		private bool update = false;
		private Doctor.Doctor doctor = LoggedInStaff.loggedInDoctor;

		public void setPatient(Patient selectedPatient) {
			patient = selectedPatient;
		}

        public PrescriptionForm()
        {
            InitializeComponent();
        }

        private void PatientTreatmentForm_Load(object sender, EventArgs e) {
	        patientNameTxtBox.Text = patient.patient_name;
	        medicineBox.DataSource = drugService.GetDrugs();
	        medicineBox.DisplayMember = "drug_name";
	        medicineBox.ValueMember = "drug_id";
	        if (update) {
		        
	        }
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e) {
	        toolTip1.SetToolTip(pictureBox1, "Close this form");
        }

        private void pictureBox1_Click(object sender, EventArgs e) {
            var patientForm = new ViewPatientsForm();
            patientForm.Show();
			this.Close();
        }

        private void medicineBox_SelectedIndexChanged(object sender, EventArgs e) {
	        //printPreviewControl1.InvalidatePreview();
        }

        private void treatmentBtn_Click(object sender, EventArgs e) {
	        if (numericUpDown1.Text.Equals("0") || numericUpDown2.Text.Equals("0")) {

				errorProvider1.Clear();

		        if (numericUpDown1.Text.Equals("0")) {
			        errorProvider1.SetError(numericUpDown1, "Cannot be 0");
		        }

		        if (numericUpDown2.Text.Equals("0")) {
			        errorProvider1.SetError(numericUpDown2, "Cannot be 0");
		        }

		        errorProvider1.BlinkRate = 0;

		        return;
	        }

	        if (printDialog1.ShowDialog() == DialogResult.OK) { 
			   printDocument1.Print();
			   Prescription.Prescription prescription = new Prescription.Prescription() {
				   dosage_per_day = int.Parse(numericUpDown1.Text),
				   duration_in_days = int.Parse(numericUpDown2.Text),
				   patient_id = patient.patient_id,
				   drug_id = int.Parse(medicineBox.SelectedValue.ToString()),
				   doctor_id = doctor.doctor_id
			   };

			   prescriptionService.CreatePatientPrescription(prescription);
	       }

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e) {
	        e.Graphics.DrawString("Patient Name: " + patientNameTxtBox.Text 
	                                               + "\n\nPatient ID: " + patient.patient_id
	                                               + "\n\nPrescription: " + medicineBox.Text
	                                               + "\n\nDosage: " + numericUpDown1.Text
	                                               + " times per day for " + numericUpDown2.Text
	                                               + " days\n\nPrescribing Doctor: " +
	                                               LoggedInStaff.loggedInDoctor.doctor_name
	                                               + "\n\nSignature: ",
		        new Font("Trebuchet MS", 28), new SolidBrush(Color.Black), 0, 0);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e) {
	        //printPreviewControl1.InvalidatePreview();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e) {
	        //printPreviewControl1.InvalidatePreview();
        }

        private void refreshPreview_Click(object sender, EventArgs e) {
	        printPreviewControl1.InvalidatePreview();
        }
    }
}

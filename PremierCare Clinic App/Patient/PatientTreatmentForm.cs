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
using PremierCare_Clinic_App.Patient_Treatment;

namespace PremierCare_Clinic_App.Patient
{
	public partial class PatientTreatmentForm : Form {

		private DrugService drugService = new DrugService();
		private Patient_TreatmentService treatmentService = new Patient_TreatmentService();
		private Patient patient = null;
		private bool update = false;

		public void setPatient(Patient selectedPatient) {
			patient = selectedPatient;
		}

        public PatientTreatmentForm()
        {
            InitializeComponent();
        }

        private void PatientTreatmentForm_Load(object sender, EventArgs e) {
	        patientNameTxtBox.Text = patient.patient_name;
	        medicineBox.DataSource = drugService.GetDrugs();
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
    }
}

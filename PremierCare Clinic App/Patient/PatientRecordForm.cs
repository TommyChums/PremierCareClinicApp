using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PremierCare_Clinic_App.Patient
{
    public partial class PatientRecordForm : Form {
	    private PatientRecordModel recordModel = null;

	    public void setRecordModel(Patient patient) {
		    recordModel = new PatientService().GetPatientRecord(patient);
	    }

        public PatientRecordForm()
        {
            InitializeComponent();
        }

        private void PatientRecordForm_Load(object sender, EventArgs e) {
	        dataGridView1.DataSource = recordModel.Appointments;
	        dataGridView2.DataSource = recordModel.Invoices;
	        dataGridView3.DataSource = recordModel.Prescriptions;
        }

        private void backBtn_Click(object sender, EventArgs e) {
	        StaticClass.LinkedForm.SetPanelForm(new ViewPatientsForm());
        }
    }
}

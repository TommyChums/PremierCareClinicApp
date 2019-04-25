using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using PremierCare_Clinic_App.Appointment;
using PremierCare_Clinic_App.Login;
using PremierCare_Clinic_App.Patient;
using Resources = PremierCare_Clinic_App.Properties.Resources;

namespace PremierCare_Clinic_App
{
    public partial class LinkedForm : Form {
	    private bool isCollapsed = true;
        public LinkedForm()
        {
            InitializeComponent();
        }

        private void LinkedForm_Load(object sender, EventArgs e) {

	        if (LoggedInStaff.loggedInStaff == null && LoggedInStaff.loggedInDoctor == null) {
                new StaffLoginForm().Show();
                Hide();
                return;
	        }

	        if (LoggedInStaff.loggedInStaff != null) {
		        label1.Text += LoggedInStaff.loggedInStaff.staff_name;
	        }
	        else {
		        pictureBox2.Enabled = false;
		        flowLayoutPanel1.Enabled = false;
		        label1.Text += LoggedInStaff.loggedInDoctor.doctor_name;
		        SetPanelForm(new ViewPatientsForm());
            }
        }

        public void SetPanelForm(Form form) {
	        pictureBox3.Visible = false;
	        welcomeLabel.Visible = false;
	        formPanel.Controls.Clear();
	        form.TopLevel = false;
	        formPanel.Controls.Add(form);
	        form.Dock = DockStyle.Fill;
	        form.Show();
        }

        private void patientBtn_Click(object sender, EventArgs e) {
	        timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e) {
	        var startTime = System.DateTime.Now;

	        if (isCollapsed) {
		        patientBtn.Image = Resources.up_512;
                flowLayoutPanel2.Height += 10;
		        if (flowLayoutPanel2.Size == flowLayoutPanel2.MaximumSize) {
					timer1.Stop();
					isCollapsed = false;
		        }
	        }
	        else {
		        patientBtn.Image = Resources.down_512;
		        flowLayoutPanel2.Height -= 10;
		        if (flowLayoutPanel2.Size == flowLayoutPanel2.MinimumSize) {
					timer1.Stop();
					isCollapsed = true;
		        }
	        }
        }

        private void addPatient_Click(object sender, EventArgs e) {
	        formPanel.Controls.Clear();
	        var form = new PatientForm {TopLevel = false};
	        formPanel.Controls.Add(form);
	        form.Dock = DockStyle.Fill;
	        form.Show();
        }

        private void viewPatients_Click(object sender, EventArgs e) {
	        formPanel.Controls.Clear();
	        var form = new ViewPatientsForm {TopLevel = false};
	        formPanel.Controls.Add(form);
	        form.Dock = DockStyle.Fill;
	        form.Show();
        }

        private void button1_Click(object sender, EventArgs e) {
	        formPanel.Controls.Clear();
	        var form = new ViewAppointmentsForm {TopLevel = false};
	        formPanel.Controls.Add(form);
	        form.Dock = DockStyle.Fill;
	        form.Show();
        }

        private void formPanel_ControlAdded(object sender, ControlEventArgs e) {
	       // MessageBox.Show(e.Control.Name + " was just added to " + formPanel.Controls.IndexOf(e.Control));
        }

        private void formPanel_ControlRemoved(object sender, ControlEventArgs e) {
	        //formPanel.Refresh();
            //MessageBox.Show(e.Control.Name + " was just removed from " + formPanel.Controls.IndexOf(e.Control));
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e) {
	        toolTip1.SetToolTip(pictureBox1, "Close this form to sign out");
        }

        private void pictureBox1_Click(object sender, EventArgs e) {
			Dispose();
			LoggedInStaff.loggedInStaff = null;
			LoggedInStaff.loggedInDoctor = null;
            StaticClass.LinkedForm = null;
			StaticClass.StaffLoginForm.ShowForm();
        }

        private void pictureBox2_Click(object sender, EventArgs e) {
			formPanel.Controls.Clear();
	        pictureBox3.Visible = true;
	        welcomeLabel.Visible = true;
			formPanel.Controls.Add(pictureBox3);
            formPanel.Controls.Add(welcomeLabel);
            welcomeLabel.BringToFront();
        }
    }
}

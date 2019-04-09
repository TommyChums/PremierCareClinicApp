﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PremierCare_Clinic_App.Login;
using PremierCare_Clinic_App.Patient;

namespace PremierCare_Clinic_App.Login
{
    public partial class StaffLoginForm : Form
    {
		
        public StaffLoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e) {
	        var loginService = new Csr_LoginService();

	        LoggedInStaff.loggedInStaff = loginService.Login(passwordField.Text);

	        if (LoggedInStaff.loggedInStaff == null) {
		        errorProvider1.SetError(passwordField, "Invalid Password");
				errorProvider1.SetIconAlignment(passwordField, ErrorIconAlignment.MiddleLeft);
				errorProvider1.SetIconPadding(passwordField, 2);
                //MessageBox.Show(@"Invalid Password. Login Failed!");
                //passwordField.Clear();
                return;
	        }

	        this.Hide();
			var patientForm = new PatientForm();
	        //var patientForm = new ViewPatientsForm();
	        patientForm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e) {
	        this.Close();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e) {
	        toolTip1.SetToolTip(pictureBox1, "Exit the program");
        }
    }
}
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
using PremierCare_Clinic_App.Invoice;
using PremierCare_Clinic_App.Login;
using PremierCare_Clinic_App.Patient;
using PremierCare_Clinic_App.Prescription;
using PremierCare_Clinic_App.Service;

namespace PremierCare_Clinic_App.Appointment
{
    public partial class ViewAppointmentsForm : Form
    {
        private AppointmentService appointmentService = new AppointmentService();
		AppointmentDAO AppointmentDAO = new AppointmentDAO();

		List<DisplayedAppointment> appointmentsToDisplay = new List<DisplayedAppointment>();

		private Appointment appointment = null;

		private Invoice.Invoice invoice = null;

        private DisplayedAppointment displayedAppointment = null;

        private ServiceService serviceService = new ServiceService();

        private PatientService patientService = new PatientService();

        private PrescriptionService prescriptionService = new PrescriptionService();

        private DrugService drugService = new DrugService();

        double drugCost = 0;
        double serviceCost = 0;

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

        private void generateInvoiceBtn_Click(object sender, EventArgs e) {

	        var invoicePatient = patientService.GetPatientById(appointment.patient_id);

            var invoiceService = serviceService.GetServiceById(appointment.service_id);
	        serviceCost = invoiceService.cost;

	        var prescriptions = prescriptionService.GetPatientPrescriptionByPatientId(invoicePatient.patient_id);

			List<string> drugNames = new List<string>();
	        foreach (var prescription in prescriptions) {
				drugNames.Add(drugService.GetDrugById(prescription.drug_id).drug_name);
				drugCost += drugService.GetDrugById(prescription.drug_id).cost;
	        }

	        StringBuilder stringBuilder = new StringBuilder();
	        foreach (var drugName in drugNames) {
		        stringBuilder.AppendLine(drugName);
	        }

            var invoiceTotalCost = drugCost + serviceCost;

			InvoiceService invoiceDAOService = new InvoiceService();

			invoice = new Invoice.Invoice() {
				patient_id = invoicePatient.patient_id,
				service_id = invoiceService.service_id,
				drug_names = stringBuilder.ToString(),
				total_cost = invoiceTotalCost
			};

			MessageBox.Show(invoiceDAOService.CreateInvoice(invoice) ? "Invoice Successfully Generated!" : "Failed to Generate Invoice");

			printPreviewDialog1.StartPosition = FormStartPosition.CenterScreen;
			printPreviewDialog1.Size = new Size(480, 600);
			if (printPreviewDialog1.ShowDialog() == DialogResult.OK) {
				printDocument1.Print();
			}
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e) {
	        e.Graphics.DrawString("Patient Name: " + patientService.GetPatientById(appointment.patient_id).patient_name 
	                                               + "\nMedication: " + invoice.drug_names + "\tcost: $" + drugCost 
	                                               + "\nService: " + serviceService.GetServiceById(appointment.service_id).service_category + "\tcost: $" + serviceCost 
	                                               + "\nTotal Cost: $" + (drugCost + serviceCost),
		        new Font("Trebuchet MS", 28), new SolidBrush(Color.Black), 0, 0);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Dapper;

namespace PremierCare_Clinic_App.Invoice
{
    public class Invoice {
        public int invoice_id { get; set; }
        public int patient_id { get; set; }
        public int service_id { get; set; }
        public string drug_names { get; set; }
        public double total_cost { get; set; }
    }

    public class InvoiceDAO {
	    public bool CreateInvoice(Invoice invoice) {
		    using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["premierCare"].ConnectionString)) {
			    const string sql = "INSERT INTO Invoice(patient_id, service_id, drug_names, total_cost) VALUES(@patient, @service, @drugs, @cost)";

			    var rowsAffected =
				    connection.Execute(sql, new {patient = invoice.patient_id, service = invoice.service_id, drugs = invoice.drug_names, cost = invoice.total_cost});

			    return rowsAffected > 0;
		    }
        }

	    public List<Invoice> GetInvoices() {
		    using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["premierCare"].ConnectionString)) {
			    const string sql = "SELECT * FROM Invoice";

			    return connection.Query<Invoice>(sql).AsList();
		    }
        }

	    public Invoice GetInvoiceById(int id) {
		    using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["premierCare"].ConnectionString)) {
			    const string sql = "SELECT * FROM Invoice WHERE invoice_id = @invoice_id";

			    return connection.QuerySingle<Invoice>(sql, new {invoice_id = id});
		    }
        }

	    public List<Invoice> GetInvoicesByPatientId(int id) {
		    using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["premierCare"].ConnectionString)) {
			    const string sql = "SELECT * FROM Invoice WHERE patient_id = @patient";

			    return connection.Query<Invoice>(sql, new {patient = id}).AsList();
		    }
        }

	    public bool UpdateInvoice(Invoice invoice) {
		    using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["premierCare"].ConnectionString)) {
			    const string sql = "UPDATE Invoice SET patient_id = @patient, service_id = @service";

			    var rowsAffected =
				    connection.Execute(sql, new {patient = invoice.patient_id, service = invoice.service_id});

			    return rowsAffected > 0;
		    }
        }

	    public bool DeleteInvoice(Invoice invoice) {
		    using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["premierCare"].ConnectionString)) {
			    const string sql = "DELETE FROM Invoice WHERE invoice_id = @invoice";

			    var rowsAffected = connection.Execute(sql, new {invoice = invoice.invoice_id});

			    return rowsAffected > 0;
		    }
        }
    }
}

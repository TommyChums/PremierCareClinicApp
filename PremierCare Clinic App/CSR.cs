using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using MySql.Data.MySqlClient;

namespace PremierCare_Clinic_App
{
    public class CSR {
	    public int csr_id { get; set; }
	    public string csr_name { get; set; }
	    public string csr_contact_number { get; set; }
	    public string csr_address { get; set; }
    }

    public class csrDAO {
	    public bool CreateCSR(CSR csr) {
		    using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["premierCare"].ConnectionString)) {
			    const string sql =
				    "INSERT INTO CSR(csr_name, csr_contact_number, csr_address) VALUES(@csr_name, @csr_contact_number, @csr_address)";

			    var rowsAffected = connection.Execute(sql,
				    new {
					    csr_name = csr.csr_name, csr_contact_number = csr.csr_contact_number,
					    csr_address = csr.csr_address
				    });

			    return rowsAffected > 0;
		    }
	    }

	    public List<CSR> GetCSRS() {
		    using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["premierCare"].ConnectionString)) {
			    const string sql = "SELECT * FROM CSR";

			    return connection.Query<CSR>(sql).AsList();
		    }
        }

	    public List<CSR> GetCSRS(string term) {
		    using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["premierCare"].ConnectionString)) {
			    const string sql =
				    "SELECT * FROM CSR WHERE csr_name LIKE %@term% OR csr_contact_number LIKE %@term% OR csr_address LIKE %@term%";

			    return connection.Query<CSR>(sql, new {term = term}).AsList();
		    }
        }

	    public bool UpdateCSR(CSR csr) {
		    using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["premierCare"].ConnectionString)) {
			    const string sql =
				    "UPDATE CSR SET csr_name = @csr_name, csr_contact_number = @csr_contact_number, csr_address = @csr_address WHERE csr_id = @csr_id";

			    var rowsAffected = connection.Execute(sql,
				    new {
					    csr_name = csr.csr_name, csr_contact_number = csr.csr_contact_number,
					    csr_address = csr.csr_address
				    });

			    return rowsAffected > 0;
		    }
        }

	    public bool DeleteCSR(CSR csr) {
		    using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["premierCare"].ConnectionString)) {
			    const string sql = "DELETE FROM CSR WHERE csr_id = @csr_id";

			    var rowsAffected = connection.Execute(sql, new {csr_id = csr.csr_id});

			    return rowsAffected > 0;
		    }
        }
	}
}

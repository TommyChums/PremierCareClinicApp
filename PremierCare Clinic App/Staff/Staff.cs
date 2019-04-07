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
    public class Staff {
	    public int staff_id { get; set; }
	    public string staff_name { get; set; }
	    public string staff_contact_number { get; set; }
	    public string staff_address { get; set; }
	    public string staff_type { get; set; }
    }

    public class StaffDAO {
	    public List<Staff> GetStaff() {
            using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["premierCare"].ConnectionString)) {
	            const string sql = "SELECT * FROM Staff";

	            return connection.Query<Staff>(sql).AsList();
            }
        }

	    public Staff GetStaffById(int id) {
		    using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["premierCare"].ConnectionString)) {
			    const string sql = "SELECT * FROM Staff WHERE staff_id = @staff_id";

			    return connection.QuerySingle<Staff>(sql, new {staff_id = id});
		    }
        }

	    public List<Staff> GetStaff(string term) {
		    using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["premierCare"].ConnectionString)) {
			    const string sql = "SELECT * FROM Staff WHERE staff_name LIKE %@term% OR staff_address LIKE %@term% OR staff_type LIKE %@term%";

			    return connection.Query<Staff>(sql, new {term = term}).AsList();
		    }
        }
    }
}

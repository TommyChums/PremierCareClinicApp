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
    public class Csr_Login {
	    public string login_password { get; set; }
	    public int staff_id { get; set; }
    }

    public class Csr_LoginDAO {
	    public List<Csr_Login> GetCsrLogins() {
		    using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["premierCare"].ConnectionString)) {
			    const string sql = "SELECT * FROM Csr_Login";
				
			    return connection.Query<Csr_Login>(sql).AsList();
		    }
        }
    }

    public class Csr_LoginService {
        Csr_LoginDAO csrLoginDao = new Csr_LoginDAO();
        StaffService staffService = new StaffService();

        public List<Csr_Login> GetCsrLogins() {
	        return csrLoginDao.GetCsrLogins();
        }

        public Staff Login(string password) {
	        var loginPasswords = GetCsrLogins();

	        foreach (var csrLogin in loginPasswords) {
		        if (csrLogin.login_password.Equals(password))
			        return staffService.GetStaffById(csrLogin.staff_id);
	        }

	        return null;
        }
    }
}

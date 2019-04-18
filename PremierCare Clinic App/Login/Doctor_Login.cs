using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using MySql.Data.MySqlClient;
using PremierCare_Clinic_App.Doctor;

namespace PremierCare_Clinic_App.Login
{
	public class Doctor_Login {
		public string login_password { get; set; }
		public int doctor_id { get; set; }
	}

	public class Doctor_LoginDAO {
		public Doctor.Doctor GetDoctor(string password) {
			using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["premierCare"].ConnectionString)) {
				const string sql = "SELECT doctor_id FROM Csr_Login WHERE login_password = @pass";

				int id;
				try {
					id = connection.Query<int>(sql, new {pass = password}).Single();
				}
				catch (Exception e) {
					return null;
				}
				
				DoctorService doctorService = new DoctorService();
				return doctorService.GetDoctorById(id);
			}
        }
	}

	public class Doctor_LoginService {
		private Doctor_LoginDAO loginDao = new Doctor_LoginDAO();

		public Doctor.Doctor GetDoctor(string password) {
			return loginDao.GetDoctor(password);
		}
	}
}

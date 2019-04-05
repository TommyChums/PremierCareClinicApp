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
	//Drug Model with attributes matching Database
	public class Drug {
		public int drug_id { get; set; }
		public string drug_name { get; set; }
		public int cost { get; set; }
		public string lengths_of_time { get; set; }
		public string no_of_times_per_day { get; set; }
	}

	//Drug Data Access Object for accessing and performing database operations
    public class DrugDAO {
		//Method to Insert a Drug into the database
		public bool CreateDrug(Drug drug) {
			//Connect to database using the connection string from App.config
			//Using a 'using' block to terminate the connection after we're finished with it
            using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["premierCare"].ConnectionString)) {
				//SQL code to insert the drug into the database
				const string sql = "INSERT INTO Drug(drug_name, cost, lengths_of_time, no_of_times_per_day) VALUES(@drug_name, @cost, @lengths_of_time, @no_of_times_per_day)";

                //Adding parameters to the code to prevent against SQL injection
                //Executing the SQL code with added parameters. Returns number of Rows affected
                var rowsAffected = connection.Execute(sql, new {
					drug_name = drug.drug_name,
					cost = drug.cost,
					lengths_of_time = drug.lengths_of_time,
					no_of_times_per_day = drug.no_of_times_per_day
				});

                //A successful insert will affect at least 1 Row and will return true
                //An unsuccessful insert will return 0 and therefore return false
                return rowsAffected > 0;
			}
		}

		//Method to retrieve all Drugs in the database
		public List<Drug> GetDrugs() {
			//Connect to database using the connection string from App.config
			//Using a 'using' block to terminate the connection after we're finished with it
            using (var connection =	new MySqlConnection(ConfigurationManager.ConnectionStrings["premierCare"].ConnectionString)) {
				//SQL code to select all drugs from the Drug table
				const string sql = "SELECT * FROM Drug";

				//Queries the database executing the SQL code and returns it as a list of drugs
                return connection.Query<Drug>(sql).AsList();
			}
		}

		//Method to retrieve a Drug by it's id
		public Drug GetDrugById(int id) {
			//Connect to database using the connection string from App.config
			//Using a 'using' block to terminate the connection after we're finished with it
            using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["premierCare"].ConnectionString)) {
	            //SQL code to select the drug from the Drug table by id
                const string sql = "SELECT * FROM Drug WHERE drug_id = @drug_id";

				//Adding parameters to the code to prevent against SQL injection
				//Queries the database executing the SQL code and returns the Drug
                return connection.QuerySingle<Drug>(sql, new {drug_id = id});
			}
		}

        //Method to retrieve all Drugs in the database that have a field containing the term
        public List<Drug> GetDrugs(string term) {
	        //Connect to database using the connection string from App.config
	        //Using a 'using' block to terminate the connection after we're finished with it
            using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["premierCare"].ConnectionString)) {
				//SQL code to select all drugs from the Drug table that have a field containing the term
				const string sql = "SELECT * FROM Drug WHERE drug_name LIKE %@term% OR cost LIKE %@term% OR lengths_of_time LIKE %@term% OR no_of_times_per_day LIKE %@term%";

				//Queries the database executing the SQL code and returns it as a list of drugs
                return connection.Query<Drug>(sql, new {term = term}).AsList();
			}
        }

		//Method to Update the given drug's records
		public bool UpdateDrug(Drug drug) {
			//Connect to database using the connection string from App.config
			//Using a 'using' block to terminate the connection after we're finished with it
			using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["premierCare"].ConnectionString)) {
				//SQL code to update the given drug
				const string sql =
					"UPDATE Drug SET drug_name = @drug_name, cost = @cost, lengths_of_time = @lengths_of_time, no_of_times_per_day = @no_of_times_per_day";

				//Adding parameters to the code to prevent against SQL injection
				//Executing the SQL code with added parameters. Returns number of Rows affected
                var rowsAffected = connection.Execute(sql, new {
					drug_name = drug.drug_name,
					cost = drug.cost,
					lengths_of_time = drug.lengths_of_time,
					no_of_times_per_day = drug.no_of_times_per_day
				});

                //A successful update will affect at least 1 Row and will return true
                //An unsuccessful update will return 0 and therefore return false
                return rowsAffected > 0;
			}
		}

		//Method to Delete a Drug from the database
		public bool DeleteDrug(Drug drug) {
			//Connect to database using the connection string from App.config
			//Using a 'using' block to terminate the connection after we're finished with it
			using (var connection =
				new MySqlConnection(ConfigurationManager.ConnectionStrings["premierCare"].ConnectionString)) {
				//SQL code to delete the drug from the database
				const string sql = "DELETE FROM Drug WHERE drug_id = @drug_id";

				//Adding parameters to the code to prevent against SQL injection
				//Executing the SQL code with added parameters. Returns number of Rows affected
				var rowsAffected = connection.Execute(sql, new {drug_id = drug.drug_id});

				//A successful delete will affect at least 1 Row and will return true
				//An unsuccessful delete will return 0 and therefore return false
				return rowsAffected > 0;
            }
		}
    }
}

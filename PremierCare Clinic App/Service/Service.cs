using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Dapper;

namespace PremierCare_Clinic_App.Service
{
	//Service Model with attributes matching database
    public class Service {
	    public int service_id { get; set; }
	    public int cost { get; set; }
	    public string service_category { get; set; }
    }

    //Service Data Access Object for accessing and performing database operations
    public class ServiceDAO {
	    public bool CreateService(Service service) {
		    //Connect to database using the connection string from App.config
		    //Using a 'using' block to terminate the connection after we're finished with it
            using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["premierCare"].ConnectionString)) {
	            //SQL code to insert the service into the database
                const string sql = "INSERT INTO Service(cost, service_category) VALUES(@cost, @service_category)";

                //Adding parameters to the code to prevent against SQL injection
                //Executing the SQL code with added parameters. Returns number of Rows affected
                var rowsAffected = connection.Execute(sql, new { cost = service.cost, service_category = service.service_category });

                //A successful update will affect at least 1 Row and will return true
                //An unsuccessful update will return 0 and therefore return false
                return rowsAffected > 0;
		    }
	    }

	    //Method to Retrieve all Services in the Database
        public List<Service> GetServices() {
		    //Connect to database using the connection string from App.config
		    //Using a 'using' block to terminate the connection after we're finished with it
            using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["premierCare"].ConnectionString)) {
	            //SQL code to select all services from the Service table
                const string sql = "SELECT * FROM Service";
				
                //Queries the database executing the SQL code and returns it as a list of services
                return connection.Query<Service>(sql).AsList();
		    }
        }

		//Method to Retrieve a Service by it's id
        public Service GetServiceById(int id) {
	        //Connect to database using the connection string from App.config
	        //Using a 'using' block to terminate the connection after we're finished with it
            using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["premierCare"].ConnectionString)) {
	            //SQL code to select the service from the Service table by id
                const string sql = "SELECT * FROM Service WHERE service_id = @service_id";

                //Adding parameters to the code to prevent against SQL injection
                //Queries the database executing the SQL code and returns the Service
                return connection.QuerySingle<Service>(sql, new {service_id = id});
	        }
        }

        //Method to Retrieve all Services in the Database that have a field containing the term
        public List<Service> GetServices(string term) {
		    //Connect to database using the connection string from App.config
		    //Using a 'using' block to terminate the connection after we're finished with it
            using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["premierCare"].ConnectionString)) {
	            //SQL code to select all services from the Service table where any field contains the term
                const string sql = "SELECT * FROM Service WHERE cost LIKE %@term% OR service_category LIKE %@term%";

				//Adding parameters to the code to prevent against SQL injection
                //Queries the database executing the SQL code and returns it as a list of services
			    return connection.Query<Service>(sql, new {term = term}).AsList();
		    }
        }

        //Method to Update the given service's records
        public bool UpdateService(Service service) {
		    //Connect to database using the connection string from App.config
		    //Using a 'using' block to terminate the connection after we're finished with it
            using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["premierCare"].ConnectionString)) {
	            //SQL code to Update the given service
                const string sql = "UPDATE Service SET cost = @cost, service_category = @service_category WHERE service_id = @service_id";

                //Adding parameters to the code to prevent against SQL injection
                //Executing the SQL code with added parameters. Returns number of Rows affected
                var rowsAffected = connection.Execute(sql, new {cost = service.cost, service_category = service.service_category, service_id = service.service_id});

                //A successful update will affect at least 1 Row and will return true
                //An unsuccessful update will return 0 and therefore return false
                return rowsAffected > 0;
		    }
        }

        //Method to Delete a Service from the database
        public bool DeleteService(Service service) {
		    //Connect to database using the connection string from App.config
		    //Using a 'using' block to terminate the connection after we're finished with it
            using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["premierCare"].ConnectionString)) {
	            //SQL code to Delete the given service
                const string sql = "DELETE FROM Service WHERE service_id = @service_id";

                //Adding parameters to the code to prevent against SQL injection
                //Executing the SQL code with added parameters. Returns number of Rows affected
                var rowsAffected = connection.Execute(sql, new {service_id = service.service_id});

                //A successful update will affect at least 1 Row and will return true
                //An unsuccessful update will return 0 and therefore return false
                return rowsAffected > 0;
		    }
        }
    }
}

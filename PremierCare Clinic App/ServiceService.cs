using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PremierCare_Clinic_App
{
	//Service Implementation for the Service Class
	//For Business Logic as well as DAO operations
    public class ServiceService {
		ServiceDAO serviceDAO = new ServiceDAO();

		public bool CreateService(Service service) {
			return serviceDAO.CreateService(service);
		}

		public List<Service> GetServices() {
			return serviceDAO.GetServices();
		}

		public List<Service> GetServices(string term) {
			return serviceDAO.GetServices(term);
		}

		public bool UpdateService(Service service) {
			return serviceDAO.UpdateService(service);
		}

		public bool DeleteService(Service service) {
			return serviceDAO.DeleteService(service);
		}
    }
}

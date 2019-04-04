using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierCare_Clinic_App
{
    public class CSRService {
        csrDAO csrDAO = new csrDAO();

        public bool CreateCSR(CSR csr) {
	        return csrDAO.CreateCSR(csr);
        }

        public List<CSR> GetCSRS() {
	        return csrDAO.GetCSRS();
        }

        public List<CSR> GetCSRS(string term) {
	        return csrDAO.GetCSRS(term);
        }

        public bool UpdateCSR(CSR csr) {
	        return csrDAO.UpdateCSR(csr);
        }

        public bool DeleteCSR(CSR csr) {
	        return csrDAO.DeleteCSR(csr);
        }
    }
}

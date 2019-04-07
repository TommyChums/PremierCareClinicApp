using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierCare_Clinic_App
{
	//Service Implementation for the Drug Class
	//For Business Logic as well as DAO operations
    class DrugService {
	    DrugDAO drugDAO = new DrugDAO();

	    public bool CreateDrug(Drug drug) {
		    return drugDAO.CreateDrug(drug);
	    }

	    public List<Drug> GetDrugs() {
		    return drugDAO.GetDrugs();
	    }

	    public Drug GetDrugById(int id) {
		    return drugDAO.GetDrugById(id);
	    }

	    public List<Drug> GeDrugs(string term) {
		    return drugDAO.GetDrugs(term);
	    }

	    public bool UpdateDrug(Drug drug) {
		    return drugDAO.UpdateDrug(drug);
	    }

	    public bool DeleteDrug(Drug drug) {
		    return drugDAO.DeleteDrug(drug);
	    }
    }
}

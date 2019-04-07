using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierCare_Clinic_App.Invoice
{
    public class InvoiceService {
	    private InvoiceDAO invoiceDAO = new InvoiceDAO();

	    public bool CreateInvoice(Invoice invoice) {
		    return invoiceDAO.CreateInvoice(invoice);
	    }

	    public List<Invoice> GetInvoices() {
		    return invoiceDAO.GetInvoices();
	    }

	    public Invoice GetInvoiceById(int id) {
		    return invoiceDAO.GetInvoiceById(id);
	    }

	    public List<Invoice> GetInvoicesByPatientId(int id) {
		    return invoiceDAO.GetInvoicesByPatientId(id);
	    }

	    public bool UpdateInvoice(Invoice invoice) {
		    return invoiceDAO.UpdateInvoice(invoice);
	    }

	    public bool DeleteInvoice(Invoice invoice) {
		    return invoiceDAO.DeleteInvoice(invoice);
	    }
    }
}

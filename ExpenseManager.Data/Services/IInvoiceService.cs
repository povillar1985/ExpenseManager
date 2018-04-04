using ExpenseManager.Data.Domain.Invoice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseManager.Data.Services
{
    public interface IInvoiceService: IRepository<Invoice>
    {
        IEnumerable<Invoice> GetInvoiceWithDetailAndImanges(int id);
    }
}

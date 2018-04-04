using ExpenseManager.Data.Domain.Invoice;
using ExpenseManager.Data.Services;
using ExpenseManager.Repo;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace ExpenseManager.Service.Services
{
    public class InvoiceService : Repository<Invoice>, IInvoiceService
    {
        public InvoiceService(Func<ExpenseDbContext> expenseDbContext) : base(expenseDbContext)
        {
        }

        public IEnumerable<Invoice> GetInvoiceWithDetailAndImanges(int id)
        {
            return ExpenseDbContext.Invoices.Where(x => x.Id == id).Include(x=>x.InvoiceDetail).Include(x=>x.InvoiceImages);
        }
    }
}

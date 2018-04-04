using ExpenseManager.Data.Domain;
using ExpenseManager.Data.Domain.Invoice;
using ExpenseManager.Data.Domain.Merchant;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseManager.Repo
{
    public class ExpenseDbContext: DbContext
    {
        public ExpenseDbContext(): base("ExpsenseDb")
        {
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Invoice>  Invoices { get; set; }
        public virtual DbSet<InvoiceDetail> InvoiceDetails { get; set; }
        public virtual DbSet<InvoiceImage> InvoiceImages { get; set; }
        public virtual DbSet<Merchant> Merchants { get; set; }
        public virtual DbSet<MerchantType> MerchantTypes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}

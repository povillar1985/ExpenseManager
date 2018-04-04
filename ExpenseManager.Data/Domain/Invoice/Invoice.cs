using System.Collections.Generic;
using merchant = ExpenseManager.Data.Domain.Merchant.Merchant;

namespace ExpenseManager.Data.Domain.Invoice
{
    public class Invoice: BaseEntity
    {
        public virtual merchant Merchant { get; set; }
        public int MerchantId { get; set; }
        public string Description { get; set; }
        public virtual ICollection<InvoiceImage> InvoiceImages { get; set; }
        public virtual ICollection<InvoiceDetail> InvoiceDetail { get; set; }
        public string Remarks { get; set; }

        public Invoice()
        {
            InvoiceImages = new HashSet<InvoiceImage>();
            InvoiceDetail = new HashSet<InvoiceDetail>();
        }
    }
}
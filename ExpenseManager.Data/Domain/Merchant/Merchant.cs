namespace ExpenseManager.Data.Domain.Merchant
{
    public class Merchant: BaseEntity
    {
        public string Name { get; set; }
        public MerchantType Type { get; set; }
        public string Remarks { get; set; }
    }
}

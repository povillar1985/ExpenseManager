using System;

namespace ExpenseManager.Data
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime EntryDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
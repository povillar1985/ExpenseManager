﻿namespace ExpenseManager.Data.Domain
{
    public class User: BaseEntity
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        public bool Active { get; set; }

        public override string ToString()
        {
            return $"{this.LastName}, {this.FirstName}";
        }
    }
}

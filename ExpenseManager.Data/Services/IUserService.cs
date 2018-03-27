using ExpenseManager.Data.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseManager.Data.Services
{
    public interface IUserService: IRepository<User>
    {
        IEnumerable<User> GetInactiveUsers();
    }
}

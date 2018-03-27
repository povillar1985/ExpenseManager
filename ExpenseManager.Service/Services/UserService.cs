using ExpenseManager.Data.Domain;
using ExpenseManager.Data.Services;
using ExpenseManager.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseManager.Service.Services
{
    public class UserService : Repository<User>, IUserService
    {
        public IEnumerable<User> GetInactiveUsers()
        {
            return ExpenseDbContext.Users.Where(x=>x.Active == true);
        }
    }
}
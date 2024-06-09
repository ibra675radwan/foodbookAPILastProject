using DAL.Models;
using DAL.Repositories._Genericrepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.UsersRepo
{
    public class userRepositories : GenericRepositories<User>, IuserRepositoris
    {
        public userRepositories(FoodbookContext foodbookContext) : base(foodbookContext)
        {
        }
        public User GetUserByUsername(string username)
        {
            return _dbSet.Where(x => x.Name == username).FirstOrDefault();

        }
    }
}

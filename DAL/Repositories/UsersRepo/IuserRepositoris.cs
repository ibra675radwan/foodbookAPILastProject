using DAL.Models;
using DAL.Repositories._Genericrepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.UsersRepo
{
    public interface IuserRepositoris : iGenericRepositories<User>
    {
        User GetUserByUsername(string username);

    }
}

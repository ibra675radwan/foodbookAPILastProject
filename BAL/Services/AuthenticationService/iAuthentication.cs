using BLL.Wrapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.AuthenticationService
{
    public interface iAuthentication
    {
        APIResponse<bool> Login(string username, string phoneNumber);
    }
}

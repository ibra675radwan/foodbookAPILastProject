using BLL.DTO.User;
using BLL.Wrapping;
using DAL.Repositories.UsersRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.AuthenticationService
{
    public class Authentication: iAuthentication
    {
        private readonly IuserRepositoris _iuserRepository;

        public Authentication(IuserRepositoris iuserRepository)
        {
            _iuserRepository = iuserRepository;
        }
        public APIResponse<bool> Login(string username, string phoneNumber)
        {
            var result = new APIResponse<LoginRequestDto>();
            var user = _iuserRepository.GetUserByUsername(username);
            if (user == null)
            {
                throw new Exception("User not found");
            }
            if (phoneNumber != user.PhoneNumber)
            {
                throw new Exception("wrong phone number");
            }
            result.Success = true;
            return new APIResponse<bool>(true);
        }

        APIResponse<bool> iAuthentication.Login(string username, string password)
        {
            throw new NotImplementedException();
        }
    }
}

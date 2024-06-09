using BLL.DTO.User;
using BLL.Services.GenericServices;
using BLL.Wrapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.UserServices
{
    public interface iUserService: iGenericServices<UserDto>
    {
        APIResponse<UserDto> GetUserByUserName(string Name);
    }
}

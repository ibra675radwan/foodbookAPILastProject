using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO.User
{
    public class LoginRequestDto
    {
        public string UserName { get; set; } = null!;
        public string? PhoneNumber { get; set; }
    }
}

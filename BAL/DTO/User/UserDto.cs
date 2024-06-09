using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO.User
{
    public class UserDto
    {
        public int UserId { get; set; }

        public string Name { get; set; } = null!;

        public string LastName { get; set; } = null!;
        public string? PhoneNumber { get; set; }

        public string UserName { get; set; } = null!;

    }
}

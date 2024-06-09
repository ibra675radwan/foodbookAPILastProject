using BLL.DTO.Restaurant;
using BLL.DTO.User;
using BLL.Services.UserServices;
using BLL.Wrapping;
using Microsoft.AspNetCore.Mvc;

namespace foodbookAPILastProject.Controllers
    
{
    [Route("api/[Controller]")]
    [ApiController]
    public class UserController : _GenericController<UserDto>
    {
        private readonly iUserService _iUserService;
        public UserController(iUserService genericService) : base(genericService)
        {
            _iUserService = genericService;
        }
        [HttpGet("GetAllUser")]
        public APIResponse<IEnumerable<UserDto>> GetAllUsers()
        {
        return _iUserService.GetAll();
        
        
        }

        [HttpPost("AddUser")]
        public APIResponse<UserDto> Add(UserDto UserDTO)
        {
            return _iUserService.Add(UserDTO);
        }
    }
}

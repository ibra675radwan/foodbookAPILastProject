using AutoMapper;
using BLL.DTO.User;
using DAL.Models;
using DAL.Repositories.UsersRepo;
using BLL.Services.GenericServices;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.DTO.Restaurant;
using BLL.Wrapping;
using DAL.Repositories.restaurantRepositories;

namespace BLL.Services.UserServices
{
    public class UserService : GenericServices<User, UserDto>, iUserService
    {
        private readonly IMapper _mapper;
        private readonly IuserRepositoris _iuserRepositoris;

        public UserService(IuserRepositoris _iuserRepositoris , IMapper mapper): base(_iuserRepositoris, mapper)
        {
            _mapper = mapper;
            _iuserRepositoris = _iuserRepositoris;
        }

        public APIResponse<UserDto> GetUserByUserName(string name)
        {
            var response = new APIResponse<UserDto>();
            var result = _iuserRepositoris.GetUserByUsername(name);
            response.Data = _mapper.Map<UserDto>(result);
            return response;
        }
    }

}

using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using pycFinalApi.Data;
using pycFinalApi.Dto;
using pycFinalApi.Service;

namespace pycFinalApi
{
    [ApiController]
    [Route("api/nhb/[controller]")]
    public class UserController : BaseController<UserDto, User>
    {
        private readonly IUserService userService;
        private readonly IMapper mapper;


        public UserController(IUserService userService, IMapper mapper) : base(userService, mapper)
        {
            this.mapper = mapper;
            this.userService = userService;
        }




    }
}

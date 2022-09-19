using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using pycFinalApi.Data;
using pycFinalApi.Dto;
using pycFinalApi.Service;

namespace pycFinalApi
{
    [ApiController]
    [Route("api/nhb/[controller]")]
    public class AccountController : BaseController<AccountDto, Account>
    {
        private readonly IAccountService accountService;
        private readonly IMapper mapper;


        public AccountController(IAccountService accountService, IMapper mapper) : base(accountService, mapper)
        {
            this.mapper = mapper;
            this.accountService = accountService;
        }




    }
}

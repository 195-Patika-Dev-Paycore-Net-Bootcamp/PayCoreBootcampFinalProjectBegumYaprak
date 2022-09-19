using Microsoft.AspNetCore.Mvc;
using pycFinalApi.Base;
using pycFinalApi.Service;


namespace pycFinalApi
{
    [ApiController]
    [Route("api/nhb/[controller]")]
    public class TokenController : ControllerBase
    {
        private readonly ITokenService tokenService;

        public TokenController(ITokenService tokenService)
        {
            this.tokenService = tokenService;
        }


        [HttpPost("Login")]
        public BaseResponse<TokenResponse> Login([FromBody] TokenRequest request)
        {
            var response = tokenService.GenerateToken(request);
            return response;
        }


    }
}

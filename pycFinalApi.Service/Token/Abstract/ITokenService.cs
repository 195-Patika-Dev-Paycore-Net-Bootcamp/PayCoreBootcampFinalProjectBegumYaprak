using pycFinalApi.Base;

namespace pycFinalApi.Service
{
    public interface ITokenService
    {
        BaseResponse<TokenResponse> GenerateToken(TokenRequest tokenRequest);
    }
}

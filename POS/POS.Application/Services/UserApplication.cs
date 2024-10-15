using POS.Application.Commons.Bases;
using POS.Application.Dtos.User.Request;
using POS.Application.Interfases;

namespace POS.Application.Services
{
    public class UserApplication : IUserApplication
    {
        public Task<BaseResponse<string>> GenerateToken(TokenRequestDto requestDto)
        {

        }

        public Task<BaseResponse<bool>> RegisterUser(UserRequestDto requestDto)
        {

        }
    }
}

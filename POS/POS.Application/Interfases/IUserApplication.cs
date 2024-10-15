using POS.Application.Commons.Bases;
using POS.Application.Dtos.User.Request;

namespace POS.Application.Interfases
{
    public interface IUserApplication
    {
        Task<BaseResponse<bool>> RegisterUser(UserRequestDto requestDto);
        Task<BaseResponse<string>> GenerateToken(TokenRequestDto requestDto);

    }
}

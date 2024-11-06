
namespace ApiService.Model.DTO.Response
{
    public class RegisterUser : ResponseBase<UserInfoResponse>
    {
    }

    public class UserInfoResponse
    {
        public required string UserEmail { get; set; }
    }
}
using CLASSEM_MVC_PRO.Models.DTOs.UserDTOs;

namespace CLASSEM_MVC_PRO.Services.Interfaces
{
    public interface IUserService
    {
        CreateUserRequestModel Create(CreateUserRequestModel user);
        UserResponseModel Login(LoginRequestModel user);
        void Delete(string customerId);
        UserResponseModel GetById(string customerId);
        UpdateUserPasswordRequestModel UpdatePassword(UpdateUserPasswordRequestModel user);
    }
}
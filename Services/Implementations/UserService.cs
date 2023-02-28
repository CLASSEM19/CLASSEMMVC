using CLASSEM_MVC_PRO.Models.DTOs.UserDTOs;
using CLASSEM_MVC_PRO.Models.Entities;
using CLASSEM_MVC_PRO.Repositorises.Interfaces;
using CLASSEM_MVC_PRO.Services.Interfaces;

namespace CLASSEM_MVC_PRO.Services.Implementations
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _user;
        public UserService(IUserRepository user)
        {
            _user = user;
        }
        public CreateUserRequestModel Create(CreateUserRequestModel user)
        {
            var userr = new User
            {
                Password = user.Password,
                Email = user.Email,
                Created = DateTime.Now,
            };
            _user.Create(userr);
            return user;
        }

        public void Delete(string customerId)
        {
            var user = _user.GetById(customerId);
            _user.Delete(user);
        }

        public UserResponseModel GetById(string customerId)
        {
            var user = _user.GetById(customerId);
            var use = new UserResponseModel
            {
                Message = "User Successfully Retrieved",
                Status = true,
                Data = new UserDTOs
                {
                    Password = user.Password,
                    Email = user.Email,
                }
            };
            return use;
        }

        public UserResponseModel Login(LoginRequestModel user)
        {
            var userr = _user.Login(user.Email, user.Password);
            if (user != null)
            {
                var userResponseModel = new UserResponseModel
                {
                    Message = "Successful",
                    Status = true,
                    Data = new UserDTOs
                    {
                        Email = user.Email,
                        Password = user.Password,
                    }
                };
                return userResponseModel;
            }
            return null;
        }
        public UpdateUserPasswordRequestModel UpdatePassword(UpdateUserPasswordRequestModel user)
        {
            var use = _user.GetById(user.Email);
            use.Password = user.Password ?? use.Password;
            return user;
        }
    }
}
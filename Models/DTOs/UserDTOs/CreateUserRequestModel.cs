using System.ComponentModel.DataAnnotations;
using CLASSEM_MVC_PRO.Enums;

namespace CLASSEM_MVC_PRO.Models.DTOs.UserDTOs
{
    public class CreateUserRequestModel
    {
        [Required]
        public string Email {get;set;}
        [Required]
        public string Password {get;set;}
        public UserRoleType Role {get;set;}
    }
}   
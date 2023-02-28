using System.ComponentModel.DataAnnotations;

namespace CLASSEM_MVC_PRO.Models.DTOs.UserDTOs
{
    public class LoginRequestModel
    {
        [Required]
        public string Email{get;set;}
        [Required]
        public string Password{get;set;}
    }
}
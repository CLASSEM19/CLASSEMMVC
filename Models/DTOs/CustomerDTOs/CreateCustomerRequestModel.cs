using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using CLASSEM_MVC_PRO.Enums;

namespace CLASSEM_MVC_PRO.Models.DTOs.CustomerDTOs
{
    public class CreateCustomerRequestModel
    {
        [Required(ErrorMessage ="Name sholu valid")]
        public string FirstName{get;set;}
        public string LastName{get;set;}
        [Required]
        public string PhoneNumber{get;set;}
        [DisplayName("Email")]
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email{get;set;}
        [Required(ErrorMessage = "Enter Valid password")]
        [DisplayName("Password")]
        public string Password{get;set;}
        public string Address{get;set;}
        public DateTime DateOfBirth{get;set;}
        public GenderType Gender{get;set;}
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using CLASSEM_MVC_PRO.Enums;

namespace CLASSEM_MVC_PRO.Models.DTOs.CustomerDTOs
{
    public class CustomerDTOs
    {
        [DisplayName("First Name")]
        public string FirstName{get;set;}
        [DisplayName("Last Name")]
        public string LastName{get;set;}
        [Required]
        public string UserId{get;set;}
        [Required]
        public string Email{get;set;}
        public string Password{get;set;}
        [DisplayName("Email")]
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string PhoneNumber{get;set;}
        [DisplayName("Address")]
        public string Address{get;set;}
        public double Balance{get;set;}
        public bool IsActive{get;set;}
        public bool IsDelete{get;set;}
        public DateTime DateOfBirth{get;set;}
        public GenderType Gender{get;set;}
        public UserRoleType UserRole{get;set;}
    }
}
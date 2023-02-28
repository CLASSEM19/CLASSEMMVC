using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CLASSEM_MVC_PRO.Enums;

namespace CLASSEM_MVC_PRO.Models.Entities
{
    public class Customer : BaseEntity
    {
        public User User{get;set;}
        [ForeignKey("User")]
        public string UserEmail{get;set;}
        public string FirstName{get;set;}
        public string LastName{get;set;}
        [Required]
        [Key]
        public string CustomerId{get;set;}
        [Required]
        public string PhoneNumber{get;set;}
        public double Balance{get;set;}
        public string Address{get;set;}
        public bool IsActive{get;set;}
        public DateTime DateOfBirth{get;set;}
        public GenderType Gender{get;set;}
        public UserRoleType UserRole{get;set;}
        public List<Transaction> Transactions{get;set;}
        // public List<Product> Products{get;set;}
    }
}
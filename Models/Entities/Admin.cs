using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CLASSEM_MVC_PRO.Enums;
using Microsoft.EntityFrameworkCore;

namespace CLASSEM_MVC_PRO.Models.Entities
{
    [Index(nameof(PhoneNumber), IsUnique = true)]
    public class Admin
    {
        public User User{get;set;}
        [ForeignKey("User")]
        public string UserEmail{get;set;}
        public string FirstName{get;set;}
        public string LastName{get;set;}
        [Key]
        public string AdminId{get;set;}
        [Required]
        public string PhoneNumber{get;set;}
        public string Address{get;set;}
        public ActiveStatus IsActive{get;set;}
        public DateTime DateOfBirth{get;set;}
        public double Balance{get;set;}
        public UserRoleType UserRole{get;set;}
        public GenderType Gender{get;set;}
        public List<Transaction> Transactions{get;set;}

    }
}
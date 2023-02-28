using System.ComponentModel.DataAnnotations;
using CLASSEM_MVC_PRO.Enums;

namespace CLASSEM_MVC_PRO.Models.Entities
{
    public class User : BaseEntity
    {
        [Required]
        [Key]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        public double Balance { get; set; }
        public UserRoleType Role { get; set; }
        public string UserId { get; set; }
        public Customer Customer { get; set; }
        public Admin Admin { get; set; }

        public static string GenerateId(string generateId)
        {
            var alphabet = "abcdefghijklmnopqrstuvwxyz".ToUpper();
            var r1 = new Random().Next(25);
            var r2 = new Random().Next(25);
            var userId = $"{generateId}{alphabet[r1]}{alphabet[r2]}" + new Random().Next(1100000);
            return userId;
        }
    }
}
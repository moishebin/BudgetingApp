using System.ComponentModel.DataAnnotations;

namespace BudgetingApp.Models
{
    public class Users
    {
        [Key]
        public int UserID { get; set; }
        [Required]
        [MaxLength(50)]
        public string Username { get; set; }
        [Required]
        [MinLength(4), MaxLength(16)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        
    }
}

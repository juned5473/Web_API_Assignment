using System.ComponentModel.DataAnnotations;

namespace Web_API_Assignment.Models
{
    public class LoginInfo
    {
        [Required]
        [Key]
        public string? Email { get; set; }
       
        [Required]
        public string? Password { get; set; }

    }
}

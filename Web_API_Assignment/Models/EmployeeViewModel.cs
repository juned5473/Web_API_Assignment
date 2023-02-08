using System.ComponentModel.DataAnnotations;

namespace Web_API_Assignment.Models
{
    public class EmployeeViewModel
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; } = String.Empty;
        public string LastName { get; set; } = String.Empty;
        public string City { get; set; } = String.Empty;


        [Required(ErrorMessage = "Please enter your Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; } = String.Empty;

        [Required(ErrorMessage = "Please enter your Password")]
        [DataType(DataType.Password)]
        [MaxLength(15, ErrorMessage = "Password cannot be greater than 15 characters")]
        [MinLength(6, ErrorMessage = "Password cannot be less than 6 characters")]
        public string Password { get; set; } = String.Empty;
    }
}

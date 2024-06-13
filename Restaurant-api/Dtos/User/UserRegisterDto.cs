using System.ComponentModel.DataAnnotations;

namespace Restaurant_api.Dtos.User
{
    public class UserRegisterDto
    {
        public string fullName { get; set; }
        [Required]
        [EmailAddress]
       public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d).{8,}$", ErrorMessage = "Password must contain at least one uppercase letter, one lowercase letter, one digit, and be at least 8 characters long.")]
        public string Password { get; set; }


        [Required]
        [DataType(DataType.Password)]
        public string confirmPassword { get; set; } 

        public UserRegisterDto(string email, string password, string fullname, string confirmpassword)
        {
            Email = email;
            Password = password;
            fullName = fullname;
            confirmPassword = confirmpassword;
        }
    }
}

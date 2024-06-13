using System.ComponentModel.DataAnnotations;

namespace Restaurant_api.Dtos.User
{
    public class UserLoginDto
    {
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        public string Password { get; set; } = string.Empty;
    }
}

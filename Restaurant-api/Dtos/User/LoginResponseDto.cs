namespace Restaurant_api.Dtos.User
{
    public class LoginResponseDto(string token, string fullName)
    {
        public string Token { get; set; } = token;
        public string FullName { get; set; } = fullName;
    }
}

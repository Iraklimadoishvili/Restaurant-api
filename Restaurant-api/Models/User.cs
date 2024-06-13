using System.ComponentModel.DataAnnotations;

namespace Restaurant_api.Models
{
    public class User
    {


        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Username { get;set; } =string.Empty;

        [Required]
        [StringLength(50)]
        [EmailAddress]
        public string Email {  get; set; }  =string.Empty;

        public Byte [] PasswordHash {  get; set; }   

        public Byte[] PasswordSalt { get; set; }

 

        public User()
        {
      
        }
        public User(int id, string username, byte[] passwordHash, byte[] passwordSalt)
        {
            Id = id;
            Username = username;
            PasswordHash = passwordHash;
            PasswordSalt = passwordSalt;
          
        }
    }
}

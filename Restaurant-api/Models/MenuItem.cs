using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Restaurant_api.Models
{
    public class MenuItem
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }

        [Required]
        public string PhotoUrl { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        [Required]
        public string Category { get; set; }

        [Required]
        public List<string> DietaryRestrictions { get; set; }
        public MenuItem()
        {
            
        }


        public MenuItem(int id, string name, string description, string photoUrl, decimal price,string category, List<string> dietaryRestrictions)
        {
            Id = id;
            Name = name;
            Description = description;
            PhotoUrl = photoUrl;
            Price = price;
            Category = category;
            DietaryRestrictions = dietaryRestrictions;
        }   
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Restaurant_api.Models
{
    public class CartItem
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        [Required]
        public string PhotoUrl {  get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price {  get; set; }

        [Required]
        public int Quantity {  get; set; }  

        public decimal TotalPrice => Price * Quantity;
  

        public CartItem()
        {
            
        }

        public CartItem(int id, string name, string photoUrl, decimal price, int quantity)
        {
            Id = id;
            Name = name;
            PhotoUrl = photoUrl;
            Price = price;
            Quantity = quantity;
        
        }
    }
}

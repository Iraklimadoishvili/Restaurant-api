using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Restaurant_api.Data;
using Restaurant_api.Models;

namespace Restaurant_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly RestaurantDbContext _context;

        public CartController(RestaurantDbContext context)
        {
            _context = context;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<CartItem>>> GetCartItem()
        {
            return await _context.CartItems.ToListAsync();
        }


        [HttpPost]
        public async Task<ActionResult<CartItem>> AddToCart(CartItem item)
        {
        

            var existingItem = await _context.CartItems
                .FirstOrDefaultAsync(i =>i.Id ==item.Id);

            if (existingItem != null)
            {
                existingItem.Quantity += item.Quantity;
            }
            else
            {
                _context.CartItems.Add(item);
            }

            await _context.SaveChangesAsync();
            return Ok(item);
        }


        [HttpPut("{id}")]
        public async Task<IActionResult>UpdateCartItem(int id,CartItem item)
        {
            if(id != item.Id)
            {
                return BadRequest();
            }
            _context.Entry(item).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                if(!_context.CartItems.Any(e => e.Id ==id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return NoContent(); 
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult>RemoveCartItem(int id)
        {
            var item = await _context.CartItems.FindAsync(id);

            if(item == null)
            {
                return NotFound();
            }

            _context.CartItems.Remove(item);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("clear")]
        public async Task<IActionResult> ClearCart()
        {
            var cartItems = await _context.CartItems.ToListAsync();
            _context.CartItems.RemoveRange(cartItems);
            await _context.SaveChangesAsync();
            return NoContent(); 
        }
    }
}

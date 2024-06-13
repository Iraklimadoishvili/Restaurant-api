using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Restaurant_api.Data;
using Restaurant_api.Models;
using System.IO;
using System;

namespace Restaurant_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuController : ControllerBase
    {
       private readonly RestaurantDbContext _context;

        public MenuController(RestaurantDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<MenuItem>>> GetMenuItems()
        {
            var menuItems = await _context.MenuItems.ToListAsync();

            // Constructs the base URL for the current HTTP request, incorporating the scheme (e.g., HTTP or HTTPS) and host (e.g., domain name or IP address).
            var baseUrl = $"{Request.Scheme}://{Request.Host}";

            foreach (var item in menuItems)
            {
                // Modifies the PhotoUrl property of each menu item to include the base URL and the relative path to the image file.
                // Path.GetFileName() extracts the file name from the full path of the image URL.
                item.PhotoUrl = $"{baseUrl}/Images/{Path.GetFileName(item.PhotoUrl)}";
            }


            return menuItems;
        }

        //getting menu items by id
        [HttpGet("{id}")]
        public async Task<ActionResult<MenuItem>> GetMenuItem(int id)
        {
            var menuItem = await _context.MenuItems.FindAsync(id);

            if (menuItem == null)
            {
                return NotFound();
            }
            var baseUrl = $"{Request.Scheme}://{Request.Host}";
            menuItem.PhotoUrl = $"{baseUrl}/Images/{Path.GetFileName(menuItem.PhotoUrl)}";

            return menuItem;
        }

        //updating menu items by id
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMenuItem (int id,MenuItem item)
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
            catch (DbUpdateConcurrencyException)
            {
                if (!MenuItemExists(id))
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

        private bool MenuItemExists(int id) { 
           return _context.MenuItems.Any(e => e.Id == id);  
        }





        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMenuItem(int id)
        {
            var menuItem = await _context.MenuItems.FindAsync(id);
            if (menuItem == null)
            {
                return NotFound();
            }

            _context.MenuItems.Remove(menuItem);
            
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}

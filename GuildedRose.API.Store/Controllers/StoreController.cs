using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GuildedRose.API.Store.Models;
using GuildedRose.API.Store.Interfaces;

namespace GuildedRose.API.Store.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoreController : ControllerBase
    {
        private readonly IStoreRepository _context;

        public StoreController(IStoreRepository context)
        {
            _context = context;
        }

        // GET: api/Store
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StoreItem>>> GetItems()
        {
            return await _context.GetItems();
        }

        // GET: api/Store/5
        [HttpGet("{id}")]
        public async Task<ActionResult<StoreItem>> GetStoreItem(string id)
        {
            var storeItem = await _context.GetStoreItem(id);

            if (storeItem == null)
            {
                return NotFound();
            }

            return storeItem;
        }

        // PUT: api/Store/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStoreItem(string id, StoreItem storeItem)
        {

            // ***************************
            // Should be protected by AUTH
            // ***************************
            //if (id != storeItem.Id)
            //{
            //    return BadRequest();
            //}

            //_context.Entry(storeItem).State = EntityState.Modified;

            //try
            //{
            //    await _context.SaveChangesAsync();
            //}
            //catch (DbUpdateConcurrencyException)
            //{
            //    if (!StoreItemExists(id))
            //    {
            //        return NotFound();
            //    }
            //    else
            //    {
            //        throw;
            //    }
            //}

            // Users should not be able to update the Store db, unless authorized
            return NoContent();
        }

        // POST: api/Store
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<StoreItem>> PostStoreItem(StoreItem storeItem)
        {
            // ***************************
            // Should be protected by AUTH
            // ***************************
            // _context.Items.Add(storeItem);
            // await _context.SaveChangesAsync();

            // return CreatedAtAction(nameof(GetStoreItem), new { id = storeItem.Id }, storeItem);
            return NoContent();
        }

        // DELETE: api/Store/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStoreItem(Guid id)
        {

            // ***************************
            // Should be protected by AUTH
            // ***************************
            //var storeItem = await _context.Items.FindAsync(id);
            //if (storeItem == null)
            //{
            //    return NotFound();
            //}

            //_context.Items.Remove(storeItem);
            //await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}

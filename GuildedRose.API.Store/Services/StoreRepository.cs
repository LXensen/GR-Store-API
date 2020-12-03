using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GuildedRose.API.Store.Interfaces;
using GuildedRose.API.Store.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace GuildedRose.API.Store.Services
{
    public class StoreRepository : IStoreRepository
    {
        private readonly StoreItemContext _context;

        public StoreRepository(StoreItemContext context)
        {
            _context = context;

            if (_context.Items.Any()) return;

            StoreItemSeed.InitializeData(context);
        }

        public async Task<ActionResult<IEnumerable<StoreItem>>> GetItems()
        {
            var storeitems =  await _context.Items.ToListAsync();

            return storeitems;

        }

        public async  Task<ActionResult<StoreItem>> GetStoreItem(string id)
        {
            return await _context.Items.FindAsync(id);
        }
    }
}

using Microsoft.EntityFrameworkCore;

namespace GuildedRose.API.Store.Models
{
    public class StoreItemContext : DbContext
    {
        public StoreItemContext(DbContextOptions<StoreItemContext> options) : base(options)
        {
        }

        public DbSet<StoreItem> Items { get; set; }

    }
}

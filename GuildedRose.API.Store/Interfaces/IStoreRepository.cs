using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GuildedRose.API.Store.Models;
using System.Collections.Generic;


namespace GuildedRose.API.Store.Interfaces
{
    public interface IStoreRepository
    {
        Task<ActionResult<IEnumerable<StoreItem>>> GetItems();

        Task<ActionResult<StoreItem>> GetStoreItem(string id);
    }
}

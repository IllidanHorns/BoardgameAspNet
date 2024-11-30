using BoardgameShopASPNET.Models;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using BoardgameShop.WEBUI.Models.DbEntities;

namespace BoardgameShop.WEBUI.Repositories
{
    public class AccountRepository (AppDbContext appDbContext)
    {
        public void Add(AccountUser account) 
        {
            appDbContext.Add<AccountUser>(account);
        }

        public AccountUser? GetAccountById(int id) 
        {
            return appDbContext.Find<AccountUser>(id);
        }
    }
}

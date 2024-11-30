using BoardgameShop.WEBUI.Models.DbEntities.Interfaces;

namespace BoardgameShop.WEBUI.Models.DbEntities.Classes
{
    public class RoleAccount : BaseModel
    {
        public int Id { get; set; }
        public string RoleName { get; set; }
        public virtual ICollection<AccountUser> AccountUsers { get; set; } = new List<AccountUser>();
    }
}

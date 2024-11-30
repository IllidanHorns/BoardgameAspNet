using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using BoardgameShop.WEBUI.Models.DbEntities.Classes;
using BoardgameShop.WEBUI.Models.DbEntities.Interfaces;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace BoardgameShop.WEBUI.Models.DbEntities;

public partial class AccountUser : BaseModel
{
    public int Id { get; set; }

    public string Login { get; set; } = null!;

    public string Password { get; set; } = null!;

    public int RoleAccount_ID { get; set; }

    public virtual RoleAccount RoleAccount { get; set; }

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}

using BoardgameShop.WEBUI.Models.DbEntities.Interfaces;
using System;
using System.Collections.Generic;

namespace BoardgameShop.WEBUI.Models.DbEntities.Classes;

public partial class Admin : BaseModel
{
    public int Id { get; set; }

    public string Login { get; set; } = null!;

    public string Password { get; set; } = null!;
}

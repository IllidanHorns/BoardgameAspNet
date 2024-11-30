using BoardgameShop.WEBUI.Models.DbEntities.Interfaces;
using System;
using System.Collections.Generic;

namespace BoardgameShop.WEBUI.Models.DbEntities.Classes;

public partial class CartPhoto : BaseModel
{
    public int Id { get; set; }

    public int ProductId { get; set; }

    public int PhotoId { get; set; }

    public virtual Photo Photo { get; set; } = null!;

    public virtual Product Product { get; set; } = null!;
}

using System;
using System.Collections.Generic;

namespace BoardgameShopASPNET.Models;

public partial class CartPhoto
{
    public int IdCartPhoto { get; set; }

    public int ProductId { get; set; }

    public int PhotoId { get; set; }

    public virtual Photo Photo { get; set; } = null!;

    public virtual Product Product { get; set; } = null!;
}

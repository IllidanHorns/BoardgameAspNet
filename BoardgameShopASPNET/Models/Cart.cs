using System;
using System.Collections.Generic;

namespace BoardgameShopASPNET.Models;

public partial class Cart
{
    public int IdCart { get; set; }

    public int UserId { get; set; }

    public int ProductId { get; set; }

    public virtual Product Product { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}

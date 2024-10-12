using System;
using System.Collections.Generic;

namespace BoardgameShopASPNET.Models;

public partial class ProductAttribute
{
    public int IdAttribute { get; set; }

    public int? ProductId { get; set; }

    public int? ValueAttributeId { get; set; }

    public virtual Product? Product { get; set; }

    public virtual AttributeValue? ValueAttribute { get; set; }
}

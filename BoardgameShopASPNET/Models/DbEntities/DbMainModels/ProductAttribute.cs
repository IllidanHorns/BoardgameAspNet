using BoardgameShop.WEBUI.Models.DbEntities.Interfaces;
using System;
using System.Collections.Generic;

namespace BoardgameShop.WEBUI.Models.DbEntities.Classes;

public partial class ProductAttribute : BaseModel
{
    public int Id { get; set; }

    public int? ProductId { get; set; }

    public int? ValueAttributeId { get; set; }

    public virtual Product? Product { get; set; }

    public virtual AttributeValue? ValueAttribute { get; set; }
}

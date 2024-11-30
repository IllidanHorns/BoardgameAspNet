using BoardgameShop.WEBUI.Models.DbEntities.Interfaces;
using System;
using System.Collections.Generic;

namespace BoardgameShop.WEBUI.Models.DbEntities.Classes;

public partial class AttributeValue : BaseModel
{
    public int Id { get; set; }

    public int? AttributeTypeId { get; set; }

    public string Value { get; set; } = null!;

    public virtual AttributeType? AttributeType { get; set; }

    public virtual ICollection<ProductAttribute> ProductAttributes { get; set; } = new List<ProductAttribute>();
}

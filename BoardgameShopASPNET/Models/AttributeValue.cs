using System;
using System.Collections.Generic;

namespace BoardgameShopASPNET.Models;

public partial class AttributeValue
{
    public int IdValueAttribure { get; set; }

    public int? AttributeTypeId { get; set; }

    public string Value { get; set; } = null!;

    public virtual AttributeType? AttributeType { get; set; }

    public virtual ICollection<ProductAttribute> ProductAttributes { get; set; } = new List<ProductAttribute>();
}

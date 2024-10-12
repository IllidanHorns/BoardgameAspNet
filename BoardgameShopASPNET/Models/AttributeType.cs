using System;
using System.Collections.Generic;

namespace BoardgameShopASPNET.Models;

public partial class AttributeType
{
    public int IdAttributeType { get; set; }

    public string AttributeTypeName { get; set; } = null!;

    public virtual ICollection<AttributeValue> AttributeValues { get; set; } = new List<AttributeValue>();
}

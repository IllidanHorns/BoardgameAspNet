using BoardgameShop.WEBUI.Models.DbEntities.Interfaces;
using System;
using System.Collections.Generic;

namespace BoardgameShop.WEBUI.Models.DbEntities.Classes;

public partial class AttributeType : BaseModel
{
    public int Id { get; set; }

    public string AttributeTypeName { get; set; } = null!;

    public virtual ICollection<AttributeValue> AttributeValues { get; set; } = new List<AttributeValue>();
}

using BoardgameShop.WEBUI.Models.DbEntities.Interfaces;
using System;
using System.Collections.Generic;

namespace BoardgameShop.WEBUI.Models.DbEntities.Classes;

public partial class Photo : BaseModel
{
    public int Id { get; set; }

    public string LinkValue { get; set; } = null!;

    public virtual ICollection<CartPhoto> CartPhotos { get; set; } = new List<CartPhoto>();
}

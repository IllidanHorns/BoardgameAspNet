using System;
using System.Collections.Generic;

namespace BoardgameShopASPNET.Models;

public partial class Photo
{
    public int IdPhoto { get; set; }

    public string LinkValue { get; set; } = null!;

    public virtual ICollection<CartPhoto> CartPhotos { get; set; } = new List<CartPhoto>();
}

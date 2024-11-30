using BoardgameShop.WEBUI.Models.DbEntities.Interfaces;
using System;
using System.Collections.Generic;

namespace BoardgameShop.WEBUI.Models.DbEntities.Classes;

public partial class Product : BaseModel
{
    public int Id { get; set; }

    public string ProductName { get; set; } = null!;

    public decimal Price { get; set; }

    public string? Description { get; set; }

    public decimal? Discount { get; set; }

    public long Quantity { get; set; }

    public int? CategoryId { get; set; }

    public virtual ICollection<CartPhoto> CartPhotos { get; set; } = new List<CartPhoto>();

    public virtual ICollection<Cart> Carts { get; set; } = new List<Cart>();

    public virtual ProductCategory? Category { get; set; }

    public virtual ICollection<Favorite> Favorites { get; set; } = new List<Favorite>();

    public virtual ICollection<ProductAttribute> ProductAttributes { get; set; } = new List<ProductAttribute>();
}

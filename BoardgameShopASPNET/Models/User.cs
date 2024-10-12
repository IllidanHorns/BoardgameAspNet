using System;
using System.Collections.Generic;

namespace BoardgameShopASPNET.Models;

public partial class User
{
    public int IdUser { get; set; }

    public string Surname { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string? MiddleName { get; set; }

    public string PhoneNumber { get; set; } = null!;

    public string Email { get; set; } = null!;

    public DateOnly? BirthDate { get; set; }

    public int? AccountId { get; set; }

    public virtual AccountUser? Account { get; set; }

    public virtual ICollection<Cart> Carts { get; set; } = new List<Cart>();

    public virtual ICollection<Favorite> Favorites { get; set; } = new List<Favorite>();
}

using System;
using System.Collections.Generic;

namespace BoardgameShopASPNET.Models;

public partial class AccountUser
{
    public int IdAccount { get; set; }

    public string Login { get; set; } = null!;

    public string Password { get; set; } = null!;

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}

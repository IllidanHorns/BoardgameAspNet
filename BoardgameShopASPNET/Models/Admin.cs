using System;
using System.Collections.Generic;

namespace BoardgameShopASPNET.Models;

public partial class Admin
{
    public int IdAdmin { get; set; }

    public string Login { get; set; } = null!;

    public string Password { get; set; } = null!;
}

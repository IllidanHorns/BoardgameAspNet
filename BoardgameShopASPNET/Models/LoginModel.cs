﻿using BoardgameShop.WEBUI.Models;
using System.ComponentModel.DataAnnotations;

namespace BoardgameShopASPNET.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Не указан пароль")]
        public string Login { get; set; } = null!;

        [Required(ErrorMessage = "Не указан пароль")]
        [DataType(DataType.Password)]
        public string Password { get; set; } = null!;
    }
}
 
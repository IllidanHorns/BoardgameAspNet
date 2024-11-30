using System.ComponentModel.DataAnnotations;

namespace BoardgameShop.WEBUI.Models.SideModels
{
    public class RegistrationViewModel
    {
        [Required(ErrorMessage = "Введите логин")]
        public string Login { get; set; } = null!;

        [Required(ErrorMessage = "Введите пароль")]
        [MinLength(6, ErrorMessage = "Пароль должен быть не менее 6 символов")]
        public string Password { get; set; } = null!;
    }
}

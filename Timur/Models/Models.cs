using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Timur.Models
{
    public class LoginModel
    {
        [Display(Name = "Логин")]
        [RegularExpression(@"^[a-z ]+$", ErrorMessage = "Логин может содержать только строчные буквы")]
        [Required(ErrorMessage = "Введите логин")]
        public string Name { get; set; }
        
        [Display(Name = "Пароль")]
        [RegularExpression(@"^[a-z0-9 ]+$", ErrorMessage = "Пароль может содержать только цифры и строчные буквы")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Введите пароль")]
        public string Password { get; set; }
    }
    public class RegisterModel
    {
        [Display(Name = "Придумайте логин")]
        [RegularExpression(@"^[a-z ]+$", ErrorMessage = "Логин может содержать только строчные буквы")]
        [Required(ErrorMessage ="Введите логин")]
        public string Name { get; set; }
        [Display(Name = "Придумайте пароль")]
        [RegularExpression(@"^[a-z0-9 ]+$", ErrorMessage = "Пароль может содержать только цифры и строчные буквы")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Введите пароль")]
        public string Password { get; set; }
    }
}
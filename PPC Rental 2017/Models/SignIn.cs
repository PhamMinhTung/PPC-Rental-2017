using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace PPC_Rental_2017.Models
{
    public class SignIn
    {
        [Display(Name = "usename")]
        [Required(ErrorMessage = "Vui lòng nhập email")]
        public string Email { set; get; }

        [Display(Name ="Password")]
        [StringLength (15, MinimumLength = 6, ErrorMessage = "Độ dài mật khẩu không hợp lệ")]
        [Required(ErrorMessage ="Vui lòng nhập mật khẩu")]
        public string Password { set; get; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DK_NVQS.ViewModel
{
    public class LoginVM
    {
        [Required(ErrorMessage = "Tên tài khoản trống.")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Mật khẩu trống.")]
        public string Password { get; set; }
    }
}
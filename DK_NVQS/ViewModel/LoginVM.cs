using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DK_NVQS.ViewModel
{
    public class LoginVM
    {
        [Required(ErrorMessage = "Không được để trống tên tài khoản.")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Không được để trống mật khẩu.")]
        public string Password { get; set; }
    }
}
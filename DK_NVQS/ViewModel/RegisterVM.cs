﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace DK_NVQS.ViewModel
{
    public class RegisterVM
    {
        [Required(ErrorMessage = "Tên tài khoản trống.")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Mật khẩu trống.")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Nhập lại mật khẩu.")]
        [Compare("Password", ErrorMessage = "Mật khẩu không trùng khớp")]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage = "Email trống.")]
        [EmailAddress(ErrorMessage = "Email không hợp lệ.")]
        public string Email { get; set; }
        public string CitizenID { get; set; }
        public string Name { get; set; }
        public Nullable<bool> Gender { get; set; }
        public Nullable<DateTime> DateOfBirth { get; set; }
        public string Address { get; set; }
        public string Hometown { get; set; }
    }
}
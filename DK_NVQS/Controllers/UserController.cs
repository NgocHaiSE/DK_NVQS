using DK_NVQS.Models;
using DK_NVQS.ViewModel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ZXing;

namespace DK_NVQS.Controllers
{
    public class UserController : Controller
    {
        NVQSDBContext db = new NVQSDBContext();

        public ActionResult Home()
        {
            return View();
        }

        public ActionResult Register()
        {
            var model = new QRVM
            {
                SuccessMessage = TempData["SuccessMessage"] as string,
                ErrorMessage = TempData["ErrorMessage"] as string
            };

            return View(model);
        }

        [HttpPost]
        public ActionResult Register(string citizenID, string fullName, string birthDate, string gender, string address)
        {
            if (string.IsNullOrEmpty(citizenID) || string.IsNullOrEmpty(fullName))
            {
                ModelState.AddModelError("", "Căn cước công dân và họ tên không được để trống");
                return View();
            }
            DateTime birthDateParsed;
            try
            {
                birthDateParsed = DateTime.ParseExact(birthDate, "ddMMyyyy", CultureInfo.InvariantCulture);
            }
            catch (System.FormatException)
            {
                ModelState.AddModelError("", "Invalid date format. Please use ddMMyyyy.");
                return View();
            }

            if (db.Citizens.Any(c => c.CitizenID == citizenID))
            {
                TempData["ErrorMessage"] = "Tài khoản với số Căn cước công dân này đã tồn tại trong cơ sở dữ liệu.";
                return RedirectToAction("Register");
            }

            var citizen = new Citizen();
            citizen.CitizenID = citizenID;
            citizen.Name = fullName;
            citizen.DateOfBirth = birthDateParsed;
            citizen.Gender = (gender == "Nam");
            citizen.Address = address;

            db.Citizens.Add(citizen);
            db.SaveChanges();

            TempData["SuccessMessage"] = "Đăng ký thành công!";
            return RedirectToAction("Register");
        }
    }
}

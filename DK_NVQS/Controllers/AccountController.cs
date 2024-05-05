using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DK_NVQS.Models;
using DK_NVQS.ViewModel;
using DK_NVQS.Identity;
using System.Web.Helpers;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;


namespace DK_NVQS.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(RegisterVM rvm)
        {
            if (ModelState.IsValid)
            {
                var appDbContext = new AppDbContext();
                var userStore = new AppUserStore(appDbContext);
                var userManager = new AppUserManager(userStore);
                var passwdHash = Crypto.HashPassword(rvm.Password);
                var user = new AppUser()
                {
                    Email = rvm.Email,
                    Name = rvm.Name,
                    UserName = rvm.UserName,
                    PasswordHash = passwdHash,
                    CitizenID = rvm.CitizenID,

                    //public string CitizenID { get; set; }
                    //public string Name { get; set; }
                    //public Nullable<bool> Gender { get; set; }
                    //public Nullable<DateTime> DateOfBirth { get; set; }
                    //public string Address { get; set; }
                    //public string Hometown { get; set; }

                };
                IdentityResult identityResult = userManager.Create(user);
                if (identityResult.Succeeded)
                {
                    userManager.AddToRole(user.Id, "Citizen");
                    var authenManager = HttpContext.GetOwinContext().Authentication;
                    var userIdentity = userManager.CreateIdentity(user,
                        DefaultAuthenticationTypes.ApplicationCookie);
                    authenManager.SignIn(new AuthenticationProperties(), userIdentity);
                }
            }
            else
            {
                ModelState.AddModelError("New Error", "Invalid data");
                return View();
            }
            return RedirectToAction("Index", "Home");
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(LoginVM lvm)
        {
            var appDbContext = new AppDbContext();
            var userStore = new AppUserStore(appDbContext);
            var userManager = new AppUserManager(userStore);
            var user = userManager.Find(lvm.UserName, lvm.Password);
            if (user != null)
            {
                var authenManager = HttpContext.GetOwinContext().Authentication;
                var userIdentity = userManager.CreateIdentity(user,
                        DefaultAuthenticationTypes.ApplicationCookie);
                authenManager.SignIn(new AuthenticationProperties(), userIdentity);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("myError", "Invalid username and password");
                return View();
            }
        }
    }

}
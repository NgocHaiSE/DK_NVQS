using DK_NVQS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DK_NVQS.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public NVQSDBContext db = new NVQSDBContext();
        public ActionResult ChangeStatus(int id, string newStatus)
        {
            var registration = db.Registrations.Find(id);
            if (registration != null)
            {
                registration.Status = newStatus;
                db.SaveChanges();
            }
            return RedirectToAction("RegisterList", "Registration");
        }
    }
}
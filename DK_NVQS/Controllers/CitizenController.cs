using DK_NVQS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DK_NVQS.Controllers
{
    public class CitizenController : Controller
    {
        NVQSDBContext db = new NVQSDBContext();

        public ActionResult CitizenList(string citizenID = null, string name = null, string gender = null, DateTime? dob = null,
            int? age = null, string hometown = null, string address = null, string status = null, string eligible = null, string ready = null)
        {
            var citizenList = db.Citizens.AsQueryable();
            if (!string.IsNullOrEmpty(citizenID))
            {
                citizenList = citizenList.Where(a => a.CitizenID == citizenID);
            }
            if (!string.IsNullOrEmpty(name))
            {
                citizenList = citizenList.Where(a => a.Name.ToLower().Contains(name.ToLower()));
            }
            if (!string.IsNullOrEmpty(gender))
            {
                if (gender == "Nam")
                    citizenList = citizenList.Where(c => c.Gender == true);
                else if (gender == "Nữ")
                    citizenList = citizenList.Where(c => c.Gender == false);
            }
            if (age.HasValue)
            {
                citizenList = citizenList.Where(c => c.Age == age.Value);
            }
            if (!string.IsNullOrEmpty(status))
            {
                citizenList = citizenList.Where(c => c.Status == status);
            }
            if (!string.IsNullOrEmpty(hometown))
            {
                citizenList = citizenList.Where(c => c.Hometown == hometown);
            }
            if (!string.IsNullOrEmpty(address))
            {
                citizenList = citizenList.Where(c => c.Address == address);
            }
            if (dob.HasValue)
            {
                citizenList = citizenList.Where(c => c.DateOfBirth == dob);
            }
            if (!string.IsNullOrEmpty(eligible))
            {
                if (eligible == "Đủ điều kiện")
                    citizenList = citizenList.Where(c => c.Eligible == true);
                else if (eligible == "Không đủ điều kiện")
                    citizenList = citizenList.Where(c => c.Eligible == false);
            }
            if (!string.IsNullOrEmpty(ready))
            {
                if (ready == "Sẵn sàng nhập ngũ")
                    citizenList = citizenList.Where(a => a.Ready == true);
                else if (ready == "Chưa sẵn sàng nhập ngũ")
                    citizenList = citizenList.Where(a => a.Ready == false);
            }

            return View(citizenList.ToList());
        }

        public ActionResult Edit(string citizenID, Citizen updated = null)
        {
            if (Request.HttpMethod == "POST")
            {
                if (ModelState.IsValid)
                {
                    db.Entry(updated).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Citizenlist");
                }
                return View(updated);
            }

            Citizen congDan = db.Citizens.Find(citizenID);
            if (congDan == null)
            {
                return HttpNotFound();
            }

            return View(congDan);
        }

        public ActionResult Delete(string citizenID)
        {
            Citizen congDan = db.Citizens.Find(citizenID);
            if (congDan == null)
            {
                return HttpNotFound();
            }
            return View(congDan);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(string citizenID)
        {
            Citizen congDan = db.Citizens.Find(citizenID);
            if (congDan == null)
            {
                return HttpNotFound();
            }

            db.Citizens.Remove(congDan);
            db.SaveChanges();
            return RedirectToAction("Citizenlist");
        }

        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Citizen newCitizen)
        {
            if (ModelState.IsValid)
            {
                db.Citizens.Add(newCitizen);
                db.SaveChanges();
                return RedirectToAction("Citizenlist");
            }
            return View(newCitizen);
        }
    }
}
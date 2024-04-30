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
        // GET: Citizen
        public ActionResult CitizenList()
        {
            List<Citizen> citizenList = db.Citizens.ToList();
            return View(citizenList);
        }
        
        [HttpPost]
        public ActionResult CitizenList(string citizenID, string name, string gender, DateTime? dob, 
            int? age, string hometown, string address, string status, string eligible, string ready)
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
                if(eligible == "Đủ điều kiện")
                    citizenList = citizenList.Where(c => c.Eligible == true);
                else if (eligible == "Không đủ điều kiện")
                    citizenList = citizenList.Where(c => c.Eligible == false);
            }
            if (!string.IsNullOrEmpty(ready))
            {
                if(ready == "Sẵn sàng nhập ngũ")
                    citizenList = citizenList.Where(a => a.Ready == true);
                else if (ready == "Chưa sẵn sàng nhập ngũ")
                    citizenList = citizenList.Where(a => a.Ready == false);
            }

            return View(citizenList.ToList());
        }
    }
}
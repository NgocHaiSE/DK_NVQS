using DK_NVQS.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DK_NVQS.Controllers
{
    public class RegistrationController : Controller
    {
        NVQSDBContext db = new NVQSDBContext();
        // GET: RegistrationForm
        public ActionResult RegisterList()
        {
            List<Registration> registrationForms = db.Registrations.ToList();
            return View(registrationForms);

        }

        [HttpPost]
        public ActionResult RegisterList(string citizenID, string name, int? numberOfRegister,
            string year, string status)
        {
            var registerList = db.Registrations.AsQueryable();

            if (!string.IsNullOrWhiteSpace(citizenID))
            {
                registerList = registerList.Where(b => b.Citizen.CitizenID == citizenID);
            }

            if (!string.IsNullOrWhiteSpace(name))
            {
                registerList = registerList.Where(b => b.Citizen.Name.ToLower().Contains(name.ToLower()));
            }

            if (!string.IsNullOrWhiteSpace(year))
            {
                registerList = registerList.Where(b => b.Date.ToString("yyyy") == year);
            }

            if (!string.IsNullOrWhiteSpace(status))
            {
                registerList = registerList.Where(b => b.Status.ToLower() == status.ToLower());
            }

            if(numberOfRegister.HasValue)
            {
                registerList = registerList.Where(b => b.NumberOfRegisters ==  numberOfRegister.Value);
            }

            return View(registerList.ToList());
        }
    }
}
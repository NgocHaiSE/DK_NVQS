using DK_NVQS.Models;
using DK_NVQS.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DK_NVQS.Controllers
{
    public class HealthRecordController : Controller
    {
        NVQSDBContext db = new NVQSDBContext();
        // GET: HealthRecord
        public ActionResult Detail(int id)
        {
            var healthRecord = db.HealthRecords.FirstOrDefault(a => a.RecordID == id);
            if (healthRecord == null)
            {
                return HttpNotFound("Không tìm thấy hồ sơ!");
            }
            return View(healthRecord);
        }

        public ActionResult List(string citizenID, int? year, bool? isSubclinical, bool? isClinical)
        {
            var query = db.HealthRecords
                          .Include("Citizen")
                          .Include("Subclinicals")
                          .Include("Clinicals")
                          .AsQueryable();
            if (!string.IsNullOrEmpty(citizenID))
            {
                query = query.Where(hr => hr.Citizen.CitizenID == citizenID);
            }
            if (year.HasValue)
            {
                query = query.Where(hr => hr.Date.Year == year.Value);
            }
            if (isSubclinical.HasValue)
            {
                query = query.Where(hr => hr.Subclinicals.Any() == isSubclinical.Value);
            }
            if (isClinical.HasValue)
            {
                query = query.Where(hr => hr.Clinicals.Any() == isClinical.Value);
            }
            var list = query.ToList();
            var viewModel = new HealthRecordListVM
            {
                CitizenID = citizenID,
                Year = year,
                IsSubclinical = isSubclinical,
                IsClinical = isClinical,
                HealthRecords = list
            };

            return View(viewModel);
        }
    }
}
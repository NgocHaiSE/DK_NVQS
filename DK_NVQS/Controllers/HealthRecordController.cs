using DK_NVQS.Models;
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
                return HttpNotFound("Không tìm thấy hồ sơ khám bệnh!");
            }
            return View(healthRecord);
        }

    }
}
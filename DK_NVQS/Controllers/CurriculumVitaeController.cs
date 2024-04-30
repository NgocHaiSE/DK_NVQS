using DK_NVQS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DK_NVQS.Controllers
{
    public class CurriculumVitaeController : Controller
    {
        NVQSDBContext db = new NVQSDBContext();
        public ActionResult List()
        {
            var list = db.CurriculumVitaes.ToList();
            return View(list);
        }

        public ActionResult Detail(int id)
        {
            var curriculumVitae = db.CurriculumVitaes.FirstOrDefault(a => a.QurriculumVitaeID == id);
            if(curriculumVitae == null)
            {
                return HttpNotFound("Không tìm thấy bản sơ yếu lý lịch!");
            }
            return View(curriculumVitae);
        }
    }
}
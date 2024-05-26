using DK_NVQS.Models;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace DK_NVQS.Controllers
{
    public class SubClinicalController : Controller
    {
        NVQSDBContext db = new NVQSDBContext();
        public ActionResult Detail(int RecordID)
        {
            var subclinical = db.Subclinicals
                                 .Include(c => c.BloodTest)
                                 .Include(c => c.BiochemicalTest)
                                 .Include(c => c.ImmunologicalTest)
                                 .Include(c => c.UrineTest)
                                 .FirstOrDefault(a => a.RecordID == RecordID);

            if (subclinical == null)
            {
                return HttpNotFound();
            }

            return View(subclinical);
        }
    }
}
using DK_NVQS.Models;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace DK_NVQS.Controllers
{
    public class ClinicalController : Controller
    {
        NVQSDBContext db = new NVQSDBContext();

        public ActionResult Detail(int RecordID)
        {
            Clinical clinical = db.Clinicals
                                  .Include(c => c.PhysicalStrength)
                                  .Include(c => c.Eyes)
                                  .Include(c => c.ENT)
                                  .Include(c => c.DentalOral)
                                  .Include(c => c.InternalMedicine)
                                  .Include(c => c.Neurology)
                                  .Include(c => c.Surgery)
                                  .Include(c => c.Dermatology)
                                  .FirstOrDefault(a => a.RecordID == RecordID);

            return View(clinical);
        }
    }
}

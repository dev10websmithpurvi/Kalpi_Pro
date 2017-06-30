using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using BAL = WS.Framework.Logic;
using COM = WS.Framework.Common;
using ENT = WS.Framework.Entity;

namespace KALPI.Controllers
{
    public class VisitMasterController : Controller
    {
        // GET: VisitMaster
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public JsonResult Get_GetAll(string id)
        {
            return Json(new BAL.VisitMaster().VisitMaster_Get_GetAll(Guid.Parse(id)), JsonRequestBehavior.AllowGet);
        }

    }
}
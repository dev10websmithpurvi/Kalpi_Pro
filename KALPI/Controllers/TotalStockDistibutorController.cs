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
    [Authorize]
    public class TotalStockDistibutorController : Controller
    {
        // GET: TotalStockDistibutor
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult GetAll(string id)
        {
            return Json(new BAL.TotalStockDistibutor().TotalStockDistibutor_GetAll(), JsonRequestBehavior.AllowGet);
        }
    }
}
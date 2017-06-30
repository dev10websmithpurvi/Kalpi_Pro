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
    public class TotalStockSuperStockistController : Controller
    {
        // GET: TotalStockSuperStockist
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult GetAll(string id)
        {
            return Json(new BAL.TotalStockSuperStockist().TotalStockSuperStockist_GetAll(), JsonRequestBehavior.AllowGet);
        }
    }
}
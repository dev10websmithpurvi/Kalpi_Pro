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
    public class SalesStockSuperStockistController : Controller
    {
        // GET: SalesStockSuperStockist
        public ActionResult Index()
        {
            ViewBag.ProductList = new BAL.ProductMaster().ProductMaster_Get_GetAll(Guid.Parse("00000000-0000-0000-0000-000000000000"));
            ViewBag.SuperstockistList = new BAL.SuperStockIsMaster().SuperStockIsMaster_Get_GetAll(Guid.Parse("00000000-0000-0000-0000-000000000000"));
            return View();
        }

        [HttpPost]
        public JsonResult GetAll()
        {
            return Json(new BAL.SalesStockSuperStockist().SalesStockSuperStockist_GetAll(), JsonRequestBehavior.AllowGet);
        }
    }
}
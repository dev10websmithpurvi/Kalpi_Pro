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
    public class SalesStockDistibutorController : Controller
    {
        // GET: SalesStockDistibutor
        public ActionResult Index()
        {
            ViewBag.ProductList = new BAL.ProductMaster().ProductMaster_Get_GetAll(Guid.Parse("00000000-0000-0000-0000-000000000000"));
            ViewBag.Superstockist = new BAL.SuperStockIsMaster().SuperStockIsMaster_Get_GetAll(Guid.Parse("00000000-0000-0000-0000-000000000000"));
            return View();
        }

        [HttpPost]
        public JsonResult GetAll()
        {
            return Json(new BAL.SalesStockDistibutor().SalesStockDistibutor_GetAll(), JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult GetAllDistibutor_BySuperID(string id)
        {
            return Json(new BAL.DistributorMaster().DistributorMaster_GetAll_BySuperstockistID(Guid.Parse(id)), JsonRequestBehavior.AllowGet);
        }
    }
}
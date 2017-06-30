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
    public class PurchaseStockDistibutorController : Controller
    {
        // GET: PurchaseStockDistibutor
        public ActionResult Index()
        {
            ViewBag.ProductList = new BAL.ProductMaster().ProductMaster_Get_GetAll(Guid.Parse("00000000-0000-0000-0000-000000000000"));
            ViewBag.SuperstockistList = new BAL.SuperStockIsMaster().SuperStockIsMaster_Get_GetAll(Guid.Parse("00000000-0000-0000-0000-000000000000"));
            return View();
        }

        [HttpPost]
        public JsonResult Save(ENT.PurchaseStockDistibutor model)
        {
            COM.MEMBERS.SQLReturnValue mRes = new COM.MEMBERS.SQLReturnValue();
            mRes.Outval = "SOMETHING WENT WRONG DATA.";
            if (model != null)
            {
                mRes = new BAL.PurchaseStockDistibutor().PurchaseStockDistibutor_Insert(model);
            }
            return Json(mRes.Outval, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult GetAll(string id)
        {
            return Json(new BAL.PurchaseStockDistibutor().PurchaseStockDistibutor_GetAll(), JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult GetAllDistibutor_BySuperID(string id)
        {
            return Json(new BAL.DistributorMaster().DistributorMaster_GetAll_BySuperstockistID(Guid.Parse(id)), JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult GetSupeStockProductWise(string pid, string sid)
        {
            COM.MEMBERS.SQLReturnValue mRes = new BAL.PurchaseStockSuperStockist().TotalStockSuperStockist_GetStock(Guid.Parse(pid), Guid.Parse(sid));
            return Json(mRes.Outval, JsonRequestBehavior.AllowGet);
        }
    }
}
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
    public class PurchaseStockSuperStockistController : Controller
    {
        // GET: PurchaseStockSuperStockist
        public ActionResult Index()
        {
            ViewBag.ProductList = new BAL.ProductMaster().ProductMaster_Get_GetAll(Guid.Parse("00000000-0000-0000-0000-000000000000"));
            ViewBag.SuperstockistList = new BAL.SuperStockIsMaster().SuperStockIsMaster_Get_GetAll(Guid.Parse("00000000-0000-0000-0000-000000000000"));
            return View();
        }

        [HttpPost]
        public JsonResult Save(ENT.PurchaseStockSuperStockist model)
        {
            COM.MEMBERS.SQLReturnValue mRes = new COM.MEMBERS.SQLReturnValue();
            mRes.Outval = "SOMETHING WENT WRONG DATA.";
            if (model != null)
            {
                mRes = new BAL.PurchaseStockSuperStockist().PurchaseStockSuperStockist_Insert(model);
            }
            return Json(mRes.Outval, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult GetAll(string id)
        {
            return Json(new BAL.PurchaseStockSuperStockist().PurchaseStockSuperStockist_GetAll(), JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult GetCompanyProfile()
        {
            return Json(new BAL.CompanyProfile().CompanyProfile_Get(), JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult GetCompayStockProductWise(string id)
        {
            COM.MEMBERS.SQLReturnValue mRes = new BAL.InwardStockCompany().TotalStockCompany_GetStock(Guid.Parse(id));
            return Json(mRes.Outval, JsonRequestBehavior.AllowGet);
        }
    }
}
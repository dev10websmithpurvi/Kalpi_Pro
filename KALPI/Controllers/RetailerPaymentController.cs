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
    public class RetailerPaymentController : Controller
    {
        // GET: RetailerPayment
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult GetAll()
        {
            return Json(new BAL.RetailerPayment().RetailerPayment_GetAll(), JsonRequestBehavior.AllowGet);
        }
    }
}
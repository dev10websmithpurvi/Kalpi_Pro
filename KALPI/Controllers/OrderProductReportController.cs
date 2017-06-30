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
    public class OrderProductReportController : Controller
    {
        // GET: OrderProductReport
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult GetAll()
        {
            return Json(new BAL.OrderProduct().OrderProduct_GetAllDelivery_Report(), JsonRequestBehavior.AllowGet);
        }
    }
}
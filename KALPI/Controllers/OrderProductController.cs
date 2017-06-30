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
    public class OrderProductController : Controller
    {
        // GET: OrderProduct
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult GetAll()
        {
            return Json(new BAL.OrderProduct().OrderProduct_Get_GetAll(Guid.Parse("00000000-0000-0000-0000-000000000000")), JsonRequestBehavior.AllowGet);
        }
    }
}
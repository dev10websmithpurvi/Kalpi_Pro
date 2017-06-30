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
    public class VisitPurposeMasterController : Controller
    {
        // GET: VisitPurposeMaster
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public JsonResult Save(ENT.VisitPurposeMaster model)
        {
            COM.MEMBERS.SQLReturnValue mRes = new COM.MEMBERS.SQLReturnValue();
            mRes.Outval = "SOMETHING WENT WRONG DATA.";
            if (model != null)
            {
                if (model.vp_id == new Guid("00000000-0000-0000-0000-000000000000"))
                    model.vp_isactive = true;
                mRes = new BAL.VisitPurposeMaster().VisitPurposeMaster_Insert_Update(model);
            }
            return Json(mRes.Outval, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult Get_GetAll(string id)
        {
            return Json(new BAL.VisitPurposeMaster().VisitPurposeMaster_Get_GetAll(Guid.Parse(id)), JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult GeneralAction(string id, Int32 ActionType)
        {
            COM.MEMBERS.SQLReturnValue mRes = new BAL.VisitPurposeMaster().VisitPurposeMaster_Delete_IsActive(Guid.Parse(id), ActionType);
            return Json(mRes.Outval, JsonRequestBehavior.AllowGet);
        }
    }
}
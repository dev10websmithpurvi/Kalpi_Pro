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
    public class SMSManagementController : Controller
    {
        // GET: SMSRouteManagement
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Save(ENT.SMSManagement model)
        {
            COM.MEMBERS.SQLReturnValue mRes = new COM.MEMBERS.SQLReturnValue();
            mRes.Outval = "SOMETHING WENT WRONG DATA.";
            if (model != null)
            {
                if (model.sm_id == new Guid("00000000-0000-0000-0000-000000000000"))
                {
                    model.sm_isacative = true;
                    model.sm_isdefault = false;
                }
                mRes = new BAL.SMSManagement().SMS_Insert_Update(model);
            }
            return Json(mRes.Outval, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult Get_GetAll(string id)
        {
            return Json(new BAL.SMSManagement().SMSManagement_Get_GetAll(Guid.Parse(id)), JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult GeneralAction(string id, Int32 ActionType)
        {
            COM.MEMBERS.SQLReturnValue mRes = new BAL.SMSManagement().SMSManagement_Delete_IsActive_IsDefault(Guid.Parse(id), ActionType);
            return Json(mRes.Outval, JsonRequestBehavior.AllowGet);
        }
    }
}
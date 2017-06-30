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
    public class SMTPServerManagementController : Controller
    {
        // GET: SMTPServerManagement
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Save(ENT.SMTPServerManagement model)
        {
            COM.MEMBERS.SQLReturnValue mRes = new COM.MEMBERS.SQLReturnValue();
            mRes.Outval = "SOMETHING WENT WRONG DATA.";
            if (model != null)
            {
                if (model.ssm_id == new Guid("00000000-0000-0000-0000-000000000000"))
                {
                    model.ssm_isactive = true;
                    model.ssm_isdefault = false;
                    model.ssm_enablessl = true;
                }
                mRes = new BAL.SMTPServerManagement().SMTPServerManagement_Insert_Update(model);
            }
            return Json(mRes.Outval, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult Get_GetAll(string id)
        {
            return Json(new BAL.SMTPServerManagement().SMTPServerManagement_Get_GetAll(Guid.Parse(id)), JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult GeneralAction(string id, Int32 ActionType)
        {
            COM.MEMBERS.SQLReturnValue mRes = new BAL.SMTPServerManagement().SMTPServerManagement_Delete_IsActive_IsDefault_IsEnableSSL(Guid.Parse(id), ActionType);
            return Json(mRes.Outval, JsonRequestBehavior.AllowGet);
        }
    }
}
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
    public class SchemeBuilderController : Controller
    {
        // GET: SchemeBuilder
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Save(ENT.SchemeBuilder model)
        {
            COM.MEMBERS.SQLReturnValue mRes = new COM.MEMBERS.SQLReturnValue();
            mRes.Outval = "SOMETHING WENT WRONG DATA.";
            if (model != null)
            {
                if (model.sb_id == new Guid("00000000-0000-0000-0000-000000000000"))
                    model.sb_isactive = true;
                mRes = new BAL.SchemeBuilder().SchemeBuilder_Insert_Update(model);
            }
            return Json(mRes.Outval, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult Get_GetAll(string id)
        {
            return Json(new BAL.SchemeBuilder().SchemeBuilder_Get_GetAll(Guid.Parse(id)), JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult GeneralAction(string id, int ActionType)
        {
            COM.MEMBERS.SQLReturnValue mRes = new BAL.SchemeBuilder().SchemeBuilder_Delete_IsActive(Guid.Parse(id), ActionType);
            return Json(mRes.Outval, JsonRequestBehavior.AllowGet);
        }
    }
}
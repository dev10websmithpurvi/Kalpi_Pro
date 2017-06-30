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
    public class SuperStockIsMasterController : Controller
    {
        // GET: SuperStockIsMaster
        public ActionResult Index()
        {
            ViewBag.StateList = new BAL.StateMaster().StateMaster_Get_GetAll(Guid.Parse("00000000-0000-0000-0000-000000000000"));
            return View();
        }

        [HttpPost]
        public JsonResult Save(ENT.SuperStockIsMaster model)
        {
            COM.MEMBERS.SQLReturnValue mRes = new COM.MEMBERS.SQLReturnValue();
            mRes.Outval = "SOMETHING WENT WRONG DATA.";
            if (model != null)
            {
                if (model.ss_id == new Guid("00000000-0000-0000-0000-000000000000"))
                    model.ss_isactive = true;
                model.CreatedBy = User.GetLogged_Userid();
                mRes = new BAL.SuperStockIsMaster().SuperStockIsMaster_Insert_Update(model);
            }
            return Json(mRes.Outval, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult Get_GetAll(string id)
        {
            return Json(new BAL.SuperStockIsMaster().SuperStockIsMaster_Get_GetAll(Guid.Parse(id)), JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult GeneralAction(string id, Int32 ActionType)
        {
            COM.MEMBERS.SQLReturnValue mRes = new BAL.SuperStockIsMaster().SuperStockIsMaster_Delete_IsActive(Guid.Parse(id), ActionType);
            return Json(mRes.Outval, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult City_GetAll_ByStateID(string id)
        {
            return Json(new BAL.CityMaster().CityMaster_GetAll_ByStateID(Guid.Parse(id)), JsonRequestBehavior.AllowGet);
        }
    }
}
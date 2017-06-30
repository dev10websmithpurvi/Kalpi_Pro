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
    public class RetailOutletMasterController : Controller
    {
        // GET: RetailOutletMaster
        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.StateList = new BAL.StateMaster().StateMaster_Get_GetAll(Guid.Parse("00000000-0000-0000-0000-000000000000"));
            ViewBag.DistibutorList = new BAL.DistributorMaster().DistributorMaster_Get_GetAll(Guid.Parse("00000000-0000-0000-0000-000000000000"));
            return View();
        }

        [HttpPost]
        public JsonResult Save(ENT.RetailOutletMaster model)
        {
            COM.MEMBERS.SQLReturnValue mRes = new COM.MEMBERS.SQLReturnValue();
            mRes.Outval = "SOMETHING WENT WRONG DATA.";
            if (model != null)
            {
                if (model.rom_id == new Guid("00000000-0000-0000-0000-000000000000"))
                    model.rom_isactive = true;
                model.CreatedBy = User.GetLogged_Userid();
                mRes = new BAL.RetailOutletMaster().RetailOutletMaster_Insert_Update(model);
            }
            return Json(mRes.Outval, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult Get_GetAll(string id)
        {
            return Json(new BAL.RetailOutletMaster().RetailOutletMaster_Get_GetAll(Guid.Parse(id)), JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult GeneralAction(string id, Int32 ActionType)
        {
            COM.MEMBERS.SQLReturnValue mRes = new BAL.RetailOutletMaster().RetailOutletMaster_Delete_IsActive(Guid.Parse(id), ActionType);
            return Json(mRes.Outval, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult City_GetAll_ByStateID(string id)
        {
            return Json(new BAL.CityMaster().CityMaster_GetAll_ByStateID(Guid.Parse(id)), JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult Route_GetAll_ByCityID(string id)
        {
            return Json(new BAL.RouteMaster().RouteMaster_GetAll_ByCityID(Guid.Parse(id)), JsonRequestBehavior.AllowGet);
        }
    }
}
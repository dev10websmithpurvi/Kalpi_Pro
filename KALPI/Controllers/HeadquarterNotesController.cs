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
    public class HeadquarterNotesController : Controller
    {
        // GET: HeadquarterNotes
        public ActionResult Index()
        {
            ViewBag.SalesmanList = new BAL.SalesmanMaster().SalesmanMaster_Get_GetAll(Guid.Parse("00000000-0000-0000-0000-000000000000"));
            return View();
        }

        [HttpPost]
        public JsonResult Save(ENT.HeadquarterNotes model)
        {
            COM.MEMBERS.SQLReturnValue mRes = new BAL.HeadquarterNotes().HeadquarterNotes_Insert_Update(model);

            string Message = string.Empty, DeviceID = string.Empty;
            if (mRes.Outval.ToString().Split('#').Length > 0)
            {
                Message = mRes.Outval.ToString().Split('#')[0];
                DeviceID = mRes.Outval.ToString().Split('#')[1];

                if (DeviceID != "NA")
                {
                    COM.UserNotification obj = new WS.Framework.Common.UserNotification();
                    obj.SendFCM(DeviceID, model.hn_note,"Notes from Headquarter",string.Empty, "kalpi");
                }
            }

            return Json(Message, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult Get_GetAll(string id)
        {
            return Json(new BAL.HeadquarterNotes().HeadquarterNotes_Get_GetAll(Guid.Parse(id)), JsonRequestBehavior.AllowGet);
        }
    }
}
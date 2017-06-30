using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using BAL = WS.Framework.Logic;
using COM = WS.Framework.Common;
using ENT = WS.Framework.Entity;
using System.Web.Script.Serialization;

namespace KALPI.Controllers
{
    [Authorize]
    public class CustomeSchemeController : Controller
    {
        // GET: CustomeScheme
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult GetAll()
        {
            return Json(new BAL.CustomeScheme().CustomeScheme_GetAll_PendingApprove(), JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult Get_GetAll(Guid id)
        {
            return Json(new BAL.CustomeScheme().CustomeScheme_Get_GetAll(id), JsonRequestBehavior.AllowGet);
        }


        /// <summary>
        /// Change Approved staus like approve /rejected,
        /// </summary>
        /// <param name="id">id of custome scheme</param>
        /// <param name="cs_status">status of approved /type
        /// 0=pending
        /// 1=approved
        /// 2=rejected
        /// ========
        /// type
        /// ====
        /// 0=Onetime
        /// 1=Continue
        /// </param>
        /// <param name="type">if want to change type than pass 1 or 0</param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult GeneralAction(string id, int cs_status, int type)
        {
            COM.MEMBERS.SQLReturnValue mRes = new COM.MEMBERS.SQLReturnValue();

            if (type == 0)
                mRes = new BAL.CustomeScheme().CustomeScheme_IsApprove(Guid.Parse(id), cs_status);
            else
                mRes = new BAL.CustomeScheme().CustomeScheme_ChangeType(Guid.Parse(id), cs_status);

            string Message = string.Empty, DeviceID = string.Empty, SchemeDetails = string.Empty; string Status = string.Empty, Schemetitle=string.Empty;
            //send fcm notification to salesman 
            if (mRes.Outval.ToString().Split('#').Length > 0)
            {
                Message = mRes.Outval.ToString().Split('#')[0];
                DeviceID = mRes.Outval.ToString().Split('#')[1];
                SchemeDetails = mRes.Outval.ToString().Split('#')[2];
                //Status = (mRes.Outval.ToString().Split('#')[3] == "1" ? "Approved" : "Rejected");
                Schemetitle = mRes.Outval.ToString().Split('#')[3];

                if (DeviceID != "NA")
                {
                    COM.UserNotification obj = new WS.Framework.Common.UserNotification();
                    List<ENT.CustomeScheme> Json = new BAL.CustomeScheme().CustomeScheme_Get_GetAll(Guid.Parse(id));
                    obj.SendFCM(DeviceID, SchemeDetails, Schemetitle, Json, "kalpi");
                }
            }

            return Json((!string.IsNullOrWhiteSpace(Message) ? Message : mRes.Outval), JsonRequestBehavior.AllowGet);
        }
    }
}
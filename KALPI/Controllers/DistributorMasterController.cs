using System;
using System.Web.Mvc;
using BAL = WS.Framework.Logic;
using COM = WS.Framework.Common;
using ENT = WS.Framework.Entity;

namespace KALPI.Controllers
{
    [Authorize]
    public class DistributorMasterController : Controller
    {
        // GET: DistributorMaster
        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.StateList = new BAL.StateMaster().StateMaster_Get_GetAll(Guid.Parse("00000000-0000-0000-0000-000000000000"));
            ViewBag.SuperStockIsList = new BAL.SuperStockIsMaster().SuperStockIsMaster_Get_GetAll(Guid.Parse("00000000-0000-0000-0000-000000000000"));
            return View();
        }

        //mandtory field validaion check
        //ADDRESS NULL,PIN CODE ,BIRTH DATE VALIDATION
        //IF ANY ERROR OCCUR MODAL CLOSED 
        //designing site is_approved issue update solved
        //known issue when data add in distributor then identity sent duplicate error if data duplicate at the edit time
        /// <summary>
        /// SAVE AND EDIT DUSTRIBUTOR AND ALSO IDENTITY TABLE
        /// </summary>
        /// <param name="model">list of field's model</param>
        /// <returns>return Outval message of success/fail(error)</returns>
        [HttpPost]
        public JsonResult Save(ENT.DistributorMaster model)
        {
            COM.MEMBERS.SQLReturnValue mRes = new COM.MEMBERS.SQLReturnValue();
            mRes.Outval = "SOMETHING WENT WRONG DATA.";
            if (model != null)
            {
                if (model.dm_id == new Guid("00000000-0000-0000-0000-000000000000"))
                    model.dm_isactive = true;
                model.CreatedBy = User.GetLogged_Userid();
                mRes = new BAL.DistributorMaster().DistributorMaster_Insert_Update(model);
            }
            return Json(mRes.Outval, JsonRequestBehavior.AllowGet);

        }

        [HttpPost]
        public JsonResult Get_GetAll(string id)
        {
            return Json(new BAL.DistributorMaster().DistributorMaster_Get_GetAll(Guid.Parse(id)), JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult City_GetAll_ByStateID(string id)
        {
            return Json(new BAL.CityMaster().CityMaster_GetAll_ByStateID(Guid.Parse(id)), JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult GeneralAction(string id, int ActionType)
        {
            COM.MEMBERS.SQLReturnValue mRes = new BAL.DistributorMaster().DistributorMaster_Delete_IsActive(Guid.Parse(id), ActionType);
            return Json(mRes.Outval, JsonRequestBehavior.AllowGet);
        }
    }
}
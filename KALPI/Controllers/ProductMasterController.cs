using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using BAL = WS.Framework.Logic;
using COM = WS.Framework.Common;
using ENT = WS.Framework.Entity;

namespace KALPI.Controllers
{
    [Authorize]
    public class ProductMasterController : Controller
    {
        // GET: ProductMaster
        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.CategoryList = new BAL.CategoryMaster().CategoryMaster_Get_GetAll(Guid.Parse("00000000-0000-0000-0000-000000000000"));
            return View();
        }

        [HttpPost]
        public JsonResult Save(ENT.ProductMaster model)
        {

            HttpFileCollectionBase files = Request.Files;
            string fname = string.Empty, fileNameOnly = string.Empty;

            if (files.Count > 0)
            {
                for (int i = 0; i < files.Count; i++)
                {
                    string path = Server.MapPath("~/ProductImage/");
                    string NewFilename = Guid.NewGuid().ToString(); //Path.GetFileName(Request.Files[i].FileName);
                    string NewFileExt = Path.GetExtension(Request.Files[i].FileName);

                    HttpPostedFileBase file = files[i];

                    if (Request.Browser.Browser.ToUpper() == "IE" || Request.Browser.Browser.ToUpper() == "INTERNETEXPLORER")
                    {
                        string[] testfiles = file.FileName.Split(new char[] { '\\' });
                        fname = testfiles[testfiles.Length - 1];
                    }
                    else
                    {
                        fname = file.FileName;
                    }
                    fileNameOnly = NewFilename + NewFileExt;
                    fname = Path.Combine(Server.MapPath("~/ProductImage/"), NewFilename + NewFileExt);
                    file.SaveAs(fname);
                }
                model.pm_productimage = fileNameOnly;
            }

            model.pm_isactive = true;
            COM.MEMBERS.SQLReturnMessageNValue mRes = new BAL.ProductMaster().ProductMaster_Insert_Update(model);
            return Json(new COM.ResponseClass(mRes.Outval.ToString(), mRes.Outmsg), JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult Get_GetAll(string id)
        {
            return Json(new BAL.ProductMaster().ProductMaster_Get_GetAll(Guid.Parse(id)), JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult GeneralAction(string id, Int32 ActionType)
        {
            if (ActionType == 1)
            {
                List<ENT.ProductMaster> pList = new BAL.ProductMaster().ProductMaster_Get_GetAll(Guid.Parse(id));
                string fileName = pList[0].pm_productimage;

                if ((System.IO.File.Exists(fileName)))
                {
                    System.IO.File.Delete(fileName);
                }
            }

            COM.MEMBERS.SQLReturnValue mRes = new BAL.ProductMaster().ProductMaster_Delete_IsActive(Guid.Parse(id), ActionType);
            return Json(mRes.Outval, JsonRequestBehavior.AllowGet);
        }
    }
}
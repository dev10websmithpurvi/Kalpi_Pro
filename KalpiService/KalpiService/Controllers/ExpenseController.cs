using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

using BAL = WS.Framework.Logic;
using COM = WS.Framework.Common;
using ENT = WS.Framework.Entity;

namespace KalpiService.Controllers
{
  //  [Authorize]
    [RoutePrefix("api/Expense")]
    public class ExpenseController : ApiController
    {
        // POST : api/Retailer/GetExpenseType
        [HttpGet]
        [Route("GetExpenseType")]
        public HttpResponseMessage GetExpenseType()
        {
            try
            {
                return new HttpResponseMessage()
                {
                    Content = new StringContent("{\"" + "ExpenseTypeResponse" + "\":" + JArray.FromObject(new BAL.ExpenseTypeMaster().ExpenseTypeMaster_Get_GetAll(Guid.Parse("00000000-0000-0000-0000-000000000000"))).ToString() + "}", Encoding.UTF8, "application/json")
                };
            }
            catch (Exception ee)
            {
                return new HttpResponseMessage()
                {
                    Content = new StringContent("{\"" + "ExpenseTypeResponse" + "\":" + JArray.FromObject(ee.Message).ToString() + "}", Encoding.UTF8, "application/json")
                };
            }
        }

        // POST : api/Retailer/GetDistibutor
        [HttpGet]
        [Route("GetExpenseMode")]
        public HttpResponseMessage GetExpenseMode()
        {
            try
            {
                return new HttpResponseMessage()
                {
                    Content = new StringContent("{\"" + "ExpenseModeResponse" + "\":" + JArray.FromObject(new BAL.ExpenseModeMaster().ExpenseModeMaster_Get_GetAll(Guid.Parse("00000000-0000-0000-0000-000000000000"))).ToString() + "}", Encoding.UTF8, "application/json")
                };
            }
            catch (Exception ee)
            {
                return new HttpResponseMessage()
                {
                    Content = new StringContent("{\"" + "ExpenseModeResponse" + "\":" + JArray.FromObject(ee.Message).ToString() + "}", Encoding.UTF8, "application/json")
                };
            }
        }

        // POST : api/Retailer/GetDistibutor
        [HttpGet]
        [Route("GetExpense")]
        public HttpResponseMessage GetExpense()
        {
            try
            {
                return new HttpResponseMessage()
                {
                    Content = new StringContent("{\"" + "ExpenseResponse" + "\":" + JArray.FromObject(new BAL.ExpenseMaster().ExpenseMaster_Get_GetAll(Guid.Parse("00000000-0000-0000-0000-000000000000"))).ToString() + "}", Encoding.UTF8, "application/json")
                };
            }
            catch (Exception ee)
            {
                return new HttpResponseMessage()
                {
                    Content = new StringContent("{\"" + "ExpenseResponse" + "\":" + JArray.FromObject(ee.Message).ToString() + "}", Encoding.UTF8, "application/json")
                };
            }
        }

        // POST : api/Expense/ExpenseSave
        [HttpPost]
        [Route("ExpenseSave")]
        public COM.ResponseClass ExpenseSave([FromBody] ENT.ExpenseMaster _ExpenseMaster)
        {
            try
            {
                COM.MEMBERS.SQLReturnValue mRes = new BAL.ExpenseMaster().ExpenseMaster_Insert_Update(_ExpenseMaster);
                return new COM.ResponseClass("1", mRes.Outval.ToString());
            }
            catch (Exception ee)
            {
                return new COM.ResponseClass("0", ee.Message);
            }
        }

        //[HttpPost]
        //[Route("UploadExpenseDocument")]
        //public COM.ResponseClass UploadExpenseDocument([FromBody] ENT.ExpenseMaster _ExpenseMaster)
        //{
        //    try
        //    {
        //        if (_ExpenseMaster != null)
        //        {
        //            if (_ExpenseMaster.vm_imagebyte != null)
        //            {
        //                MemoryStream ms = new MemoryStream(_ExpenseMaster.vm_imagebyte);
        //                //Image image = Image.FromStream(ms);
        //                //image.Save(@"F:\KALPI_Pro\KALPI_Pro\KalpiService\KalpiService\AppImages\imageTest.png");
        //                FileStream fs = new FileStream(System.Web.Hosting.HostingEnvironment.MapPath("~/AppImages/") + _ExpenseMaster.vm_visitfile, FileMode.Create);
        //                ms.WriteTo(fs);
        //                ms.Close();
        //                fs.Close();
        //                fs.Dispose();
        //            }

        //            COM.MEMBERS.SQLReturnValue mRes = new BAL.ExpenseMaster().ExpenseDocument_Insert_Update(_ExpenseMaster);
        //            return new COM.ResponseClass("1", mRes.Outval.ToString());
        //        }
        //        else
        //        {
        //            return new COM.ResponseClass("0", "Something went wrong");
        //        }
        //    }
        //    catch (Exception ee)
        //    {
        //        return new COM.ResponseClass("0", ee.Message);
        //    }
        //}

    }

}
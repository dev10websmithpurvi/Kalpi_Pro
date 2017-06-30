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

    }
}
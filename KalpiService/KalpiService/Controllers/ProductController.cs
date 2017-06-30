using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Text;
using System.Web.Http;

using BAL = WS.Framework.Logic;

namespace KalpiService.Controllers
{
    [Authorize]
    [RoutePrefix("api/Product")]
    public class ProductController : ApiController
    {
        // GET : api/Product/GetProduct
        [HttpGet]
        [Route("GetProduct")]
        public HttpResponseMessage GetProduct()
        {
            try
            {
                return new HttpResponseMessage()
                {
                    Content = new StringContent("{\"" + "ProductResponse" + "\":" + JsonConvert.SerializeObject(new BAL.ProductMaster().ProductMaster_GetAll_Service()) + "}", Encoding.UTF8, "application/json")
                };
            }
            catch (Exception ee)
            {
                return new HttpResponseMessage()
                {
                    Content = new StringContent("{\"" + "ProductResponse" + "\":" + JArray.FromObject(ee.Message).ToString() + "}", Encoding.UTF8, "application/json")
                };
            }
        }
    }
}
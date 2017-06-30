using KalpiService.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Data;
using System.Net.Http;
using System.Text;
using System.Web.Http;

using BAL = WS.Framework.Logic;
using COM = WS.Framework.Common;
using ENT = WS.Framework.Entity;

namespace KalpiService.Controllers
{
    [Authorize]
    [RoutePrefix("api/Master")]
    public class MasterController : ApiController
    {
        // GET : api/Master/UserProfile
        [HttpGet]
        [Route("UserProfile")]
        public HttpResponseMessage UserProfile(string deviceid)
        {
            try
            {
                return new HttpResponseMessage()
                {
                    Content = new StringContent("{\"" + "UserProfileResponse" + "\":" + JsonConvert.SerializeObject(User.GetUserProfile(deviceid)).ToString() + "}", Encoding.UTF8, "application/json")
                };
            }
            catch (Exception ee)
            {
                return new HttpResponseMessage()
                {
                    Content = new StringContent("{\"" + "UserProfileResponse" + "\":" + JArray.FromObject(ee.Message).ToString() + "}", Encoding.UTF8, "application/json")
                };
            }
        }

        // GET : api/Master/GetState
        [HttpGet]
        [Route("GetState")]
        public HttpResponseMessage GetState()
        {
            try
            {
                return new HttpResponseMessage()
                {
                    Content = new StringContent("{\"" + "StateResponse" + "\":" + JArray.FromObject(new BAL.StateMaster().StateMaster_Get_GetAll(Guid.Parse("00000000-0000-0000-0000-000000000000"))).ToString() + "}", Encoding.UTF8, "application/json")
                };
            }
            catch (Exception ee)
            {
                return new HttpResponseMessage()
                {
                    Content = new StringContent("{\"" + "StateResponse" + "\":" + JArray.FromObject(ee.Message).ToString() + "}", Encoding.UTF8, "application/json")
                };
            }
        }

        // GET : api/Master/GetCity
        [HttpPost]
        [Route("GetCity")]
        public HttpResponseMessage GetCity(string id)
        {
            try
            {
                return new HttpResponseMessage()
                {
                    Content = new StringContent("{\"" + "CityResponse" + "\":" + JArray.FromObject(new BAL.CityMaster().CityMaster_GetAll_ByStateID(Guid.Parse(id))).ToString() + "}", Encoding.UTF8, "application/json")
                };
            }
            catch (Exception ee)
            {
                return new HttpResponseMessage()
                {
                    Content = new StringContent("{\"" + "CityResponse" + "\":" + JArray.FromObject(ee.Message).ToString() + "}", Encoding.UTF8, "application/json")
                };
            }
        }

        // GET : api/Master/GetRoute
        [HttpPost]
        [Route("GetRoute")]
        public HttpResponseMessage GetRoute(string id)
        {
            try
            {
                return new HttpResponseMessage()
                {
                    Content = new StringContent("{\"" + "RouteResponse" + "\":" + JArray.FromObject(new BAL.RouteMaster().RouteMaster_GetAll_ByCityID(Guid.Parse(id))).ToString() + "}", Encoding.UTF8, "application/json")
                };
            }
            catch (Exception ee)
            {
                return new HttpResponseMessage()
                {
                    Content = new StringContent("{\"" + "RouteResponse" + "\":" + JArray.FromObject(ee.Message).ToString() + "}", Encoding.UTF8, "application/json")
                };
            }
        }

        // POST : api/Master/GetSuperStockist
        [HttpGet]
        [Route("GetSuperStockist")]
        public HttpResponseMessage GetSuperStockist(string id)
        {
            try
            {
                return new HttpResponseMessage()
                {
                    Content = new StringContent("{\"" + "SuperStockistResponse" + "\":" + JArray.FromObject(new BAL.SuperStockIsMaster().SuperStockIsMaster_GetAll_ByCityID(Guid.Parse(id))).ToString() + "}", Encoding.UTF8, "application/json")
                };
            }
            catch (Exception ee)
            {
                return new HttpResponseMessage()
                {
                    Content = new StringContent("{\"" + "SuperStockistResponse" + "\":" + JArray.FromObject(ee.Message).ToString() + "}", Encoding.UTF8, "application/json")
                };
            }
        }

        // GET : api/Master/GetScheme
        [HttpGet]
        [Route("GetScheme")]
        public HttpResponseMessage GetScheme()
        {
            try
            {
                return new HttpResponseMessage()
                {
                    Content = new StringContent("{\"" + "SchemeResponse" + "\":" + JArray.FromObject(new BAL.SchemeBuilder().SchemeBuilder_Get_GetAll(Guid.Parse("00000000-0000-0000-0000-000000000000"))).ToString() + "}", Encoding.UTF8, "application/json")
                };
            }
            catch (Exception ee)
            {
                return new HttpResponseMessage()
                {
                    Content = new StringContent("{\"" + "SchemeResponse" + "\":" + JArray.FromObject(ee.Message).ToString() + "}", Encoding.UTF8, "application/json")
                };
            }
        }

        // GET : api/Master/GetHQNote
        [HttpGet]
        [Route("GetHQNote")]
        public HttpResponseMessage GetHQNote(string id)
        {
            try
            {
                return new HttpResponseMessage()
                {
                    Content = new StringContent("{\"" + "HQNoteResponse" + "\":" + JArray.FromObject(new BAL.HeadquarterNotes().HeadquarterNotes_Get_BySalesman(Guid.Parse(id))).ToString() + "}", Encoding.UTF8, "application/json")
                };
            }
            catch (Exception ee)
            {
                return new HttpResponseMessage()
                {
                    Content = new StringContent("{\"" + "HQNoteResponse" + "\":" + JArray.FromObject(ee.Message).ToString() + "}", Encoding.UTF8, "application/json")
                };
            }
        }

        // GET : api/Master/SaveAtt
        [HttpPost]
        [Route("SaveAtt")]
        public COM.ResponseClass SaveAtt([FromBody] ENT.SalesmanAttadance _salesmanAttadance)
        {
            try
            {
                COM.MEMBERS.SQLReturnValue mRes = new BAL.SalesmanAttadance().SalesmanAttadance_Insert(_salesmanAttadance);
                return new COM.ResponseClass("1", mRes.Outval.ToString());
            }
            catch (Exception ee)
            {
                return new COM.ResponseClass("0", ee.Message);
            }
        }

        // GET : api/Master/GetAllRetailer
        [HttpGet]
        [Route("GetAllRetailer")]
        public HttpResponseMessage GetAllRetailer()
        {
            try
            {
                return new HttpResponseMessage()
                {
                    Content = new StringContent("{\"" + "RetailerResponse" + "\":" + JArray.FromObject(new BAL.RetailOutletMaster().RetailOutletMaster_Get_GetAll(Guid.Parse("00000000-0000-0000-0000-000000000000"))).ToString() + "}", Encoding.UTF8, "application/json")
                };
            }
            catch (Exception ee)
            {
                return new HttpResponseMessage()
                {
                    Content = new StringContent("{\"" + "RetailerResponse" + "\":" + JArray.FromObject(ee.Message).ToString() + "}", Encoding.UTF8, "application/json")
                };
            }
        }

        // GET : api/Master/GetSalesmanAtt
        [HttpGet]
        [Route("GetSalesmanAtt")]
        public HttpResponseMessage GetSalesmanAtt(string id)
        {
            try
            {
                return new HttpResponseMessage()
                {
                    Content = new StringContent("{\"" + "SalesmanattResponse" + "\":" + JArray.FromObject(new BAL.SalesmanAttadance().SalesmanAttadance_GetAll_TodayAttedance(Guid.Parse(id))).ToString() + "}", Encoding.UTF8, "application/json")
                };
            }
            catch (Exception ee)
            {
                return new HttpResponseMessage()
                {
                    Content = new StringContent("{\"" + "SalesmanattResponse" + "\":" + JArray.FromObject(ee.Message).ToString() + "}", Encoding.UTF8, "application/json")
                };
            }
        }

        // GET : api/Master/SaveLatLong
        [HttpPost]
        [Route("SaveLatLong")]
        public COM.ResponseClass SaveLatLong([FromBody] ENT.SalesmanLatLong _salesmanLatLong)
        {
            try
            {
                //JObject jObject = JObject.Parse(_salesmanLatLongJSON);
                //string JSON = (string)jObject["LatLongArray"].ToString();

                //var table = JsonConvert.DeserializeObject<DataTable>(JSON);

                COM.MEMBERS.SQLReturnValue mRes = new BAL.SalesmanLatLong().SalesmanLatLong_Insert(_salesmanLatLong);
                return new COM.ResponseClass("1", mRes.Outval.ToString());
            }
            catch (Exception ee)
            {
                return new COM.ResponseClass("0", ee.Message);
            }
        }
    }
}
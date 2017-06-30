
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Http;

using BAL = WS.Framework.Logic;
using COM = WS.Framework.Common;
using ENT = WS.Framework.Entity;

namespace KalpiService.Controllers
{
    [Authorize]
    [RoutePrefix("api/Order")]
    public class OrderController : ApiController
    {
        // POST : api/Order/GetDistibutorBySSWise
        [HttpGet]
        [Route("GetDistibutorBySSWise")]
        public HttpResponseMessage GetDistibutorBySSWise(string id)
        {
            try
            {
                return new HttpResponseMessage()
                {
                    Content = new StringContent("{\"" + "DistibutorResponse" + "\":" + JArray.FromObject(new BAL.DistributorMaster().DistributorMaster_GetAll_BySuperstockistID(Guid.Parse(id))).ToString() + "}", Encoding.UTF8, "application/json")
                };
            }
            catch (Exception ee)
            {
                return new HttpResponseMessage()
                {
                    Content = new StringContent("{\"" + "DistibutorResponse" + "\":" + JArray.FromObject(ee.Message).ToString() + "}", Encoding.UTF8, "application/json")
                };
            }
        }

        // POST : api/Order/GetRouteByDistibutor
        [HttpGet]
        [Route("GetRouteByDistibutor")]
        public HttpResponseMessage GetRouteByDistibutor(string id)
        {
            try
            {
                return new HttpResponseMessage()
                {
                    Content = new StringContent("{\"" + "RouteResponse" + "\":" + JArray.FromObject(new BAL.RouteMaster().RouteMaster_GetAll_ByDistibutorID(Guid.Parse(id))).ToString() + "}", Encoding.UTF8, "application/json")
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

        // POST : api/Order/GetRetailerByRoute
        [HttpGet]
        [Route("GetRetailerByRoute")]
        public HttpResponseMessage GetRetailerByRoute(string id)
        {
            try
            {
                return new HttpResponseMessage()
                {
                    Content = new StringContent("{\"" + "RetailerResponse" + "\":" + JArray.FromObject(new BAL.RetailOutletMaster().RetailOutletMaster_GetAll_ByRouteID_Service(Guid.Parse(id))).ToString() + "}", Encoding.UTF8, "application/json")
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

        // POST : api/Order/SaveOrder
        [HttpPost]
        [Route("SaveOrder")]
        public COM.ResponseClass SaveOrder([FromBody] ENT.OrderProduct _orderProduct)
        {
            try
            {
                COM.MEMBERS.SQLReturnMessageNValue mRes = new BAL.OrderProduct().OrderProduct_Insert_Update(_orderProduct);
                return new COM.ResponseClass(mRes.Outval.ToString(), mRes.Outmsg.ToString());
            }
            catch (Exception ee)
            {
                return new COM.ResponseClass("0", ee.Message);
            }
        }

        // POST : api/Order/GetOrder

        /// <summary>
        /// get Pending order report With Upcoming,Past(Missed orders) , Todays  ,Or all
        /// </summary>
        /// <param name="id">op_retailoutletid</param>
        /// <param name="op_expecteddekiverydt">Expected delivery  date</param>
        /// <param name="filtertype">Filter type
        /// 0-all
        /// 1-Upcoming
        /// 2-Past(Missed Order)
        /// 3-Today</param>
        /// <param name="upcoming_days">No of days Upcoming days e.x(24/7/2017 date with 3 upcoming_days)then from 24/7/2017 to 27/7/2017) data return </param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetOrder")]
        public HttpResponseMessage Get_GetAll_Order(string id, DateTime op_expecteddekiverydt,int filtertype,int upcoming_days)
        {
            if (string.IsNullOrEmpty(id) ||string.IsNullOrEmpty(op_expecteddekiverydt.ToString()) )
                return new HttpResponseMessage()
                {
                    Content = new StringContent("{\"" + "OrderResponse" + "\":" + JArray.FromObject("Retailer id or date should be proper").ToString() + "}", Encoding.UTF8, "application/json")
                };
            try
            {
                return new HttpResponseMessage()
                {
                    Content = new StringContent("{\"" + "OrderResponse" + "\":" + JArray.FromObject(new BAL.OrderProduct().OrderProduct_GetAll_ByOutletID(Guid.Parse(id), op_expecteddekiverydt,filtertype,upcoming_days)).ToString() + "}", Encoding.UTF8, "application/json")
                };
            }
            catch (Exception ee)
            {
                return new HttpResponseMessage()
                {
                    Content = new StringContent("{\"" + "OrderResponse" + "\":" + JArray.FromObject(ee.Message).ToString() + "}", Encoding.UTF8, "application/json")
                };
            }
        }

        // POST : api/Order/GetDistibutorBySSWise
        [HttpGet]
        [Route("GetDistibutorStock")]
        public HttpResponseMessage GetDistibutorStock(string pid, string did)
        {
            try
            {
                COM.MEMBERS.SQLReturnValue mRes = new BAL.PurchaseStockDistibutor().TotalStockDistibutor_GetStock(Guid.Parse(pid), Guid.Parse(did));
                return new HttpResponseMessage()
                {
                    Content = new StringContent("{\"" + "DistibutorSotck" + "\":" + mRes.Outval.ToString() + "}", Encoding.UTF8, "application/json")
                };
            }
            catch (Exception ee)
            {
                return new HttpResponseMessage()
                {
                    Content = new StringContent("{\"" + "DistibutorSotck" + "\":" + JArray.FromObject(ee.Message).ToString() + "}", Encoding.UTF8, "application/json")
                };
            }
        }

        // POST : api/Order/GetRetailerByRoute
        [HttpGet]
        [Route("GetOfftack")]
        public HttpResponseMessage GetOfftack(string op_retailoutletid, string op_productid)
        {
            try
            {
                return new HttpResponseMessage()
                {
                    Content = new StringContent("{\"" + "OfftakeResponse" + "\":" + JArray.FromObject(new BAL.OrderProduct().OrderProduct_GetLastStockOfRetailer(Guid.Parse(op_retailoutletid), Guid.Parse(op_productid))).ToString() + "}", Encoding.UTF8, "application/json")
                };
            }
            catch (Exception ee)
            {
                return new HttpResponseMessage()
                {
                    Content = new StringContent("{\"" + "OfftakeResponse" + "\":" + JArray.FromObject(ee.Message).ToString() + "}", Encoding.UTF8, "application/json")
                };
            }
        }

        //_customeScheme  null check
        //if freeqty and rate both greater than 0 
        //freeqty and rate should not 0 or null
        //_customeScheme free qty and rate 
        // 
        // POST : api/Order/CustomScheme
        [HttpPost]
        [Route("CustomSchemeSave")]
        public COM.ResponseClass CustomSchemeSave([FromBody] ENT.CustomeScheme _customeScheme)
        {
            try
            {
                if (_customeScheme != null)
                {
                    if (_customeScheme.cs_freeqty > 0 && _customeScheme.cs_rate > 0)
                    {
                        return new COM.ResponseClass("0", "Please enter either free qty or rate");
                    }
                    if (_customeScheme.cs_freeqty == 0 && _customeScheme.cs_rate == 0)
                    {
                        return new COM.ResponseClass("0", "Please enter free qty or rate");
                    }

                    COM.MEMBERS.SQLReturnValue mRes = new BAL.CustomeScheme().CustomeScheme_Insert(_customeScheme);
                    string Message = string.Empty, DeviceID = string.Empty, SchemeDetails = string.Empty,
                    Schemetitle = string.Empty;
                    if (mRes.Outval.ToString().Split('#').Length > 0)
                    {
                        Message = mRes.Outval.ToString().Split('#')[0];
                        DeviceID = mRes.Outval.ToString().Split('#')[1];
                        SchemeDetails = mRes.Outval.ToString().Split('#')[2];
                        Schemetitle = mRes.Outval.ToString().Split('#')[3];

                        if (DeviceID != "NA")
                        {
                            COM.UserNotification obj = new COM.UserNotification();
                            List<ENT.CustomeScheme> Json = new BAL.CustomeScheme().CustomeScheme_Get_GetAll((Guid.Parse(Message)));

                            obj.SendFCM(DeviceID, SchemeDetails, Schemetitle, Json[0], "kalpiAdmin");
                        }
                    }
                    return new COM.ResponseClass("1", Message);
                }
                return new COM.ResponseClass("0", "Something wrong with data");
            }
            catch (Exception ee)
            {
                return new COM.ResponseClass("0", ee.Message);
            }
        }

        // POST : api/Order/CustomScheme
        //id and status should not null or empty or 0
        [HttpPost]
        [Route("CustomScheme_Approve")]
        public COM.ResponseClass CustomScheme_Approve(string id, int cs_status)
        {
            try
            {
                if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(Convert.ToString(cs_status)))
                    return new COM.ResponseClass("0", "Please enter Valid data");


                COM.MEMBERS.SQLReturnValue mRes = new BAL.CustomeScheme().CustomeScheme_IsApprove(Guid.Parse(id), cs_status);

                string Message = string.Empty, DeviceID = string.Empty, SchemeDetails = string.Empty; string Status = string.Empty, Schemetitle = string.Empty;
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

                return new COM.ResponseClass("1", Message.ToString());
            }
            catch (Exception ee)
            {
                return new COM.ResponseClass("0", ee.Message);
            }
        }

        // POST : api/Order/CustomScheme_Get_GetAll
        //id=00000000-0000-0000-0000-000000000000  means return all rows
        [HttpGet]
        [Route("CustomScheme_Get_GetAll")]
        public HttpResponseMessage CustomScheme_Get_GetAll(string id)
        {
            //00000000-0000-0000-0000-000000000000
            if (string.IsNullOrEmpty(id))
                return new HttpResponseMessage()
                {
                    Content = new StringContent("{\"" + "CustomSchemeResponse" + "\":" + JArray.FromObject("Custom scheme should be proper").ToString() + "}", Encoding.UTF8, "application/json")
                };
            try
            {
                return new HttpResponseMessage()
                {
                    Content = new StringContent("{\"" + "CustomSchemeResponse" + "\":" + JArray.FromObject(new BAL.CustomeScheme().CustomeScheme_Get_GetAll(Guid.Parse(id))).ToString() + "}", Encoding.UTF8, "application/json")
                };
            }
            catch (Exception ee)
            {
                return new HttpResponseMessage()
                {
                    Content = new StringContent("{\"" + "CustomSchemeResponse" + "\":" + JArray.FromObject(ee.Message).ToString() + "}", Encoding.UTF8, "application/json")
                };
            }

        }
        // POST : api/Order/PaymentSave
        [HttpPost]
        [Route("PaymentSave")]
        public COM.ResponseClass PaymentSave([FromBody] ENT.RetailerPayment _retailerPayment)
        {
            try
            {
                if (_retailerPayment.rp_paymenttype == 2) // CHEQUE
                {
                    if (_retailerPayment.rp_imagebyte != null)
                    {
                        MemoryStream ms = new MemoryStream(_retailerPayment.rp_imagebyte);
                        FileStream fs = new FileStream(System.Web.Hosting.HostingEnvironment.MapPath("~/AppImages/") + _retailerPayment.rp_chequeimage, FileMode.Create);
                        ms.WriteTo(fs);
                        ms.Close();
                        fs.Close();
                        fs.Dispose();
                    }
                }

                COM.MEMBERS.SQLReturnValue mRes = new BAL.RetailerPayment().RetailerPayment_Insert(_retailerPayment);
                return new COM.ResponseClass("1", mRes.Outval.ToString());
            }
            catch (Exception ee)
            {
                return new COM.ResponseClass("0", ee.Message);
            }
        }

        // POST : api/Order/PaymentSaveNew
        [HttpPost]
        [Route("PaymentSaveNew")]
        [AllowAnonymous]
        public COM.ResponseClass PaymentSaveNew([FromBody] ENT.RetailerPayment _retailerPayment)
        {
            string PostedFileName = string.Empty;
            try
            {
                if (_retailerPayment.rp_paymenttype == 2) // CHEQUE
                {
                    var httpRequest = HttpContext.Current.Request;
                    foreach (string file in httpRequest.Files)
                    {
                        HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created);
                        var postedFile = httpRequest.Files[file];
                        if (postedFile != null && postedFile.ContentLength > 0)
                        {
                            int MaxContentLength = 1024 * 1024 * 1; //Size = 1 MB  

                            IList<string> AllowedFileExtensions = new List<string> { ".jpg", ".gif", ".png" };
                            var ext = postedFile.FileName.Substring(postedFile.FileName.LastIndexOf('.'));
                            var extension = ext.ToLower();
                            if (!AllowedFileExtensions.Contains(extension))
                            {
                                return new COM.ResponseClass("0", "Please Upload image of type .jpg,.gif,.png.");
                            }
                            else if (postedFile.ContentLength > MaxContentLength)
                            {
                                return new COM.ResponseClass("0", "Please Upload a file upto 1 mb.");
                            }
                            else
                            {
                                PostedFileName = postedFile.FileName + extension;
                                var filePath = HttpContext.Current.Server.MapPath("~/AppImages/" + postedFile.FileName + extension);
                                postedFile.SaveAs(filePath);
                            }
                        }
                    }
                }
                
                
                _retailerPayment.rp_chequeimage = PostedFileName;
                COM.MEMBERS.SQLReturnValue mRes = new BAL.RetailerPayment().RetailerPayment_Insert(_retailerPayment);
                return new COM.ResponseClass("1", mRes.Outval.ToString());
            }
            catch (Exception ee)
            {
                return new COM.ResponseClass("0", ee.Message);
            }
        }

        // POST : api/Order/DeliveryDone
        [HttpPost]
        [Route("DeliveryDone")]
        public COM.ResponseClass DeliveryDone(string op_id, bool op_isdeliver, DateTime op_deliverydate)
        {
            try
            {
                COM.MEMBERS.SQLReturnValue mRes = new BAL.OrderProduct().OrderProduct_IsDeliveryDone(Guid.Parse(op_id), op_isdeliver, op_deliverydate);
                return new COM.ResponseClass("1", mRes.Outval.ToString());
            }
            catch (Exception ee)
            {
                return new COM.ResponseClass("0", ee.Message);
            }
        }
    }
}
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
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
    [RoutePrefix("api/Visit")]
    public class VisitController : ApiController
    {
        /// <summary>
        /// Get Visit master type list
        /// </summary>
        /// <param name="id">visit type id </param>
        /// <returns></returns>
        // POST : api/Visit/GetVisitType
        [HttpGet]
        [Route("GetVisitType")]
        public HttpResponseMessage GetVisitType(string id)
        {
            try
            {
                return new HttpResponseMessage()
                {
                    Content = new StringContent("{\"" + "VisitTypeResponse" + "\":" + JArray.FromObject(new BAL.VisitTypeMaster().VisitTypeMaster_Get_GetAll(Guid.Parse(id))).ToString() + "}", Encoding.UTF8, "application/json")
                };
            }
            catch (Exception ee)
            {
                return new HttpResponseMessage()
                {
                    Content = new StringContent("{\"" + "VisitTypeResponse" + "\":" + JArray.FromObject(ee.Message).ToString() + "}", Encoding.UTF8, "application/json")
                };
            }
        }

        // POST : api/Visit/GetVisitPurpose
        /// <summary>
        /// Get Visit Purpose master list
        /// </summary>
        /// <param name="id">Visit purpose id </param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetVisitPurpose")]
        public HttpResponseMessage GetVisitPurpose(string id)
        {
            try
            {
                return new HttpResponseMessage()
                {
                    Content = new StringContent("{\"" + "VisitPurposeResponse" + "\":" + JArray.FromObject(new BAL.VisitPurposeMaster().VisitPurposeMaster_Get_GetAll(Guid.Parse(id))).ToString() + "}", Encoding.UTF8, "application/json")
                };
            }
            catch (Exception ee)
            {
                return new HttpResponseMessage()
                {
                    Content = new StringContent("{\"" + "VisitPurposeResponse" + "\":" + JArray.FromObject(ee.Message).ToString() + "}", Encoding.UTF8, "application/json")
                };
            }
        }

        // POST : api/Visit/GetCustomerType
        /// <summary>
        /// Get Customer Master list
        /// </summary>
        /// <param name="id">Customer type id</param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetCustomerType")]
        public HttpResponseMessage GetCustomerType(string id)
        {
            try
            {
                return new HttpResponseMessage()
                {
                    Content = new StringContent("{\"" + "CustomerTypeResponse" + "\":" + JArray.FromObject(new BAL.CustomerTypeMaster().CustomerTypeMaster_Get_GetAll(Guid.Parse(id))).ToString() + "}", Encoding.UTF8, "application/json")
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

        // POST : api/Visit/GetSalesmans
        /// <summary>
        /// Get salesmans list
        /// </summary>
        /// <param name="id">salesman id</param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetSalesmans")]
        public HttpResponseMessage GetSalesmans(string id)
        {
            try
            {
                return new HttpResponseMessage()
                {
                    Content = new StringContent("{\"" + "SalesmanResponse" + "\":" + JArray.FromObject(new BAL.SalesmanMaster().SalesmanMaster_Get_GetAll(Guid.Parse(id))).ToString() + "}", Encoding.UTF8, "application/json")
                };
            }
            catch (Exception ee)
            {
                return new HttpResponseMessage()
                {
                    Content = new StringContent("{\"" + "SalesmanResponse" + "\":" + JArray.FromObject(ee.Message).ToString() + "}", Encoding.UTF8, "application/json")
                };
            }
        }

        DataTable DtVisitProductDetailData = new DataTable();

        // POST : api/Visit/VisitSave
        [HttpPost]
        [Route("VisitSave")]
        public COM.ResponseClass VisitSave([FromBody] ENT.VisitMaster _VisitMaster)
        {
            DtVisitProductDetailData.Columns.AddRange(new DataColumn[1] {
                new DataColumn("ProductIDF", typeof(Guid))});
            for (int i = 0; i < _VisitMaster._VisitProductDetailData.Length; i++)
            {
                DtVisitProductDetailData.Rows.Add(_VisitMaster._VisitProductDetailData[i].ProductIDF);
            }
            try
            {
                COM.MEMBERS.SQLReturnValue mRes = new BAL.VisitMaster().VisitMaster_Insert_Update(_VisitMaster, DtVisitProductDetailData);
                return new COM.ResponseClass("1", mRes.Outval.ToString());
            }
            catch (Exception ee)
            {
                return new COM.ResponseClass("0", ee.Message);
            }
        }

        [HttpPost]
        [Route("UploadVisitDocument")]
        public COM.ResponseClass UploadVisitDocument([FromBody] ENT.VisitMasterDocument _VisitMaster)
        {
            try
            {
                if (_VisitMaster != null)
                {
                    if (_VisitMaster.vm_imagebyte != null)
                    {
                        MemoryStream ms = new MemoryStream(_VisitMaster.vm_imagebyte);
                        //Image image = Image.FromStream(ms);
                        //image.Save(@"F:\KALPI_Pro\KALPI_Pro\KalpiService\KalpiService\AppImages\imageTest.png");
                        FileStream fs = new FileStream(System.Web.Hosting.HostingEnvironment.MapPath("~/AppImages/") + _VisitMaster.vm_visitfile, FileMode.Create);
                        ms.WriteTo(fs);
                        ms.Close();
                        fs.Close();
                        fs.Dispose();
                    }

                    COM.MEMBERS.SQLReturnValue mRes = new BAL.VisitMaster().VisitDocument_Insert_Update(_VisitMaster);
                    return new COM.ResponseClass("1", mRes.Outval.ToString());
                }
                else
                {
                    return new COM.ResponseClass("0", "Something went wrong");
                }
            }
            catch (Exception ee)
            {
                return new COM.ResponseClass("0", ee.Message);
            }
        }

    }

}
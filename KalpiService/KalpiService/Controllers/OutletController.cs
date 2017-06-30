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
    [Authorize]
    [RoutePrefix("api/Retailer")]
    public class OutletController : ApiController
    {
        // POST : api/Retailer/GetDistibutor
        [HttpGet]
        [Route("GetDistibutor")]
        public HttpResponseMessage GetDistibutor()
        {
            try
            {
                return new HttpResponseMessage()
                {
                    Content = new StringContent("{\"" + "DistibutorResponse" + "\":" + JArray.FromObject(new BAL.DistributorMaster().DistributorMaster_Get_GetAll(Guid.Parse("00000000-0000-0000-0000-000000000000"))).ToString() + "}", Encoding.UTF8, "application/json")
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

        // POST : api/Retailer/SaveRetailer
        [HttpPost]
        [Route("SaveRetailer")]
        public COM.ResponseClass SaveRetailer([FromBody] ENT.RetailOutletMaster _retailOutletMaster)
        {
            try
            {
                //KalpiService.Models.RegisterBindingModel oBind = new Models.RegisterBindingModel();
                //oBind.UserName = _retailOutletMaster.rom_mobileno;
                //oBind.Mobile = _retailOutletMaster.rom_mobileno;
                //oBind.DisplayName = _retailOutletMaster.rom_name;
                //oBind.Email = _retailOutletMaster.rom_emailid;
                //oBind.UserType = COM.Enumration.UserType.Retailer;
                //AccountController obj = new AccountController();
                //string UserID = obj.RegisterUsers(oBind).Result;

                COM.MEMBERS.SQLReturnValue mRes = new BAL.RetailOutletMaster().RetailOutletMaster_Insert_Update_Service(_retailOutletMaster);
                return new COM.ResponseClass("1", mRes.Outval.ToString());
            }
            catch (Exception ee)
            {
                return new COM.ResponseClass("0", ee.Message);
            }
        }

        //// POST : api/Retailer/OutletImage
        //[HttpPost]
        //[Route("OutletImage")]
        //public COM.ResponseClass OutletImage(byte[] f, string fileName, string outletid, int iType)
        //{
        //    try
        //    {
        //        MemoryStream ms = new MemoryStream(f);
        //        FileStream fs = new FileStream(System.Web.Hosting.HostingEnvironment.MapPath("~/AppImages/") + fileName, FileMode.Create);
        //        ms.WriteTo(fs);
        //        ms.Close();
        //        fs.Close();
        //        fs.Dispose();

        //        COM.MEMBERS.SQLReturnValue mRes = new BAL.RetailOutletMaster().RetailOutletMaster_UploadImage(Guid.Parse(outletid), fileName, iType);
        //        return new COM.ResponseClass("1", mRes.Outval.ToString());
        //    }
        //    catch (Exception ee)
        //    {
        //        return new COM.ResponseClass("0", ee.Message);
        //    }
        //}

        /// <summary>  
        /// Upload Document.....  
        /// </summary>        
        /// <returns></returns>  
        //[HttpPost]
        //[Route("api/DocumentUpload/MediaUpload")]
        //public async Task<HttpResponseMessage> MediaUpload()
        //{
        //    // Check if the request contains multipart/form-data.  
        //    if (!Request.Content.IsMimeMultipartContent())
        //    {
        //        throw new HttpResponseException(HttpStatusCode.UnsupportedMediaType);
        //    }

        //    var provider = await Request.Content.ReadAsMultipartAsync<InMemoryMultipartFormDataStreamProvider>(new InMemoryMultipartFormDataStreamProvider());
        //    //access form data  
        //    NameValueCollection formData = provider.FormData;
        //    //access files  
        //    IList<HttpContent> files = provider.Files;

        //    HttpContent file1 = files[0];
        //    var thisFileName = file1.Headers.ContentDisposition.FileName.Trim('\"');

        //    ////-------------------------------------For testing----------------------------------  
        //    //to append any text in filename.  
        //    //var thisFileName = file1.Headers.ContentDisposition.FileName.Trim('\"') + DateTime.Now.ToString("yyyyMMddHHmmssfff"); //ToDo: Uncomment this after UAT as per Jeeevan  

        //    //List<string> tempFileName = thisFileName.Split('.').ToList();  
        //    //int counter = 0;  
        //    //foreach (var f in tempFileName)  
        //    //{  
        //    //    if (counter == 0)  
        //    //        thisFileName = f;  

        //    //    if (counter > 0)  
        //    //    {  
        //    //        thisFileName = thisFileName + "_" + DateTime.Now.ToString("yyyyMMddHHmmssfff") + "." + f;  
        //    //    }  
        //    //    counter++;  
        //    //}  

        //    ////-------------------------------------For testing----------------------------------  

        //    string filename = String.Empty;
        //    Stream input = await file1.ReadAsStreamAsync();
        //    string directoryName = String.Empty;
        //    string URL = String.Empty;
        //    //string tempDocUrl = WebConfigurationManager.AppSettings["DocsUrl"];

        //    if (formData["ClientDocs"] == "ClientDocs")
        //    {
        //        var path = HttpRuntime.AppDomainAppPath;
        //        directoryName = System.IO.Path.Combine(path, "AppImages");
        //        filename = System.IO.Path.Combine(directoryName, thisFileName);

        //        //Deletion exists file  
        //        if (File.Exists(filename))
        //        {
        //            File.Delete(filename);
        //        }

        //        //string DocsPath = tempDocUrl + "/" + "AppImages" + "/";
        //        //URL = DocsPath + thisFileName;

        //         URL = HttpContext.Current.Server.MapPath("~/AppImages/" + thisFileName);

        //    }


        //    //Directory.CreateDirectory(@directoryName);  
        //    using (Stream file = File.OpenWrite(filename))
        //    {
        //        input.CopyTo(file);
        //        //close file  
        //        file.Close();
        //    }

        //    var response = Request.CreateResponse(HttpStatusCode.OK);
        //    response.Headers.Add("DocsUrl", URL);
        //    return response;
        //}

   // }


    // POST : api/Retailer/OutletImage
    [HttpPost]
        [Route("OutletImage")]
        [AllowAnonymous]
        public List<COM.ResponseClass> OutletImage()
        {
            List<COM.MEMBERS.SQLReturnValue> mResult = new List<WS.Framework.Common.MEMBERS.SQLReturnValue>();
            List<COM.ResponseClass> mResClass = new List<COM.ResponseClass>();
            string PostedFileName = string.Empty;
            try
            {
                var httpRequest = HttpContext.Current.Request;
                int iType = 1;
                string outletid = HttpContext.Current.Request.Form["outletid"];
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
                            mResClass.Add(new COM.ResponseClass("0", "Please Upload image of type .jpg,.gif,.png."));
                          
                        }
                        else if (postedFile.ContentLength > MaxContentLength)
                        {
                            mResClass.Add(new COM.ResponseClass("0", "Please Upload a file upto 1 mb."));
                        }
                        else
                        {
                            PostedFileName = postedFile.FileName + extension;
                            var filePath = HttpContext.Current.Server.MapPath("~/AppImages/" + postedFile.FileName + extension);
                            postedFile.SaveAs(filePath);


                        }
                        COM.MEMBERS.SQLReturnValue mRes = new BAL.RetailOutletMaster().RetailOutletMaster_UploadImage(Guid.Parse(outletid), PostedFileName, iType);
                        mResClass.Add(new COM.ResponseClass("1", mRes.Outval.ToString()));
                    }
                }
                ++iType;
            }
            catch (Exception ee)
            {
                mResClass.Add(new COM.ResponseClass("0", ee.Message));
            }
            return mResClass;
        }

 
    }


}
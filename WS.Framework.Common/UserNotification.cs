using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;
using System.Text;

namespace WS.Framework.Common
{
    public class UserNotification
    {
        public String PushNotification(string deviceId, string message)
        {
            try
            {
                var applicationID = "AAAAeTit5yA:APA91bGVN_l5IDxPXM_7DeO5VPJ14uAjwa9cz2XW5gsku1HvgWP0PvrBqgaruGDYj2njY0uJW2E8HzlMK1bKcVHDQYS62LjS-e0DvtRk7Mw9vcAMDfbiom-lxCVukJ_fasCZVdbyqO2z";
                var senderId = "520641963808";

                WebRequest tRequest = WebRequest.Create("https://fcm.googleapis.com/fcm/send");
                tRequest.Method = "post";
                tRequest.ContentType = "application/json";
                var data = new
                {
                    to = deviceId,
                    notification = new { collapse_key = "score_update", body = message, title = "Test", sound = "default" }
                };
                //score = "4x8",  //5x1
                var json = JsonConvert.SerializeObject(data);
                Byte[] byteArray = Encoding.UTF8.GetBytes(json);
                tRequest.Headers.Add(string.Format("Authorization: key={0}", applicationID));
                tRequest.Headers.Add(string.Format("Sender: id={0}", senderId));
                tRequest.ContentLength = byteArray.Length;
                using (Stream dataStream = tRequest.GetRequestStream())
                {
                    dataStream.Write(byteArray, 0, byteArray.Length);
                    using (WebResponse tResponse = tRequest.GetResponse())
                    {
                        using (Stream dataStreamResponse = tResponse.GetResponseStream())
                        {
                            using (StreamReader tReader = new StreamReader(dataStreamResponse))
                            {
                                String sResponseFromServer = tReader.ReadToEnd();
                                string str = sResponseFromServer;
                            }
                        }
                    }
                }
            }

            catch (Exception ex)
            {

                string str = ex.Message;

            }
            return "1";
        }
        public String SendFCM(string deviceId, string message, string Title, object dataJson, string appname)
        {
            if (dataJson == null)
            {
                dataJson = new object();
            }
            string YOUR_FIREBASE_SERVER_KEY = string.Empty;
            if (appname == "kalpiAdmin")
                YOUR_FIREBASE_SERVER_KEY = "AAAAJbq010Q:APA91bHv1uyl-oyKrFAdTDXst_OjDWvfLojud23gRIDtYVP2yMtnU3UlkjQ-UtlsTQgr0Ym2_gL0iamYM5gMiR8VP13msWV1IVNW_v3maEFvHicLx97LP_aquaILU4Y8ysEmYhcQtEQj";

            else if (appname == "kalpi")
                YOUR_FIREBASE_SERVER_KEY = "AAAAeTit5yA:APA91bGVN_l5IDxPXM_7DeO5VPJ14uAjwa9cz2XW5gsku1HvgWP0PvrBqgaruGDYj2njY0uJW2E8HzlMK1bKcVHDQYS62LjS-e0DvtRk7Mw9vcAMDfbiom-lxCVukJ_fasCZVdbyqO2z";

            var result = "-1";
            var webAddr = "https://fcm.googleapis.com/fcm/send";

            var httpWebRequest = (HttpWebRequest)WebRequest.Create(webAddr);
            httpWebRequest.ContentType = "application/json";
            //httpWebRequest.Headers.Add("Authorization: key", YOUR_FIREBASE_SERVER_KEY);
            httpWebRequest.Headers.Add(string.Format("Authorization: key={0}", YOUR_FIREBASE_SERVER_KEY));
            //httpWebRequest.Headers.Add("Authorization:key=" + YOUR_FIREBASE_SERVER_KEY);
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                //var data = new
                //{
                //    to = deviceId,
                //    notification = new
                //    {
                //        collapse_key = "score_update",
                //        body = message,
                //        title = Title,
                //        sound = "default",
                //        Details = dataJson
                //    },
                //};


                var data = new
                {
                    to = deviceId,
                    notification = new
                    {
                        collapse_key = "score_update",
                        body = message,
                        title = Title,
                        sound = "default",
                        //    data = dataJson
                    },
                    //data = dataJson
                };
                //score = "4x8",  //5x1
                var json = JsonConvert.SerializeObject(data);
                streamWriter.Write(json);
                streamWriter.Flush();
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                result = streamReader.ReadToEnd();
            }

            return result;
        }
    }
}

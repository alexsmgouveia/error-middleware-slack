using Newtonsoft.Json;
using System;
using System.Net;
using System.Text;

namespace SlackMiddlewareAPI.Util
{
    public static class WebClientMessage
    { 
        public static void SendObject<T>(Uri uri, T @object, string httpMethod = "POST", string contentType = "application/x-www-form-urlencoded")
        {
            using (WebClient client = new WebClient())
            {
                client.Headers.Add("Content-Type", contentType);

                var payload = JsonConvert.SerializeObject(@object);
                byte[] request = Encoding.UTF8.GetBytes("payload=" + payload);
                _ = client.UploadData(uri, httpMethod, request); 

            }

        }

    }
}

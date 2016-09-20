using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace MeuTioOperouREST
{
    public class RestGateway
    {
        public string ContentType { get; set; }
        public int StatusCode { get; set; }
        public string GetContent(string path)
        {
            try
            {
                var request = (HttpWebRequest)WebRequest.Create(path);
                var response = (HttpWebResponse)request.GetResponse();
                ContentType = response.ContentType;
                StatusCode = (int)response.StatusCode;
                
                using (var stream = response.GetResponseStream())
                {
                    var reader = new StreamReader(stream, Encoding.UTF8);
                    return reader.ReadToEnd();
                }
            }
            catch (WebException we)
            {
                StatusCode = (int)(((HttpWebResponse)we.Response).StatusCode);
                throw we;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        public string SetContent(string path, string postData)
        {
            try
            {
                var request = WebRequest.Create(path);
                request.Method = "POST";
                var byteArray = Encoding.UTF8.GetBytes(postData);
                request.ContentType = "application/json";
                request.ContentLength = byteArray.Length;

                using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                {
                    streamWriter.Write(postData);
                }

                var httpResponse = (HttpWebResponse)request.GetResponse();
                ContentType = httpResponse.ContentType;
                StatusCode = (int)httpResponse.StatusCode;
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var responseText = streamReader.ReadToEnd();
                    return responseText;
                }
            }
            catch (WebException we)
            {
                StatusCode = (int)(((HttpWebResponse)we.Response).StatusCode);
                throw we;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

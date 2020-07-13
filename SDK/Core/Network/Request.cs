using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Net;
using System.Text;
using System.Collections.Generic;

using Base;

namespace Core
{
    public enum RequestType
    {
        None,
        Get,
        Post,
        Put,
        Delete
    };

    public static class Request
    {
        public static String HttpUrl { get; set; } = String.Empty;
        public static async Task<JObject> HttpRequest(JObject data, RequestType methodtype, String url)
        {
            JObject jsonData = null;
            switch (methodtype)
            {
                case RequestType.Get:
                    {
                        jsonData = await HttpGet(url);
                    }
                    break;
                case RequestType.Post:
                    {
                        jsonData = await HttpPost(data, url);
                    }
                    break;
                default:
                    break;
            }

            return jsonData;
        }

        public static async Task<JObject> HttpGet(String url)
        {
            initClient();
            JObject jsonData = new JObject();
            using (HttpResponseMessage response = await httpClient.GetAsync(url))
            {
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    String strType = response.Content.Headers.ContentEncoding.ToString();
                    String strJson = "";
                    if (strType.Contains("gzip"))
                    {
                        byte[] byteArray = await response.Content.ReadAsByteArrayAsync();
                        strJson = ReadGzip(byteArray);
                    }
                    else
                    {
                        strJson = await response.Content.ReadAsStringAsync();
                    }
                    jsonData = CoreAPI.Deserialize<JObject>(strJson);
                    if (jsonData["result"] != null)
                    {
                        String code = jsonData["result"].ToString();
                        String msg = jsonData["msg"].ToString();
                        if (code != "0")
                        {
                            Logger.LogError("NetError" + code + msg + url);
                            throw new Exception("NetError" + code + url);
                        }
                    }
                }
                else
                {
                    String strError = response.StatusCode.GetHashCode().ToString() + "," + response.ReasonPhrase;
                    Logger.LogError(strError);
                    throw new Exception(strError);
                }
            }
            return jsonData;
        }


        public static async Task<JObject> HttpPost(JObject input, String url)
        {
            initClient();
            JObject jsonData = new JObject();
            HttpContent content = new StringContent(input.ToString(), Encoding.UTF8, "application/json");
            using (HttpResponseMessage response = await httpClient.PostAsync(url, content))
            {
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    String strType = response.Content.Headers.ContentEncoding.ToString();
                    String strJson = "";
                    if (strType.Contains("gzip"))
                    {
                        byte[] byteArray = await response.Content.ReadAsByteArrayAsync();
                        strJson = ReadGzip(byteArray);
                    }
                    else
                    {
                        strJson = await response.Content.ReadAsStringAsync();
                    }
                    jsonData = CoreAPI.Deserialize<JObject>(strJson);
                    //String code = jsonData["result"].ToString();
                    //String msg = jsonData["msg"].ToString();
                    //if (code != "0")
                    //{
                    //    Logger.LogError("NetError" + code + msg + url);
                    //    throw new Exception(msg);
                    //}
                }
                else
                {
                    String strError = response.StatusCode.GetHashCode().ToString() + "," + response.RequestMessage;
                    Logger.LogError(strError);
                    throw new Exception(strError);
                }
            }
            return jsonData;
        }

        public static async Task<JObject> HttpPost(String url, HttpContent content)
        {
            initClient();
            dynamic jsonData = null;
            using (HttpResponseMessage response = await httpClient.PostAsync(url, content))
            {
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    String strType = response.Content.Headers.ContentEncoding.ToString();
                    String strJson = "";
                    if (strType.Contains("gzip"))
                    {
                        byte[] byteArray = await response.Content.ReadAsByteArrayAsync();
                        strJson = ReadGzip(byteArray);
                    }
                    else
                    {
                        strJson = await response.Content.ReadAsStringAsync();
                    }
                    jsonData = CoreAPI.Deserialize<JObject>(strJson);
                    String code = jsonData["result"].ToString();
                    String msg = jsonData["msg"].ToString();
                    if (code != "0")
                    {
                        Logger.LogError("NetError" + code + msg + url);
                        throw new Exception("NetError" + code + url);
                    }
                }
                else
                {
                    String strError = response.StatusCode.GetHashCode().ToString() + "," + response.ReasonPhrase;
                    Logger.LogError(strError);
                    throw new Exception(strError);
                }
            }
            return jsonData;
        }

        /// <summary>
        /// 上传文件到远程服务器
        /// </summary>
        /// <param name="url">上传路径</param>
        /// <param name="files">文件路径数组</param>
        /// <param name="nvc">同文件一同上传的表单文本域及值</param>
        public static string UploadFilesToRemoteUrl(string url, string file)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                string boundary = "----------------" + DateTime.Now.Ticks.ToString("x");

                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
                httpWebRequest.ContentType = "multipart/form-data; boundary=" + boundary;
                httpWebRequest.Method = "POST";
                httpWebRequest.KeepAlive = true;
                httpWebRequest.Credentials = System.Net.CredentialCache.DefaultCredentials;

                Stream memStream = new System.IO.MemoryStream();

                string formdataTemplate = "\r\n--" + boundary + "\r\nContent-Disposition: form-data; name=\"{0}\"\r\n\r\n{1}";
                /*foreach (string key in nvc.Keys)
                {
                    string formitem = string.Format(formdataTemplate, key, nvc[key]);
                    sb.Append(formitem);
                    byte[] formitembytes = System.Text.Encoding.UTF8.GetBytes(formitem);
                    memStream.Write(formitembytes, 0, formitembytes.Length);
                }*/

                string headerTemplate = "\r\n--" + boundary + "\r\nContent-Disposition: form-data; name=\"{0}\"; filename=\"{1}\"\r\nContent-Type: application/octet-stream\r\n\r\n";

                // 逐个将文件内容写入流

                FileInfo fi = new FileInfo(file);

                // 写入文件开始标记
                string header = string.Format(headerTemplate, "file", fi.Name);
                sb.Append(header);
                byte[] headerbytes = System.Text.Encoding.UTF8.GetBytes(header);
                memStream.Write(headerbytes, 0, headerbytes.Length);

                FileStream fileStream = new FileStream(fi.FullName, FileMode.Open, FileAccess.Read);



                byte[] buffer = new byte[1024 * 1024 * 8];//每次上传10M

                int bytesRead = 0;
                // 写入文件内容
                while ((bytesRead = fileStream.Read(buffer, 0, buffer.Length)) != 0)
                {
                    memStream.Write(buffer, 0, bytesRead);
                }
                fileStream.Close();
                sb.Append("\r\n--" + boundary + "--\r\n");
                // 将结束标记写入内存流
                byte[] boundarybytes = System.Text.Encoding.ASCII.GetBytes("\r\n--" + boundary + "--\r\n");
                memStream.Write(boundarybytes, 0, boundarybytes.Length);

                httpWebRequest.ContentLength = memStream.Length;//流总大小

                Stream requestStream = httpWebRequest.GetRequestStream();

                memStream.Position = 0;
                byte[] tempBuffer = new byte[memStream.Length];
                memStream.Read(tempBuffer, 0, tempBuffer.Length);
                memStream.Close();
                requestStream.Write(tempBuffer, 0, tempBuffer.Length);
                requestStream.Close();

                WebResponse webResponse = httpWebRequest.GetResponse();
                Stream stream = webResponse.GetResponseStream();
                StreamReader reader = new StreamReader(stream);
                string ret = reader.ReadToEnd();

                return ret;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return "";
        }

        public static async Task<String> HttpDownload(String url)
        {
            initClient();
            String strFilePath = "";
            FileStream fileStream = null;
            Directory.CreateDirectory(Rigel.BIMTempPath);  //创建临时文件目录
            try
            {
                using (HttpClient httpClient = new HttpClient())
                {
                    httpClient.Timeout = new TimeSpan(0, 1, 0);

                    String strFileName = "";
                    HttpResponseMessage response = await httpClient.GetAsync(url);
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        var stream = response.Content.ReadAsStreamAsync().Result;
                        String strHeads = response.Content.Headers.ToString();
                        /* if (response.Content.Headers.ContentDisposition != null)
                         {
                             strFileName = response.Content.Headers.ContentDisposition.FileName;
                             strFileName = strFileName.Replace("\"", "");
                             strFileName = strFileName.Replace("\r\n", "");
                         }
                         else if(strHeads != null && strHeads.Contains("filename="))
                         {
                             int index = strHeads.IndexOf("filename=");
                             String strName = strHeads.Substring(index + 9);
                             byte[] buffer = Encoding.GetEncoding("iso-8859-1").GetBytes(strName);
                             strFileName = Encoding.UTF8.GetString(buffer);
                             strFileName = strFileName.Replace("\r\n", "");
                         }
                         else
                             strFileName = Path.GetFileName(url);*/

                        //如果最终都没有获取到文件名
                        /*                     if(String.IsNullOrEmpty(strHeads))
                                             {
                                                 throw new Exception("下载文件的文件名称获取失败！");
                                             }*/

                        byte[] strBuf = new byte[stream.Length];
                        stream.Read(strBuf, 0, strBuf.Length);

                        strFilePath = Rigel.BIMTempPath + GetTimeStamp() + ".pptx";
                        if (System.IO.File.Exists(strFilePath))
                        {
                            //判断是否被占用
                            if (!UtilAPI.IsUsing(strFilePath))
                            {
                                File.Delete(strFilePath);    //存在则删除
                            }
                        }

                        fileStream = new FileStream(strFilePath, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
                        await fileStream.WriteAsync(strBuf, 0, strBuf.Length);
                    }
                    else
                    {
                        String strError = response.StatusCode.GetHashCode().ToString() + "," + response.RequestMessage;
                        Logger.LogError(strError);
                        throw new Exception(strError);
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.LogError(ex.ToString());
                return strFilePath;
            }
            finally
            {
                if (fileStream != null)
                {
                    fileStream.Close();
                }
            }
            return strFilePath;
        }


        public static string GetTimeStamp()
        {
            TimeSpan ts = DateTime.Now - new DateTime(1970, 1, 1, 0, 0, 0, 0);
            return Convert.ToInt64(ts.TotalSeconds).ToString();
        }
        // 从文件头得到远程文件的长度
        private static long GetHttpLength(String url)
        {
            long length = 0;

            try
            {
                HttpWebRequest request = HttpWebRequest.Create(url) as HttpWebRequest;// 打开网络连接
                HttpWebResponse response = request.GetResponse() as HttpWebResponse;

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    length = response.ContentLength;// 从文件头得到远程文件的长度
                }

                response.Close();
                return length;
            }
            catch
            {
                Logger.LogError("获取文件长度出错");
                return length;
            }

        }

        private static void initClient()
        {
            if (httpClient == null)
            {
                //设置HttpClientHandler的AutomaticDecompression
                var handler = new HttpClientHandler() { AutomaticDecompression = DecompressionMethods.None };

                httpClient = new HttpClient(handler);
                httpClient.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.Timeout = new TimeSpan(0, 1, 0);
            }
        }

        public static string ReadGzip(byte[] bytes, string encoding = "utf-8")
        {
            string result = string.Empty;
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                using (System.IO.Compression.GZipStream decompressedStream = new System.IO.Compression.GZipStream(
                    ms, System.IO.Compression.CompressionMode.Decompress))
                {
                    using (StreamReader sr = new StreamReader(decompressedStream, Encoding.GetEncoding(encoding)))
                    {
                        result = sr.ReadToEnd();
                    }
                }
            }
            return result;
        }

        private static HttpClient httpClient = null;

    }
}
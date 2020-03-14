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
            JObject jsonData = new JObject();
            using (HttpResponseMessage response = await httpClient.GetAsync(url))
            {
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    String strType = response.Content.Headers.ContentEncoding.ToString();
                    String strJson = "";
                    if(strType.Contains("gzip"))
                    {
                        byte[] byteArray = await response.Content.ReadAsByteArrayAsync();
                        strJson = ReadGzip(byteArray);
                    }
                    else
                    {
                        strJson = await response.Content.ReadAsStringAsync();
                    }
                    jsonData = CoreAPI.Deserialize<JObject>(strJson);
                    if(jsonData["code"] != null)
                    {
                        String code = jsonData["code"].ToString();
                        String msg = jsonData["message"].ToString();
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
                    String code = jsonData["code"].ToString();
                    String msg = jsonData["message"].ToString();
                    if (code != "0")
                    {
                        Logger.LogError("NetError" + code + msg + url);
                        throw new Exception(msg);
                    }
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
                    String code = jsonData["code"].ToString();
                    String msg = jsonData["message"].ToString();
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

        public static bool HttpLogin(String strUser, String strPass)
        {
            List<KeyValuePair<string, string>> param = new List<KeyValuePair<string, string>>();
            param.Add(new KeyValuePair<string, string>("account", strUser));
            param.Add(new KeyValuePair<string, string>("password", strPass));

            /*
            string strURL = String.Format("{0}/identification/login", Global.HttpUrl);
            using (HttpClient client = new HttpClient())
            {
                HttpContent content = new FormUrlEncodedContent(param);
                HttpResponseMessage response = client.PostAsync(strURL, content).Result;
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    string responseContent = response.Content.ReadAsStringAsync().Result;
                    var stream = response.Content.ReadAsStreamAsync().Result;
                    JObject jsonData = CoreAPI.Deserialize<JObject>(responseContent);

                    if (jsonData["success"] != null && !jsonData["success"].ToObject<bool>())
                    {
                        String str = jsonData["errorMsg"].ToString();
                        throw new Exception(str);
                    }
                    Global.UserToken = jsonData["cloudToken"].ToString();
                    Global.UserName = jsonData["realname"].ToString();
                    Global.UserID = jsonData["id"].ToString();
                }
                else
                {
                    String strError = response.StatusCode.GetHashCode().ToString() + "," + response.ReasonPhrase;
                    Logger.LogError(strError);
                    throw new Exception(strError);
                }
            }
            */
            initClient();
            return true;
        }

        public static bool HttpLogout()
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Add(
               new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("endpoint", "WEB");
                client.Timeout = new TimeSpan(0, 1, 0);

                String strAPI = String.Format("{0}/logout", Global.HttpUrl);
                using (HttpResponseMessage response = client.GetAsync(strAPI).Result)
                {
                    httpClient.Dispose();
                    httpClient = null;
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        return true;
                    }
                    else
                    {
                        String strError = response.StatusCode.GetHashCode().ToString() + "," + response.ReasonPhrase;
                        Logger.LogError(strError);
                        return false;
                    }
                }
            }
        }

        //下载文件
        public static async Task<String> HttpDownload(String url)
        {
            String strFilePath = "";
            FileStream fileStream = null;
            Directory.CreateDirectory(Global.BIMTempPath);  //创建临时文件目录

            try
            {
                using (HttpClient httpClient = new HttpClient())
                {
                    httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    httpClient.DefaultRequestHeaders.Add("Accept-Charset", "iso-8859-1");
                    httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + Global.UserToken);
                    httpClient.DefaultRequestHeaders.Add(".ENDPOINT", "WEB");
                    httpClient.Timeout = new TimeSpan(0, 1, 0);
                    
                    String strFileName = "";
                    HttpResponseMessage response = await httpClient.GetAsync(url);
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        var stream = response.Content.ReadAsStreamAsync().Result;
                        String strHeads = response.Content.Headers.ToString();
                        if (response.Content.Headers.ContentDisposition != null)
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
                            strFileName = Path.GetFileName(url);

                        //如果最终都没有获取到文件名
                        if(String.IsNullOrEmpty(strHeads))
                        {
                            throw new Exception("下载文件的文件名称获取失败！");
                        }

                        byte[] strBuf = new byte[stream.Length];
                        stream.Read(strBuf, 0, strBuf.Length);

                        strFilePath = Global.BIMTempPath + strFileName;
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

        //下载图片
        public static async Task<String> HttpDownloadImage(String fileID, String category)
        {
            if (category.Contains("security") || category.Contains("inspection"))
            {
                category = "safe";
            }
            else if (category.Contains("quality"))
            {
                category = "quality";
            }
            fileID = fileID.Replace("/", "@");
            //bim5d_product/api/v1/projects/${projectId}/anonymous/download/file/${fileId}?category=${category}
            String strAPI = "{0}/api/v1/projects/{1}/anonymous/download/file/{2}?category={3}";
            String strUrl = String.Format(strAPI, Global.HttpUrl, Global.ProjectID, fileID, category);

            String strFilePath = "";
            Directory.CreateDirectory(Global.BIMTempPath);  //创建临时文件目录
            
            FileStream fileStream = null;
            try
            {
                using (HttpClient httpClient = new HttpClient())
                {
                    httpClient.DefaultRequestHeaders.Accept.Add(
                   new MediaTypeWithQualityHeaderValue("application/json"));
                    httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + Global.UserToken);
                    httpClient.DefaultRequestHeaders.Add(".ENDPOINT", "WEB");

                    httpClient.Timeout = new TimeSpan(0, 1, 0);

                    HttpResponseMessage response = await httpClient.GetAsync(strUrl);
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        String strFileName = "";
                        var stream = response.Content.ReadAsStreamAsync().Result;
                        if (response.Content.Headers.ContentDisposition != null)
                        {
                            strFileName = response.Content.Headers.ContentDisposition.FileName.Replace("mpeg4", "mp4");
                        }
                        else
                            strFileName = System.Guid.NewGuid().ToString() + ".jpg";

                        strFilePath = Global.BIMTempPath + strFileName;
                        fileStream = new FileStream(strFilePath, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);

                        byte[] strBuf = new byte[stream.Length];
                        stream.Read(strBuf, 0, strBuf.Length);
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

        //下载图片
        public static async Task<String> HttpDownloadImage(String url)
        {
            String strFilePath = "";
            Directory.CreateDirectory(Global.BIMTempPath);  //创建临时文件目录

            FileStream fileStream = null;
            try
            {
                using (HttpClient httpClient = new HttpClient())
                {
                    httpClient.DefaultRequestHeaders.Accept.Add(
                   new MediaTypeWithQualityHeaderValue("application/json"));
                    httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + Global.UserToken);
                    httpClient.DefaultRequestHeaders.Add(".ENDPOINT", "WEB");

                    httpClient.Timeout = new TimeSpan(0, 1, 0);

                    HttpResponseMessage response = await httpClient.GetAsync(url);
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        String strFileName = "";
                        var stream = response.Content.ReadAsStreamAsync().Result;
                        if (response.Content.Headers.ContentDisposition != null)
                        {
                            strFileName = response.Content.Headers.ContentDisposition.FileName.Replace("mpeg4", "mp4");
                        }
                        else
                            strFileName = System.Guid.NewGuid().ToString() + ".jpg";

                        strFilePath = Global.BIMTempPath + strFileName;
                        fileStream = new FileStream(strFilePath, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);

                        byte[] strBuf = new byte[stream.Length];
                        stream.Read(strBuf, 0, strBuf.Length);
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

        //下载文件
        public static async Task<Stream> HttpDownloadImageStream(String fileID, String category = "")
        {
            Stream imgStream = null;
            if(category.Contains("security") || category.Contains("inspection"))
            {
                category = "safe";
            }
            else if(category.Contains("quality"))
            {
                category = "quality";
            }
            fileID = fileID.Replace("/", "@");
            //bim5d_product/api/v1/projects/${projectId}/anonymous/download/file/${fileId}?category=${category}
            String strAPI = "{0}/api/v1/projects/{1}/anonymous/download/file/{2}?category={3}";
            String strUrl = String.Format(strAPI, Global.HttpUrl, Global.ProjectID, fileID, category);
            try
            {
                using (HttpClient httpClient = new HttpClient())
                {
                    httpClient.DefaultRequestHeaders.Accept.Add(
                   new MediaTypeWithQualityHeaderValue("application/json"));
                    httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + Global.UserToken);
                    httpClient.DefaultRequestHeaders.Add(".ENDPOINT", "WEB");

                    httpClient.Timeout = new TimeSpan(0, 1, 0);

                    HttpResponseMessage response = await httpClient.GetAsync(strUrl);
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        int flag = fileID.LastIndexOf('/');
                        if (flag > 0)
                        {
                            flag += 1;
                            fileID = fileID.Substring(flag, fileID.Length - flag);
                        }

                        imgStream = response.Content.ReadAsStreamAsync().Result;
                        if (response.Content.Headers.ContentDisposition != null)
                        {
                            //strFileName = response.Content.Headers.ContentDisposition.FileName;
                        }
                        
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
            }
            return imgStream;
        }

        //上传文件
        public static async Task<dynamic> httpUpload(String url, String filePath)
        {
            // 时间戳，用做boundary
            string timeStamp = DateTime.Now.Ticks.ToString("x");
            //根据uri创建HttpWebRequest对象
            HttpWebRequest httpReq = (HttpWebRequest)WebRequest.Create(new Uri(url));
            httpReq.Method = "POST";
            String temp = String.Format("Bearer {0}", Global.UserToken);
            httpReq.Headers.Add("Authorization", temp);
            httpReq.Headers.Add("CLIENTVERSION", "V1");

            httpReq.AllowWriteStreamBuffering = false; //对发送的数据不使用缓存
            httpReq.Timeout = 10000;  //设置获得响应的超时时间（300秒）
            httpReq.ContentType = "multipart/form-data; boundary=" + timeStamp;

            //文件
            FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            BinaryReader binaryReader = new BinaryReader(fileStream);

            //头信息
            string boundary = "--" + timeStamp;
            string dataFormat = boundary + "\r\nContent-Disposition: form-data; name={0};filename={1};projectID={2}\r\nContent-Type:application/octet-stream\r\n\r\n";
            string header = string.Format(dataFormat, "file", Path.GetFileName(filePath), Global.ProjectID);
            byte[] postHeaderBytes = Encoding.UTF8.GetBytes(header);

            //结束边界
            byte[] boundaryBytes = Encoding.ASCII.GetBytes("\r\n--" + timeStamp + "--\r\n");

            long length = fileStream.Length + postHeaderBytes.Length + boundaryBytes.Length;

            httpReq.ContentLength = length;//请求内容长度

            string returnValue = "";
            try
            {
                //每次上传4k
                int bufferLength = 409600;
                byte[] buffer = new byte[bufferLength];

                //已上传的字节数
                long offset = 0;
                int size = binaryReader.Read(buffer, 0, bufferLength);
                Stream postStream = httpReq.GetRequestStream();

                //发送请求头部消息
                postStream.Write(postHeaderBytes, 0, postHeaderBytes.Length);
                int nCurrentSize = 0;
                nCurrentSize += size;
                while (size > 0)
                {
                    postStream.Write(buffer, 0, size);
                    offset += size;
                    size = binaryReader.Read(buffer, 0, bufferLength);
                    nCurrentSize += size;
                }

                //添加尾部边界
                postStream.Write(boundaryBytes, 0, boundaryBytes.Length);
                postStream.Close();

                //获取服务器端的响应
                using (HttpWebResponse response = httpReq.GetResponse() as HttpWebResponse)
                {
                    Stream receiveStream = response.GetResponseStream();
                    StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8);
                    returnValue = readStream.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                Logger.LogError(ex.ToString());
                Console.WriteLine("文件传输异常：" + ex.ToString());
            }
            finally
            {
                fileStream.Close();
                binaryReader.Close();
            }
            JObject jsonData = CoreAPI.Deserialize<JObject>(returnValue);
            return jsonData;
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
                //httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + Global.UserToken);
                //httpClient.DefaultRequestHeaders.Add("endpoint", "WEB");
                //httpClient.DefaultRequestHeaders.AcceptEncoding.Add(new StringWithQualityHeaderValue("GZIP"));

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
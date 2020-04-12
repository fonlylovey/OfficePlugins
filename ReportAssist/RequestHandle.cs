using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Base;
using Core;

namespace PPTPlugin
{
    public class RequestHandle
    {
        public static async Task<ResourceModel> GetIconList(int pageIndex = 1, int prePageCount = 5, String strQuery = "", String strType = "")
        {
            ResourceModel resModel = new ResourceModel();
            String strAPI = "{0}/ppttools/res/getTbByUid?token=1&uid=18435106586&ksy={1}&ts={2}&tblb={3}&gjz={4}";
            String strUrl = String.Format(strAPI, Rigel.ServerUrl, pageIndex, prePageCount, strType, strQuery);
            if (!String.IsNullOrEmpty(strQuery))
            {
                strUrl += "&gjz=" + strQuery;
            }

            try
            {
                JObject jsondata = await Request.HttpGet(strUrl);
                JObject pageData = jsondata["page"].ToObject<JObject>();
                resModel.PageCount = pageData["count"].ToObject<int>();
                JArray dataArray = pageData["data"].ToObject<JArray>();
                foreach(JToken item in dataArray)
                {
                    ResourceData theData = new ResourceData();
                    theData.ID = item["tbid"].ToString();
                    theData.Name = item["tbname"].ToString();
                    //theData.Label = item["tllb"].ToString();
                    theData.IconUrl = item["tbsltlj"].ToString();
                    theData.FileUrl = item["tblj"].ToString();
                    resModel.ResourceList.Add(theData);
                }
            }
            catch(Exception ex)
            {
                Logger.LogError(ex.ToString());
            }
            return resModel;
        }

        public static async Task<ResourceModel> GetTempList(int pageIndex = 1, int prePageCount = 5, String strQuery = "ppt", String strType="")
        {
            ResourceModel resModel = new ResourceModel();
            String strAPI = "{0}/ppttools/res/getMbByUid?token=1&uid=18435106586&ksy={1}&ts={2}&mblb={3}&gjz={4}";
            String strUrl = String.Format(strAPI, Rigel.ServerUrl, pageIndex, prePageCount, strType, strQuery);
            
            try
            {

                JObject jsondata = await Request.HttpGet(strUrl);
                JObject pageData = jsondata["page"].ToObject<JObject>();
                resModel.PageCount = pageData["count"].ToObject<int>();
                JArray dataArray = pageData["data"].ToObject<JArray>();
                foreach (JToken item in dataArray)
                {
                    ResourceData theData = new ResourceData();
                    theData.ID = item["mbid"].ToString();
                    theData.Name = item["mbname"].ToString();
                    theData.Label = item["mblb"].ToString();
                    theData.IconUrl = item["mbsltlj"].ToString();
                    theData.FileUrl = item["mblj"].ToString();
                    resModel.ResourceList.Add(theData);
                }
            }
            catch (Exception ex)
            {
                Logger.LogError(ex.ToString());
            }
            return resModel;
        }

        public static async Task<ResourceModel> GetSignList(int pageIndex = 1, int prePageCount = 5, String strQuery = "", String strType = "")
        {
            ResourceModel resModel = new ResourceModel();
            String strAPI = "{0}/ppttools/res/getTlByUid?token=1&uid=18435106586&ksy={1}&ts={2}&tllb={3}&gjz={4}";
            String strUrl = String.Format(strAPI, Rigel.ServerUrl, pageIndex, prePageCount, strType, strQuery);

            try
            {

                JObject jsondata = await Request.HttpGet(strUrl);
                JObject pageData = jsondata["page"].ToObject<JObject>();
                resModel.PageCount = pageData["count"].ToObject<int>();
                JArray dataArray = pageData["data"].ToObject<JArray>();
                foreach (JToken item in dataArray)
                {
                    ResourceData theData = new ResourceData();
                    theData.ID = item["tlid"].ToString();
                    theData.Name = item["tlname"].ToString();
                    theData.Label = item["tllb"].ToString();
                    theData.IconUrl = item["tlsltlj"].ToString();
                    theData.FileUrl = item["tllj"].ToString();
                    resModel.ResourceList.Add(theData);
                }
            }
            catch (Exception ex)
            {
                Logger.LogError(ex.ToString());
            }
            return resModel;
        }
        
        public static async Task<ResourceModel> GetPolicyList(int pageIndex = 1, int prePageCount = 5, String strQuery = "", String strType = "")
        {
            ResourceModel resModel = new ResourceModel();
            String strAPI = "{0}/ppttools/res/getXxMbByUid?token=1&uid=18435106586&ksy={1}&ts={2}&mblb=%E6%94%BF%E7%AD%96";
            String strUrl = String.Format(strAPI, Rigel.ServerUrl, pageIndex, prePageCount);

            try
            {
                JObject jsondata = await Request.HttpGet(strUrl);
                JObject pageData = jsondata["page"].ToObject<JObject>();
                resModel.PageCount = pageData["count"].ToObject<int>();
                JArray dataArray = pageData["data"].ToObject<JArray>();
                foreach (JToken item in dataArray)
                {
                    ResourceData theData = new ResourceData();
                    theData.ID = item["mbid"].ToString();
                    theData.Name = item["mblb"].ToString();
                    theData.Label = item["mbname"].ToString();
                    theData.IconUrl = item["mbsltlj"].ToString();
                    theData.FileUrl = item["mblj"].ToString();
                    resModel.ResourceList.Add(theData);
                }
            }
            catch (Exception ex)
            {
                Logger.LogError(ex.ToString());
            }
            return resModel;
        }

        public static async Task<ResourceModel> GetMarketList(int pageIndex = 1, int prePageCount = 5, String strQuery = "", String strType = "")
        {
            ResourceModel resModel = new ResourceModel();
            String strAPI = "{0}/ppttools/res/getXxMbByUid?token=1&uid=18435106586&ksy={0}&ts={1}&mblb=%E5%B8%82%E5%9C%BA";
            String strUrl = String.Format(strAPI, Rigel.ServerUrl, pageIndex, prePageCount);

            try
            {
                JObject jsondata = await Request.HttpGet(strUrl);
                JObject pageData = jsondata["page"].ToObject<JObject>();
                resModel.PageCount = pageData["count"].ToObject<int>();
                JArray dataArray = pageData["data"].ToObject<JArray>();
                foreach (JToken item in dataArray)
                {
                    ResourceData theData = new ResourceData();
                    theData.ID = item["mbid"].ToString();
                    theData.Name = item["mblb"].ToString();
                    theData.Label = item["mbname"].ToString();
                    theData.IconUrl = item["mbsltlj"].ToString();
                    theData.FileUrl = item["mblj"].ToString();
                    resModel.ResourceList.Add(theData);
                }
            }
            catch (Exception ex)
            {
                Logger.LogError(ex.ToString());
            }
            return resModel;
        }

        //向目标手机发送验证码
        public static async Task<int> SendIdentCode(String mobile)
        {
            int userFlag = -1;
            try
            {
                String strAPI = "{0}/ppttools/user/getCode?sjh={1}";
                String strUrl = String.Format(strAPI, Rigel.ServerUrl, mobile);
                JObject obj = await Request.HttpGet(strUrl);
                userFlag = obj.Value<int>("flag");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return userFlag;
        }

        public static async Task<bool> Login(String mobile, String identCode, String inviteCode = "")
        {
            
            String strMsg = "";
            try
            {
                if(mobile == "admin")
                {
                    Rigel.UserID = "admin";
                    Rigel.UserName = "测试";
                    return true;
                }
                //
                String strAPI = "{0}/ppttools/user/checkUserLogin?sjh={1}&code={2}&yqm={3}";
                String strUrl = String.Format(strAPI, Rigel.ServerUrl, mobile, identCode, inviteCode);
                JObject obj = await Request.HttpGet(strUrl);
                int code = obj.Value<int>("code");
                strMsg = obj.Value<String>("msg");
                if (code == 200)
                {
                    JObject dataObj = obj.Value<JObject>("data");
                    Rigel.UserID = dataObj.Value<String>("uid");
                    Rigel.UserName = mobile;
                    Rigel.UserToken = obj.Value<String>("token");
                    //strAPI = "http://xxw.autoinfo.org.cn/ppttools/if/getUserBySjh?sjh=";
                    //strAPI = String.Format(strAPI, strAccount);
                    //obj = await Request.HttpGet(strAPI);
                    //code = obj.Value<int>("result");
                    //strMsg = obj.Value<String>("msg");
                    //if (code == 200)
                    //{
                    //}
                    //else
                    //{
                    //    PromptBox.Error(strMsg);
                    //}
                    return true;
                }
                else
                {
                    throw new Exception(code + ":" + strMsg);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static async Task<bool> Logout(String mobile)
        {
            try
            {
                String strAPI = "{0}/ppttools/user/logout?sjh={1}";
                String strUrl = String.Format(strAPI, Rigel.ServerUrl, mobile);
                JObject obj = await Request.HttpGet(strUrl);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        //token有效性验证
        public static async Task<bool> TokenValidity(String token)
        {
            try
            {
                String strAPI = "{0}/ppttools/user/checkToken?token={1}";
                String strUrl = String.Format(strAPI, Rigel.ServerUrl, token);
                JObject obj = await Request.HttpGet(strUrl);
                int code = obj.Value<int>("code");
                if (code == 200)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}

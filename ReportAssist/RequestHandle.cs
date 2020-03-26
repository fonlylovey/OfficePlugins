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
            String strUrl = @"http://60.30.69.48/ppttools/res/getTbByUid?token=1&uid=18435106586&ksy={0}&ts={1}&tblb={2}&gjz={3}";
            strUrl = String.Format(strUrl, pageIndex, prePageCount, strType, strQuery);
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
            String strUrl = @"http://60.30.69.48/ppttools/res/getMbByUid?token=1&uid=18435106586&ksy={0}&ts={1}&mblb={2}&gjz={3}";
            strUrl = String.Format(strUrl, pageIndex, prePageCount, strType, strQuery);
            
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
            String strUrl = @"http://60.30.69.48/ppttools/res/getTlByUid?token=1&uid=18435106586&ksy={0}&ts={1}&tllb={2}&gjz={3}";
            strUrl = String.Format(strUrl, pageIndex, prePageCount, strType, strQuery);
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
    }
}

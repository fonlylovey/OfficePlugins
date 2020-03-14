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
        public static async Task<List<ResourceData>> GetIconList()
        {
            List<ResourceData> list = new List<ResourceData>();
            String strUrl = @"http://60.30.69.48/ppttools/res/getTbByUid?token=1&uid=18435106586&ksy=1&ts=5&gjz=ppt&tblb=";
            try
            {
                JObject jsondata = await Request.HttpGet(strUrl);
                JArray dataArray = jsondata["data"].ToObject<JArray>();
                foreach(JToken item in dataArray)
                {
                    ResourceData theData = new ResourceData();
                    theData.ID = item["tbid"].ToString();
                    theData.Name = item["tbname"].ToString();
                    theData.Label = item["tllb"].ToString();
                    theData.IconUrl = item["tbsltlj"].ToString();
                    theData.FileUrl = item["tblj"].ToString();
                    list.Add(theData);
                }
            }
            catch(Exception ex)
            {
                Logger.LogError(ex.ToString());
            }
            return list;
        }

        public static async Task<List<ResourceData>> GetTempList()
        {
            List<ResourceData> list = new List<ResourceData>();
            String strUrl = @"http://60.30.69.48/ppttools/res/getMbByUid?token=1&uid=18435106586&ksy=1&ts=5&gjz=ppt&mblb=";
            try
            {
                JObject jsondata = await Request.HttpGet(strUrl);
                JArray dataArray = jsondata["data"].ToObject<JArray>();
                foreach (JToken item in dataArray)
                {
                    ResourceData theData = new ResourceData();
                    theData.ID = item["mbid"].ToString();
                    theData.Name = item["mbname"].ToString();
                    theData.Label = item["mblb"].ToString();
                    theData.IconUrl = item["mbsltlj"].ToString();
                    theData.FileUrl = item["mblj"].ToString();
                    list.Add(theData);
                }
            }
            catch (Exception ex)
            {
                Logger.LogError(ex.ToString());
            }
            return list;
        }

        public static async Task<List<ResourceData>> GetSignList()
        {
            List<ResourceData> list = new List<ResourceData>();
            String strUrl = @"http://60.30.69.48/ppttools/res/getTlByUid?token=1&uid=18435106586&ksy=1&ts=5&gjz=ppt&tllb=";
            try
            {
                JObject jsondata = await Request.HttpGet(strUrl);
                JArray dataArray = jsondata["data"].ToObject<JArray>();
                foreach (JToken item in dataArray)
                {
                    ResourceData theData = new ResourceData();
                    theData.ID = item["tlid"].ToString();
                    theData.Name = item["tlname"].ToString();
                    theData.Label = item["tllb"].ToString();
                    theData.IconUrl = item["tlsltlj"].ToString();
                    theData.FileUrl = item["tllj"].ToString();
                    list.Add(theData);
                }
            }
            catch (Exception ex)
            {
                Logger.LogError(ex.ToString());
            }
            return list;
        }
    }
}

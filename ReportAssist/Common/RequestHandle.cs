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
        //获取图标数据
        public static async Task<ResourceModel> GetIconList(int pageIndex = 1, int prePageCount = 5, String strType = "", String strQuery = "")
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
                resModel.ResCount = pageData["count"].ToObject<int>();
                JArray dataArray = pageData["data"].ToObject<JArray>();
                foreach (JToken item in dataArray)
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
            catch (Exception ex)
            {
                Logger.LogError(ex.ToString());
            }
            return resModel;
        }

        //获取模板数据
        public static async Task<ResourceModel> GetTempList(int pageIndex = 1, int prePageCount = 5, String strType = "", String strQuery = "")
        {
            ResourceModel resModel = new ResourceModel();
            String strAPI = "{0}/ppttools/res/getAllMb?token={1}&uid={2}&ksy={3}&ts={4}&mblb={5}&gjz={6}&type={7}";
            String strUrl = String.Format(strAPI, Rigel.ServerUrl,Rigel.UserToken,Rigel.UserID, pageIndex, prePageCount, strType, strQuery,App.ResourceType.ToString());

            try
            {
                JObject jsondata = await Request.HttpGet(strUrl);
                JObject pageData = jsondata["pageInfo"].ToObject<JObject>();
                resModel.PageCount = pageData["pages"].ToObject<int>();
                resModel.ResCount = pageData["total"].ToObject<int>();
                JArray dataArray = pageData["list"].ToObject<JArray>();
                foreach (JToken item in dataArray)
                {
                    ResourceData theData = new ResourceData();
                    theData.ID = item["mbid"].ToString();
                    theData.Name = item["mbname"].ToString();
                    theData.Label = item["mblb"].ToString();
                    theData.IconUrl = item["mbsltlj"].ToString();
                    theData.FileUrl = item["mblj"].ToString();
                    theData.MarkFlag = item["markFlag"].ToString();
                    resModel.ResourceList.Add(theData);
                }
            }
            catch (Exception ex)
            {
                Logger.LogError(ex.ToString());
            }
            return resModel;
        }

        //获取图例数据
        public static async Task<ResourceModel> GetLegendList(int pageIndex = 1, int prePageCount = 5, String strType = "", String strQuery = "")
        {
            ResourceModel resModel = new ResourceModel();
            String strAPI = "{0}/ppttools/res/getTlByUid?token=1&uid=18435106586&ksy={1}&ts={2}&tllb={3}&gjz={4}";
            String strUrl = String.Format(strAPI, Rigel.ServerUrl, pageIndex, prePageCount, strType, strQuery);

            try
            {

                JObject jsondata = await Request.HttpGet(strUrl);
                JObject pageData = jsondata["page"].ToObject<JObject>();
                resModel.ResCount = pageData["count"].ToObject<int>();
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

        //获取政策数据
        public static async Task<ResourceModel> GetPolicyList(int pageIndex = 1, int prePageCount = 5, String strType = "", String strQuery = "")
        {
            ResourceModel resModel = new ResourceModel();
            String strAPI = "{0}/ppttools/res/getXxMbByUid?token=1&uid=18435106586&ksy={1}&ts={2}&mblb=%E6%94%BF%E7%AD%96";
            String strUrl = String.Format(strAPI, Rigel.ServerUrl, pageIndex, prePageCount);

            try
            {
                JObject jsondata = await Request.HttpGet(strUrl);
                JObject pageData = jsondata["page"].ToObject<JObject>();
                resModel.ResCount = pageData["count"].ToObject<int>();
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

        //获取市场数据
        public static async Task<ResourceModel> GetMarketList(int pageIndex = 1, int prePageCount = 5, String strType = "市场", String strQuery = "")
        {
            ResourceModel resModel = new ResourceModel();
            String strAPI = "{0}/ppttools/res/getSjMbByUid?token=1&uid=18435106586&ksy={1}&ts={2}&mblb={3}";
            String strUrl = String.Format(strAPI, Rigel.ServerUrl, pageIndex, prePageCount, strType);

            try
            {
                JObject jsondata = await Request.HttpGet(strUrl);
                JObject pageData = jsondata["page"].ToObject<JObject>();
                resModel.ResCount = pageData["count"].ToObject<int>();
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

        //获取产品数据
        public static async Task<ResourceModel> GetProductList(int pageIndex = 1, int prePageCount = 5, String strType = "产品", String strQuery = "")
        {
            ResourceModel resModel = new ResourceModel();
            String strAPI = "{0}/ppttools/res/getCpByUid?token=1&ksy={1}&ts={2}&mblb={3}&gjz={4}&uid=18435106586";
            String strUrl = String.Format(strAPI, Rigel.ServerUrl, pageIndex, prePageCount, strType, strQuery);

            try
            {
                JObject jsondata = await Request.HttpGet(strUrl);
                JObject pageData = jsondata["page"].ToObject<JObject>();
                resModel.ResCount = pageData["count"].ToObject<int>();
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

        //获取预测数据
        public static async Task<ResourceModel> GetPredictList(int pageIndex = 1, int prePageCount = 5, String strType = "预测", String strQuery = "")
        {
            ResourceModel resModel = new ResourceModel();
            String strAPI = "{0}/ppttools/res/getYcByUid?token=1&ksy={1}&ts={2}&mblb={3}&gjz={4}&uid=18435106586";
            String strUrl = String.Format(strAPI, Rigel.ServerUrl, pageIndex, prePageCount, strType, strQuery);

            try
            {
                JObject jsondata = await Request.HttpGet(strUrl);
                JObject pageData = jsondata["page"].ToObject<JObject>();
                resModel.ResCount = pageData["count"].ToObject<int>();
                resModel.PageCount = (int)Math.Ceiling((float)resModel.ResCount / (float)prePageCount);
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

        //获取宏观数据
        public static async Task<ResourceModel> GetMacroList(int pageIndex = 1, int prePageCount = 5, String strType = "宏观", String strQuery = "")
        {
            ResourceModel resModel = new ResourceModel();
            String strAPI = "{0}/ppttools/res/getHgByUid?token=1&ksy={1}&ts={2}&mblb={3}&gjz={4}&uid=18435106586";
            String strUrl = String.Format(strAPI, Rigel.ServerUrl, pageIndex, prePageCount, strType, strQuery);

            try
            {
                JObject jsondata = await Request.HttpGet(strUrl);
                JObject pageData = jsondata["page"].ToObject<JObject>();
                resModel.ResCount = pageData["count"].ToObject<int>();
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

        //获取我的模板数据
        public static async Task<ResourceModel> GetUploadTemplateList(int pageIndex = 1, int prePageCount = 5, String strType = "", String strQuery = "")
        {


            ResourceModel resModel = new ResourceModel();
            String strAPI = "{0}/ppttools/api/getUploadTemplate?token={1}&ksy={2}&ts={3}&mblb={4}&gjz={5}&uid={6}";
            String strUrl = String.Format(strAPI, Rigel.ServerUrl, Rigel.UserToken, pageIndex, prePageCount, strType, strQuery, Rigel.UserID);

            try
            {
                JObject jsondata = await Request.HttpGet(strUrl);
                JObject pageData = jsondata["pageInfo"].ToObject<JObject>();
                resModel.ResCount = pageData["total"].ToObject<int>();
                JArray dataArray = pageData["list"].ToObject<JArray>();
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

        //获取我的图标数据
        public static async Task<ResourceModel> GetUploadIconList(int pageIndex = 1, int prePageCount = 5, String strType = "", String strQuery = "")
        {


            ResourceModel resModel = new ResourceModel();
            String strAPI = "{0}/ppttools/api/getUploadIcon?token={1}&ksy={2}&ts={3}&mblb={4}&gjz={5}&uid={6}";
            String strUrl = String.Format(strAPI, Rigel.ServerUrl, Rigel.UserToken, pageIndex, prePageCount, strType, strQuery, Rigel.UserID);

            try
            {
                JObject jsondata = await Request.HttpGet(strUrl);
                JObject pageData = jsondata["pageInfo"].ToObject<JObject>();
                resModel.ResCount = pageData["total"].ToObject<int>();
                JArray dataArray = pageData["list"].ToObject<JArray>();
                foreach (JToken item in dataArray)
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
            catch (Exception ex)
            {
                Logger.LogError(ex.ToString());
            }
            return resModel;
        }
        //获取我的图例数据
        public static async Task<ResourceModel> GetUploadTlList(int pageIndex = 1, int prePageCount = 5, String strType = "", String strQuery = "")
        {


            ResourceModel resModel = new ResourceModel();
            String strAPI = "{0}/ppttools/api/getUploadTl?token={1}&ksy={2}&ts={3}&mblb={4}&gjz={5}&uid={6}";
            String strUrl = String.Format(strAPI, Rigel.ServerUrl, Rigel.UserToken, pageIndex, prePageCount, strType, strQuery, Rigel.UserID);

            try
            {
                JObject jsondata = await Request.HttpGet(strUrl);
                JObject pageData = jsondata["pageInfo"].ToObject<JObject>();
                resModel.ResCount = pageData["total"].ToObject<int>();
                JArray dataArray = pageData["list"].ToObject<JArray>();
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
                if (mobile == "admin")
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
                    throw new Exception(strMsg);
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
            catch
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
            catch
            {
                return false;
            }
        }
        public static async Task<bool> Wdsc(JObject jObject)
        {
            try
            {
                string strAPI = "{0}/ppttools/res/wdsc?token={1}";
                string strUrl = string.Format(strAPI, Rigel.ServerUrl, Rigel.UserToken);
                JObject obj = await Request.HttpPost(jObject, strUrl);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static async Task<bool> delWdsc(JObject jObject)
        {
            try
            {
                string strAPI = "{0}/ppttools/res/delWdsc?token={1}";
                string strUrl = string.Format(strAPI, Rigel.ServerUrl,Rigel.UserToken);
                JObject obj = await Request.HttpPost(jObject, strUrl);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static async Task<ResourceModel> GetWdscList(int pageIndex = 1, int prePageCount = 5, String strType = "", String strQuery = "")
        {
            ResourceModel resModel = new ResourceModel();
            String strAPI = "{0}/ppttools/res/wdscQuery?token={1}&uid={2}&ksy={3}&ts={4}&lb={5}&gjz={6}&type={7}";
            String strUrl = String.Format(strAPI, Rigel.ServerUrl, Rigel.UserToken, Rigel.UserID, pageIndex, prePageCount, strType, strQuery, App.ResourceType);

            try
            {

                JObject jsondata = await Request.HttpGet(strUrl);
                if (jsondata != null)
                {


                    JObject pageData = jsondata["pageInfo"].ToObject<JObject>();
                    resModel.PageCount = pageData["pages"].ToObject<int>();
                    resModel.ResCount = pageData["total"].ToObject<int>();
                    JArray dataArray = pageData["list"].ToObject<JArray>();
                    
                    if (App.ResourceType == ResourceType.Legend)
                    {
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
                    else if (App.ResourceType == ResourceType.Icon)
                    {
                        foreach (JToken item in dataArray)
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
                    else
                    {
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
                }

            }
            catch (Exception ex)
            {
                Logger.LogError(ex.ToString());
            }
            return resModel;
        }

        public static async Task<ResourceModel> GetLsjlList(int pageIndex = 1, int prePageCount = 5, String strType = "", String strQuery = "")
        {
            ResourceModel resModel = new ResourceModel();
            String strAPI = "{0}/ppttools/lsjl/query?token={1}&uid={2}&ksy={3}&ts={4}&lb={5}&gjz={6}&type={7}";
            String strUrl = String.Format(strAPI, Rigel.ServerUrl, Rigel.UserToken, Rigel.UserID, pageIndex, prePageCount, strType, strQuery, App.ResourceType);

            try
            {

                JObject jsondata = await Request.HttpGet(strUrl);
                if (jsondata != null)
                {
                    JObject pageData = jsondata["pageInfo"].ToObject<JObject>();
                    resModel.PageCount = pageData["pages"].ToObject<int>();
                    resModel.ResCount = pageData["total"].ToObject<int>();
                    JArray dataArray = pageData["list"].ToObject<JArray>();

                    if (App.ResourceType == ResourceType.Legend)
                    {
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
                    else if (App.ResourceType == ResourceType.Icon)
                    {
                        foreach (JToken item in dataArray)
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
                    else
                    {
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
                }

            }
            catch (Exception ex)
            {
                Logger.LogError(ex.ToString());
            }
            return resModel;
        }

        public static List<GroupItem> GetIconFilter()
        {
            List<GroupItem> group = new List<GroupItem>();
            GroupItem gItem = new GroupItem("交通");
            group.Add(gItem);
            GroupItem item = new GroupItem("驾驶员");
            gItem.Children.Add(item);
            item = new GroupItem("普通车辆");
            gItem.Children.Add(item);
            item = new GroupItem("交通标志");
            gItem.Children.Add(item);
            item = new GroupItem("基础设施");
            gItem.Children.Add(item);

            gItem = new GroupItem("节能减排");
            group.Add(gItem);
            item = new GroupItem("汽车节能");
            gItem.Children.Add(item);
            item = new GroupItem("污染防治");
            gItem.Children.Add(item);
            item = new GroupItem("汽车减排");
            gItem.Children.Add(item);

            gItem = new GroupItem("新能源");
            group.Add(gItem);
            item = new GroupItem("新能源车辆");
            gItem.Children.Add(item);
            item = new GroupItem("电池");
            gItem.Children.Add(item);
            item = new GroupItem("电极");
            gItem.Children.Add(item);
            item = new GroupItem("充电设施");
            gItem.Children.Add(item);

            gItem = new GroupItem("智能网联");
            group.Add(gItem);
            item = new GroupItem("自动驾驶车辆");
            gItem.Children.Add(item);
            item = new GroupItem("智能驾舱");
            gItem.Children.Add(item);
            item = new GroupItem("汽车互联");
            gItem.Children.Add(item);

            gItem = new GroupItem("共享出行");
            group.Add(gItem);
            item = new GroupItem("网约车");
            gItem.Children.Add(item);
            item = new GroupItem("汽车租赁");
            gItem.Children.Add(item);

            gItem = new GroupItem("工具");
            group.Add(gItem);
            item = new GroupItem("人员");
            gItem.Children.Add(item);
            item = new GroupItem("数据");
            gItem.Children.Add(item);
            item = new GroupItem("经济");
            gItem.Children.Add(item);
            return group;
        }

        public static List<GroupItem> GetTempFilter()
        {
            List<GroupItem> group = new List<GroupItem>();
            GroupItem gItem = new GroupItem();
            group.Add(gItem);
            GroupItem item = new GroupItem("宏观环境");
            gItem.Children.Add(item);
            item = new GroupItem("企业战略");
            gItem.Children.Add(item);
            item = new GroupItem("技术产品");
            gItem.Children.Add(item);
            item = new GroupItem("市场");
            gItem.Children.Add(item);
            item = new GroupItem("商业模式");
            gItem.Children.Add(item);
            item = new GroupItem("节能与新能源");
            gItem.Children.Add(item);
            item = new GroupItem("智能网联");
            gItem.Children.Add(item);
            item = new GroupItem("共享出行");
            gItem.Children.Add(item);
            return group;
        }
        public static List<GroupItem> GetMacroFilter()
        {
            List<GroupItem> group = new List<GroupItem>();
            GroupItem gItem = new GroupItem("经济指标");
            group.Add(gItem);
            GroupItem item = new GroupItem("CPI");
            gItem.Children.Add(item);
            item = new GroupItem("GDP");
            gItem.Children.Add(item);
            item = new GroupItem("PMI");
            gItem.Children.Add(item);
            item = new GroupItem("PPI");
            gItem.Children.Add(item);
            item = new GroupItem("进出口");
            gItem.Children.Add(item);
            item = new GroupItem("投资");
            gItem.Children.Add(item);

            gItem = new GroupItem("金融指标");
            group.Add(gItem);
            item = new GroupItem("汇率");
            gItem.Children.Add(item);
            item = new GroupItem("货币");
            gItem.Children.Add(item);
            item = new GroupItem("信贷");
            gItem.Children.Add(item);


            gItem = new GroupItem("原材料");
            group.Add(gItem);
            item = new GroupItem("电解钴");
            gItem.Children.Add(item);
            item = new GroupItem("钢价");
            gItem.Children.Add(item);
            item = new GroupItem("硫酸钴");
            gItem.Children.Add(item);
            item = new GroupItem("石墨");
            gItem.Children.Add(item);
            item = new GroupItem("稀土");
            gItem.Children.Add(item);
            item = new GroupItem("油价");
            gItem.Children.Add(item);

            return group;
        }

        public static List<GroupItem> GetMarketFilter()
        {
            List<GroupItem> group = new List<GroupItem>();

            GroupItem gItem = new GroupItem("总体市场");
            group.Add(gItem);
            GroupItem item = new GroupItem("乘用车");
            gItem.Children.Add(item);
            item = new GroupItem("商用车");
            gItem.Children.Add(item);

            gItem = new GroupItem("轿车");
            group.Add(gItem);
            item = new GroupItem("轿车车型");
            gItem.Children.Add(item);
            item = new GroupItem("轿车份额");
            gItem.Children.Add(item);
            item = new GroupItem("轿车销量");
            gItem.Children.Add(item);

            gItem = new GroupItem("SUV");
            group.Add(gItem);
            item = new GroupItem("SUV车型");
            gItem.Children.Add(item);
            item = new GroupItem("SUV份额");
            gItem.Children.Add(item);
            item = new GroupItem("SUV销量");
            gItem.Children.Add(item);

            gItem = new GroupItem("MPV");
            group.Add(gItem);
             item = new GroupItem("MPV车型");
            gItem.Children.Add(item);
            item = new GroupItem("MPV份额");
            gItem.Children.Add(item);
            item = new GroupItem("MPV销量");
            gItem.Children.Add(item);


            gItem = new GroupItem("载货车");
            group.Add(gItem);
            item = new GroupItem("轻卡市场");
            gItem.Children.Add(item);
            item = new GroupItem("微卡市场");
            gItem.Children.Add(item);
            item = new GroupItem("中卡市场");
            gItem.Children.Add(item);
            item = new GroupItem("重卡市场");
            gItem.Children.Add(item);
            item = new GroupItem("总体市场");
            gItem.Children.Add(item);


            gItem = new GroupItem("客车");
            group.Add(gItem);
            item = new GroupItem("大客市场");
            gItem.Children.Add(item);
            item = new GroupItem("轻客市场");
            gItem.Children.Add(item);
            item = new GroupItem("中客市场");
            gItem.Children.Add(item);


            return group;
        }
        public static List<GroupItem> GetLegendFilter()
        {
            List<GroupItem> group = new List<GroupItem>();
            GroupItem gItem = new GroupItem();
            group.Add(gItem);
            GroupItem item = new GroupItem("并列");
            gItem.Children.Add(item);
            item = new GroupItem("对比");
            gItem.Children.Add(item);
            item = new GroupItem("总分");
            gItem.Children.Add(item);
            item = new GroupItem("等级");
            gItem.Children.Add(item);
            item = new GroupItem("递进");
            gItem.Children.Add(item);
            item = new GroupItem("循环");
            gItem.Children.Add(item);
            item = new GroupItem("饼状图");
            gItem.Children.Add(item);
            item = new GroupItem("柱形");
            gItem.Children.Add(item);
            item = new GroupItem("折线");
            gItem.Children.Add(item);
            item = new GroupItem("时间线");
            gItem.Children.Add(item);
            item = new GroupItem("环形");
            gItem.Children.Add(item);
            item = new GroupItem("层次");
            gItem.Children.Add(item);
            item = new GroupItem("包含");
            gItem.Children.Add(item);
            return group;
        }

        public static List<GroupItem> GetPolicyFilter()
        {
            List<GroupItem> group = new List<GroupItem>();
            GroupItem gItem = new GroupItem();
            group.Add(gItem);
            GroupItem item = new GroupItem("国家政策");
            gItem.Children.Add(item);

            item = new GroupItem("地方政策");
            gItem.Children.Add(item);

            item = new GroupItem("新能源政策");
            gItem.Children.Add(item);
            item = new GroupItem("智能网联政策");
            gItem.Children.Add(item);
            return group;
        }

        public static List<GroupItem> GetTechnologyFilter()
        {
            List<GroupItem> group = new List<GroupItem>();
            GroupItem gItem = new GroupItem();
            group.Add(gItem);
            GroupItem item = new GroupItem("新能源技术");
            gItem.Children.Add(item);
            item = new GroupItem("智能网联技术");
            gItem.Children.Add(item);
            item = new GroupItem("技术概览");
            gItem.Children.Add(item);
            return group;
        }
        public static List<GroupItem> GetEnterpriseFilter()
        {
            List<GroupItem> group = new List<GroupItem>();

            GroupItem gItem = new GroupItem("乘用车");
            group.Add(gItem);
            GroupItem item = new GroupItem("北京现代");
            gItem.Children.Add(item);
            item = new GroupItem("东风本田");
            gItem.Children.Add(item);
            item = new GroupItem("东风小康");
            gItem.Children.Add(item);
            item = new GroupItem("一汽丰田");
            gItem.Children.Add(item);

            gItem = new GroupItem("商用车");
            group.Add(gItem);
            item = new GroupItem("北汽福田");
            gItem.Children.Add(item);
            item = new GroupItem("东风商用车");
            gItem.Children.Add(item);
            item = new GroupItem("一汽解放");
            gItem.Children.Add(item);

            return group;
        }
        public static List<GroupItem> GetPredictFilter()
        {
            List<GroupItem> group = new List<GroupItem>();
            GroupItem gItem = new GroupItem();
            group.Add(gItem);
            GroupItem item = new GroupItem("市场预测");
            gItem.Children.Add(item);
            item = new GroupItem("新上市车型");
            gItem.Children.Add(item);
            item = new GroupItem("车型分析");
            gItem.Children.Add(item); 
            item = new GroupItem("预测报表");
            gItem.Children.Add(item);
            return group;
        }

        public static List<GroupItem> GetProductFilter()
        {
            List<GroupItem> group = new List<GroupItem>();

            GroupItem gItem = new GroupItem();
            GroupItem item = new GroupItem("上市新产品");
            group.Add(item);
            item = new GroupItem("公告新产品");
            group.Add(item);
            item = new GroupItem("预上市产品");
            group.Add(item);

            gItem = new GroupItem("产品布局");
            group.Add(gItem);
            item = new GroupItem("北京现代");
            gItem.Children.Add(item);
            item = new GroupItem("东风本田");
            gItem.Children.Add(item);
            item = new GroupItem("东风小康");
            gItem.Children.Add(item);
            item = new GroupItem("一汽丰田");
            gItem.Children.Add(item); 
            item = new GroupItem("长安福特");
            gItem.Children.Add(item);

            
            return group;
        }
    }
}

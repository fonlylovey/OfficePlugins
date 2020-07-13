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
    class RequestData
    {
        //获取图标数据
        public static async Task<JObject> GetPredictData(String strMBID)
        {
            String strAPI = "{0}/ppttools/res/getPPTDataByIdAndLb?token={1}&mbid={2}&mblb={3}";
            String strUrl = String.Format(strAPI, Rigel.ServerUrl,Rigel.UserToken, strMBID,App.ResourceType);

            try
            {
                JObject jsondata = await Request.HttpGet(strUrl);
                return jsondata;
            }
            catch (Exception ex)
            {
                Logger.LogError(ex.ToString());
            }
            return new JObject();
        }

        public static async Task<JObject> GetWxPPTData(String strMBID)
        {
            String strAPI = "{0}/ppttools/wx/api/queryWxPPTData?token={1}&mbid={2}";
            String strUrl = String.Format(strAPI, Rigel.ServerUrl, Rigel.UserToken, strMBID);

            try
            {
                JObject jsondata = await Request.HttpGet(strUrl);
                return jsondata;
            }
            catch (Exception ex)
            {
                Logger.LogError(ex.ToString());
            }
            return new JObject();
        }

    }

    class PredictData
    {
        public String Month = String.Empty;
        public String Sales = String.Empty;
        public String Ratio = String.Empty;
    }
}

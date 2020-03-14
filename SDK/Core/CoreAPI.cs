using Newtonsoft.Json;
using System;

using Base;

namespace Core
{
	public class CoreAPI
	{
        public static T Deserialize<T>(String strData)
		{
			T data = default(T);
			data = (T)typeof(T).GetConstructor(new System.Type[] { }).Invoke(new object[] { });
			Type type = data.GetType();
			try
			{
				var jSetting = new JsonSerializerSettings();
				jSetting.NullValueHandling = NullValueHandling.Ignore;

				data = JsonConvert.DeserializeObject<T>(strData, jSetting);

			}
			catch (Exception ex)
			{
				Logger.LogError(ex.ToString());
				throw new Exception("反序列化数据失败！ " + type);
			}
			return data;
		}

        public static string Serialize(object obj)
        {
            string strData = "";
            try
            {
                strData = JsonConvert.SerializeObject(obj);
            }
            catch (Exception ex)
            {
                Logger.LogError(ex.ToString());
                throw new Exception("序列化数据失败！ ");
            }
            return strData;
        }

    }
}

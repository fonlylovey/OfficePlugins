using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Core
{
	public class Rigel
	{
        public static int AppHwnd = -1;
        public static String BIMTempPath = System.Environment.GetEnvironmentVariable("TEMP");
		public static String PluginVersion = String.Empty;
		public static String PluginDir = "";
		public static String ServerUrl = "http://www.catarc.ac.cn";
		public static String UpdateUrl = "http://www.catarc.ac.cn/ppttools/static/update/publish/";


		//用户
		public static String UserID = String.Empty;
		public static String UserName = String.Empty;
		public static String UserToken = String.Empty;
		public static String UserRegKey = "Software\\Auto PPTer";


		public static void InitWorkConfig()
		{
			try
			{
				string strConfigPath = PluginDir + "Config.xml";
				if (File.Exists(strConfigPath))
				{
					XmlDocument document = new XmlDocument();
					document.Load(strConfigPath);
					//获取到XML的Name素进行操作
					XmlNode rootNode = document.SelectSingleNode("PluginOption");
					if (rootNode != null)
					{
                        XmlNode xmlUrlNode = rootNode.SelectSingleNode("ServerUrl");
                        if (xmlUrlNode != null)
                        {
                            ServerUrl = xmlUrlNode.InnerText.TrimEnd('/');
                        }

                        //自动更新的Url
                        XmlNode xmlUpdateNode = rootNode.SelectSingleNode("UpdateUrl");
						if(xmlUpdateNode != null)
						{
							UpdateUrl = xmlUpdateNode.InnerText;
						}
                    }
				} 
			}
			catch (Exception e)
			{
				throw e;
			}
		}
	}
}

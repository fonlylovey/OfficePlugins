
using Microsoft.Win32;
using System;
using Base;

namespace Core
{
    public class Regditer
    {
        //其他键需要管理权限，作为用户不希望程序任意修改，不建议去动
        public enum RootKey
        {
            CurrentUser,
            //LocalMachine,
            //ClassesRoot,
            //PerformanceData,
            //CurrentConfig,
            //DynData,
            //Users
        }

        //subKey xxxx/xxx/xxx
        static public bool WriteReg(RootKey rootType, string regSubKey, string strName, string strValue)
        {
            RegistryKey rootKey = GetRootKey(rootType);
            try
            {
                RegistryKey theKey = rootKey.CreateSubKey(regSubKey, true);
                if (theKey != null)
                {
                    theKey.SetValue(strName, strValue);
                }
            }
            catch (Exception ex)
            {
                Logger.LogError("操作注册表失败！" + ex.ToString());
                return false;
            }
            finally
            {
                rootKey.Close();
            }
            return true;
        }


        static public String GetValue(RootKey rootType, string regSubKey, string strName)
        {
            String strValue = "";
            RegistryKey rootKey = GetRootKey(rootType);
            try
            {
                RegistryKey theKey = rootKey.OpenSubKey(regSubKey, true);
                if (theKey != null)
                {
                    object obj = theKey.GetValue(strName, "");
                    strValue = obj.ToString();
                }
            }
            catch (Exception ex)
            {
                Logger.LogError("操作注册表失败！" + ex.ToString());
            }
            return strValue;
        }

        static public bool DeleteKey(RootKey rootType, string regSubKey)
        {
            RegistryKey rootKey = GetRootKey(rootType);
            try
            {
                rootKey.DeleteSubKeyTree(regSubKey);
            }
            catch (Exception ex)
            {
                Logger.LogError("操作注册表失败！" + ex.ToString());
                return false;
            }
            finally
            {
                rootKey.Close();
            }
            return true;
        }

        static RegistryKey GetRootKey(RootKey rootKey)
        {
            RegistryKey key = null;
            switch (rootKey)
            {
                case RootKey.CurrentUser:
                    key = Registry.CurrentUser;
                    break;
                //case RootKey.LocalMachine:
                //    key = Registry.LocalMachine;
                //    break;
                //case RootKey.ClassesRoot:
                //    key = Registry.ClassesRoot;
                //    break;
                //case RootKey.PerformanceData:
                //    key = Registry.PerformanceData;
                //    break;
                //case RootKey.CurrentConfig:
                //    key = Registry.CurrentConfig;
                //    break;
                //case RootKey.DynData:
                //    key = Registry.DynData;
                //    break;
                //case RootKey.Users:
                //    key = Registry.Users;
                //    break;
            }
            return key;
        }
    }
}

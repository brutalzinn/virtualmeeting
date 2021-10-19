using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text.RegularExpressions;

namespace VisualMeetingPluginInterface
{
    public interface IPlugin
    {

       
        string Name();

        string Description();

        string Authors();

        string Contact();


        string PluginId();

        Dictionary<string, Func<string>> GetPlaceHolder();


        string getPluginId()
        {
            string packageId = Regex.Replace(this.PluginId(), @"\s+", "");
            return $"{GetType().Namespace}.{packageId}".ToLower();
        }


        string Version(string versionServer = null)
        {
            Assembly thisAssem = GetType().Assembly;
            AssemblyName thisAssemName = thisAssem.GetName();
            Version ver = thisAssemName.Version;
            if (versionServer != null)
            {
                return $"{versionServer}-{ver}";
            }
            return ver.ToString();
        }
    }
    public interface InterfacePlugin: IPlugin
    {
        Dictionary<string, Func<object, dynamic>> Interfaces();
    }

    public interface ConfigDataPlugin : IPlugin
    {
        string getConfigData();

        void loadConfigData(dynamic data = null);
    }


}

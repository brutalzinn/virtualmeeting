using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace VisualMeetingPluginInterface
{
    public interface IPlugin
    {
      
        string Name();

        string PluginId()
        {
            string packageId = Regex.Replace(this.Name(), @"\s+", "");
            return packageId.ToLower();
        }

        string Description();

        string Authors();

        string Contact();

        string Version(string versionServer = null);

   
        Dictionary<string, Func<string>> GetPlaceHolder();

    }
    public interface InterfacePlugin: IPlugin
    {
        Dictionary<string, Func<object, dynamic>> Interfaces();
    }

    public interface ConfigData : IPlugin
    {
        string getConfigData();

        void loadConfigData(dynamic data = null);
    }


}

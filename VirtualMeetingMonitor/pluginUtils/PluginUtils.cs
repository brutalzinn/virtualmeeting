using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMeetingMonitor.pluginUtils
{
   public class PluginUtils
    {
        public static void saveData(Profile CurrentProfile, string configData,string pluginName = "")
        {
            dynamic data = JsonConvert.DeserializeObject<object>(configData);
            data["PluginName"] = pluginName;
            bool AlreadyExist = false;
            int i = 0;
            for(i = 0; i < CurrentProfile.PluginsSettings.Count; i++)
            {
                dynamic searchData = JsonConvert.DeserializeObject(CurrentProfile.PluginsSettings[i].ToString());
                if (searchData["PluginName"] == pluginName)
                {
                    AlreadyExist = true;
                    break;
                }
            }
          
            if (!AlreadyExist)
            {
                CurrentProfile.PluginsSettings.Add(data);
            }
            else
            {
                CurrentProfile.PluginsSettings[i] = data;
            }
        }
        public static dynamic loadData(Profile CurrentProfile, string pluginName = "")
        {


            foreach (object item in CurrentProfile.PluginsSettings)
            {
                dynamic data = JsonConvert.DeserializeObject(item.ToString());
                if(data["PluginName"] == pluginName)
                {
                    return data;
                }
              
            }
            return null;
      
        }
    }
}

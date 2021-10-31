using Newtonsoft.Json;
using PluginInterface;
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
        public static void saveData(Profile CurrentProfile, IConfig PluginConfigData)
        {
            dynamic data = JsonConvert.DeserializeObject(PluginConfigData.getConfigData());
            
            data["PluginId"] = PluginConfigData.getPluginId();
            bool AlreadyExist = false;
            int i = 0;
            for(i = 0; i < CurrentProfile.PluginsSettings.Count; i++)
            {
                dynamic searchData = JsonConvert.DeserializeObject(CurrentProfile.PluginsSettings[i].ToString());
                if (searchData["PluginId"] == PluginConfigData.getPluginId())
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
        public static dynamic loadData(Profile CurrentProfile, IConfig PluginConfigDat)
        {


            foreach (object item in CurrentProfile.PluginsSettings)
            {
                dynamic data = JsonConvert.DeserializeObject(item.ToString());
                if(data["PluginId"] == PluginConfigDat.getPluginId())
                {
                    return data;
                }
              
            }
            return null;
      
        }
    }
}

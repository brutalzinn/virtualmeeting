using PluginInterface;
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Windows.Forms;
using PluginServiceExample.Views;

namespace PluginServiceExample
{
    internal class PluginService : IPlugin, IService, IConfig, IVisual
    {
        public Dictionary<string, Func<object, dynamic>> ControlList = new Dictionary<string, Func<object, dynamic>>();

        public string Authors()
        {
            return "brutalzinn";
        }

        public string Contact()
        {
            return "brutalzinn";
        }

        public string Description()
        {
            return "Google API connetor - Oficial";
        }

        public void Executor(List<object> values)
        {
            throw new NotImplementedException();
        }
        public Dictionary<string, Func<object, dynamic>> Interfaces()
        {
            ControlList.Add(Name(), MethodControlConfig);
            return ControlList;
        }
        public UserControl MethodControlConfig(dynamic data)
        {
            if (data != null)
            {
                Config configModel = JsonConvert.DeserializeObject<Config>(Convert.ToString(data));
                return new ServiceView(configModel);
            }
            else
            {
                return new ServiceView(null);
            }
        }
        public void loadConfigData(dynamic data)
        {
            Config configModel = JsonConvert.DeserializeObject<Config>(Convert.ToString(data));
            Globals.saveConfig(configModel);
        }

        public string getConfigData()
        {
            return JsonConvert.SerializeObject(Globals._Config, Formatting.Indented);
        }


        public string Name()
        {
            return "GoogleAPI service example";
       }

   
    }
}

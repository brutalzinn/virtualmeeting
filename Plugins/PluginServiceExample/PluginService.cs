using PluginInterface;
using System;
using System.Collections.Generic;
using Newtonsoft.Json;


namespace PluginServiceExample
{
    internal class PluginService : IPlugin, IService, IConfig
    {
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

        public void loadConfigData(string data)
        {
            Config configModel = JsonConvert.DeserializeObject<Config>(data);
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

using PluginInterface;
using System;
using System.Collections.Generic;

namespace PluginServiceExample
{
    internal class PluginService : IPlugin, IServiceExternalAPI
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

        public string Name()
        {
            return "GoogleAPI service example";
       }
    }
}

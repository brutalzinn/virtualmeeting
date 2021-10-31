using System;
using RestSharp;
using System.Collections.Generic;
using System.Reflection;
using PluginInterface;

namespace PluginExample
{
    internal class PluginExample : IPlugin, ITextFormat
    {
        private Dictionary<string, Func<string>> PlaceHolders = new Dictionary<string, Func<string>>();
        public Dictionary<string, Func<string>> GetPlaceHolder()
        {
            PlaceHolders.Add("PLUGINEXAMPLE", Main);
            return PlaceHolders;
        }
        public string Description()
        {
            return "Esse é um plugin de exemplo.";
        }
        public string Authors()
        {
            return "brutalzinn";
        }
        public string Contact()
        {
            return "robertinho.net";
        }
        public string Name() => "PluginExample v1";
        private string Main()
        {
            return ApiCall();
        }
        private string ApiCall()
        {
            RestClient client = new RestClient("https://baconipsum.com/api/?callback=?");     
            var request = new RestRequest(Method.GET);           
            return client.Execute(request).Content;
        }     
        public string Version(string versionServer = null)
        {
            Assembly thisAssem = typeof(PluginExample).Assembly;
            AssemblyName thisAssemName = thisAssem.GetName();
            Version ver = thisAssemName.Version;
            if (versionServer != null)
            {
                return $"{versionServer}-{ver}";
            }
            return ver.ToString();
        }    
    }
}

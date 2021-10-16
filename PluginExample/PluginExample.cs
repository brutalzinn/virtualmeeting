using System;
using VisualMeetingPluginInterface;
using RestSharp;
using System.Collections.Generic;

namespace PluginExample
{
    internal class PluginExample : IPlugin
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

        public string GetName() => "PluginExample v1";

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

        public Dictionary<string, Func<object, dynamic>> Interfaces()
        {
            return null;
        }

        public string getConfigData()
        {
            return null;
        }

        public void loadConfigData(dynamic data = null)
        {
        
        }
    }
}

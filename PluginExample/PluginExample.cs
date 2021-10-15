using System;
using VisualMeetingPluginInterface;
using RestSharp;

namespace PluginExample
{
    internal class PluginExample : IPlugin
    {
        public string GetName() => "My plugin v1";


        public string GetPlaceHolder() => "PLUGINEXAMPLE";


        public string Main()
        {
            return ApiCall();
        }
        private string ApiCall()
        {
            RestClient client = new RestClient("https://baconipsum.com/api/?callback=?");

      
            var request = new RestRequest(Method.GET);

           
            return client.Execute(request).Content;
        }

        
    }
}

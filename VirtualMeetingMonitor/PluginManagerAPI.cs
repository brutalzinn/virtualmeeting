using Newtonsoft.Json;
using RestSharp;
using System;
using System.Net;
using VirtualMeetingMonitor.ApiPluginManager.models;

namespace VirtualMeetingMonitor
{
    public class PluginManagerAPI
    {
        private readonly string url = "http://localhost:8000/files"; //esp 8266 fixed ip
        public GenericFiles getPackages(int page = 0, int size = 3) =>  CallPackageList(page,size);
        private GenericFiles CallPackageList(int page, int size)
        {
            RestClient client = new RestClient($"{url}?page={page}&size={size}");      
            var request = new RestRequest(url, Method.GET);
            dynamic json = client.Execute(request).Content;
            GenericFiles configModel = JsonConvert.DeserializeObject<GenericFiles>(Convert.ToString(json));
            return configModel;
        }
    }
}
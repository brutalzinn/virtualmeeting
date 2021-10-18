using Newtonsoft.Json;
using RestSharp;
using System;
using System.Diagnostics;
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
            RestClient client = new RestClient(url);      
            var request = new RestRequest($"?page={page}&size={size}", Method.GET);
            request.AddParameter("page", page, ParameterType.UrlSegment);
            request.AddParameter("size", size, ParameterType.UrlSegment);
            request.OnBeforeDeserialization = resp => { resp.ContentType = "application/json"; };
            var queryResult = client.Execute(request);
            GenericFiles configModel = JsonConvert.DeserializeObject<GenericFiles>(queryResult.Content);
            return configModel;
        }
    }
}
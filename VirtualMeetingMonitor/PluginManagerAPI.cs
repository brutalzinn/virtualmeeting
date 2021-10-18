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

        public static bool addPackage() => callAddPackage() == HttpStatusCode.OK;
        public GenericFiles getPackages(int page = 0, int size = 3) =>  CallPackageList(page,size);
        private HttpStatusCode callAddPackage(string body)
        {
            RestClient client = new RestClient(url);

            const string api = "/files/upload";
            var request = new RestRequest(api, Method.POST);

            request.AddJsonBody(body);
            return client.Execute(request).StatusCode;

        }
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
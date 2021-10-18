using RestSharp;
using System.Net;

namespace VirtualMeetingMonitor
{
    internal class Routes
    {
        private readonly string url = "http://192.168.0.25"; //esp 8266 fixed ip

        public bool TurnOn(int hue, int sat) => CallAPI($"{{ \"on\": true, \"hue\" : {hue}, \"sat\": {sat} }}") == HttpStatusCode.OK;
        public bool RunTest() => CallTeste() == HttpStatusCode.OK;

        public bool TurnOff() => CallAPI("{ \"on\": false }") == HttpStatusCode.OK;
        //public bool TurnOn() => CallAPI("{ \"status\": true }") == HttpStatusCode.OK;

        //public bool TurnOff() => CallAPI("{ \"status\": false }") == HttpStatusCode.OK;
        private HttpStatusCode CallTeste()
        {

            RestClient client = new RestClient(url);
            var request = new RestRequest(Method.GET);
            return client.Execute(request).StatusCode;
        }
        private HttpStatusCode CallAPI(string body)
        {

            RestClient client = new RestClient(url);

            const string api = "/LED";
            var request = new RestRequest(api, Method.POST);

            request.AddJsonBody(body);
            return client.Execute(request).StatusCode;
        }
    }
}
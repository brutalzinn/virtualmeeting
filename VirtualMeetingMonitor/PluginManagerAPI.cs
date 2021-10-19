
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Diagnostics;
using System.Dynamic;
using System.Net;
using System.Text;
using VirtualMeetingMonitor.ApiPluginManager.models;

namespace VirtualMeetingMonitor
{
    public class PluginManagerAPI
    {
        private readonly string url = "http://localhost:8000"; //esp 8266 fixed ip

        public UserModel User { get; set; } = new UserModel();

        public bool addUser(UserModel body) => callAuthUser(body) == HttpStatusCode.OK;

        public bool addPackage(FileModel body) => callAddPackage(body) == HttpStatusCode.OK;
        public GenericFiles getPackages(int page = 0, int size = 3) =>  CallPackageList(page,size);

        public string DecodeBase64(string token)
        {
            token = token.Replace('_', '/').Replace('-', '+');
            switch (token.Length % 4)
            {
                case 2: token += "=="; break;
                case 3: token += "="; break;
            }
            var decoded = Convert.FromBase64String(token);
            var decodedToken = System.Text.Encoding.Default.GetString(decoded);
            return decodedToken;
        }

        private HttpStatusCode callAuthUser(UserModel body)
        {
            RestClient client = new RestClient(url);

            const string api = "/login";
            var request = new RestRequest(api, Method.POST);
            dynamic json = new ExpandoObject();
            json.email = body.Email;
            json.password = body.Password;
            request.AddJsonBody(json);
            var query = client.Execute(request);
            string token = JsonConvert.DeserializeObject<UserModel>(query.Content).Token.Split('.')[1];
            Debug.WriteLine($"TOKEN:|{token}|");
            Debug.WriteLine(DecodeBase64(token));
       
            User = JsonConvert.DeserializeObject<UserModel>(DecodeBase64(token));
            return query.StatusCode;
        }

            private HttpStatusCode callAddPackage(FileModel body)
        {
            RestClient client = new RestClient(url);
            var request = new RestRequest("/files/upload", Method.POST)
            {
                AlwaysMultipartFormData = true
            };
            string token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6MSwibmFtZSI6IlJvb3QgdXNlciIsImVtYWlsIjoicm9vdEByb290LmNvbSIsInJhbmsiOjEsImlhdCI6MTYzNDYwNDU2NCwiZXhwIjoxNjM0NjkwOTY0fQ.5ifac6yOSrhfmlr1BPc0awML7hwZhvBrZSnjyyvI7U4";
            request.AddHeader("Content-Type", "multipart/form-data");
            request.AddHeader("Authorization", $"Bearer {token}");
            request.AddFile("plugin",body.Filename);
            request.AddParameter("name", body.Name);
            request.AddParameter("description", body.Description);
            request.AddParameter("repo", body.Repo);
            request.AddParameter("version", Convert.ToString(body.Version.version));
            request.AddParameter("crc", Convert.ToString(body.Version.crc));
            request.AddParameter("sha", Convert.ToString(body.Version.sha));
            return client.Execute(request).StatusCode;
        }
        private GenericFiles CallPackageList(int page, int size)
        {
            RestClient client = new RestClient(url);      
            var request = new RestRequest($"/files?page={page}&size={size}", Method.GET);
            request.AddParameter("page", page, ParameterType.UrlSegment);
            request.AddParameter("size", size, ParameterType.UrlSegment);
            request.OnBeforeDeserialization = resp => { resp.ContentType = "application/json"; };
            var queryResult = client.Execute(request);
            GenericFiles configModel = JsonConvert.DeserializeObject<GenericFiles>(queryResult.Content);
            return configModel;
        }
    }
}
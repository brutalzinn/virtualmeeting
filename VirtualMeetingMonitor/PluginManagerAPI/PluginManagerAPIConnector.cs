﻿
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.IO;
using System.Net;
using System.Text;
using VirtualMeetingMonitor.PluginManager.models;
using VirtualMeetingMonitor.PluginManagerAPI.models;

namespace VirtualMeetingMonitor.PluginManager
{
    public class PluginManagerAPIConnector
    {
        private readonly string url = "http://localhost:8000"; //esp 8266 fixed ip
        private int ProgressValue { get; set; } = 0;
        private string Response { get; set; }
        private void ResponseContent(string value) => Response = value;
        public string getResponseContent() => Response;
        public int getProgress() => ProgressValue;
        private void ProgressBar(int value) => ProgressValue = value;
        public bool addUser(UserModel body) => CallAuthUser(body) == HttpStatusCode.OK;

        public bool CheckPluginVersion(string unique_id) => CallCheckPluginId(unique_id);

        public bool updatePackage(FileModel body) => CallUpdatePackage(body) == HttpStatusCode.OK;
        public bool addPackage(FileModel body) => CallAddPackage(body) == HttpStatusCode.OK;
        public GenericFiles getPackages(int page = 0, int size = 3, bool isUser = false) =>  CallPackageList(page,size,isUser);
        private HttpStatusCode CallAuthUser(UserModel body)
        {
            RestClient client = new RestClient(url);
            const string api = "/login";
            var request = new RestRequest(api, Method.POST);
            dynamic json = new ExpandoObject();
            json.email = body.Email;
            json.password = body.Password;
            request.AddJsonBody(json);
            var query = client.Execute(request);
            string tokenOriginal = JsonConvert.DeserializeObject<UserModel>(query.Content).Token;
            string token = JsonConvert.DeserializeObject<UserModel>(query.Content).Token?.Split('.')[1];
            if (token != null) {
            var user_info = JsonConvert.DeserializeObject<UserModel>(Core.DecodeBase64(token));
            Core.UserAccount.Id = user_info.Id;
            Core.UserAccount.Token = tokenOriginal;
            Core.UserAccount.Rank = user_info.Rank;
            Core.UserAccount.Name = user_info.Name;
            Core.UserAccount.Email = user_info.Email;
            Core.UserAccount.onLogin();
           return query.StatusCode;
            }
            else
            {
                Core.UserAccount.Error();
                return HttpStatusCode.BadRequest;
            }
        }     
        private HttpStatusCode CallAddPackage(FileModel body)
        {
            RestClient client = new RestClient(url);
            var request = new RestRequest("/files/upload", Method.POST)
            {
                AlwaysMultipartFormData = true
            };
            ProgressBar(5);
           
            request.AddHeader("Content-Type", "multipart/form-data");
            request.AddHeader("Authorization", $"Bearer {Core.UserAccount.Token}");
            request.AddFile("plugin",body.Filename);
            ProgressBar(25);
            request.AddParameter("name", body.Name);
            request.AddParameter("description", body.Description);
            request.AddParameter("repo", body.Repo);
            request.AddParameter("version", body.Version.Version);
            request.AddParameter("crc", body.Version.Crc);
            request.AddParameter("sha", body.Version.Hash);
            request.AddParameter("unique_id", body.Version.Unique_id);
            ProgressBar(50);
            var query = client.Execute(request);
            if(query.StatusCode != HttpStatusCode.OK)
            {
                dynamic json = JsonConvert.DeserializeObject(query.Content);
                ResponseContent(Convert.ToString(json.error));
                ProgressBar(0);
            }
            else
            {
              ProgressBar(100);
            }
            return query.StatusCode;
        }

        /// <summary>
        /// needs refactor this method to do a really progressbar
        /// </summary>
        /// <param name="body"></param>
        /// <returns></returns>
        private HttpStatusCode CallUpdatePackage(FileModel body)
        {
            RestClient client = new RestClient(url);
            var request = new RestRequest($"/files/update/{body.Version.Unique_id}", Method.PUT)
            {
                AlwaysMultipartFormData = true
            };
            ProgressBar(5);

            request.AddHeader("Content-Type", "multipart/form-data");
            request.AddHeader("Authorization", $"Bearer {Core.UserAccount.Token}");
            request.AddFile("plugin", body.Filename);
            ProgressBar(25);
            request.AddParameter("name", body.Name);
            request.AddParameter("description", body.Description);
            request.AddParameter("repo", body.Repo);
            request.AddParameter("version", body.Version.Version);
            request.AddParameter("crc", body.Version.Crc);
            request.AddParameter("sha", body.Version.Hash);
            ProgressBar(50);
            var query = client.Execute(request);
            if (query.StatusCode != HttpStatusCode.OK)
            {
                dynamic json = JsonConvert.DeserializeObject(query.Content);
                ResponseContent(Convert.ToString(json.error));
                ProgressBar(0);
            }
            else
            {
                ProgressBar(100);
            }
            return query.StatusCode;
        }
        private GenericFiles CallPackageList(int page, int size,bool isUser)
        {
            RestClient client = new RestClient(url);
            RestRequest request;
            if (!isUser)
            {
                request = new RestRequest($"/files?page={page}&size={size}", Method.GET);
            }
            else
            {
                request = new RestRequest($"/user/files?page={page}&size={size}", Method.GET);
                request.AddHeader("Authorization", $"Bearer {Core.UserAccount.Token}");
            }
            request.AddParameter("page", page, ParameterType.UrlSegment);
            request.AddParameter("size", size, ParameterType.UrlSegment);
            request.OnBeforeDeserialization = resp => { resp.ContentType = "application/json"; };
            var queryResult = client.Execute(request);
            GenericFiles configModel = JsonConvert.DeserializeObject<GenericFiles>(queryResult.Content);
            return configModel;
        }

        private bool CallCheckPluginId(string unique_id)
        {
            RestClient client = new RestClient(url);
            RestRequest request = new RestRequest($"/version/check/{unique_id}", Method.GET);
            request.OnBeforeDeserialization = resp => { resp.ContentType = "application/json"; };
            var queryResult = client.Execute(request);
            return queryResult.StatusCode == HttpStatusCode.OK;
        }

        public List<PluginUpdateResponse> CheckLocalPluginVersion(List<PluginUpdateRequest> body) => CallPackageUpdates(body) ;

        private List<PluginUpdateResponse> CallPackageUpdates(List<PluginUpdateRequest> body)
        {
            RestClient client = new RestClient(url);
            RestRequest request;
         
            request = new RestRequest($"/version/check", Method.POST);
            
            request.OnBeforeDeserialization = resp => { resp.ContentType = "application/json"; };
            request.AddJsonBody(body);
            var queryResult = client.Execute(request);
            List<PluginUpdateResponse> configModel = JsonConvert.DeserializeObject<List<PluginUpdateResponse>>(queryResult.Content);
            return configModel;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Reflection;
using VisualMeetingPluginInterface;

namespace PluginMultipleTags
{
    internal class PluginExampleMultipleTags : IPlugin
    {

        Dictionary<string, Func<string>> PlaceHolders = new Dictionary<string, Func<string>>();
        public Dictionary<string, Func<string>> GetPlaceHolder()
        {
            PlaceHolders.Add("TAG1", TAGONE);
            PlaceHolders.Add("TAG2", TAGTWO);
            PlaceHolders.Add("TAG3", TAGTHREE);
            return PlaceHolders;
        }

   

        private string TAGONE()
        {
            return "This is a tag one with same plugin";
        }

        private string TAGTWO()
        {
            return "This is a tag two with same plugin";
        }
        private string TAGTHREE()
        {
            return $"This is a tag thread with same plugin {new Random().Next(0, 42).ToString()}";
        }
        public string Name() => "Multiple TAGS Plugin";

        public string Description()
        {
            return "Esse é um plugin com múltiplas tags";
        }

        public string Authors()
        {
            return "brutalzinn";
        }

        public string Contact()
        {
            return "robertinho.net";
        }
        public string Version(string versionServer = null)
        {
            Assembly thisAssem = typeof(PluginExampleMultipleTags).Assembly;
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

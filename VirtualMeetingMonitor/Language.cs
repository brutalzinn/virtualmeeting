using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace VirtualMeetingMonitor
{
    public class Language
    {

        private string name { get; set; }
        private string path { get; set; }
        private bool enabled { get; set; }

        private JObject json { get;set; }
        public Language(string name, string path, bool enabled)
        {
            this.name = name;
            this.path = path;
            this.enabled = enabled;
        }

        public void readLanguage()
        {
            this.json = JObject.Parse(File.ReadAllText(path));
        }
        public string getValue(string key)
        {
            return this.json[key].ToString();
        }


    }
}

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
        public delegate void Notify();  // delegate

        public event Notify LanguageChanged;

        public void readLanguage()
        {
            this.json = JObject.Parse(File.ReadAllText(this.path));
            LanguageChanged?.Invoke();
        }
        public string getValue(string key)
        {
            return this.json[key].ToString();
        }

      


        public string getFileName()
        {
            return Path.GetFileNameWithoutExtension(this.name);

        }
        public override string ToString()
        {
            if(this.json != null)
            {
                return this.json["language_name"].ToString();
            }
            else
            {
                return Path.GetFileNameWithoutExtension(this.name);
            }
        }

    }
}

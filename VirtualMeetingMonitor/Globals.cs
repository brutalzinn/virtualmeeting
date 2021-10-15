using McMaster.NETCore.Plugins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VirtualMeetingMonitor.ActionsControl;
using VirtualMeetingMonitor.formater;
using VirtualMeetingMonitor.profile;

namespace VirtualMeetingMonitor
{
    public  class Globals
    {
       public static List<Language> languages = new List<Language>();

        public static ProfileUtils ProfileUtil = new ProfileUtils();
        public static Form form { get; set; }

        public static string UpdateUrl = "http://robertocpaes.dev/update.xml";
        public static List<MethodExecutor> Methods = new List<MethodExecutor>();

        public static CustomerFormatter CustomFormater { get; set; }

        public static CustomDay CustomDays { get; set; }

        public static CustomDataGrid CustomDataGrids { get; set; }

        public static  List<PluginLoader> loaders = new List<PluginLoader>();


        public static Language CurrentLanguage { get; set; }

        public static string getHtmlVersion()
        {
            return $"<h1>{Application.ProductName} </br> {Application.ProductVersion}</h1></br>"+
                "Github:https://github.com/brutalzinn/zoom-monitor-googlesheets";

        }
        public static string getKey(string key)
        {
            return CurrentLanguage.getValue(key);
        }
        public static string getAppName (string name)
        {
              return  $"{Application.ProductName} - {name}";
        }

        public static void showHelper(string url)
        {
            using (WebClient web1 = new WebClient())
            {
                string data = web1.DownloadString(url);
                Helper helper = new Helper();
                Console.WriteLine(data);
                helper.markdown = data;
                helper.ShowDialog();
            }
        }
    }
}

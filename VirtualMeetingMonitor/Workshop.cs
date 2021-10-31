using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using VirtualMeetingMonitor.PluginManager;
using VirtualMeetingMonitor.PluginManager.models;
using VirtualMeetingMonitor.PluginManagerAPI.models;

namespace VirtualMeetingMonitor
{
    /// <summary>
    /// Class that consists of functions that allow system to fetch packages from a remote repository aswell as download and install them.
    /// </summary>
    public static class Workshop
    {
        /// <summary>
        /// String containing address to the ScribeBot-Workshop script repository.
        /// </summary>
        ///

        public static Package[] installedPackages { get; set; }

        public static PluginManagerAPIConnector PluginManagerWeb { get; set; } = new PluginManagerAPIConnector();

        /// <summary>
        /// WebClient used for simple HTTP Requests. Mainly workshop fetching/downloading.
        /// </summary>
        /// 
        public static WebClient NetClient { get; set; } = new WebClient();

        /// <summary>
        /// Get list of installed packages.
        /// </summary>
        /// <returns>List of installed packages.</returns>
        public static Package[] GetInstalled()
        {
            var packages = new List<Package>();

            //Directory.GetFiles(Core.PluginFolder, "*.zip").ToList().ForEach(x =>
            //{
            //    var package = new Package(x);
            //    packages.Add(package);
            //});

            Directory.GetDirectories(Core.PluginFolder).ToList().ForEach(x =>
            {
                var package = new Package(x);

                packages.Add(package);
            });

            return packages.ToArray();
        }
        /// <summary>
        /// This method is be used to check versions
        /// </summary>
        /// <param name="data"></param>
        public static void CheckPluginVersion(PluginUpdateResponse data)
        {
            if(installedPackages != null)
            if (data.status)
            {
                installedPackages.ToList().ForEach(x =>
                {
                    Dictionary<string, string> packageInfo = x.GetInfo();
                    if (packageInfo["PluginId"] == data.unique_id)
                    {
                        var version1 = new Version(data.version);
                        var version2 = new Version(packageInfo["Version"]);
                        var result = version1.CompareTo(version2);
                        if (result > 0)
                        {
                    
                            Core.WriteLine($"{packageInfo["Name"]} tem uma atualização. \n Instalada: {packageInfo["Version"]} Disponível: {data.version}");
                            Core.MainWindow.ConsoleOutput.SelectedRtf = @"{\rtf1 {\field{\*\fldinst{HYPERLINK " + data.url + "," + Path.GetFileName(x.ArchivePath).Replace(" ", "+") + @" }}{\fldrslt{\cf1 Clique aqui para atualizar.\cf0 }}}}";
                        }
                   }
                });
               
            }


        }
        /// <summary>
        /// Fetch workshop scripts.
        /// </summary>
        /// <returns>List of downloadable packages.</returns>
        public static GenericFiles GetPackageList(int page = 0, int size = 3, bool isUser = false)
        {
            GenericFiles Files;
            if (!isUser) { 
             Files = PluginManagerWeb.getPackages(page, size, isUser);
            }
            else
            {
                Files = PluginManagerWeb.getPackages(page, size, isUser);
            }
            Core.WriteLine(new ColorContainer(89, 73, 163),$"Workshop list fetched. Happy downloading! {Files.currentPage}");
            return Files;
        }

        /// <summary>
        /// Download a script from workshop.
        /// </summary>
        public static void DownloadPackage(string url, string name = "package")
        {
           Core.WriteLine($@"Downloading workshop package: {name}");

            if (File.Exists($@"{Core.PluginFolder}\{name}.zip"))
            {
              Core.WriteLine( "A package of this name already exists!");
                return;
            }

            NetClient.Headers["User-Agent"] = "ScribeBot - Workshop - Download Package";
            NetClient.DownloadFile(url, $@"{Core.PluginFolder}\{name}.zip");


          Core.WriteLine($@"Downloaded workshop package: {name}");
          Package.DescompressPackage(name);
        }

        /// <summary>
        /// Create a .zip package from a supplied folder.
        /// </summary>
        /// <param name="folderPath">Path to folder to turn into package.</param>
        /// <param name="info">Unformatted table containing data that later will be turned to info.json.</param>
     
        
        public static void CreatePackage(string folderPath, Dictionary<string, string> info)
        {
            var json = JsonConvert.SerializeObject(info, Formatting.Indented);
            var filePaths = new List<string>();

            File.WriteAllText($@"{folderPath}\info.json", json);

            Directory.GetFiles(folderPath).ToList().ForEach(x => filePaths.Add(x));
            Package.CreateWithoutZip(Path.GetFileName(folderPath));
            //Package.Create(Path.GetFileName(folderPath), filePaths.ToArray());
        }
    }
}

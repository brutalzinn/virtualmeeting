using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;
using System.Diagnostics;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Dynamic;
using McMaster.NETCore.Plugins;
using VisualMeetingPluginInterface;
using VirtualMeetingMonitor.PluginManager.models;


//TO-DO: Remake this entire class
namespace VirtualMeetingMonitor
{
    /// <summary>
    /// Class that contains script files along with author's data.
    /// </summary>
    public class Package
    {
        /// <summary>
        /// Marks packages that are plain folders and not zip files.
        /// </summary>
        public bool IsZipped { get => ArchivePath.EndsWith(".zip"); }

        /// <summary>
        /// Path to the archive that the instance of this class represents.
        /// </summary>
        public string ArchivePath { get; set; }

        /// <summary>
        /// Creates a package with given archive path.
        /// </summary>
        /// <param name="path">Path to archive.</param>
        public Package(string path) => ArchivePath = path;

     
        public static void DescompressPackage(string packageName)
        {
            try
            {
                var archive = ZipFile.Open($@"{Core.PluginFolder}\{packageName}.zip", ZipArchiveMode.Read);
                archive.ExtractToDirectory($@"{Core.PluginFolder}\{packageName}");
                string pathInfo = $@"{Core.PluginFolder}\{packageName}\info.json";
                if (!File.Exists(pathInfo))
                {
                    File.WriteAllText(pathInfo, GetPackageInfo($@"{Core.PluginFolder}\{packageName}"));
                }
                archive.Dispose();
                File.Delete($@"{Core.PluginFolder}\{packageName}.zip");
                Core.WriteLine($@"Package {packageName}.zip extracted!");
            }
            catch (Exception e)
            {
                Core.WriteLine(e.Message);
            }
        }
        public static Package CreateWithoutZip(string packageName)
        {
            return new Package($@"plugins\{packageName}");

        }

        public static dynamic GetPluginInfo(string filename)
        {
            PluginLoader _loader = PluginLoader.CreateFromAssemblyFile(filename, new[] { typeof(IPlugin) });
            foreach (var pluginType in _loader
                .LoadDefaultAssembly()
                .GetTypes()
                .Where(t => typeof(IPlugin).IsAssignableFrom(t) && !t.IsAbstract))
            {
                // This assumes the implementation of IPlugin has a parameterless constructor
                var plugin = Activator.CreateInstance(pluginType) as IPlugin;

                dynamic json = new ExpandoObject();
                json.Authors = plugin.Authors();
                json.Contact = plugin.Contact();
                json.Name = plugin.Name();
                json.Description = plugin.Description();
                json.Version = plugin.Version();
                json.PluginId = plugin.getPluginId();
                return json;


                //new MethodExecutor(plugin.GetPlaceHolder(), Globals.Methods, plugin.Main);

            }
            return null;
           
        }


        public static string GetPackageInfo(string ArchivePath)
        {
            List<PluginLoader> loaders = new List<PluginLoader>();
            string json = "";
            var dirName = Path.GetFileName(ArchivePath);
            var pluginDll = Path.Combine(ArchivePath, dirName + ".dll");
            if (File.Exists(pluginDll))
            {
                var loader = PluginLoader.CreateFromAssemblyFile(
                    pluginDll,
                    sharedTypes: new[] { typeof(IPlugin) });
                loaders.Add(loader);
            }

            foreach (var loader in loaders)
            {
                foreach (var pluginType in loader
                    .LoadDefaultAssembly()
                    .GetTypes()
                    .Where(t => typeof(IPlugin).IsAssignableFrom(t) && !t.IsAbstract))
                {
                    // This assumes the implementation of IPlugin has a parameterless constructor
                    var plugin = Activator.CreateInstance(pluginType) as IPlugin;
                    json = JsonConvert.SerializeObject(new
                    {
                        Name = plugin.Name(),
                        Description = plugin.Description(),
                        Authors = plugin.Authors(),
                        Contact = plugin.Contact(),
                        Version = plugin.Version(),
                        PluginId = plugin.getPluginId()
                    }, Formatting.Indented);

                
                    //new MethodExecutor(plugin.GetPlaceHolder(), Globals.Methods, plugin.Main);
                }
            }
            return json;
        }
        public static Package Create(string packageName, string[] filePaths)
        {
            packageName = packageName.ToLower();
            try
            {
                var archive = ZipFile.Open($@"{Core.PluginFolder}\{packageName}.zip", ZipArchiveMode.Create);

                filePaths.ToList().ForEach(x => archive.CreateEntryFromFile(x, Path.GetFileName(x)));

                archive.Dispose();

                Core.WriteLine($@"Package {packageName}.zip created!");
            }
            catch( Exception e )
            {
                Core.WriteLine(e.Message);
            }
            return new Package($@"plugins\{packageName}.zip");
        }

        /// <summary>
        /// Returns package info stored inside info.json file.
        /// </summary>
        /// <returns>Package name, authors, description etc.</returns>
        public Dictionary<string, string> GetInfo()
        {
            string contents;
            if (IsZipped)
            {
                var archive = ZipFile.OpenRead(ArchivePath);

                var reader = new StreamReader(archive.GetEntry("info.json").Open());

                contents = reader.ReadToEnd();

                //Neccessary force-disposal and close to preven IO exceptions.
                reader.Dispose();
                archive.Dispose();
            }
            else
            {
                string path = $@"{ArchivePath}\info.json";
                if (!File.Exists(path))
                {
                    File.WriteAllText(path, GetPackageInfo(ArchivePath));
                }

                contents = File.ReadAllText($@"{ArchivePath}\info.json");
            }

            return JsonConvert.DeserializeObject<Dictionary<string, string>>(contents);
        }
        
        /// <summary>
        /// Read contents of a specific file entry inside a package.
        /// </summary>
        /// <param name="fileName">Name of entry to get contents of.</param>
        /// <returns>Contents as a string.</returns>
        public string ReadFileContents(string fileName)
        {
            string contents;
            if (IsZipped)
            {
                var archive = ZipFile.OpenRead(ArchivePath);

                var reader = new StreamReader(archive.GetEntry(fileName).Open());

                contents = reader.ReadToEnd();

                reader.Dispose();
                archive.Dispose();
            }
            else
            {
                contents = File.ReadAllText($@"{ArchivePath}\{fileName}");
            }

            return contents;
        }

        /// <summary>
        /// Write content to a specific file entry inside a package.
        /// </summary>
        /// <param name="fileName">Name of entry to set contents of.</param>
        /// <param name="contents">Contents to write.</param>
        public void WriteFileContents(string fileName, string contents)
        {
            if (IsZipped)
            {
                var archive = ZipFile.Open(ArchivePath, ZipArchiveMode.Update);

                archive.GetEntry(fileName).Delete();
                archive.CreateEntry(fileName);

                var writer = new StreamWriter(archive.GetEntry(fileName).Open());

                writer.Write(contents);

                writer.Dispose();
                archive.Dispose();
            }
            else
            {
                File.WriteAllText($@"{ArchivePath}\{fileName}", contents);
            }
        }

        /// <summary>
        /// Execute a package at specified entry point (defined inside info.json).
        /// </summary>
        /// <param name="silent">Defines whether console shouldn't output the executed code.</param>
        

        /// <summary>
        /// Get files inside a package.
        /// </summary>
        /// <returns>Entries as a ZipArchiveEntry array.</returns>
        public object[] GetFiles()
        {
            if (IsZipped)
            {
                using (var archive = ZipFile.OpenRead(ArchivePath))
                {
                    return archive.Entries.ToArray();
                }
            }
            else
            {
                return Directory.GetFiles(ArchivePath);
            }
        }
    }
}

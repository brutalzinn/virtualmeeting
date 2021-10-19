using Cyclic.Redundancy.Check;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VirtualMeetingMonitor.ApiPluginManager.models;

namespace VirtualMeetingMonitor.Forms.WorshopForms.UserControllers
{
    public partial class PluginManager : UserControl
    {
        public PluginManager()
        {
            InitializeComponent();
        }
        private string Crc32 { get; set; }

        private string Hash { get; set; }

        private string Filename { get; set; }

        private void PluginManager_Load(object sender, EventArgs e)
        {

        }

        private static string GetHashSha(OpenFileDialog openfile)
        {
            using (SHA256 mySHA256 = SHA256.Create())
            {
                try
                {
                    FileStream fileStream = (FileStream)openfile.OpenFile();
                    // Be sure it's positioned to the beginning of the stream.
                    fileStream.Position = 0;
                    // Compute the hash of the fileStream.
                    byte[] hashValue = mySHA256.ComputeHash(fileStream);
                    fileStream.Close();

                    // Write the name and hash value of the file to the console.
                    return Core.BytesToString(hashValue);
                    // Close the file.
                }
                catch (IOException f)
                {
                    Console.WriteLine($"I/O Exception: {f.Message}");
                    return "ERRORSHA";
                }
            }
        }
        private static string GetHashCrc(OpenFileDialog openfile)
        {
            CRC cRC = new CRC();
            byte [] hash = cRC.ComputeHash((FileStream)openfile.OpenFile());
            return Core.BytesToString(hash);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Hash = GetHashSha(openFileDialog1);
                Crc32 = GetHashCrc(openFileDialog1);
                Filename = openFileDialog1.FileName;
            }       
        }

        private void button2_Click(object sender, EventArgs e)
        {
             FileModel _file = new FileModel();
            _file.Name = "Plugin Upado";
            _file.Filename = Filename;
            _file.Description = "Descrição obrigatória. blalbla";
            _file.Repo = "http://github.com/teste/pluginupado";
            _file.Version = new ExpandoObject();
            _file.Version.version = "1.0.0.0";
            _file.Version.sha = Hash;
            _file.Version.crc = Crc32;

         
         Workshop.PluginManagerWeb.addPackage(_file);    
        }
    }
}

using Cyclic.Redundancy.Check;
using Newtonsoft.Json;
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
using VirtualMeetingMonitor.PluginManager.models;

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

        private string Version { get; set; }

        private string Description { get; set; }

        private string PluginName { get; set; }   

        private string PluginId { get; set; }
        private bool isUpdate { get; set; } = false;


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

                dynamic pluginInfo = Package.GetPluginInfo(openFileDialog1.FileName);


                Hash = GetHashSha(openFileDialog1);
                Crc32 = GetHashCrc(openFileDialog1);
                Filename = openFileDialog1.FileName;
                PluginName = pluginInfo.Name;
                Version = pluginInfo.Version;
                Description = pluginInfo.Description;
                PluginId = pluginInfo.PluginId;

                if (pluginInfo != null)
                {
                        lbl_pluginInfo.Text = $"Name:{PluginName}\n" +
                        $"Description:{Description}\n " +
                        $"Version:{Version}\n" +
                        $"Hash:{Hash}\n" +
                        $"Crc32:{Crc32}\n " +
                        $"PluginId:{PluginId}";                  
                }

                isUpdate = Workshop.PluginManagerWeb.CheckPluginVersion(PluginId);

                if (isUpdate) {
                    btn_submit.Text = "Release new version";
                }
                else
                {
                    btn_submit.Text = "Upload";
                }
            }
        }
        public void Submit(bool _isUpdate = false)
        {
            isUpdate = _isUpdate;
            progressBar1.Maximum = 100;
            BackgroundWorker _worker = new BackgroundWorker();
            _worker.WorkerReportsProgress = true;
            _worker.DoWork += _worker_DoWork;

            _worker.ProgressChanged += _worker_ProgressChanged;
            _worker.RunWorkerAsync();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            Submit(isUpdate);
        }

        private void _worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }
        public void WriteTextSafe(Control control, string text)
        {

            MethodInvoker method = delegate
            {
                control.Text = text;

            };

            if (control.InvokeRequired)
            {
                // Call this same method but append THREAD2 to the text
                BeginInvoke(method);
            }
            else
                control.Text = text;
        }
        private void _worker_DoWork(object sender, DoWorkEventArgs e)
        {

            BackgroundWorker worker = sender as BackgroundWorker;

            if ((worker.CancellationPending == true))
            {
                e.Cancel = true;
              
            }
            else
            {
                FileModel _file = new FileModel();
                _file.Name = PluginName;
                _file.Filename = Filename;
                _file.Description = Description;
                _file.Repo = txb_repo.Text.Length > 0 ? txb_repo.Text : "";
                _file.Version = new VersionModel
                {
                    Version = Version,
                    Hash = Hash,
                    Crc = Crc32,
                    Unique_id = PluginId
                };
                switch (isUpdate)
                {
                    case true:
                        if (Workshop.PluginManagerWeb.updatePackage(_file))
                        {
                            worker.ReportProgress(100);
                        }
                        else
                        {
                            WriteTextSafe(lbl_status, Workshop.PluginManagerWeb.getResponseContent());
                            e.Cancel = true;
                        }
                        break;
                    case false:
                        if (Workshop.PluginManagerWeb.addPackage(_file))
                        {
                            worker.ReportProgress(100);
                        }
                        else
                        {
                            WriteTextSafe(lbl_status, Workshop.PluginManagerWeb.getResponseContent());
                            e.Cancel = true;
                        }


                        break;
                }
           
               

                System.Threading.Thread.Sleep(500);
                worker.ReportProgress(Workshop.PluginManagerWeb.getProgress());
            }

           
        }

        private void lbl_status_Click(object sender, EventArgs e)
        {

        }
    }
}

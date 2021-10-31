﻿using Cyclic.Redundancy.Check;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Dynamic;
using System.IO;
using System.IO.Compression;
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

        private string FolderPath { get; set; }

        private string Filename { get; set; }

        private string Version { get; set; }

        private string Description { get; set; }

        private string PluginName { get; set; }   

        private string PluginId { get; set; }
        private bool isUpdate { get; set; } = false;


        private void PluginManager_Load(object sender, EventArgs e)
        {

        }

        private static string GetHashSha(string file)
        {
            using (SHA256 mySHA256 = SHA256.Create())
            {
                try
                {


                    using (FileStream fs = File.OpenRead(file))
                    {

                        // Be sure it's positioned to the beginning of the stream.
                        fs.Position = 0;
                        // Compute the hash of the fileStream.
                        byte[] hashValue = mySHA256.ComputeHash(fs);
                        return Core.BytesToString(hashValue);
                    }
                    // Write the name and hash value of the file to the console.
                   
                    // Close the file.
                }
                catch (IOException f)
                {
                    Console.WriteLine($"I/O Exception: {f.Message}");
                    return "ERRORSHA";
                }
            }
        }
        private static string GetHashCrc(string file)
        {
            CRC cRC = new CRC();
            byte [] hash = cRC.ComputeHash(File.OpenRead(file));
            return Core.BytesToString(hash);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
               dynamic pluginInfo = JsonConvert.DeserializeObject<dynamic>(Package.GetPackageInfo(folderBrowserDialog1.SelectedPath));
                FolderPath = folderBrowserDialog1.SelectedPath;
                Filename = pluginInfo.Filename;
                Hash = GetHashSha(Filename);
                Crc32 = GetHashCrc(Filename);
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
                var archive = ZipFile.Open($@"{FolderPath}.zip", ZipArchiveMode.Create);
                Directory.GetFiles(FolderPath).ToList().ForEach(x => archive.CreateEntryFromFile(x, Path.GetFileName(x)));
                archive.Dispose();

                FileModel _file = new FileModel();
                _file.Name = PluginName;
                _file.Filename = FolderPath +".zip";
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

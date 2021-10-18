using Cyclic.Redundancy.Check;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VirtualMeetingMonitor.Forms.WorshopForms.UserControllers
{
    public partial class PluginManager : UserControl
    {
        public PluginManager()
        {
            InitializeComponent();
        }

        private void PluginManager_Load(object sender, EventArgs e)
        {

        }
        private static string BytesToString(byte [] bytes)
        {
            string result = "";
            foreach(byte b in bytes)
            {
                result += b.ToString("x2");
            }
            return result;
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
                    return BytesToString(hashValue);
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
            return BytesToString(hash);
        }
        private void button1_Click(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
               label1.Text = $"{GetHashSha(openFileDialog1)} \n {GetHashCrc(openFileDialog1)}";
            }

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
         
            
        }
    }
}

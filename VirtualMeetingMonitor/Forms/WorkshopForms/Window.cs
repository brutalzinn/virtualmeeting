using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using VirtualMeetingMonitor.ApiPluginManager.models;
using VirtualMeetingMonitor.formater;
using VirtualMeetingMonitor.Forms.WorkshopForms.UserControllers;
using VirtualMeetingMonitor.Forms.WorshopForms.UserControllers;

namespace VirtualMeetingMonitor.Forms.WorshopForms
{
    /// <summary>
    /// Main interface window.
    /// </summary>
    public partial class Window : System.Windows.Forms.Form
    {
        private List<string> commands = new List<string>();
        public Window()
        {
            InitializeComponent();
            Core.UserAccount.OnLoginSucess += UserAccount_OnLoginSucess;
            Core.UserAccount.OnLoginError += UserAccount_OnLoginError;

             Text = Globals.getAppName("PLUGIN MANAGER");

            //InfoVersion.Text = Application.ProductVersion;

            ConsoleOutput.Font = new System.Drawing.Font(Core.Fonts.Families[0], 10f);

            Package[] installedPackages = Workshop.GetInstalled();

            installedPackages.ToList().ForEach(x =>
            {
                Dictionary<string, string> packageInfo = x.GetInfo();

                PackageInfo p = new PackageInfo();
                p.NameLabel.Text = packageInfo["Name"];
                p.AuthorLabel.Text = packageInfo["Authors"];
                p.DescLabel.Text = packageInfo["Description"];
                p.Package = x;

                p.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left;

                InstalledPackagesList.Controls.Add(p);

               
            });

     //       var hoverColor = new ColorContainer(0, 0, 0);
     //       var cursorPos = new PointContainer(0, 0);

     //       var timer = new System.Timers.Timer();
     //       timer.Interval = 1000;
     //       timer.Elapsed += (s, a) =>
     //       {
     //           if (this == null)
     //               return;

     //           cursorPos = InputWrapper.GetCursorPos();
     //           hoverColor = ScreenWrapper.GetPixels(cursorPos.X, cursorPos.Y, 1, 1)[0][0];
                
     //           Invoke(new Action(() =>
     //           {
					//if (IsDisposed)
					//	return;

     //               ColorDisplay.Text = $"R: {hoverColor.R} G: {hoverColor.G} B: {hoverColor.B}";
     //               CursorPosDisplay.Text = $"X: {cursorPos.X} Y: {cursorPos.Y}";
     //           }));
     //       };
     //       timer.Start();
        }

        private void UserAccount_OnLoginError()
        {
            Core.WriteLine(new ColorContainer(255, 0, 0), "Authentication failed");
        }

        private void UserAccount_OnLoginSucess()
        {
         //   Core.WriteLine("Welcome,", new ColorContainer(255, 0, 255), Core.UserAccount.Name);
         //   Text = $"{Globals.getAppName("PLUGIN MANAGER")} - {Core.UserAccount.Name}";
            tab_login.Text = "Panel";
            tab_login.Controls.Clear();
            PluginManager tab_pm = new PluginManager();
            tab_login.Controls.Add(tab_pm);

            PluginUser tab_pu = new PluginUser();
            LoadWorkList(tab_pu.browserPackageList,isUser: true);

            TabPage tb = new TabPage();

            tb.Text = "My Plugins";
            tb.Controls.Add(tab_pu);

            optionsPanel.Controls.Add(tb);


         


        }

        private void scriptStop_Click(object sender, EventArgs e)
        {
            //Scripter.Stop();
        }

        private void consoleRun_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(ConsoleInput.Text))
                return;

            //Scripter.InjectLine(ConsoleInput.Text);
            Core.WriteLine($@"{Formatter.Format(ConsoleInput.Text)}");


            //commands.Insert(0, ConsoleInput.Text);

            //ConsoleInput.Text = "";
        }

        private void consoleInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                ConsoleRun.PerformClick();
                e.Handled = true;
            }
        }

        private void consoleInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                int i = commands.FindIndex(x => x == ConsoleInput.Text) + 1;

                if (commands.Count > 0 && i < commands.Count)
                    ConsoleInput.Text = commands[i];

                e.Handled = true;
            }

            if (e.KeyCode == Keys.Down)
            {
                int i = commands.FindIndex(x => x == ConsoleInput.Text) - 1;

                if (commands.Count > 0 && i >= 0)
                    ConsoleInput.Text = commands[i];

                e.Handled = true;
            }
        }

        private void consoleOutput_TextChanged(object sender, EventArgs e)
        {
            ConsoleOutput.ScrollToCaret();
        }

        private void consoleClearButton_Click(object sender, EventArgs e)
        {
            ConsoleOutput.Clear();
        }

        private void Window_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Scripter.Stop();

            //Core.DumpLog();

            //if (Core.Editor.InvokeRequired)
            //{
            //    Core.Editor.BeginInvoke(new Action(() =>
            //    {
            //        Core.Editor.Close();
            //    }));
            //}
        }
        private void LoadWorkList(TableLayoutPanel browserList, int page = 0, int size = 3, bool isUser = false)
        {

            WorkshopFetchButton.Text = "Fetching..";
            WorkshopFetchButton.Enabled = false;

            browserList.Controls.Clear();
          
            Task.Run(() =>
            {
                GenericFiles packages = Workshop.GetPackageList(page, size, isUser);

                Invoke(new Action(() =>
            {
           
                WorkshopFetchButton.Text = "Fetch";
                WorkshopFetchButton.Enabled = true;
                Core.WriteLine($"Current page: {packages.currentPage} - {page}");
                foreach (var package in packages.files)
                {
                    PackageInfoMinimal p = new PackageInfoMinimal();
                    p.NameLabel.Text = package.Name;
                    // p.na.Text = package.User["name"]
                    p.authorLabel.Text = package.User["name"];
                    p.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left;
                    browserList.Controls.Add(p);
                    p.DownloadButton.Click += (o, ce) =>
                    {
                        p.DownloadButton.Text = "Downloading..";
                        p.DownloadButton.Enabled = false;

                        WorkshopFetchButton.Enabled = false;

                        Workshop.DownloadPackage(package.Url, package.Name);

                        p.DownloadButton.Text = "Download";
                        p.DownloadButton.Enabled = true;

                        WorkshopFetchButton.Text = "Fetch";
                        WorkshopFetchButton.Enabled = true;

                        InstalledPackagesList.Controls.Clear();

                        Workshop.GetInstalled().ToList().ForEach(x =>
                        {
                            Dictionary<string, string> packageInfo = x.GetInfo();

                            PackageInfo i = new PackageInfo();
                            i.NameLabel.Text = packageInfo["Name"];
                            i.AuthorLabel.Text = packageInfo["Authors"];
                            i.DescLabel.Text = packageInfo["Description"];
                            i.Package = x;

                            i.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left;

                            InstalledPackagesList.Controls.Add(i);


                        });
                    };
                }
            }));
            });

        }
        private void workshopFetchButton_Click(object sender, EventArgs e)
        {
            linkLayoutPanel.Controls.Clear();
            Task.Run(() =>
            {
                GenericFiles packages = Workshop.GetPackageList();
                Invoke(new Action(() =>
                {
                    Debug.WriteLine($"COUNT TOTAL: {packages.totalPages}");
                    for (var i = 0; i < packages.totalPages; i++)
                    {
                        LinkLabel link_label = new LinkLabel();
                        link_label.Text = i.ToString();
                        link_label.Tag = i;
                        link_label.Anchor =  AnchorStyles.Right | AnchorStyles.Left;
                        link_label.Click += (o, ce) =>
                        {
                         //   Debug.WriteLine($"BUTTON CLICK: {(int)link_label.Tag}");
                          LoadWorkList(browserPackageList,(int)link_label.Tag);
                        };
                        linkLayoutPanel.Controls.Add(link_label);
                    }
                   // LoadWorkList();

                }));

            });

            LoadWorkList(browserPackageList);
        }

        private void packageSelectFolder_Click(object sender, EventArgs e)
        {
            //We need separate thread for this, one with STA state
            //This will be a crude but effective workaround
            Thread fileDialogThread = new Thread(() =>
            {
                PackageFolderSelectDialog.ShowDialog();

                Thread.CurrentThread.Interrupt();
            });

            fileDialogThread.TrySetApartmentState(ApartmentState.STA);
            fileDialogThread.Start();
            fileDialogThread.Join();

            if (!String.IsNullOrEmpty(PackageFolderSelectDialog.SelectedPath))
            {
                string pathJson = @$"{PackageFolderSelectDialog.SelectedPath}\info.json";
                PackageCreateFolder.Enabled = true;

                if (!File.Exists(pathJson))
                {
                    return;
                }
                string json = File.ReadAllText(@$"{PackageFolderSelectDialog.SelectedPath}\info.json");
                dynamic info = JsonConvert.DeserializeObject(json);

                PackageName.Text = info.Name;
                PackageAuthors.Text = info.Authors;
                PackageDescription.Text = info.Description;
                  

            }
        }

        private void packageCreateFolder_Click(object sender, EventArgs e)
        {
            List<TextBox> fields = new List<TextBox>() { PackageName, PackageAuthors, PackageDescription };

            if (fields.All(x => !String.IsNullOrEmpty(x.Text)))
            {
                Dictionary<string, string> info = new Dictionary<string, string>()
                {
                    ["Name"] = PackageName.Text,
                    ["Authors"] = PackageAuthors.Text,
                    ["Description"] = PackageDescription.Text,
                    ["Contact"] = ""
                };

               Workshop.CreatePackage(PackageFolderSelectDialog.SelectedPath, info);

                InstalledPackagesList.Controls.Clear();

                Workshop.GetInstalled().ToList().ForEach(x =>
                {
                    Dictionary<string, string> packageInfo = x.GetInfo();

                    PackageInfo i = new PackageInfo();
                    i.NameLabel.Text = packageInfo["Name"];
                    i.AuthorLabel.Text = packageInfo["Authors"];
                    i.DescLabel.Text = packageInfo["Description"];
                    i.Package = x;

                    i.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left;

                    InstalledPackagesList.Controls.Add(i);

                });
            }
           
              
        }

        private void openPackagesFolderButton_Click(object sender, EventArgs e)
        {
            Process.Start($@"{Application.ExecutablePath}\plugins");

        }

        private void checkUpdate_Click(object sender, EventArgs e)
        {
           // Core.WriteLine(new ColorContainer(89, 73, 163), "Checking for updates.", new ColorContainer(177, 31, 41), "\nWARNING: Using this function too often might get you temporarily IP banned from Github API!");

            using (var client = new WebClient())
            {
                client.Headers["User-Agent"] = "ScribeBot - Update Fetching";

                IEnumerable<JToken> tokens = JArray.Parse(client.DownloadString(Core.ReleaseAddress)).Children();

                var latestVersion = float.Parse(Regex.Match(tokens.First()["tag_name"].ToString(), @"\d+[.]\d+").Value);
                var currentVersion = float.Parse(Regex.Match(Core.Version, @"\d+[.]\d+").Value);

                if (latestVersion > currentVersion)
                {
                    //Core.WriteLine(new ColorContainer(89, 73, 163), $"New version is available: {tokens.First()["tag_name"]}.\nClick 'Update' to download and install the update.\nData folder will be backed up before the process.");
                    //downloadUpdate.Enabled = true;
                }
                
                  //  Core.WriteLine(new ColorContainer(89, 73, 163), "You have the latest version. No update is neccessary.");
            }
        }

        private void downloadUpdate_Click(object sender, EventArgs e)
        {
           
        }

        private void Window_Load(object sender, EventArgs e)
        {
            Core.WriteLine(new ColorContainer(255, 73, 255), $"You are running on version {Application.ProductVersion}");
        }

        private void optionsPanel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolTip_Popup(object sender, PopupEventArgs e)
        {

        }
        private void CloseForm(DialogResult result)
        {
         
            DialogResult = result;
            Close();
        }
        private void btn_ok_Click(object sender, EventArgs e)
        {
            CloseForm(DialogResult.OK);
        }

        private void login1_Load(object sender, EventArgs e)
        {

        }
    }
}

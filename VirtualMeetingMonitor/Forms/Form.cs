using AutoUpdaterDotNET;
using McMaster.NETCore.Plugins;
using Microsoft.Toolkit.Uwp.Notifications;
using Newtonsoft.Json;
using PluginInterface;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

using VirtualMeetingMonitor.formater;
using VirtualMeetingMonitor.Forms;
using VirtualMeetingMonitor.pluginUtils;
using VirtualMeetingMonitor.profile;
using VirtualMeetingMonitor.Utils;
using Windows.ApplicationModel.Activation;
using Windows.Data.Xml.Dom;
using Windows.Foundation.Collections;
using Windows.System;
using Windows.UI.Notifications;
using Timer = System.Windows.Forms.Timer;

namespace VirtualMeetingMonitor
{
    public partial class Form : System.Windows.Forms.Form
    {
        private readonly OnAirSign onAirSign = new OnAirSign();
        private readonly Network network = new Network();
        private readonly VirtualMeeting meeting = new VirtualMeeting();
        readonly Timer timer = new Timer();
        private bool call_running = false;
        private const string LogFileName = "meetings.txt";
        //google sheets integration
       

        private  bool GoogleEnabled = false;
        private bool NotificationEnabled = false;
        private bool DevMode = false;
        private string LangDirectory = "language";
 
        private int timeout = Properties.Settings.Default.timeout;
        private bool IsSleep = false;
     
        public enum Days
        {
            Sunday = 0,
            Monday = 1,
            Tuesday = 2,
            Wednesday = 3,
            Thursday = 4,
            Friday = 5,
            Saturday = 6,
        }
        public enum CustomDays
        {
            Monday = 1,
            Wednesday = 3,
        }
        public Form()
        {
            InitializeComponent();
            Globals.form = this;
     
      
            notifyIcon.Text = Text;
            notifyIcon.ContextMenuStrip = contextMenuStrip;

            timer.Interval = 1000;
            timer.Enabled = false;
            timer.Tick += OnTimerEvent;

            network.OutsideUDPTafficeReceived += Network_OutsideUDPTafficeReceived;
            network.StartListening();

            meeting.OnMeetingStarted += Meeting_OnMeetingStarted;
            meeting.OnMeetingEnded += Meeting_OnMeetingEnded;
            this.Size = new Size(382, 200);
            // init the UI text
            meetingTxt.Text = "";
            startedTxt.Text = "";
            IpTxt.Text = "";
            EnedTxt.Text = "";
            InboundTxt.Text = "";
            OutboundTxt.Text = "";
            TotalTxt.Text = "";
            BackColor = System.Drawing.Color.DarkGray;
            LoadProfiles();
            LoadPlugins();
            LoadFormater();
            LanguageLoad();

            LanguageConfig();
            UpdateProfileSettings();


            if (Properties.Settings.Default.firstRun)
            {
                Globals.showHelper("https://raw.githubusercontent.com/wiki/brutalzinn/zoom-monitor-googlesheets/Welcome-to-VirtualMeetingMonitor.md");
                Properties.Settings.Default.firstRun = false;
                Properties.Settings.Default.Save();
            }
            Translate();
            //DateTime thisDay = DateTime.Today;
            //int todayName = (int)thisDay.DayOfWeek;
            //Console.WriteLine(setHours(todayName));
            // ReadEntries();
            // CreateEntry();
        }
        private void Translate()
        {
            label_meeting.Text = Globals.getKey("label_meeting");
            label_started.Text = Globals.getKey("label_started");
            label_ended.Text = Globals.getKey("label_ended");
            label_ip.Text = Globals.getKey("label_ip");
            label_udp_packts.Text = Globals.getKey("label_udp_packts");
            label_inbound.Text = Globals.getKey("label_inbound");
            label_outbound.Text = Globals.getKey("label_outbound");
            label_total.Text = Globals.getKey("label_total");
            configTimeoutToolStripMenuItem.Text = Globals.getKey("config_tool_strip_menu");
            openLogToolStripMenuItem.Text  = Globals.getKey("log_tool_strip_menu");
            helpToolStripMenuItem.Text = Globals.getKey("help_tool_strip_menu");
            closeToolStripMenuItem.Text = Globals.getKey("close_tool_strip_menu");
            statusNoCallToolStripMenuItem.Text = Globals.getKey("meeting_status_no_running");
            endCallToolStripMenuItem.Text = Globals.getKey("endcall_tool_strip_menu");
            aboutToolStripMenuItem.Text = Globals.getKey("about_tool_strip_menu");
            notificationsToolStripMenuItem.Text = Globals.getKey("notifications_tool_strip_menu");
            enableSleepToolStripMenuItem.Text = Globals.getKey("notifications_tool_strip_menu_activate");

        }
        /// <summary>
        /// Google sheets migration process to plugin
        /// </summary>
        /// <param name="day"></param>
        /// <returns></returns>
        /// 
        //private void checkGoogleKey()
        //{
        //    if (File.Exists(GoogleSecret))
        //    {

        //        GoogleCredential credential;
        //        using (var stream = new FileStream(GoogleSecret, FileMode.Open, FileAccess.Read))
        //        {
        //            credential = GoogleCredential.FromStream(stream)
        //                .CreateScoped(Scopes);
        //        }
        //        service = new SheetsService(new BaseClientService.Initializer()
        //        {
        //            HttpClientInitializer = credential,
        //            ApplicationName = ApplicationName,
        //        });
        //        GoogleEnabled = true;
                
        //        WriteTextSafe(Status, CheckGoogleConnection() ? Globals.getKey("google_status_connected") : Globals.getKey("google_status_error"));
        //    }
        //    else
        //    {
        //        GoogleEnabled = false;
        //        WriteTextSafe(Status, Globals.getKey("google_status_error_critical"));
        //    }
        //}
   
        static string setHours(int day)
        {
            if (Enum.IsDefined(typeof(CustomDays), day))
            {
                return "7:00 - 12:00";
            }
            else
            {
                return "9:30 - 12:00";
            }
        }
        void CreateEntry()
        {

            var oblist = new List<object>();
            if (Globals.ProfileUtil.CurrentProfile.CustomDataGrid != null)
            {
                foreach(var item in Globals.ProfileUtil.CurrentProfile.CustomDataGrid.List)
                {
                    oblist.Add(Formatter.Format(item.Value));
                }
            }
            else
            {
                return;
            }
           
        }

        //static void ReadEntries()
        //{
        //    var range = $"{sheet}!A:C";
        //    SpreadsheetsResource.ValuesResource.GetRequest request =
        //            service.Spreadsheets.Values.Get(SpreadsheetId, range);

        //    var response = request.Execute();
        //    IList<IList<object>> values = response.Values;
        //    if (values != null && values.Count > 0)
        //    {
        //        foreach (var row in values)
        //        {
        //            // Print columns A to F, which correspond to indices 0 and 4.
        //            Console.WriteLine("{0}", row[0]);
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine("No data found.");
        //    }
        //}

        /// <summary>
        /// Migration process to google plugn
        /// </summary>
        /// <param name="ipHeader"></param>
        //static bool CheckGoogleConnection()
        //{
        //    try
        //    {
        //        var range = $"{sheet}!A:C";
        //        SpreadsheetsResource.ValuesResource.GetRequest request =
        //                service.Spreadsheets.Values.Get(SpreadsheetId, range);

        //        var response = request.Execute();
        //        return true;
        //    }
        //    catch
        //    {
        //        return false;
        //    }
          
        //}

        private void Network_OutsideUDPTafficeReceived(IPHeader ipHeader)
        {
            meeting.ReceivedUDP(ipHeader);
        }
        public void WriteStatusStrip(string text)
        {
            // notifyIcon. = "fsdfsdfd";
            notifyIcon.Text = this.Text + "\n" + text;
            MethodInvoker method = delegate
            {
                statusNoCallToolStripMenuItem.Text = text;

            };

            if (contextMenuStrip.InvokeRequired)
            {
                // Call this same method but append THREAD2 to the text
                BeginInvoke(method);
            }
            else
                statusNoCallToolStripMenuItem.Text = text;
        }
        private void Meeting_OnMeetingStarted()
        {
            if (call_running)
            {
                return;
            }
            int hue = 0;
            int sat = 254;

            if (meeting.IsTeamsMeeting())
            {
                hue = 225;
            }
            else if (meeting.IsDiscordMeeting())
            {
                hue = 270;
            }
            else if (meeting.IsZoomMeeting())
            {
                hue = 180;
            }
           
            onAirSign.TurnOn(hue, sat);
            LogMeeting(Globals.getKey("meeting_log_started"));
            WriteStatusStrip(Globals.getKey("meeting_status_running"));

            call_running = true;
            BackColor = System.Drawing.Color.Green;

            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            notifyIcon.Icon = ((Icon)(resources.GetObject("$this.Icon")));

            meetingTxt.Text = meeting.GetMeetingType();
            startedTxt.Text = DateTime.Now.ToString("MM/dd H:mm:ss");
            IpTxt.Text = meeting.GetIP();
            EnedTxt.Text = "";
        }


       private void Warn(string text)
        {
            MessageBox.Show(text);
        }
        static async System.Threading.Tasks.Task ShowWindwosNotificationController()
        {
            await Launcher.LaunchUriAsync(new System.Uri("ms-settings:notifications"));

        }
        public void errorNotification()
        {
            NotificationEnabled = false;
            ShowWindwosNotificationController().Wait();

        }
        public  void CheckNotification()
        {
            var notifier = ToastNotificationManagerCompat.CreateToastNotifier();
            var setting = notifier.Setting;
            switch (setting)
            {
                case NotificationSetting.Enabled:
                    // everything is great.
                    NotificationEnabled = true;
                    Console.WriteLine("habilitado");
                    break;

                case NotificationSetting.DisabledForApplication:
                    Warn(Globals.getKey("notification_error_disabled"));
                    errorNotification();
                    // await Launcher.LaunchUriAsync(new System.Uri("ms-settings:notifications"));

                    break;

                case NotificationSetting.DisabledForUser:
                    Warn(Globals.getKey("notification_error_user"));
                    errorNotification();

                    break;

                case NotificationSetting.DisabledByGroupPolicy:
                    Warn(Globals.getKey("notification_error_group"));
                    errorNotification();

                    break;

                case NotificationSetting.DisabledByManifest:
                    Warn(Globals.getKey("notification_error_manifest"));
                    errorNotification();

                    break;

                // Catch-all case for reasons that are defined
                // in future versions of Windows.
                default:
                    Warn(Globals.getKey("notification_error_not_found"));
                    NotificationEnabled = false;

                    break;
            }
        }
        public void WriteTextSafe(Control control,string text)
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
        private void EndMeeting()
        {
   
            LogMeeting(Globals.getKey("meeting_log_ended"));
            try
            {
                if (GoogleEnabled)
                {
                    CreateEntry();

                }
            }
            catch
            {
             WriteTextSafe(Status, Globals.getKey("google_status_error"));
            }
            BackColor = System.Drawing.Color.DarkGray;
            WriteStatusStrip(Globals.getKey("meeting_status_no_running"));
            WriteTextSafe(EnedTxt, DateTime.Now.ToString("MM/dd H:mm:ss"));

            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            notifyIcon.Icon = ((Icon)(resources.GetObject("notifyIcon.Icon")));
        }
        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            //Console.WriteLine("Timer iniciado. Aguardando timeout.");
            //while (true)
            //{
            //    Console.WriteLine("Tempo terminado.");
            //    if (!call_running)
            //    {

            //        EndMeeting();
            //        Console.WriteLine(" chamada foi fechada.");
            //    }
            //    else
            //    {
            //        call_running = true;
            //        Console.WriteLine("A chamada voltou.");
            //        break;
            //        //  backgroundWorker1.CancelAsync();
            //    }
            //    Thread.Sleep(5000);

            //}
            int value = (int)e.Argument;
            IsSleep = true;
            Thread.Sleep(value);
            IsSleep = false;
            CreateAndShowPrompt(Globals.getKey("notification_popup_text"));




        }
        private void Meeting_OnMeetingEnded()
        {
            // CreateEntry();

            //if (!NotificationEnabled)
            //{
            //    if (!backgroundWorker1.IsBusy)
            //    {
            //        backgroundWorker1.RunWorkerAsync();
            //    }
            //}
            //else
            //{
            if (!IsSleep )
            {
                CreateAndShowPrompt(Globals.getKey("notification_popup_text"));
            }
          

           call_running = false;

            
            //}

        }

        private void LogMeeting(string Msg)
        {
            string logEntry = $"{DateTime.Now:MM/dd H:mm:ss}: {Msg} - {meeting.GetIP()} {meeting.GetMeetingType()}";
            using (StreamWriter w = File.AppendText( LogFileName ))
            {
                w.WriteLine(logEntry);
            }
        }


        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void notifyIcon_Click(object sender, EventArgs e)
        {

         
        }

        private void handler_method(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Show();
                WindowState = FormWindowState.Normal;
            }
            Activate();
        }

        private void onAirOnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int hue = 255;
            int sat = 254;

            if (meeting.IsTeamsMeeting())
            {
                hue = 225;
            }
            else if (meeting.IsDiscordMeeting())
            {
                hue = 270;
            }
            else if (meeting.IsZoomMeeting())
            {
                hue = 180;
            }

            onAirSign.TurnOn(hue, sat);
        
        }

        private void onAirOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            onAirSign.TurnOff();
        }

        private void OnTimerEvent(object sender, EventArgs e)
        {
            InboundTxt.Text = meeting.GetUdpInbound().ToString();
            OutboundTxt.Text = meeting.GetUdpOutbound().ToString();
            TotalTxt.Text = meeting.GetUdpTotal().ToString();
            meeting.CheckMeetingStatus();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            ToastNotificationManagerCompat.Uninstall();

            network.Stop();
        }

        private void openLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessStartInfo pi = new ProcessStartInfo(LogFileName);
            pi.Arguments = Path.GetFileName(LogFileName);
            pi.UseShellExecute = true;
            pi.WorkingDirectory = Path.GetDirectoryName(LogFileName);
            pi.FileName = LogFileName;
            pi.Verb = "EDIT";

            Process.Start(pi);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Hide();
                //notifyIcon.Visible = true;
            }
        }
        /// <summary>
        /// Google sheets migration process to plugin
        /// </summary>
        /// <param name="day"></param>
        /// <returns></returns>
        /// 
        public void LanguageChangedEvent()
        {

            Console.WriteLine("#####Frog has Jumped!");

            if (Globals.CurrentLanguage != null)
            {
              //  LanguageConfig();
               // checkGoogleKey();
            }
        }
        private void LanguageLoad()
        {
            foreach (string path in Directory.GetFiles(Application.StartupPath + $@"\{LangDirectory}"))
            {
                Language _lang = new Language(Path.GetFileName(path), path, false);
                Globals.languages.Add(_lang);
            }
        }
        private void LanguageConfig()
        {
          

            if(Globals.ProfileUtil.CurrentProfile.Language != null)
            {
                string path = Application.StartupPath + $@"\{LangDirectory}\{Globals.ProfileUtil.CurrentProfile.Language}.json";
            
              
                Globals.CurrentLanguage = new Language(Path.GetFileName(path), path, false);
                Globals.CurrentLanguage.readLanguage();
             //   Globals.CurrentLanguage.LanguageChanged += LanguageChangedEvent;

                Console.WriteLine(Globals.CurrentLanguage.ToString());
                //Console.WriteLine(Globals.CurrentLanguage.getValue("notification_error_disabled"));
            }



        }
        private void internetWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            WriteTextSafe(lbl_arduino_status, $"Arduino: Checking..");

            AutoUpdater.LetUserSelectRemindLater = true;
            string jsonPath = Path.Combine(Environment.CurrentDirectory, "settings.json");
            AutoUpdater.PersistenceProvider = new JsonFilePersistenceProvider(jsonPath);
            AutoUpdater.ParseUpdateInfoEvent += AutoUpdaterOnParseUpdateInfoEvent;
            AutoUpdater.Start();
            string status = onAirSign.RunTest() ? "Online" : "Offline";
            WriteTextSafe(lbl_arduino_status, $"Arduino: {status}");


        }
        private void AutoUpdaterOnParseUpdateInfoEvent(ParseUpdateInfoEventArgs args)
        {
            RestClient client = new RestClient("https://api.github.com/repos/brutalzinn/zoom-monitor-googlesheets/releases/latest");
            var request = new RestRequest(Method.GET);
            dynamic deserializedProduct = JsonConvert.DeserializeObject(client.Execute(request).Content);
            args.UpdateInfo = new UpdateInfoEventArgs
            {
                CurrentVersion = deserializedProduct.tag_name,
                DownloadURL = deserializedProduct.assets[0].browser_download_url,
                ChangelogURL = "https://github.com/brutalzinn/zoom-monitor-googlesheets/releases/latest"
            };
        }
            private void Form_Load(object sender, EventArgs e)
        {
            internetWorker.RunWorkerAsync();
            lbl_version.Text = $"Version: {Application.ProductVersion}";
            setDevModeGroup(Globals.ProfileUtil.CurrentProfile.DevMode);
            CheckNotification();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EndMeeting();
        }

        private void configTimeoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Config config = new Config();
            config.ShowDialog();
        }
        //https://stackoverflow.com/questions/58136119/windows-action-center-toast-activation

        public void CreateAndShowPrompt(string message)
        {
            string ButtonYes = Globals.getKey("notification_button_yes");
            string ButtonNo = Globals.getKey("notification_button_no");
            ToastSelectionBox selection = new ToastSelectionBox("delay");
            selection.Items.Add(new ToastSelectionBoxItem("1", Globals.getKey("notification_button_sleeper_five")));
            selection.Items.Add(new ToastSelectionBoxItem("2", Globals.getKey("notification_button_sleeper_fiveteen")));
            selection.Items.Add(new ToastSelectionBoxItem("3", Globals.getKey("notification_button_sleeper_thirty")));
            selection.Items.Add(new ToastSelectionBoxItem("4", Globals.getKey("notification_button_sleeper_one_hour")));
            selection.Items.Add(new ToastSelectionBoxItem("5", Globals.getKey("notification_button_sleeper_custom")));
            ToastContent toastContent = new ToastContent()
            {
                Launch = "bodyTapped",

                Visual = new ToastVisual()
                {
                    BindingGeneric = new ToastBindingGeneric()
                    {
                        Children =
                        {
                            new AdaptiveText()
                            {
                                Text = message
                            },

                        }
                    }
                },
                Actions = new ToastActionsCustom()
                {
                    Inputs = { selection },

                    Buttons = { new ToastButton(ButtonYes, "Yes"), new ToastButton(ButtonNo, "No") }
                   
                },
                Header = new ToastHeader("header", "VirtualMeetingMonitor - User manager", "header")
            };
            var doc = new XmlDocument();
            doc.LoadXml(toastContent.GetContent());
            var promptNotification = new ToastNotification(doc);
            promptNotification.Activated += PromptNotificationOnActivated;        
            ToastNotificationManagerCompat.CreateToastNotifier().Show(promptNotification);
        }
        private void PromptNotificationOnActivated(ToastNotification sender, object args)
        {
            ToastActivatedEventArgs strArgs = args as ToastActivatedEventArgs;
            switch (strArgs.Arguments)
            {
                case "Yes":
                    break;
                case "No":
                    call_running = false;
                    EndMeeting();
                    onAirSign.TurnOff();
                    break;
                case "bodyTapped":
                    break;
            }
            switch (strArgs.UserInput["delay"])
            {
                case "1":               
                    backgroundWorker1.RunWorkerAsync(argument: 300000);
                    break;
                case "2":
                    backgroundWorker1.RunWorkerAsync(argument: 900000);
                    break;
                case "3":
                    backgroundWorker1.RunWorkerAsync(argument: 1800000);
                    break;
                case "4":
                    backgroundWorker1.RunWorkerAsync(argument: 3600000);
                    break;
                case "5":
                    DateTime dateTime = DateTime.Parse(Globals.ProfileUtil.CurrentProfile.CustomTime);
                    TimeSpan span = dateTime - DateTime.Now;
                    backgroundWorker1.RunWorkerAsync(argument: (int)span.TotalMilliseconds);
                    break;
                default:
                    IsSleep = false;
                    break;

            }


        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (!IsSleep)
            {
                CreateAndShowPrompt(Globals.getKey("notification_popup_text"));
            }  
        }
        private void setDevModeGroup(bool mode)
        {
            DevMode = mode;
            devGroupBox.Enabled = mode;
            devGroupBox.Visible = mode;
            string devMode = mode ? "Dev" : "Normal";
            Dev_LabelMode.Text = $"Mode: {devMode}";
            if (mode)
            {
                this.Size = new Size(445, 413);
            }
            else
            {
                this.Size = new Size(382, 200);

            }
        }
        private void Form_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (!DevMode)
            {
                setDevModeGroup(true);
            }
            else
            {
                setDevModeGroup(false);
            }

        }

        private void Dev_ClearConfigs_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reset();
        }
        private void pluginManagertoolStripMenuItem_Click(object sender, EventArgs e)
        {
            Core.Initialize();      
         }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/brutalzinn/zoom-monitor-googlesheets/issues");
        }

        private void Dev_helpButton_Click(object sender, EventArgs e)
        {
          
        }
        /// <summary>
        /// Migration process to google sheets plugin
        /// </summary>
        private void UpdateProfileSettings()
        {
            //            private static string SpreadsheetId = Properties.Settings.Default.googlesheetsID;
            //private static string sheet = Properties.Settings.Default.sheetName;
           // SpreadsheetId = Globals.ProfileUtil.CurrentProfile.GoogleKey;
        //    sheet = Globals.ProfileUtil.CurrentProfile.SheetId;
         //   Text = $"{ApplicationName} - {Globals.ProfileUtil.CurrentProfile.Name}";
            Translate();
         //   checkGoogleKey();
            Console.WriteLine("EVENT CALLED");
    }
        private void LoadProfiles()
        {

            string path = Application.StartupPath + @"\config.json";
            if (!File.Exists(path))
            {
                var _customdays = new CustomDaysUtils(new List<int> { }, "", "");
                var _customdatagrid = new CustomDataGridUtils(new Dictionary<int,string> { }, true);

                Profile _default = new Profile("default", "", "", "", 0, "en");
                _default.CustomDays = _customdays;
                _default.PluginsSettings = new List<object>();
                _default.CustomDataGrid = _customdatagrid;
                Globals.ProfileUtil.CurrentProfile = _default;
                Globals.ProfileUtil.profiles.Add(_default);
                string output = JsonConvert.SerializeObject(Globals.ProfileUtil, Formatting.Indented);
                File.WriteAllText(path, output);
            }
            string json = File.ReadAllText(path);
            ProfileUtils profiles = JsonConvert.DeserializeObject<ProfileUtils>(json);
            Globals.ProfileUtil.profiles = profiles.profiles;
            Globals.ProfileUtil.CurrentProfile = profiles.CurrentProfile;
            //Text = $"{ApplicationName} - {Globals.ProfileUtil.CurrentProfile.Name}";
            Globals.ProfileUtil.ProfileChanged += UpdateProfileSettings;

        }
        public string teste()
        {
            return "Testandooo é golpe.";
        }
        public string date()
        {
            return DateTime.Today.ToString("d");
        }
        public string customday()
        {
            return Globals.ProfileUtil.CurrentProfile.CustomDays.checkToday();
        }
        private void LoadFormater()
        {
            MethodExecutor _methodExecutorA = new MethodExecutor("TESTE", Globals.Methods, teste);
            MethodExecutor _methodExecutorB = new MethodExecutor("TODAY", Globals.Methods, date);
            MethodExecutor _methodExecutorC = new MethodExecutor("CUSTOMDAY", Globals.Methods, customday);
            foreach (var loader in Globals.loaders)
            {
                foreach (var pluginType in loader
                    .LoadDefaultAssembly()
                    .GetTypes()
                    .Where(t => typeof(IPlugin).IsAssignableFrom(t) && !t.IsAbstract))
                {
                    // This assumes the implementation of IPlugin has a parameterless constructor
                    IPlugin plugin = (IPlugin)Activator.CreateInstance(pluginType) ;
                   
                     


                        //Debug.WriteLine($"Created plugin instance '{plugin?.Name()}'.");


                    if (plugin is IConfig IConfigPlugin)
                    {
                        dynamic pluginConfig = PluginUtils.loadData(Globals.ProfileUtil.CurrentProfile, IConfigPlugin);

                        if (pluginConfig != null)
                        {
                            IConfigPlugin.loadConfigData(pluginConfig);
                        }
                    }
                    Debug.WriteLine($"PLUGIN:{plugin?.Name()}-{plugin?.getPluginId()} ");

                    if (plugin is ITextFormat PluginTextFormat)
                    {
                        if (PluginTextFormat != null)
                        {
                            foreach (var item in PluginTextFormat.GetPlaceHolder())
                            {
                                new MethodExecutor(item.Key.ToUpper(), Globals.Methods, item.Value);
                            }
                        }
                    }
                 


                  



                }

            }

          
            Globals.CustomFormater = new CustomerFormatter(Globals.Methods);
            lbl_tags_count.Text = $"Tags: {Globals.Methods.Count} loaded";
        }
        private void LoadPlugins()
        {
            var pluginsDir = Path.Combine(AppContext.BaseDirectory, "plugins");
            foreach (var dir in Directory.GetDirectories(pluginsDir))
            {
                var dirName = Path.GetFileName(dir);
                var pluginDll = Path.Combine(dir, dirName + ".dll");
                if (File.Exists(pluginDll))
                {
                    var loader = PluginLoader.CreateFromAssemblyFile(
                        pluginDll,
                        sharedTypes: new[] { typeof(IPlugin) });
                    Globals.loaders.Add(loader);
                }
             
            }

            lbl_plugin_count.Text = $"Plugins: {Globals.loaders.Count} loaded";
        }
        private void Dev_ButtonTeste_Click(object sender, EventArgs e)
        {
          //  Debug.WriteLine(Formatter.Format("Esse é um exemplo de plugin [PLUGINEXAMPLE]"));
            Core.Initialize();
            // Create an instance of plugin types
            
        }
        private void Dev_Config_Click(object sender, EventArgs e)
        {
            Console.WriteLine("LANG TESTE");
            LanguageConfig();
        }

        private void Dev_TestGoogle_Click(object sender, EventArgs e)
        {
            CreateEntry();
        }

        private void endCallToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void endCallToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            EndMeeting();
        }

        private void notificationstatusToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }



        private void CancelSleepToolStripMenuItem_Click(object sender, EventArgs e)
        {
       

        }

        private void contextMenuStrip_Opened(object sender, EventArgs e)
        {

            notificationstatusToolStripMenuItem.Text = IsSleep ?  Globals.getKey("notifications_tool_strip_menu_status_disabled") : Globals.getKey("notifications_tool_strip_menu_status_running");
        }

        private void enableSleepToolStripMenuItem_Click(object sender, EventArgs e)
        {
            backgroundWorker1.CancelAsync();
            IsSleep = false;
        }

        private void aboutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Helper helper = new Helper();
            helper.markdown = Globals.getHtmlVersion();
            helper.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void dev_btn_pluginmanage_Click(object sender, EventArgs e)
        {
            Core.Initialize();

        }
    }
}

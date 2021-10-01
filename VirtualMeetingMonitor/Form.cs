﻿using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;
using Microsoft.Toolkit.Uwp.Notifications;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Threading;
using System.Windows.Forms;
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
       
        static readonly string[] Scopes = { SheetsService.Scope.Spreadsheets };
        static readonly string ApplicationName = "Virtual Meeting teste";
        static readonly string GoogleSecret = "client_secret.json";
        private  bool GoogleEnabled = false;
        private bool NotificationEnabled = false;
        private bool DevMode = false;

        static readonly string SpreadsheetId = "1zWxyFh-0jkeN4pU9engXjOaDloM4torbEn286ShwL14";
        static readonly string sheet = "roberto-roboto";
        private int timeout = Properties.Settings.Default.timeout;

        static SheetsService service;
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

            notifyIcon.Text = Text;
            notifyIcon.ContextMenuStrip = contextMenuStrip;

            timer.Interval = 1000;
            timer.Enabled = true;
            timer.Tick += OnTimerEvent;

            network.OutsideUDPTafficeReceived += Network_OutsideUDPTafficeReceived;
            network.StartListening();
          
            meeting.OnMeetingStarted += Meeting_OnMeetingStarted;
            meeting.OnMeetingEnded += Meeting_OnMeetingEnded;

            // init the UI text
            meetingTxt.Text = "";
            startedTxt.Text = "";
            IpTxt.Text = "";
            EnedTxt.Text = "";
            InboundTxt.Text = "";
            OutboundTxt.Text = "";
            TotalTxt.Text = "";
            BackColor = System.Drawing.Color.DarkGray;
            if (File.Exists(GoogleSecret))
            {
            GoogleCredential credential;
            using (var stream = new FileStream(GoogleSecret, FileMode.Open, FileAccess.Read))
            {
                credential = GoogleCredential.FromStream(stream)
                    .CreateScoped(Scopes);
            }
            // Create Google Sheets API service.
            service = new SheetsService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });
            GoogleEnabled = true;
            WriteTextSafe(Status, CheckGoogleConnection() ? "Google Sheets API Connected." : "Error with google sheets api.");
            }
            else
            {
                GoogleEnabled = false;
                WriteTextSafe(Status,  "Google API Key not found. \n Check github README for more details about it.");
            }
            if (Properties.Settings.Default.firstRun)
            {
                showHelper("https://raw.githubusercontent.com/wiki/brutalzinn/zoom-monitor-googlesheets/Welcome-to-VirtualMeetingMonitor.md");
                Properties.Settings.Default.firstRun = false;
                Properties.Settings.Default.Save();
            }
            //DateTime thisDay = DateTime.Today;
            //int todayName = (int)thisDay.DayOfWeek;
            //Console.WriteLine(setHours(todayName));
            // ReadEntries();
            // CreateEntry();
        }
        private void showHelper(string url)
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
        static string setHours(int day)
        {
            if (Enum.IsDefined(typeof(CustomDays), day))
            {
                return "7:00 - 12:00";
            }
            else
            {
                return "9:00 - 12:00";
            }
        }
        static void CreateEntry()
        {
          
            DateTime thisDay = DateTime.Today;
            int todayName = (int)thisDay.DayOfWeek;
            var range = $"{sheet}!A:C";
            var valueRange = new ValueRange();

            var oblist = new List<object>() { thisDay.ToString("d"), setHours(todayName) };
            valueRange.Values = new List<IList<object>> { oblist };

            var appendRequest = service.Spreadsheets.Values.Append(valueRange, SpreadsheetId, range);
            appendRequest.ValueInputOption = SpreadsheetsResource.ValuesResource.AppendRequest.ValueInputOptionEnum.USERENTERED;
            var appendReponse = appendRequest.Execute();
        }

        static void ReadEntries()
        {
            var range = $"{sheet}!A:C";
            SpreadsheetsResource.ValuesResource.GetRequest request =
                    service.Spreadsheets.Values.Get(SpreadsheetId, range);

            var response = request.Execute();
            IList<IList<object>> values = response.Values;
            if (values != null && values.Count > 0)
            {
                foreach (var row in values)
                {
                    // Print columns A to F, which correspond to indices 0 and 4.
                    Console.WriteLine("{0}", row[0]);
                }
            }
            else
            {
                Console.WriteLine("No data found.");
            }
        }
        static bool CheckGoogleConnection()
        {
            try
            {
                var range = $"{sheet}!A:C";
                SpreadsheetsResource.ValuesResource.GetRequest request =
                        service.Spreadsheets.Values.Get(SpreadsheetId, range);

                var response = request.Execute();
                return true;
            }
            catch
            {
                return false;
            }
          
        }

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
            int hue = 0;
            int sat = 254;

            if (meeting.IsTeamsMeeting())
            {
                hue = 43690;
            }
            else if (meeting.IsWebExMeeting())
            {
                hue = 21845;
            }
            else if (meeting.IsZoomMeeting())
            {
                hue = 0;
            }

          ///  onAirSign.TurnOn(hue, sat);
            LogMeeting("Started");
            WriteStatusStrip("Status: Meeting running");

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
                    Warn("Please go to Settings, System, Notifications & Actions " +
                         "and enable this application in the " +
                
                         "'Get notifications from these senders' list.");
                    errorNotification();
                    // await Launcher.LaunchUriAsync(new System.Uri("ms-settings:notifications"));

                    break;

                case NotificationSetting.DisabledForUser:
                    Warn("Please go to Settings, System, Notifications & Actions " +
                         "and set " +
         
                         "'Get notifications from apps and other senders' to On.");
                    errorNotification();

                    break;

                case NotificationSetting.DisabledByGroupPolicy:
                    Warn("Your system administrator has prevented us from " +
                         "showing notifications.");
                    errorNotification();

                    break;

                case NotificationSetting.DisabledByManifest:
                    Warn("Oops. We forgot to ask the operating system for permission " +
                         "to display toast notifications. Please file a bug.");
                    errorNotification();

                    break;

                // Catch-all case for reasons that are defined
                // in future versions of Windows.
                default:
                    Warn("It doesn't look like toast notifications are enabled, " +
                         "but we don't know why.");
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
   
            LogMeeting("Ended  ");
            try
            {
                if (GoogleEnabled)
                {
                    CreateEntry();

                }
            }
            catch
            {
             WriteTextSafe(Status, "Error with google sheets API.");
            }
            BackColor = System.Drawing.Color.DarkGray;
            WriteStatusStrip("Status: No meeting running");
            WriteTextSafe(EnedTxt, DateTime.Now.ToString("MM/dd H:mm:ss"));

            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            notifyIcon.Icon = ((Icon)(resources.GetObject("notifyIcon.Icon")));
        }
        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            Console.WriteLine("Timer iniciado. Aguardando timeout.");
            while (true)
            {
                Console.WriteLine("Tempo terminado.");
                if (!call_running)
                {

                    EndMeeting();
                    Console.WriteLine(" chamada foi fechada.");
                }
                else
                {
                    call_running = true;
                    Console.WriteLine("A chamada voltou.");
                    break;
                    //  backgroundWorker1.CancelAsync();
                }
                Thread.Sleep(5000);

            }


        }
        private void Meeting_OnMeetingEnded()
        {
            //   onAirSign.TurnOff();
            // CreateEntry();
            call_running = false;

            if (!NotificationEnabled)
            {
                if (!backgroundWorker1.IsBusy)
                {
                    backgroundWorker1.RunWorkerAsync();
                }
            }
            else
            {
                CreateAndShowPrompt("Are you still on call?");

            }

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
            onAirSign.TurnOn(0, 254);
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

        private void LanguageConfig()
        {
            foreach (string path in Directory.GetFiles(@"\language")){
                Console.WriteLine(path);
            }
        }
        private void Form_Load(object sender, EventArgs e)
        {
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
                    Buttons = { new ToastButton("Yes", "Yes"), new ToastButton("No", "No") }
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
                    //stuff
                    Console.WriteLine("Yes");
                    break;
                case "No":
                    Console.WriteLine("No");
                    EndMeeting();

                    //stuff
                    break;
                case "bodyTapped":
                    //stuff
                    break;
            }

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            CreateAndShowPrompt("Are you still on call?");



        }
        private void setDevModeGroup(bool mode)
        {
            DevMode = mode;
            devGroupBox.Enabled = mode;
            devGroupBox.Visible = mode;
            string devMode = mode ? "Dev" : "Normal";
            Dev_LabelMode.Text = $"Mode: {devMode}";
        }
        private void Form_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (!DevMode)
            {
                setDevModeGroup(true);
                this.Size = new Size(382, 354);
            }
            else
            {
                setDevModeGroup(false);
                this.Size = new Size(382, 230);

            }
            
        }

        private void Dev_ClearConfigs_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reset();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        





        }
  
        private void Dev_helpButton_Click(object sender, EventArgs e)
        {
          
        }

        private void Dev_ButtonTeste_Click(object sender, EventArgs e)
        {
            LanguageConfig();
        }
    }
}

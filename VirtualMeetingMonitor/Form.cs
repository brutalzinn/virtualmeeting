using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace VirtualMeetingMonitor
{
    public partial class Form : System.Windows.Forms.Form
    {
        private readonly OnAirSign onAirSign = new OnAirSign();
        private readonly Network network = new Network();
        private readonly VirtualMeeting meeting = new VirtualMeeting();
        readonly Timer timer = new Timer();
        private const string LogFileName = "meetings.txt";
        //google sheets integration
       
        static readonly string[] Scopes = { SheetsService.Scope.Spreadsheets };
        static readonly string ApplicationName = "Virtual Meeting teste";
        static readonly string SpreadsheetId = "1zWxyFh-0jkeN4pU9engXjOaDloM4torbEn286ShwL14";
        static readonly string sheet = "roberto-roboto";
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
            GoogleCredential credential;
            using (var stream = new FileStream("client_secret.json", FileMode.Open, FileAccess.Read))
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
            //DateTime thisDay = DateTime.Today;
            //int todayName = (int)thisDay.DayOfWeek;
            //Console.WriteLine(setHours(todayName));
            // ReadEntries();
            // CreateEntry();
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

        private void Network_OutsideUDPTafficeReceived(IPHeader ipHeader)
        {
            meeting.ReceivedUDP(ipHeader);
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

            onAirSign.TurnOn(hue, sat);
            LogMeeting("Started");
            BackColor = System.Drawing.Color.Green;

            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            notifyIcon.Icon = ((Icon)(resources.GetObject("$this.Icon")));

            meetingTxt.Text = meeting.GetMeetingType();
            startedTxt.Text = DateTime.Now.ToString("MM/dd H:mm:ss");
            IpTxt.Text = meeting.GetIP();
            EnedTxt.Text = "";
        }

        private void Meeting_OnMeetingEnded()
        {
            onAirSign.TurnOff();
            CreateEntry();
            LogMeeting("Ended  ");
            BackColor = System.Drawing.Color.DarkGray;

            EnedTxt.Text = DateTime.Now.ToString("MM/dd H:mm:ss");

            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            notifyIcon.Icon = ((Icon)(resources.GetObject("notifyIcon.Icon")));
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

        private void Form_Load(object sender, EventArgs e)
        {

        }
    }
}

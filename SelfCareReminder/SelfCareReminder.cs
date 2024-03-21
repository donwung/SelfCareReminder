using System.Configuration;
using System.Diagnostics;
using Newtonsoft.Json.Linq;
using System.Windows.Input;
using RemindersLibrary;
using SettingsMenu;
using System.Drawing.Text;
using System.Runtime.InteropServices;


namespace SelfCareReminder
{
    public partial class SelfCareReminder : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private List<ReminderModel> reminders = new List<ReminderModel>();
        private System.Collections.Specialized.NameValueCollection config = System.Configuration.ConfigurationManager.AppSettings;

        private static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);
        private const UInt32 SWP_NOSIZE = 0x0001;
        private const UInt32 SWP_NOMOVE = 0x0002;
        private const UInt32 TOPMOST_FLAGS = SWP_NOMOVE | SWP_NOSIZE;

        private bool AlwaysOnTop = true;
        private List<ReminderBubble> ReminderBubbleList = new List<ReminderBubble>();

        public int count = 0;

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

        public SelfCareReminder()
        {
            InitializeComponent();
            Debug.WriteLine(config["testkey"]);
            //SetWindowPos(this.Handle, HWND_TOPMOST, 0, 0, 0, 0, TOPMOST_FLAGS);

            System.Windows.Forms.Timer AlwaysOnTopTimer = new System.Windows.Forms.Timer();
            AlwaysOnTopTimer.Interval = 1;
            AlwaysOnTopTimer.Tick += new EventHandler(AlwaysOnTopTick);
            AlwaysOnTopTimer.Start();

            OpenSettingsBtn.Visible = false;
        }

        private void AlwaysOnTopTick(object sender, EventArgs e)
        {
            if (AlwaysOnTop)
            {
                TopMost = true;
            }
        }


        private void SelfCareReminder_Load(object sender, EventArgs e)
        {
            var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var settings = configFile.AppSettings.Settings;


            //label1.Text = "Test text";
            //panel1.Visible = false;
            //System.Windows.Forms.Timer MyTimer = new System.Windows.Forms.Timer();
            MyTimer.Interval = Int32.Parse(settings["Interval"].Value);
            MyTimer.Tick += new EventHandler(ShowReminder_Tick);
            MyTimer.Start();
            HideBackgroundStyle();
            LoadSettings(sender, e);


        }

        private void LoadSettings(object sender, EventArgs e)
        {
            // DRY this
            var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var settings = configFile.AppSettings.Settings;

            //grabs enabled reminders
            reminders = SqlConnection.GetAllEnabled();
            //updates tick interval
            MyTimer.Interval = Int32.Parse(settings["Interval"].Value);
            AlwaysOnTop = true;
        }

        private void HideBackgroundStyle()
        {
            //Removes styling and leave only the images
            this.ControlBox = false;
            this.Text = String.Empty;

            this.BackColor = Color.LimeGreen;
            this.TransparencyKey = Color.LimeGreen;

            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }


        private void ShowReminder_Tick(object sender, EventArgs e)
        {
            //label1.Text = "";
            if (reminders.Count <= 0)
            {
                //Debug.WriteLine("writing in appconfig");
                //label1.Text = "No Reminders Enabled";
            }
            else // Show a new reminder
            {
                int rand = SpecialRandomize();
                //label1.Text = reminders[rand].Reminder;


                // TODO: make a queue to limit the amount of forms that show up
                ReminderBubble _NewReminderBubble = new ReminderBubble(reminders[rand], Location);
                _NewReminderBubble.FormClosing += ReminderBubble_FormClosing;
                _NewReminderBubble.Show();
                ReminderBubbleList.Add(_NewReminderBubble);
                if (ReminderBubbleList.Count > 5)
                {
                    // Closes oldest
                    ReminderBubbleList[0].Close();
                    Debug.WriteLine(ReminderBubbleList.Count);
                } 
            }
            //panel1.Visible = true;


            FadeReminderTimer.Interval = 10000;
            FadeReminderTimer.Stop();
            FadeReminderTimer.Start();
        }

        private void ReminderBubble_FormClosing(object sender, EventArgs e)
        {
            var closedForm = sender as ReminderBubble;
            ReminderBubbleList.Remove(closedForm);
        }

        private int previousRand;
        private int SpecialRandomize()
        {
            int rand = new Random().Next(reminders.Count);
            if (rand == previousRand)
            {
                rand = SpecialRandomize();
            }
            else
            {
                previousRand = rand;
                return rand;
            }
            return rand;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            // TODO: open a dialog to confirm close
        }

        private void Mascot_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Mascot_DoubleClick(object sender, EventArgs e)
        {
            //TODO: maybe an animation functionality?
            Debug.WriteLine("Opening Settings");

        }

        private void Mascot_MouseEnter(object sender, EventArgs e)
        {
            //Debug.WriteLine("mouse entered");
            OpenSettingsBtn.Visible = true;
            HideSettingsTimer.Interval = 3000;
            HideSettingsTimer.Stop();
            HideSettingsTimer.Start();
            HideSettingsTimer.Tick += new EventHandler(HideSettingsBtn);
        }

        private void HideSettingsBtn(object sender, EventArgs e)
        {
            OpenSettingsBtn.Visible = false;
        }

        private void OpenSettingsBtn_Click(object sender, EventArgs e)
        {
            AlwaysOnTop = false;
            TopMost = false;
            Form Settings = new Settings();
            Settings.StartPosition = FormStartPosition.Manual;
            Settings.Location = this.Location;
            Settings.FormClosed += new FormClosedEventHandler(LoadSettings);
            Settings.ShowDialog();
        }

        private void FadeReminderTimer_Tick(object sender, EventArgs e)
        {
            Debug.WriteLine("fadeaway timer");
            FadeReminderTimer.Stop();
            //panel1.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DBG_NewReminder_Click(object sender, EventArgs e)
        {
            ShowReminder_Tick(sender, EventArgs.Empty);
        }

        private void DBG_PrintLast5_Click(object sender, EventArgs e)
        {

        }
    }
}

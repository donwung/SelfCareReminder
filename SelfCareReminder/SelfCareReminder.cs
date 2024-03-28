using System.Configuration;
using System.Diagnostics;
using Newtonsoft.Json.Linq;
using System.Windows.Input;
using RemindersLibrary;
using SettingsMenu;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.Numerics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;


namespace SelfCareReminder
{
    public partial class SelfCareReminder : Form
    {
        // Needed for grabbable mascot
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        // End grabbable mascot declaration


        private List<ReminderModel> reminders = new List<ReminderModel>();
        private System.Collections.Specialized.NameValueCollection config = System.Configuration.ConfigurationManager.AppSettings;

        private static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);
        private const UInt32 SWP_NOSIZE = 0x0001;
        private const UInt32 SWP_NOMOVE = 0x0002;
        private const UInt32 TOPMOST_FLAGS = SWP_NOMOVE | SWP_NOSIZE;

        private bool AlwaysOnTop = true;
        
        private int ReminderBubbleListMax = 5;
        private int PopupTickInterval = 60000;

        private List<ReminderBubble> ReminderBubbleList = new List<ReminderBubble>();

        public int count = 0;

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

        public SelfCareReminder()
        {
            Refresh();
            InitializeComponent();
            DebugControls.Visible = false;
        }

        private void AlwaysOnTopTick(object sender, EventArgs e)
        {
            if (AlwaysOnTop)
                TopMost = true;
        }


        private void SelfCareReminder_Load(object sender, EventArgs e)
        {
            Refresh();
            //label1.Text = "Test text";
            //panel1.Visible = false;
            //System.Windows.Forms.Timer MyTimer = new System.Windows.Forms.Timer();
            System.Windows.Forms.Timer AlwaysOnTopTimer = new System.Windows.Forms.Timer();
            AlwaysOnTopTimer.Interval = 1;
            AlwaysOnTopTimer.Tick += new EventHandler(AlwaysOnTopTick);
            AlwaysOnTopTimer.Start();

            Debug.WriteLine(PopupTickInterval.ToString());

            MyTimer.Interval = PopupTickInterval;
            MyTimer.Tick += new EventHandler(ShowReminder_Tick);
            MyTimer.Start();
            HideBackgroundStyle();
            Refresh(sender, e);

            OpenSettingsBtn.Visible = false;
        }

        private void Refresh(object sender, EventArgs e)
        {
            Debug.WriteLine("Refreshing");
            // Loads config settings
            var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var settings = configFile.AppSettings.Settings;

            ReminderBubbleListMax = Int32.Parse(settings["ReminderBubbleListMax"].Value);
            PopupTickInterval = Int32.Parse(settings["PopupTickInterval"].Value);

            // Enables other settings
            reminders = SqlConnection.GetAllEnabled();
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

        private void ShowReminder_Tick(object sender, EventArgs e)
        {
            Debug.WriteLine(ReminderBubbleListMax);
            Debug.WriteLine(ReminderBubbleList.Count);

            //label1.Text = "";
            if (reminders.Count <= 0)
            {
                //Debug.WriteLine("no reminders enabled");
            }
            else // Show a new reminder
            {
                if (ReminderBubbleList.Count >= ReminderBubbleListMax)
                {
                    ReminderBubbleList[0].Close();

                    PopUpReminderBubble();
                }
                else
                {
                    PopUpReminderBubble();
                }
                this.FlashNotification();
            }
            //panel1.Visible = true;


            //FadeReminderTimer.Interval = 10000;
            //FadeReminderTimer.Stop();
            //FadeReminderTimer.Start();
        }

        private void PopUpReminderBubble()
        {
            int rand = SpecialRandomize();

            ReminderBubble _NewReminderBubble = new ReminderBubble(reminders[rand], Location);
            _NewReminderBubble.FormClosing += ReminderBubble_FormClosing;
            _NewReminderBubble.Show();
            ReminderBubbleList.Add(_NewReminderBubble);
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
            if (reminders.Count == 1)
            {
                return rand;
            }


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
            Settings.FormClosed += new FormClosedEventHandler(Refresh);
            Settings.ShowDialog();
        }

        private void FadeReminderTimer_Tick(object sender, EventArgs e)
        {
            Debug.WriteLine("fadeaway timer");
            FadeReminderTimer.Stop();
            //panel1.Visible = false;
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

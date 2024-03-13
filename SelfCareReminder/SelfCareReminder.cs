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
        }

        private void AlwaysOnTopTick(object sender, EventArgs e)
        {
            TopMost = true;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var settings = configFile.AppSettings.Settings;


            label1.Text = "Test text";
            panel1.Visible = false;
            //System.Windows.Forms.Timer MyTimer = new System.Windows.Forms.Timer();
            MyTimer.Interval = Int32.Parse(settings["Interval"].Value);
            MyTimer.Tick += new EventHandler(Tick);
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




        private void Tick(object sender, EventArgs e)
        {
            timer1.Dispose();

            label1.Text = "";
            if (reminders.Count <= 0)
            {
                //Debug.WriteLine("writing in appconfig");
                label1.Text = "No Reminders Enabled";
            }
            else
            {
                //int rand = new Random().Next(reminders.Count);
                int rand = SpecialRandomize();
                label1.Text = reminders[rand].Reminder;
            }
            panel1.Visible = true;

            timer1.Interval = 10000;
            timer1.Stop();
            timer1.Start();
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

        private void pictureBox1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            //TODO: maybe an animation functionality?
            Debug.WriteLine("Opening Settings");

        }

        private void OpenSettingsBtn_Click(object sender, EventArgs e)
        {
            Form Settings = new Settings();
            Settings.StartPosition = FormStartPosition.Manual;
            Settings.Location = this.Location;
            Settings.FormClosed += new FormClosedEventHandler(LoadSettings);
            Settings.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Debug.WriteLine("fadeaway timer");
            timer1.Stop();
            panel1.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

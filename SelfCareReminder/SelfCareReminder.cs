using System.Diagnostics;
using RemindersLibrary;
using SettingsMenu;

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



        public int count = 0;


        public SelfCareReminder()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Test text";
            panel1.Visible = false;
            System.Windows.Forms.Timer MyTimer = new System.Windows.Forms.Timer();
            MyTimer.Interval = (2000);
            MyTimer.Tick += new EventHandler(Tick);
            MyTimer.Start();
            HideBackgroundStyle();
            SetReminders(sender, e);


        }

        private void SetReminders(object sender, EventArgs e)
        {
            reminders = SqlConnection.GetAllEnabled();
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
            label1.Text = "";
            if (reminders.Count <= 0)
            {
                label1.Text = "None enabled";
            }
            else
            {
                int rand = new Random().Next(reminders.Count);
                label1.Text = reminders[rand].Reminder;
            }
            panel1.Visible = true;
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
        }

        private void settings_Click(object sender, EventArgs e)
        {
            Form Settings = new Settings();
            Settings.StartPosition = FormStartPosition.Manual;
            Settings.Location = this.Location;
            Settings.FormClosed += new FormClosedEventHandler(SetReminders);
            Settings.ShowDialog();
        }
    }
}

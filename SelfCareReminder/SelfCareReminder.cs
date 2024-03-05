using System.Diagnostics;
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



        public int count = 0;
        public string[] reminders = new string[] {
            "remember to drink water",
            "relax your eyes",
            "remember to eat",
            "make sure you stretch",
            "don't forget to stand up",
            "take a deep breath"
        };


        //dynamic text = Properties.Resources.RemindersList;
        //string RemindersJSON = Properties.Resources.RemindersList;

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

            //TEST CODE
            //Debug.WriteLine(RemindersJSON);
            //string r1r = obj[0].Reminder;
            //bool r1b = obj[0].Enabled;

            //string r2r = obj[1].Reminder;
            //bool r2b = obj[1].Enabled;


            //Debug.WriteLine(r1r);
            //Debug.WriteLine(r1b);

            //Debug.WriteLine(r2r);
            //Debug.WriteLine(r2b);

            //Debug.WriteLine(obj);

            //string fname = obj.FName;
            //string lname = obj.LName;
            //int? age = obj.Age;

            //Debug.WriteLine(fname);
            //Debug.WriteLine(lname);
            //Debug.WriteLine(age);

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
            int rand = new Random().Next(reminders.Length);
            label1.Text = reminders[rand];
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
            Settings.ShowDialog();
        }
    }
}

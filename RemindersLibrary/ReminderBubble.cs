using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RemindersLibrary
{
    public partial class ReminderBubble : Form
    {
        // Needed for grabbable mascot
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        // End grabbable mascot declaration

        ReminderModel reminder;
        public ReminderBubble(ReminderModel reminder, Point parentLocation)
        {
            InitializeComponent();
            this.reminder = reminder;
            ReminderBubbleText.Text = reminder.Reminder;
            ReminderBubbleText.MouseDown += ReminderBubble_MouseDown;
            this.FormClosing += ReminderBubble_FormClosing;

            this.ControlBox = false;
            this.Text = String.Empty;

            this.BackColor = Color.LimeGreen;
            this.TransparencyKey = Color.LimeGreen;

            this.FormBorderStyle = FormBorderStyle.None;



            StartPosition = FormStartPosition.Manual;
            Location = parentLocation;

            //PictureBox myPictureBox = new PictureBox
            //{
            //    Image = pictureBox1.Image,
            //    Width = pictureBox1.Width,
            //    Height = pictureBox1.Height,
            //    Visible = true,
            //};

            //PixelBox pixelBox = new PixelBox
            //{
            //    Image = pictureBox1.Image,
            //    Width = ClientRectangle.Width,
            //    Height = ClientRectangle.Height,
            //    Visible = true,
            //    SizeMode = PictureBoxSizeMode.StretchImage
            //};

            //this.Controls.Add(pixelBox);

            BubbleGraphic.Width = ClientRectangle.Width;
            BubbleGraphic.Height = ClientRectangle.Height;
            BubbleGraphic.SizeMode = PictureBoxSizeMode.StretchImage;
            BubbleGraphic.MouseDown += ReminderBubble_MouseDown;
            BubbleGraphic.Visible = true;

        }

        private void ReminderBubble_MouseDown(object? sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void ReminderBubble_Resize(object sender, System.EventArgs e)
        {
            Control control = (Control)sender;
            BubbleGraphic.Width = ClientRectangle.Width;
            BubbleGraphic.Height = ClientRectangle.Height;
            BubbleGraphic.SizeMode = PictureBoxSizeMode.StretchImage;
            BubbleGraphic.Visible = true;
        }

        private void ReminderBubble_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void ReminderBubble_Click(object sender, EventArgs e)
        {
            //this.Close();
        }

        private void ReminderBubble_Load(object sender, EventArgs e)
        {

        }

        private void Close_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void Close_PendingClose(object sender, EventArgs e)
        {
            this.Capture = true;
        }
    }


}

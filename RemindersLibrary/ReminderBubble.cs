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
        ReminderModel reminder;
        public ReminderBubble(ReminderModel reminder)
        {
            InitializeComponent();
            this.reminder = reminder;
            ReminderBubbleText.Text = reminder.Reminder;
            this.FormClosing += ReminderBubble_FormClosing;

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
            BubbleGraphic.Visible = true;
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
    }


}

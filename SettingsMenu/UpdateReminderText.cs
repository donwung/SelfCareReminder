using RemindersLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SettingsMenu
{
    public partial class UpdateReminderText : Form
    {
        private int index;
        private ReminderModel currentReminder;

        public UpdateReminderText(int updateAtIndex)
        {
            InitializeComponent();
            index = updateAtIndex;
            SetEditableField(index);
            // after opening the dialog
            // input something into the field
            // press the confirm btn
            // print to console
        }

        private void SetEditableField(int index)
        {
            Debug.Print("Reached updateremindertext.test");
            currentReminder = SqlConnection.GetOneReminder(index);
            //SqlConnection.GetOneReminder(index);
            //Debug.Print(oneReminder.Reminder);
            textBox1.Text = currentReminder.Reminder;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Debug.Print("cancel buttn clicked");
            this.Close();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            Debug.Print("update button clicked, new text is: ");
            Debug.Print(textBox1.Text);
            // if reminder is a default, disable that reminder, then add a new one
            // else, change nothing except the text itself

            //if (currentReminder.Default == true)
            //{
            //    // add a new reminder
            //} else
            //{
            //    // update this reminder

            //}

            ReminderModel UpdatedReminder = currentReminder;
            UpdatedReminder.Reminder = textBox1.Text;
            //Debug.Print(index.ToString());
            //Debug.Print(UpdatedReminder.Reminder);

            SqlConnection.UpdateReminderText(index, UpdatedReminder);
            this.Close();


            //SqlConnection.UpdateReminder(index, )
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Debug.Print("textbox changed");
            //Debug.Print(textBox1.Text);
        }
    }
}

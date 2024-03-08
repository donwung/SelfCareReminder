using RemindersLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SettingsMenu
{
    public partial class DeleteReminder : Form
    {
        private int index;
        private ReminderModel reminder;
        public DeleteReminder(int _index, ReminderModel _reminder)
        {
            InitializeComponent();
            index = _index;
            reminder = _reminder;
            //OpenDeleteConfirmationMenu(index, reminder);
            label2.Text = reminder.Reminder;
            toolTip1.SetToolTip(ConfirmDeleteBtn, "Tooltip text");

            if (reminder.Default)
            {
                ConfirmDeleteBtn.Enabled = false;
            }
        }

        private void OpenDeleteConfirmationMenu(int index, ReminderModel reminder)
        {
            Debug.WriteLine(index);
            Debug.WriteLine(reminder.Reminder);
        }

        private void ConfirmDeleteBtn_Click(object sender, EventArgs e)
        {
            SqlConnection.DeleteReminder(reminder.Id);
            this.Close();
        }

        private void CancelDeleteBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

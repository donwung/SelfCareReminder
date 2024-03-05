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
    public partial class CreateReminder : Form
    {
        public CreateReminder()
        {
            InitializeComponent();
        }

        private void CancelNewReminderBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddNewReminderBtn_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Adding new reminder");
            Debug.WriteLine(textBox1.Text);
            ReminderModel newReminder = new ReminderModel();
            newReminder.Reminder = textBox1.Text;
            newReminder.Enabled = true;
            //newReminder.Default = false; //this shouldn't be necessary, but just in case

            SqlConnection.CreateReminder(newReminder);
            this.Close();
        }
    }
}

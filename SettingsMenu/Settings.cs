using System.Diagnostics;
using System.Windows.Forms;
using RemindersLibrary;

namespace SettingsMenu
{
    public partial class Settings : Form
    {
        List<ReminderModel> reminderList = new List<ReminderModel>();

        public Settings()
        {
            InitializeComponent();
        }

        private void LoadReminderList()
        {
            reminderList = SqlConnection.LoadReminders();
            OutputCheckedList();
        }

        private void SettingsMenu_Load(object sender, EventArgs e)
        {
            Debug.WriteLine("Created Settings Menu");
            Debug.WriteLine("Loading reminders list");
            LoadReminderList();
        }

        private void OutputCheckedList()
        {
            for (int i = 0; i < reminderList.Count(); i++)
            {
                //Debug.WriteLine(reminderList[i].Enabled);
                if (reminderList[i].Enabled)
                {
                    checkedListBox1.Items.Add(reminderList[i].Reminder, CheckState.Checked);
                }
                else
                {
                    checkedListBox1.Items.Add(reminderList[i].Reminder, CheckState.Unchecked);
                }
                // stick this in the designer
                //checkedListBox1.ItemCheck += (s, e) => { if (e.CurrentValue == CheckState.Indeterminate) e.NewValue = CheckState.Indeterminate; };

            }
        }

        Int32 mouseClickIndex = -2;
        private void CheckedListBox1_MouseClick(Object sender, MouseEventArgs e)
        {
            mouseClickIndex = checkedListBox1.IndexFromPoint(e.Location);
            Debug.Print("Clicked on index {0}", mouseClickIndex);
        }

        private void CheckedListBox1_DoubleClick(Object sender, MouseEventArgs e)
        {
            //mouseClickIndex = checkedListBox1.IndexFromPoint(e.Location);
            //Debug.Print("Clicked on index {0}", mouseClickIndex);
            Debug.WriteLine("dbc");
            int index = checkedListBox1.IndexFromPoint(e.Location);
            Debug.WriteLine(index);
            Debug.WriteLine(reminderList[index].Reminder);

            //TODO: opendialog with the text from this idx
            
        }

        private void CheckedListBox1_ItemCheck(Object sender, ItemCheckEventArgs e)
        {
            if (mouseClickIndex == -1)
            {
                e.NewValue = e.CurrentValue;
                mouseClickIndex = -2;
                Debug.Print("Check change suppressed");
            }
        }
    }
}

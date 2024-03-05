using System.Diagnostics;
using System.Windows.Forms;
using RemindersLibrary;

namespace SettingsMenu
{
    public partial class Settings : Form
    {
        List<ReminderModel> reminderList = new List<ReminderModel>();
        Int32 mouseClickIndex = -2;


        public Settings()
        {
            InitializeComponent();
        }

        private void LoadReminderList()
        {
            checkedListBox1.Items.Clear();
            mouseClickIndex = -2;
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

        private void CheckedListBox1_MouseClick(Object sender, MouseEventArgs e)
        {
            mouseClickIndex = checkedListBox1.IndexFromPoint(e.Location);
            Debug.Print("Clicked on index {0}", mouseClickIndex);
        }

        private void CheckedListBox1_DoubleClick(Object sender, MouseEventArgs e)
        {
            //mouseClickIndex = checkedListBox1.IndexFromPoint(e.Location);
            //Debug.Print("Clicked on index {0}", mouseClickIndex);
            //Debug.WriteLine("dbc");
            int index = checkedListBox1.IndexFromPoint(e.Location);
            //Debug.WriteLine(index);
            //Debug.WriteLine(reminderList[index].Reminder);
            if (index >= 0)
            {
                Form UpdateReminderTextMenu = new UpdateReminderText(index);
                UpdateReminderTextMenu.StartPosition = FormStartPosition.Manual;
                UpdateReminderTextMenu.Location = this.Location;
                UpdateReminderTextMenu.FormClosed += new FormClosedEventHandler(UpdateReminderTextMenuClose);
                UpdateReminderTextMenu.ShowDialog();
            }
            else
            {
                Debug.WriteLine("idx == -1 aka clicked whitespace");
            }
        }

        private void UpdateReminderTextMenuClose(object sender, EventArgs e)
        {
            Debug.WriteLine("Form closed - refreshing checklistbox");
            LoadReminderList();
        }

        private void CheckedListBox1_ItemCheck(Object sender, ItemCheckEventArgs e)
        {
            if (mouseClickIndex == -1)
            {
                e.NewValue = e.CurrentValue;
                //idk why this is -2
                //mouseClickIndex = -2;
                mouseClickIndex = -1;
                //Debug.Print("Check change suppressed");
            }
            else if (mouseClickIndex >= 0)
            {
                Debug.Print($"Changed at index = {mouseClickIndex}");
                //Debug.Print(checkedListBox1.GetItemChecked(mouseClickIndex).ToString());
                SqlConnection.UpdateReminderEnable(mouseClickIndex, !checkedListBox1.GetItemChecked(mouseClickIndex));
            }
        }

        private void AddReminderBtn_Click(object sender, EventArgs e)
        {
            int index = mouseClickIndex;

            Form CreateReminderMenu = new CreateReminder();
            CreateReminderMenu.StartPosition = FormStartPosition.Manual;
            CreateReminderMenu.Location = this.Location;
            CreateReminderMenu.FormClosed += new FormClosedEventHandler(UpdateReminderTextMenuClose);
            CreateReminderMenu.ShowDialog();
        }

        // TODO: refactor this to be more DRY - this func is a dupe
        // TODO: set a universal parent location
        private void EditReminderBtn_Click(object sender, EventArgs e)
        {
            Debug.Print(mouseClickIndex.ToString());
            //mouseClickIndex = checkedListBox1.IndexFromPoint(e.Location);
            //Debug.Print("Clicked on index {0}", mouseClickIndex);
            //Debug.WriteLine("dbc");
            int index = mouseClickIndex;
            //Debug.WriteLine(index);
            //Debug.WriteLine(reminderList[index].Reminder);
            if (index >= 0)
            {
                Form UpdateReminderTextMenu = new UpdateReminderText(index);
                UpdateReminderTextMenu.StartPosition = FormStartPosition.Manual;
                UpdateReminderTextMenu.Location = this.Location;
                UpdateReminderTextMenu.FormClosed += new FormClosedEventHandler(UpdateReminderTextMenuClose);
                UpdateReminderTextMenu.ShowDialog();
            }
            else
            {
                Debug.WriteLine("idx == -1 aka clicked whitespace");
            }
        }

        private void DeleteReminderBtn_Click(object sender, EventArgs e)
        {

        }

        private void CloseSettingsBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

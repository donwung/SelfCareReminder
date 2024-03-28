using System.Diagnostics;
using System.Windows.Forms;

namespace SettingsMenu
{
    partial class Settings
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            checkedListBox1 = new CheckedListBox();
            DeleteReminderBtn = new Button();
            EditReminderBtn = new Button();
            AddReminderBtn = new Button();
            CloseSettingsBtn = new Button();
            IntervalInput = new NumericUpDown();
            label1 = new Label();
            CloseApplicationBtn = new Button();
            label4 = new Label();
            ReminderBubbleListMax = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)IntervalInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ReminderBubbleListMax).BeginInit();
            SuspendLayout();
            // 
            // checkedListBox1
            // 
            checkedListBox1.CheckOnClick = true;
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(12, 12);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(372, 166);
            checkedListBox1.TabIndex = 1;
            checkedListBox1.ItemCheck += CheckedListBox1_ItemCheck;
            checkedListBox1.MouseClick += CheckedListBox1_MouseClick;
            checkedListBox1.MouseDoubleClick += CheckedListBox1_DoubleClick;
            // 
            // DeleteReminderBtn
            // 
            DeleteReminderBtn.Location = new Point(309, 184);
            DeleteReminderBtn.Name = "DeleteReminderBtn";
            DeleteReminderBtn.Size = new Size(75, 23);
            DeleteReminderBtn.TabIndex = 2;
            DeleteReminderBtn.Text = "Delete";
            DeleteReminderBtn.UseVisualStyleBackColor = true;
            DeleteReminderBtn.Click += DeleteReminderBtn_Click;
            // 
            // EditReminderBtn
            // 
            EditReminderBtn.Location = new Point(93, 184);
            EditReminderBtn.Name = "EditReminderBtn";
            EditReminderBtn.Size = new Size(75, 23);
            EditReminderBtn.TabIndex = 3;
            EditReminderBtn.Text = "Edit";
            EditReminderBtn.UseVisualStyleBackColor = true;
            EditReminderBtn.Click += EditReminderBtn_Click;
            // 
            // AddReminderBtn
            // 
            AddReminderBtn.Location = new Point(12, 184);
            AddReminderBtn.Name = "AddReminderBtn";
            AddReminderBtn.Size = new Size(75, 23);
            AddReminderBtn.TabIndex = 4;
            AddReminderBtn.Text = "Add";
            AddReminderBtn.UseVisualStyleBackColor = true;
            AddReminderBtn.Click += AddReminderBtn_Click;
            // 
            // CloseSettingsBtn
            // 
            CloseSettingsBtn.Location = new Point(309, 495);
            CloseSettingsBtn.Name = "CloseSettingsBtn";
            CloseSettingsBtn.Size = new Size(75, 23);
            CloseSettingsBtn.TabIndex = 5;
            CloseSettingsBtn.Text = "Close";
            CloseSettingsBtn.UseVisualStyleBackColor = true;
            CloseSettingsBtn.Click += CloseSettingsBtn_Click;
            // 
            // IntervalInput
            // 
            IntervalInput.Location = new Point(343, 213);
            IntervalInput.Maximum = new decimal(new int[] { 1410065408, 2, 0, 0 });
            IntervalInput.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            IntervalInput.Name = "IntervalInput";
            IntervalInput.Size = new Size(41, 23);
            IntervalInput.TabIndex = 6;
            IntervalInput.Value = new decimal(new int[] { 1, 0, 0, 0 });
            IntervalInput.ValueChanged += IntervalInput_ValueChanged;
            IntervalInput.KeyUp += IntervalInput_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 215);
            label1.Name = "label1";
            label1.Size = new Size(182, 15);
            label1.TabIndex = 7;
            label1.Text = "Minutes before another reminder";
            // 
            // CloseApplicationBtn
            // 
            CloseApplicationBtn.Location = new Point(12, 495);
            CloseApplicationBtn.Name = "CloseApplicationBtn";
            CloseApplicationBtn.Size = new Size(127, 23);
            CloseApplicationBtn.TabIndex = 10;
            CloseApplicationBtn.Text = "Close Application";
            CloseApplicationBtn.UseVisualStyleBackColor = true;
            CloseApplicationBtn.Click += CloseApplicationBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 244);
            label4.Name = "label4";
            label4.Size = new Size(177, 15);
            label4.TabIndex = 11;
            label4.Text = "Maximum number of reminders";
            // 
            // ReminderBubbleListMax
            // 
            ReminderBubbleListMax.Location = new Point(343, 242);
            ReminderBubbleListMax.Name = "ReminderBubbleListMax";
            ReminderBubbleListMax.Size = new Size(41, 23);
            ReminderBubbleListMax.TabIndex = 12;
            ReminderBubbleListMax.Value = new decimal(new int[] { 5, 0, 0, 0 });
            ReminderBubbleListMax.ValueChanged += ReminderBubbleListMax_ValueChanged;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(396, 530);
            Controls.Add(ReminderBubbleListMax);
            Controls.Add(label4);
            Controls.Add(CloseApplicationBtn);
            Controls.Add(label1);
            Controls.Add(IntervalInput);
            Controls.Add(CloseSettingsBtn);
            Controls.Add(AddReminderBtn);
            Controls.Add(EditReminderBtn);
            Controls.Add(DeleteReminderBtn);
            Controls.Add(checkedListBox1);
            Name = "Settings";
            Text = "Settings";
            Load += SettingsMenu_Load;
            ((System.ComponentModel.ISupportInitialize)IntervalInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)ReminderBubbleListMax).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CheckedListBox checkedListBox1;
        private Button DeleteReminderBtn;
        private Button EditReminderBtn;
        private Button AddReminderBtn;
        private Button CloseSettingsBtn;
        private NumericUpDown IntervalInput;
        private Label label1;
        private Button CloseApplicationBtn;
        private Label label4;
        private NumericUpDown ReminderBubbleListMax;
    }
}

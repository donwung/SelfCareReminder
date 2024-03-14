namespace SettingsMenu
{
    partial class CreateReminder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            AddNewReminderBtn = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            CancelNewReminderBtn = new Button();
            SuspendLayout();
            // 
            // AddNewReminderBtn
            // 
            AddNewReminderBtn.Location = new Point(271, 56);
            AddNewReminderBtn.Name = "AddNewReminderBtn";
            AddNewReminderBtn.Size = new Size(75, 23);
            AddNewReminderBtn.TabIndex = 0;
            AddNewReminderBtn.Text = "Add";
            AddNewReminderBtn.UseVisualStyleBackColor = true;
            AddNewReminderBtn.Click += AddNewReminderBtn_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(334, 23);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(126, 15);
            label1.TabIndex = 2;
            label1.Text = "Create a new reminder";
            // 
            // CancelNewReminderBtn
            // 
            CancelNewReminderBtn.Location = new Point(190, 56);
            CancelNewReminderBtn.Name = "CancelNewReminderBtn";
            CancelNewReminderBtn.Size = new Size(75, 23);
            CancelNewReminderBtn.TabIndex = 3;
            CancelNewReminderBtn.Text = "Cancel";
            CancelNewReminderBtn.UseVisualStyleBackColor = true;
            CancelNewReminderBtn.Click += CancelNewReminderBtn_Click;
            // 
            // CreateReminder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(358, 88);
            Controls.Add(CancelNewReminderBtn);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(AddNewReminderBtn);
            Name = "CreateReminder";
            Text = "Create Reminder";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddNewReminderBtn;
        private TextBox textBox1;
        private Label label1;
        private Button CancelNewReminderBtn;
    }
}
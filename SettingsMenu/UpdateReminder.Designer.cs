namespace SettingsMenu
{
    partial class UpdateReminderForm
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
            updateBtn = new Button();
            cancelBtn = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            deleteBtn = new Button();
            SuspendLayout();
            // 
            // updateBtn
            // 
            updateBtn.Location = new Point(327, 64);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(120, 23);
            updateBtn.TabIndex = 0;
            updateBtn.Text = "Update Reminder";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += UpdateBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(453, 64);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(75, 23);
            cancelBtn.TabIndex = 1;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += CancelBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(105, 15);
            label1.TabIndex = 2;
            label1.Text = "Edit Reminder Text";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(516, 23);
            textBox1.TabIndex = 3;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(12, 64);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(135, 23);
            deleteBtn.TabIndex = 4;
            deleteBtn.Text = "Delete Reminder";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // UpdateReminderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(540, 99);
            Controls.Add(deleteBtn);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(cancelBtn);
            Controls.Add(updateBtn);
            MaximizeBox = false;
            Name = "UpdateReminderForm";
            Text = "Updating Reminder";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button updateBtn;
        private Button cancelBtn;
        private Label label1;
        private TextBox textBox1;
        private Button deleteBtn;
    }
}
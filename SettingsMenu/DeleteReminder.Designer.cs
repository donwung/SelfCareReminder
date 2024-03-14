namespace SettingsMenu
{
    partial class DeleteReminder
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
            components = new System.ComponentModel.Container();
            ConfirmDeleteBtn = new Button();
            CancelDeleteBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            toolTip1 = new ToolTip(components);
            label3 = new Label();
            SuspendLayout();
            // 
            // ConfirmDeleteBtn
            // 
            ConfirmDeleteBtn.Location = new Point(221, 109);
            ConfirmDeleteBtn.Name = "ConfirmDeleteBtn";
            ConfirmDeleteBtn.Size = new Size(75, 23);
            ConfirmDeleteBtn.TabIndex = 0;
            ConfirmDeleteBtn.Text = "Delete";
            ConfirmDeleteBtn.UseVisualStyleBackColor = true;
            ConfirmDeleteBtn.Click += ConfirmDeleteBtn_Click;
            // 
            // CancelDeleteBtn
            // 
            CancelDeleteBtn.Location = new Point(12, 109);
            CancelDeleteBtn.Name = "CancelDeleteBtn";
            CancelDeleteBtn.Size = new Size(75, 23);
            CancelDeleteBtn.TabIndex = 1;
            CancelDeleteBtn.Text = "Cancel";
            CancelDeleteBtn.UseVisualStyleBackColor = true;
            CancelDeleteBtn.Click += CancelDeleteBtn_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.FlatStyle = FlatStyle.System;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(284, 25);
            label1.TabIndex = 2;
            label1.Text = "Are you sure you want to delete this reminder?";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.Location = new Point(12, 48);
            label2.Name = "label2";
            label2.Size = new Size(284, 39);
            label2.TabIndex = 3;
            label2.Text = "label2";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 8.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 83);
            label3.Name = "label3";
            label3.Size = new Size(284, 23);
            label3.TabIndex = 4;
            label3.Text = "Note: You cannot delete default reminders.";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DeleteReminder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(308, 144);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(CancelDeleteBtn);
            Controls.Add(ConfirmDeleteBtn);
            Name = "DeleteReminder";
            Text = "Delete Reminder";
            ResumeLayout(false);
        }

        #endregion

        private Button ConfirmDeleteBtn;
        private Button CancelDeleteBtn;
        private Label label1;
        private Label label2;
        private ToolTip toolTip1;
        private Label label3;
    }
}
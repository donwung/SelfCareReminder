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
            // Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(396, 530);
            Controls.Add(checkedListBox1);
            Name = "Settings";
            Text = "Settings";
            Load += SettingsMenu_Load;
            ResumeLayout(false);
        }

        #endregion
        private CheckedListBox checkedListBox1;
    }
}

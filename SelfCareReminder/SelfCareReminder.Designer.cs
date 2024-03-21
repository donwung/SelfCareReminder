namespace SelfCareReminder
{
    partial class SelfCareReminder
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelfCareReminder));
            FadeReminderTimer = new System.Windows.Forms.Timer(components);
            MyTimer = new System.Windows.Forms.Timer(components);
            Mascot = new PictureBox();
            OpenSettingsBtn = new Button();
            HideSettingsTimer = new System.Windows.Forms.Timer(components);
            DebugControls = new GroupBox();
            button4 = new Button();
            button3 = new Button();
            DBG_PrintLast5 = new Button();
            DBG_NewReminder = new Button();
            ((System.ComponentModel.ISupportInitialize)Mascot).BeginInit();
            DebugControls.SuspendLayout();
            SuspendLayout();
            // 
            // FadeReminderTimer
            // 
            FadeReminderTimer.Interval = 3000;
            FadeReminderTimer.Tick += FadeReminderTimer_Tick;
            // 
            // MyTimer
            // 
            MyTimer.Interval = 1000;
            // 
            // Mascot
            // 
            Mascot.BackgroundImage = (Image)resources.GetObject("Mascot.BackgroundImage");
            Mascot.Location = new Point(94, 185);
            Mascot.Name = "Mascot";
            Mascot.Size = new Size(146, 166);
            Mascot.SizeMode = PictureBoxSizeMode.CenterImage;
            Mascot.TabIndex = 3;
            Mascot.TabStop = false;
            Mascot.MouseDoubleClick += Mascot_DoubleClick;
            Mascot.MouseDown += Mascot_MouseDown;
            Mascot.MouseEnter += Mascot_MouseEnter;
            Mascot.MouseMove += Mascot_MouseEnter;
            // 
            // OpenSettingsBtn
            // 
            OpenSettingsBtn.Location = new Point(165, 357);
            OpenSettingsBtn.Name = "OpenSettingsBtn";
            OpenSettingsBtn.Size = new Size(75, 23);
            OpenSettingsBtn.TabIndex = 5;
            OpenSettingsBtn.Text = "Settings";
            OpenSettingsBtn.UseVisualStyleBackColor = true;
            OpenSettingsBtn.Click += OpenSettingsBtn_Click;
            // 
            // DebugControls
            // 
            DebugControls.BackColor = SystemColors.Info;
            DebugControls.Controls.Add(button4);
            DebugControls.Controls.Add(button3);
            DebugControls.Controls.Add(DBG_PrintLast5);
            DebugControls.Controls.Add(DBG_NewReminder);
            DebugControls.Location = new Point(246, 185);
            DebugControls.Name = "DebugControls";
            DebugControls.Size = new Size(419, 341);
            DebugControls.TabIndex = 6;
            DebugControls.TabStop = false;
            DebugControls.Text = "DebugControls";
            // 
            // button4
            // 
            button4.Location = new Point(6, 109);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 3;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(6, 80);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 2;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // DBG_PrintLast5
            // 
            DBG_PrintLast5.Location = new Point(6, 51);
            DBG_PrintLast5.Name = "DBG_PrintLast5";
            DBG_PrintLast5.Size = new Size(129, 23);
            DBG_PrintLast5.TabIndex = 1;
            DBG_PrintLast5.Text = "DBG_PrintLast5";
            DBG_PrintLast5.UseVisualStyleBackColor = true;
            DBG_PrintLast5.Click += DBG_PrintLast5_Click;
            // 
            // DBG_NewReminder
            // 
            DBG_NewReminder.Location = new Point(6, 22);
            DBG_NewReminder.Name = "DBG_NewReminder";
            DBG_NewReminder.Size = new Size(129, 23);
            DBG_NewReminder.TabIndex = 0;
            DBG_NewReminder.Text = "DBG_NewReminder";
            DBG_NewReminder.UseVisualStyleBackColor = true;
            DBG_NewReminder.Click += DBG_NewReminder_Click;
            // 
            // SelfCareReminder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(677, 538);
            Controls.Add(DebugControls);
            Controls.Add(OpenSettingsBtn);
            Controls.Add(Mascot);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SelfCareReminder";
            Text = "SelfCareReminder";
            Load += SelfCareReminder_Load;
            MouseDown += Form1_MouseDown;
            ((System.ComponentModel.ISupportInitialize)Mascot).EndInit();
            DebugControls.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Timer MyTimer;
        private PictureBox Mascot;
        private Button OpenSettingsBtn;
        private System.Windows.Forms.Timer FadeReminderTimer;
        private System.Windows.Forms.Timer HideSettingsTimer;
        private GroupBox DebugControls;
        private Button button3;
        private Button DBG_PrintLast5;
        private Button DBG_NewReminder;
        private Button button4;
    }
}

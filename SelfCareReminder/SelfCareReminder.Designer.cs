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
            label1 = new Label();
            panel1 = new Panel();
            MyTimer = new System.Windows.Forms.Timer(components);
            Mascot = new PictureBox();
            OpenSettingsBtn = new Button();
            HideSettingsTimer = new System.Windows.Forms.Timer(components);
            DebugControls = new GroupBox();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            DBG_NewReminder = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Mascot).BeginInit();
            DebugControls.SuspendLayout();
            SuspendLayout();
            // 
            // FadeReminderTimer
            // 
            FadeReminderTimer.Interval = 3000;
            FadeReminderTimer.Tick += FadeReminderTimer_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Location = new Point(32, 55);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(132, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(309, 173);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // MyTimer
            // 
            MyTimer.Interval = 1000;
            // 
            // Mascot
            // 
            Mascot.BackgroundImage = (Image)resources.GetObject("Mascot.BackgroundImage");
            Mascot.Location = new Point(295, 185);
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
            OpenSettingsBtn.Location = new Point(366, 357);
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
            DebugControls.Controls.Add(button2);
            DebugControls.Controls.Add(DBG_NewReminder);
            DebugControls.Location = new Point(12, 185);
            DebugControls.Name = "DebugControls";
            DebugControls.Size = new Size(277, 223);
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
            // button2
            // 
            button2.Location = new Point(6, 51);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
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
            ClientSize = new Size(453, 420);
            Controls.Add(DebugControls);
            Controls.Add(OpenSettingsBtn);
            Controls.Add(panel1);
            Controls.Add(Mascot);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SelfCareReminder";
            Text = "SelfCareReminder";
            Load += SelfCareReminder_Load;
            MouseDown += Form1_MouseDown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Mascot).EndInit();
            DebugControls.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private System.Windows.Forms.Timer MyTimer;
        private PictureBox Mascot;
        private Button OpenSettingsBtn;
        private System.Windows.Forms.Timer FadeReminderTimer;
        private System.Windows.Forms.Timer HideSettingsTimer;
        private GroupBox DebugControls;
        private Button button3;
        private Button button2;
        private Button DBG_NewReminder;
        private Button button4;
    }
}

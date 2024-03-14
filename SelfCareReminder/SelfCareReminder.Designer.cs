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
            timer1 = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            panel1 = new Panel();
            MyTimer = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            OpenSettingsBtn = new Button();
            HideSettingsTimer = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Interval = 3000;
            timer1.Tick += timer1_Tick;
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
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(309, 173);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // MyTimer
            // 
            MyTimer.Interval = 1000;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(175, 191);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(146, 166);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.MouseDoubleClick += pictureBox1_DoubleClick;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            pictureBox1.MouseEnter += pictureBox1_MouseEnter;
            // 
            // OpenSettingsBtn
            // 
            OpenSettingsBtn.Location = new Point(246, 363);
            OpenSettingsBtn.Name = "OpenSettingsBtn";
            OpenSettingsBtn.Size = new Size(75, 23);
            OpenSettingsBtn.TabIndex = 5;
            OpenSettingsBtn.Text = "Settings";
            OpenSettingsBtn.UseVisualStyleBackColor = true;
            OpenSettingsBtn.Click += OpenSettingsBtn_Click;
            // 
            // SelfCareReminder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(333, 420);
            Controls.Add(OpenSettingsBtn);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SelfCareReminder";
            Text = "SelfCareReminder";
            Load += Form1_Load;
            MouseDown += Form1_MouseDown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private System.Windows.Forms.Timer MyTimer;
        private PictureBox pictureBox1;
        private Button OpenSettingsBtn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer HideSettingsTimer;
    }
}

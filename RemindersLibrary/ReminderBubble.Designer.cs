﻿namespace RemindersLibrary
{
    partial class ReminderBubble
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReminderBubble));
            ReminderBubbleText = new Label();
            BubbleGraphic = new PixelBox();
            ((System.ComponentModel.ISupportInitialize)BubbleGraphic).BeginInit();
            SuspendLayout();
            // 
            // ReminderBubbleText
            // 
            ReminderBubbleText.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            ReminderBubbleText.BackColor = Color.White;
            ReminderBubbleText.Location = new Point(12, 42);
            ReminderBubbleText.Name = "ReminderBubbleText";
            ReminderBubbleText.Size = new Size(270, 59);
            ReminderBubbleText.TabIndex = 0;
            ReminderBubbleText.Text = "label1";
            ReminderBubbleText.TextAlign = ContentAlignment.MiddleCenter;
            ReminderBubbleText.Click += this.ReminderBubble_Click;
            // 
            // BubbleGraphic
            // 
            BubbleGraphic.Image = (Image)resources.GetObject("BubbleGraphic.Image");
            BubbleGraphic.Location = new Point(0, 0);
            BubbleGraphic.Name = "BubbleGraphic";
            BubbleGraphic.Size = new Size(320, 189);
            BubbleGraphic.TabIndex = 2;
            BubbleGraphic.TabStop = false;
            BubbleGraphic.Click += this.ReminderBubble_Click;
            // 
            // ReminderBubble
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(294, 161);
            Controls.Add(ReminderBubbleText);
            Controls.Add(BubbleGraphic);
            Name = "ReminderBubble";
            Text = "Form1";
            Resize += ReminderBubble_Resize;
            ((System.ComponentModel.ISupportInitialize)BubbleGraphic).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label ReminderBubbleText;
        private PixelBox BubbleGraphic;
    }
}
namespace RemindersLibrary
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
            Close = new Button();
            ((System.ComponentModel.ISupportInitialize)BubbleGraphic).BeginInit();
            SuspendLayout();
            // 
            // ReminderBubbleText
            // 
            ReminderBubbleText.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            ReminderBubbleText.BackColor = Color.White;
            ReminderBubbleText.Location = new Point(12, 57);
            ReminderBubbleText.Name = "ReminderBubbleText";
            ReminderBubbleText.Size = new Size(329, 84);
            ReminderBubbleText.TabIndex = 0;
            ReminderBubbleText.Text = "label1";
            ReminderBubbleText.TextAlign = ContentAlignment.MiddleCenter;
            ReminderBubbleText.Click += ReminderBubble_Click;
            // 
            // BubbleGraphic
            // 
            BubbleGraphic.Image = (Image)resources.GetObject("BubbleGraphic.Image");
            BubbleGraphic.Location = new Point(0, 0);
            BubbleGraphic.Name = "BubbleGraphic";
            BubbleGraphic.Size = new Size(320, 189);
            BubbleGraphic.TabIndex = 2;
            BubbleGraphic.TabStop = false;
            BubbleGraphic.Click += ReminderBubble_Click;
            // 
            // Close
            // 
            Close.BackColor = Color.IndianRed;
            Close.BackgroundImageLayout = ImageLayout.None;
            Close.CausesValidation = false;
            Close.Cursor = Cursors.Hand;
            Close.FlatAppearance.BorderColor = Color.IndianRed;
            Close.FlatAppearance.BorderSize = 0;
            Close.FlatAppearance.MouseDownBackColor = Color.Brown;
            Close.FlatAppearance.MouseOverBackColor = Color.LightCoral;
            Close.FlatStyle = FlatStyle.Flat;
            Close.Font = new Font("BIZ UDPGothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Close.Location = new Point(322, 8);
            Close.Name = "Close";
            Close.Size = new Size(21, 21);
            Close.TabIndex = 3;
            Close.Text = "X";
            Close.UseVisualStyleBackColor = false;
            Close.MouseClick += Close_Click;
            Close.MouseUp += Close_Click;
            // 
            // ReminderBubble
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(353, 186);
            Controls.Add(Close);
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
        private Button Close;
    }
}
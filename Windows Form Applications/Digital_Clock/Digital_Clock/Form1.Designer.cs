namespace Digital_Clock
{
    partial class DigitalClock
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
            clock = new Label();
            clockTimer = new System.Windows.Forms.Timer(components);
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // clock
            // 
            clock.AutoSize = true;
            clock.BackColor = Color.Black;
            clock.Font = new Font("LCDMono2", 89.99999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clock.ForeColor = Color.Red;
            clock.Location = new Point(15, 95);
            clock.Name = "clock";
            clock.Size = new Size(713, 134);
            clock.TabIndex = 0;
            clock.Text = "00:00:00";
            clock.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // clockTimer
            // 
            clockTimer.Interval = 1000;
            clockTimer.Tick += clock_Timer;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = SystemColors.WindowText;
            button1.Location = new Point(12, 291);
            button1.Name = "button1";
            button1.Size = new Size(23, 23);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = false;
            button1.Click += change_Color;
            // 
            // button2
            // 
            button2.BackColor = Color.Green;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Popup;
            button2.ForeColor = SystemColors.WindowText;
            button2.Location = new Point(41, 291);
            button2.Name = "button2";
            button2.Size = new Size(23, 23);
            button2.TabIndex = 2;
            button2.UseVisualStyleBackColor = false;
            button2.Click += change_Color;
            // 
            // button3
            // 
            button3.BackColor = Color.Orange;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Popup;
            button3.ForeColor = SystemColors.WindowText;
            button3.Location = new Point(70, 291);
            button3.Name = "button3";
            button3.Size = new Size(23, 23);
            button3.TabIndex = 3;
            button3.UseVisualStyleBackColor = false;
            button3.Click += change_Color;
            // 
            // button4
            // 
            button4.BackColor = Color.Blue;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Popup;
            button4.ForeColor = SystemColors.WindowText;
            button4.Location = new Point(99, 291);
            button4.Name = "button4";
            button4.Size = new Size(23, 23);
            button4.TabIndex = 4;
            button4.UseVisualStyleBackColor = false;
            button4.Click += change_Color;
            // 
            // button5
            // 
            button5.BackColor = Color.Yellow;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Popup;
            button5.ForeColor = SystemColors.WindowText;
            button5.Location = new Point(128, 291);
            button5.Name = "button5";
            button5.Size = new Size(23, 23);
            button5.TabIndex = 5;
            button5.UseVisualStyleBackColor = false;
            button5.Click += change_Color;
            // 
            // DigitalClock
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(740, 326);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(clock);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "DigitalClock";
            StartPosition = FormStartPosition.CenterScreen;
            Load += DigitalClock_Load;
            Click += change_Color;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label clock;
        private System.Windows.Forms.Timer clockTimer;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}

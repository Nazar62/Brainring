namespace BrainringPC
{
    partial class Form1
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
            labelTimer = new Label();
            timer = new System.Windows.Forms.Timer(components);
            panelColor = new Panel();
            labelRedCount = new Label();
            labelBlueCount = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            SuspendLayout();
            // 
            // labelTimer
            // 
            labelTimer.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelTimer.Font = new Font("Segoe UI", 30F);
            labelTimer.ImageAlign = ContentAlignment.MiddleRight;
            labelTimer.Location = new Point(307, 22);
            labelTimer.Name = "labelTimer";
            labelTimer.Size = new Size(160, 54);
            labelTimer.TabIndex = 0;
            labelTimer.Text = "Таймер";
            labelTimer.TextAlign = ContentAlignment.TopCenter;
            labelTimer.Click += labelTimer_Click;
            // 
            // timer
            // 
            timer.Interval = 1000;
            timer.Tick += timer_Tick;
            // 
            // panelColor
            // 
            panelColor.Location = new Point(-1, 96);
            panelColor.Name = "panelColor";
            panelColor.Size = new Size(799, 190);
            panelColor.TabIndex = 1;
            // 
            // labelRedCount
            // 
            labelRedCount.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelRedCount.AutoSize = true;
            labelRedCount.Font = new Font("Segoe UI", 30F);
            labelRedCount.Location = new Point(87, 340);
            labelRedCount.Name = "labelRedCount";
            labelRedCount.Size = new Size(45, 54);
            labelRedCount.TabIndex = 2;
            labelRedCount.Text = "0";
            labelRedCount.Click += labelRedCount_Click;
            // 
            // labelBlueCount
            // 
            labelBlueCount.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelBlueCount.AutoSize = true;
            labelBlueCount.Font = new Font("Segoe UI", 30F);
            labelBlueCount.Location = new Point(665, 340);
            labelBlueCount.Name = "labelBlueCount";
            labelBlueCount.Size = new Size(45, 54);
            labelBlueCount.TabIndex = 3;
            labelBlueCount.Text = "0";
            labelBlueCount.Click += labelBlueCount_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackColor = Color.Red;
            panel1.Location = new Point(-1, 315);
            panel1.Name = "panel1";
            panel1.Size = new Size(82, 100);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel2.BackColor = Color.Blue;
            panel2.Location = new Point(716, 315);
            panel2.Name = "panel2";
            panel2.Size = new Size(82, 100);
            panel2.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(labelBlueCount);
            Controls.Add(labelRedCount);
            Controls.Add(panelColor);
            Controls.Add(labelTimer);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            MouseDown += Form1_MouseDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTimer;
        private System.Windows.Forms.Timer timer;
        private Panel panelColor;
        private Label labelRedCount;
        private Label labelBlueCount;
        private Panel panel1;
        private Panel panel2;
    }
}
